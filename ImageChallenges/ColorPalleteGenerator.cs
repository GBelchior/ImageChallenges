using ImageUtils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColorMine.ColorSpaces.Comparisons;
using ColorMine.ColorSpaces;

namespace CollorPallete
{
    public class ColorPalleteGenerator : IDisposable
    {
        private DirectBitmap Bitmap;

        public int ColorPalleteSize { get; set; }
        public int MaxColorDeviationPercentage { get; set; }
        public ImageComparisonMethod ImageComparisonMethod { get; set; }
        public IColorSpaceComparison ColorSpaceComparisonMethod { get; set; }

        public ColorPalleteGenerator(Image AImage)
        {
            Bitmap = new DirectBitmap(new Bitmap(AImage));
        }

        public async Task<List<Color>> Generate()
        {
            return await Task.Run(() => GenerateFixedKMeans());
        }

        private List<Color> GenerateFixed()
        {
            List<ColorSum> LPallete = new List<ColorSum>(ColorPalleteSize);

            for (int i = 0; i < ColorPalleteSize; i++)
            {
                ColorSum newColorSum = new ColorSum();
                newColorSum.SumColor(Color.Black);
                LPallete.Add(newColorSum);
            }

            for (int i = 0; i < Bitmap.Width * Bitmap.Height; i++)
            {
                int color = Bitmap.Bits[i];
                int idxToSum = 0;
                double minDistance = Double.MaxValue;

                for (int j = 0; j < LPallete.Count; j++)
                {
                    double distance = CalculateColorDistance(color, LPallete[j].ResultColorFast);

                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        idxToSum = j;
                    }
                }

                LPallete[idxToSum].SumColorFast(color);
            }

            return LPallete.Select(c => c.ResultColor).ToList();
        }

        private List<Color> GenerateFixedKMeans()
        {
            //Random r = new Random();

            int[] oldCentroids = new int[ColorPalleteSize];
            int[] centroids = new int[ColorPalleteSize];
            int[] pixelSectors = new int[Bitmap.Width * Bitmap.Height];

            for (int i = 0; i < ColorPalleteSize; i++)
            {
                //centroids[i] = Bitmap.Bits[r.Next(0, Bitmap.Width * Bitmap.Height - 1)];
                centroids[i] = Bitmap.Bits[i * ((Bitmap.Width * Bitmap.Height - 1) / ColorPalleteSize)];
            }

            do
            {
                Parallel.For(0, Bitmap.Width * Bitmap.Height, (i) =>
                {
                    double minCentroidDistance = Double.MaxValue;
                    int centroidIdx = -1;

                    int color = Bitmap.Bits[i];

                    for (int j = 0; j < ColorPalleteSize; j++)
                    {
                        double dist = CalculateColorDistance(color, centroids[j]);
                        if (dist < minCentroidDistance)
                        {
                            minCentroidDistance = dist;
                            centroidIdx = j;
                        }
                    }

                    pixelSectors[i] = centroidIdx;
                });

                for (int i = 0; i < ColorPalleteSize; i++)
                {
                    int newCentroidR = 0;
                    int newCentroidG = 0;
                    int newCentroidB = 0;
                    int count = 0;

                    for (int j = 0; j < Bitmap.Width * Bitmap.Height; j++)
                    {
                        if (pixelSectors[j] != i) continue;

                        newCentroidR += (Bitmap.Bits[j] >> 16) & 255;
                        newCentroidG += (Bitmap.Bits[j] >> 8) & 255;
                        newCentroidB += Bitmap.Bits[j] & 255;
                        count++;
                    }

                    oldCentroids[i] = centroids[i];

                    if (count == 0) centroids[i] = 0;
                    else centroids[i] = 255 << 24 | (newCentroidR / count) << 16 | (newCentroidG / count) << 8 | (newCentroidB / count);
                }
            } while (!centroids.SequenceEqual(oldCentroids));

            return centroids.Select(c => Color.FromArgb(c)).ToList();
        }

        private double CalculateColorDistance(int argb1, int argb2)
        {
            int r1 = (argb1 >> 16) & 255;
            int g1 = (argb1 >> 8) & 255;
            int b1 = argb1 & 255;

            int r2 = (argb2 >> 16) & 255;
            int g2 = (argb2 >> 8) & 255;
            int b2 = argb2 & 255;

            switch (ImageComparisonMethod)
            {
                case ImageComparisonMethod.Euclidean:
                default:

                    int cR = r1 - r2;
                    int cG = g1 - g2;
                    int cB = b1 - b2;

                    return Math.Sqrt(cR * cR + cG * cG + cB * cB);

                case ImageComparisonMethod.Manhattan:

                    return (Math.Abs(r2 - r1) + Math.Abs(g2 - g1) + Math.Abs(b2 - b1));

                case ImageComparisonMethod.Improved:

                    Rgb LColor1 = new Rgb
                    {
                        R = (argb1 >> 16) & 255,
                        G = (argb1 >> 8) & 255,
                        B = argb1 & 255
                    };

                    Rgb LColor2 = new Rgb
                    {
                        R = (argb2 >> 16) & 255,
                        G = (argb2 >> 8) & 255,
                        B = argb2 & 255
                    };

                    return LColor1.Compare(LColor2, ColorSpaceComparisonMethod);
            }
        }

        public async Task<Bitmap> FlattenImage(Image AOriginalImage, List<Color> AColorPallete)
        {
            return await Task.Run(() =>
            {
                DirectBitmap direct = new DirectBitmap(new Bitmap(AOriginalImage));

                Parallel.For(0, direct.Width * direct.Height, (i) =>
                {
                    Color LChosenColor = new Color();
                    double LDistance = Double.MaxValue;

                    for (int j = 0; j < AColorPallete.Count; j++)
                    {
                        double LCalculatedDistance = CalculateColorDistance(AColorPallete[j].ToArgb(), direct.Bits[i]);
                        if (LCalculatedDistance < LDistance)
                        {
                            LDistance = LCalculatedDistance;
                            LChosenColor = AColorPallete[j];
                        }
                    }

                    direct.Bits[i] = LChosenColor.ToArgb();
                });

                Bitmap newBitmap = new Bitmap(direct.Bitmap);
                direct.Dispose();

                return newBitmap;
            });
        }

        public void Dispose()
        {
            Bitmap.Dispose();
        }

        private class ColorSum
        {
            public int RSum { get; private set; }
            public int GSum { get; private set; }
            public int BSum { get; private set; }
            //public int ASum { get; private set; }
            public int N { get; private set; }

            public Color ResultColor
            {
                get
                {
                    return Color.FromArgb(/*ASum / N*/255, RSum / N, GSum / N, BSum / N);
                }
            }

            public int ResultColorFast
            {
                get
                {
                    return /*(ASum / N) << 24*/255 | (RSum / N) << 16 | (GSum / N) << 8 | (BSum / N);
                }
            }

            public void SumColor(Color c)
            {
                RSum += c.R;
                GSum += c.G;
                BSum += c.B;
                //ASum += c.A;
                N++;
            }

            public void SumColorFast(int c)
            {
                //ASum += (c >> 24) & 255;
                RSum += (c >> 16) & 255;
                GSum += (c >> 8) & 255;
                BSum += c & 255;
                N++;
            }
        }
    }

    public enum ImageComparisonMethod
    {
        Euclidean,
        Manhattan,
        Improved
    }
}

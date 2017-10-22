using ColorMine.ColorSpaces.Comparisons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollorPallete
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnFilePicker_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = openFileDialog.FileName;
                picSourceImage.BackgroundImage = Image.FromFile(openFileDialog.FileName);
                picPalleteImage.BackgroundImage = null;
                splitContainer.Panel2Collapsed = true;
                tblPallete.Controls.Clear();
                tblPallete.ColumnStyles.Clear();
                tblPallete.ColumnCount = 0;
            }
        }

        private async void btnGeneratePallete_Click(object sender, EventArgs e)
        {
            List<Color> LPallete = new List<Color>();
            Bitmap LPalleteBitmap;

            lblLoading.Visible = true;

            using (ColorPalleteGenerator LGenerator = new ColorPalleteGenerator(picSourceImage.BackgroundImage))
            {
                if (rbEuclidean.Checked) LGenerator.ImageComparisonMethod = ImageComparisonMethod.Euclidean;
                else if (rbManhattan.Checked) LGenerator.ImageComparisonMethod = ImageComparisonMethod.Manhattan;
                else
                {
                    LGenerator.ImageComparisonMethod = ImageComparisonMethod.Improved;

                    if (rbCIE76.Checked) LGenerator.ColorSpaceComparisonMethod = new Cie1976Comparison();
                    else if (rbCMCIc.Checked) LGenerator.ColorSpaceComparisonMethod = new CmcComparison();
                    else if (rbCIE94.Checked) LGenerator.ColorSpaceComparisonMethod = new Cie94Comparison(Cie94Comparison.Application.GraphicArts);
                    else if (rbCIE2000.Checked) LGenerator.ColorSpaceComparisonMethod = new CieDe2000Comparison();
                }

                LGenerator.ColorPalleteSize = (int)nudColorsInPallete.Value;

                LPallete = await LGenerator.Generate();
                LPalleteBitmap = await LGenerator.FlattenImage(picSourceImage.BackgroundImage, LPallete);
            }

            tblPallete.SuspendLayout();

            tblPallete.Controls.Clear();

            tblPallete.ColumnStyles.Clear();
            tblPallete.ColumnCount = 0;

            tblPallete.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            tblPallete.ColumnCount++;

            foreach (Color c in LPallete)
            {
                tblPallete.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50));
                tblPallete.ColumnCount++;

                Panel LPanel = new Panel { BackColor = c, Margin = Padding.Empty, Padding = Padding.Empty };
                tblPallete.Controls.Add(LPanel);
                tblPallete.SetRow(LPanel, 0);
                tblPallete.SetColumn(LPanel, tblPallete.ColumnCount - 1);
            }

            tblPallete.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            tblPallete.ColumnCount++;

            tblPallete.ResumeLayout();

            lblLoading.Visible = false;

            splitContainer.Panel2Collapsed = false;
            if (splitContainer.Width > 0) splitContainer.SplitterDistance = splitContainer.Width / 2;

            picPalleteImage.BackgroundImage = LPalleteBitmap;
        }

        private void picPalleteImage_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                picPalleteImage.BackgroundImage.Save(saveFileDialog.FileName);
            }
        }
    }
}

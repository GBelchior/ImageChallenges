namespace CollorPallete
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picSourceImage = new System.Windows.Forms.PictureBox();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFilePicker = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.nudColorsInPallete = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGeneratePallete = new System.Windows.Forms.Button();
            this.tblPallete = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rbCIE2000 = new System.Windows.Forms.RadioButton();
            this.rbCIE94 = new System.Windows.Forms.RadioButton();
            this.rbManhattan = new System.Windows.Forms.RadioButton();
            this.rbCMCIc = new System.Windows.Forms.RadioButton();
            this.rbEuclidean = new System.Windows.Forms.RadioButton();
            this.rbCIE76 = new System.Windows.Forms.RadioButton();
            this.lblLoading = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.picPalleteImage = new System.Windows.Forms.PictureBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picSourceImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColorsInPallete)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPalleteImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picSourceImage
            // 
            this.picSourceImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picSourceImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picSourceImage.Location = new System.Drawing.Point(0, 0);
            this.picSourceImage.Name = "picSourceImage";
            this.picSourceImage.Size = new System.Drawing.Size(839, 287);
            this.picSourceImage.TabIndex = 0;
            this.picSourceImage.TabStop = false;
            // 
            // txtFile
            // 
            this.txtFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFile.Location = new System.Drawing.Point(44, 12);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(508, 20);
            this.txtFile.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "File:";
            // 
            // btnFilePicker
            // 
            this.btnFilePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilePicker.Location = new System.Drawing.Point(558, 10);
            this.btnFilePicker.Name = "btnFilePicker";
            this.btnFilePicker.Size = new System.Drawing.Size(36, 23);
            this.btnFilePicker.TabIndex = 3;
            this.btnFilePicker.Text = "...";
            this.btnFilePicker.UseVisualStyleBackColor = true;
            this.btnFilePicker.Click += new System.EventHandler(this.btnFilePicker_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";
            // 
            // nudColorsInPallete
            // 
            this.nudColorsInPallete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudColorsInPallete.Location = new System.Drawing.Point(691, 13);
            this.nudColorsInPallete.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudColorsInPallete.Name = "nudColorsInPallete";
            this.nudColorsInPallete.Size = new System.Drawing.Size(70, 20);
            this.nudColorsInPallete.TabIndex = 4;
            this.nudColorsInPallete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudColorsInPallete.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(600, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Colors in Pallete:";
            // 
            // btnGeneratePallete
            // 
            this.btnGeneratePallete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGeneratePallete.Location = new System.Drawing.Point(767, 10);
            this.btnGeneratePallete.Name = "btnGeneratePallete";
            this.btnGeneratePallete.Size = new System.Drawing.Size(84, 74);
            this.btnGeneratePallete.TabIndex = 6;
            this.btnGeneratePallete.Text = "Generate";
            this.btnGeneratePallete.UseVisualStyleBackColor = true;
            this.btnGeneratePallete.Click += new System.EventHandler(this.btnGeneratePallete_Click);
            // 
            // tblPallete
            // 
            this.tblPallete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblPallete.BackColor = System.Drawing.Color.White;
            this.tblPallete.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblPallete.ColumnCount = 1;
            this.tblPallete.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPallete.Location = new System.Drawing.Point(12, 383);
            this.tblPallete.Name = "tblPallete";
            this.tblPallete.RowCount = 1;
            this.tblPallete.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPallete.Size = new System.Drawing.Size(839, 60);
            this.tblPallete.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(15, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 46);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color Comparison Algorithm";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.23077F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.23077F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.38461F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.38461F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.38461F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.38461F));
            this.tableLayoutPanel1.Controls.Add(this.rbCIE2000, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.rbCIE94, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.rbManhattan, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.rbCMCIc, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.rbEuclidean, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rbCIE76, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(740, 27);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // rbCIE2000
            // 
            this.rbCIE2000.AutoSize = true;
            this.rbCIE2000.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbCIE2000.Location = new System.Drawing.Point(626, 3);
            this.rbCIE2000.Name = "rbCIE2000";
            this.rbCIE2000.Size = new System.Drawing.Size(111, 21);
            this.rbCIE2000.TabIndex = 1;
            this.rbCIE2000.Text = "CIE2000";
            this.rbCIE2000.UseVisualStyleBackColor = true;
            // 
            // rbCIE94
            // 
            this.rbCIE94.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbCIE94.Location = new System.Drawing.Point(513, 3);
            this.rbCIE94.Name = "rbCIE94";
            this.rbCIE94.Size = new System.Drawing.Size(107, 21);
            this.rbCIE94.TabIndex = 5;
            this.rbCIE94.Text = "CIE94";
            this.rbCIE94.UseVisualStyleBackColor = true;
            // 
            // rbManhattan
            // 
            this.rbManhattan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbManhattan.Location = new System.Drawing.Point(145, 3);
            this.rbManhattan.Name = "rbManhattan";
            this.rbManhattan.Size = new System.Drawing.Size(136, 21);
            this.rbManhattan.TabIndex = 6;
            this.rbManhattan.Text = "Manhattan Distance";
            this.rbManhattan.UseVisualStyleBackColor = true;
            // 
            // rbCMCIc
            // 
            this.rbCMCIc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbCMCIc.Location = new System.Drawing.Point(400, 3);
            this.rbCMCIc.Name = "rbCMCIc";
            this.rbCMCIc.Size = new System.Drawing.Size(107, 21);
            this.rbCMCIc.TabIndex = 3;
            this.rbCMCIc.Text = "CMC l:c";
            this.rbCMCIc.UseVisualStyleBackColor = true;
            // 
            // rbEuclidean
            // 
            this.rbEuclidean.AutoSize = true;
            this.rbEuclidean.Checked = true;
            this.rbEuclidean.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbEuclidean.Location = new System.Drawing.Point(3, 3);
            this.rbEuclidean.Name = "rbEuclidean";
            this.rbEuclidean.Size = new System.Drawing.Size(136, 21);
            this.rbEuclidean.TabIndex = 0;
            this.rbEuclidean.TabStop = true;
            this.rbEuclidean.Text = "Euclidean Distance";
            this.rbEuclidean.UseVisualStyleBackColor = true;
            // 
            // rbCIE76
            // 
            this.rbCIE76.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbCIE76.Location = new System.Drawing.Point(287, 3);
            this.rbCIE76.Name = "rbCIE76";
            this.rbCIE76.Size = new System.Drawing.Size(107, 21);
            this.rbCIE76.TabIndex = 2;
            this.rbCIE76.Text = "CIE76";
            this.rbCIE76.UseVisualStyleBackColor = true;
            // 
            // lblLoading
            // 
            this.lblLoading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoading.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lblLoading.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.Location = new System.Drawing.Point(12, 383);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(839, 60);
            this.lblLoading.TabIndex = 0;
            this.lblLoading.Text = "Generating Pallete...";
            this.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLoading.Visible = false;
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(12, 90);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.picSourceImage);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.picPalleteImage);
            this.splitContainer.Panel2Collapsed = true;
            this.splitContainer.Size = new System.Drawing.Size(839, 287);
            this.splitContainer.SplitterDistance = 419;
            this.splitContainer.TabIndex = 11;
            // 
            // picPalleteImage
            // 
            this.picPalleteImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picPalleteImage.Cursor = System.Windows.Forms.Cursors.Default;
            this.picPalleteImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPalleteImage.Location = new System.Drawing.Point(0, 0);
            this.picPalleteImage.Name = "picPalleteImage";
            this.picPalleteImage.Size = new System.Drawing.Size(416, 287);
            this.picPalleteImage.TabIndex = 1;
            this.picPalleteImage.TabStop = false;
            this.picPalleteImage.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.picPalleteImage_MouseDoubleClick);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "generated.jpg";
            this.saveFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 455);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tblPallete);
            this.Controls.Add(this.btnGeneratePallete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudColorsInPallete);
            this.Controls.Add(this.btnFilePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFile);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "FrmMain";
            this.Text = "Collor Pallete Generator";
            ((System.ComponentModel.ISupportInitialize)(this.picSourceImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColorsInPallete)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPalleteImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSourceImage;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFilePicker;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.NumericUpDown nudColorsInPallete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGeneratePallete;
        private System.Windows.Forms.TableLayoutPanel tblPallete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCIE2000;
        private System.Windows.Forms.RadioButton rbEuclidean;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.RadioButton rbCIE94;
        private System.Windows.Forms.RadioButton rbCMCIc;
        private System.Windows.Forms.RadioButton rbCIE76;
        private System.Windows.Forms.RadioButton rbManhattan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.PictureBox picPalleteImage;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}


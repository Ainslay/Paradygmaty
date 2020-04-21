namespace Lab5
{
    partial class Form1
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
            this.MainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.OriginalPicture = new System.Windows.Forms.PictureBox();
            this.RGBTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.RedPicture = new System.Windows.Forms.PictureBox();
            this.GreenPicture = new System.Windows.Forms.PictureBox();
            this.BluePicture = new System.Windows.Forms.PictureBox();
            this.GrayPicture = new System.Windows.Forms.PictureBox();
            this.NegativePicture = new System.Windows.Forms.PictureBox();
            this.SepiaPicture = new System.Windows.Forms.PictureBox();
            this.RandomPixelsPicture = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LeftMirrorPicture = new System.Windows.Forms.PictureBox();
            this.RightMirrorPicture = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.RGBButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.LoadButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.GrayButton = new System.Windows.Forms.Button();
            this.NegativeButton = new System.Windows.Forms.Button();
            this.SepiaButton = new System.Windows.Forms.Button();
            this.RandomPixelsButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.MirrorButton = new System.Windows.Forms.Button();
            this.inputPictureFile = new System.Windows.Forms.OpenFileDialog();
            this.MainTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalPicture)).BeginInit();
            this.RGBTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RedPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrayPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NegativePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SepiaPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RandomPixelsPicture)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftMirrorPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightMirrorPicture)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTableLayout
            // 
            this.MainTableLayout.ColumnCount = 4;
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainTableLayout.Controls.Add(this.OriginalPicture, 0, 0);
            this.MainTableLayout.Controls.Add(this.RGBTableLayout, 1, 0);
            this.MainTableLayout.Controls.Add(this.GrayPicture, 3, 0);
            this.MainTableLayout.Controls.Add(this.NegativePicture, 0, 2);
            this.MainTableLayout.Controls.Add(this.SepiaPicture, 2, 2);
            this.MainTableLayout.Controls.Add(this.RandomPixelsPicture, 3, 2);
            this.MainTableLayout.Controls.Add(this.tableLayoutPanel1, 1, 2);
            this.MainTableLayout.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.MainTableLayout.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.MainTableLayout.Controls.Add(this.GrayButton, 3, 1);
            this.MainTableLayout.Controls.Add(this.NegativeButton, 0, 3);
            this.MainTableLayout.Controls.Add(this.SepiaButton, 2, 3);
            this.MainTableLayout.Controls.Add(this.RandomPixelsButton, 3, 3);
            this.MainTableLayout.Controls.Add(this.tableLayoutPanel4, 1, 3);
            this.MainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayout.Name = "MainTableLayout";
            this.MainTableLayout.RowCount = 4;
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MainTableLayout.Size = new System.Drawing.Size(956, 520);
            this.MainTableLayout.TabIndex = 0;
            // 
            // OriginalPicture
            // 
            this.OriginalPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OriginalPicture.Location = new System.Drawing.Point(3, 3);
            this.OriginalPicture.Name = "OriginalPicture";
            this.OriginalPicture.Size = new System.Drawing.Size(185, 202);
            this.OriginalPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OriginalPicture.TabIndex = 0;
            this.OriginalPicture.TabStop = false;
            // 
            // RGBTableLayout
            // 
            this.RGBTableLayout.ColumnCount = 3;
            this.MainTableLayout.SetColumnSpan(this.RGBTableLayout, 2);
            this.RGBTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.RGBTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.RGBTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.RGBTableLayout.Controls.Add(this.RedPicture, 0, 0);
            this.RGBTableLayout.Controls.Add(this.GreenPicture, 1, 0);
            this.RGBTableLayout.Controls.Add(this.BluePicture, 2, 0);
            this.RGBTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RGBTableLayout.Location = new System.Drawing.Point(194, 3);
            this.RGBTableLayout.Name = "RGBTableLayout";
            this.RGBTableLayout.RowCount = 1;
            this.RGBTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RGBTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 202F));
            this.RGBTableLayout.Size = new System.Drawing.Size(567, 202);
            this.RGBTableLayout.TabIndex = 1;
            // 
            // RedPicture
            // 
            this.RedPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RedPicture.Location = new System.Drawing.Point(3, 3);
            this.RedPicture.Name = "RedPicture";
            this.RedPicture.Size = new System.Drawing.Size(183, 196);
            this.RedPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RedPicture.TabIndex = 0;
            this.RedPicture.TabStop = false;
            // 
            // GreenPicture
            // 
            this.GreenPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GreenPicture.Location = new System.Drawing.Point(192, 3);
            this.GreenPicture.Name = "GreenPicture";
            this.GreenPicture.Size = new System.Drawing.Size(183, 196);
            this.GreenPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GreenPicture.TabIndex = 1;
            this.GreenPicture.TabStop = false;
            // 
            // BluePicture
            // 
            this.BluePicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BluePicture.Location = new System.Drawing.Point(381, 3);
            this.BluePicture.Name = "BluePicture";
            this.BluePicture.Size = new System.Drawing.Size(183, 196);
            this.BluePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BluePicture.TabIndex = 2;
            this.BluePicture.TabStop = false;
            // 
            // GrayPicture
            // 
            this.GrayPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrayPicture.Location = new System.Drawing.Point(767, 3);
            this.GrayPicture.Name = "GrayPicture";
            this.GrayPicture.Size = new System.Drawing.Size(186, 202);
            this.GrayPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GrayPicture.TabIndex = 3;
            this.GrayPicture.TabStop = false;
            // 
            // NegativePicture
            // 
            this.NegativePicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NegativePicture.Location = new System.Drawing.Point(3, 263);
            this.NegativePicture.Name = "NegativePicture";
            this.NegativePicture.Size = new System.Drawing.Size(185, 202);
            this.NegativePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NegativePicture.TabIndex = 4;
            this.NegativePicture.TabStop = false;
            // 
            // SepiaPicture
            // 
            this.SepiaPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SepiaPicture.Location = new System.Drawing.Point(576, 263);
            this.SepiaPicture.Name = "SepiaPicture";
            this.SepiaPicture.Size = new System.Drawing.Size(185, 202);
            this.SepiaPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SepiaPicture.TabIndex = 5;
            this.SepiaPicture.TabStop = false;
            // 
            // RandomPixelsPicture
            // 
            this.RandomPixelsPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RandomPixelsPicture.Location = new System.Drawing.Point(767, 263);
            this.RandomPixelsPicture.Name = "RandomPixelsPicture";
            this.RandomPixelsPicture.Size = new System.Drawing.Size(186, 202);
            this.RandomPixelsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RandomPixelsPicture.TabIndex = 6;
            this.RandomPixelsPicture.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.LeftMirrorPicture, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RightMirrorPicture, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(194, 263);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 202F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(376, 202);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // LeftMirrorPicture
            // 
            this.LeftMirrorPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftMirrorPicture.Location = new System.Drawing.Point(3, 3);
            this.LeftMirrorPicture.Margin = new System.Windows.Forms.Padding(0);
            this.LeftMirrorPicture.Name = "LeftMirrorPicture";
            this.LeftMirrorPicture.Size = new System.Drawing.Size(182, 196);
            this.LeftMirrorPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftMirrorPicture.TabIndex = 0;
            this.LeftMirrorPicture.TabStop = false;
            // 
            // RightMirrorPicture
            // 
            this.RightMirrorPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightMirrorPicture.Location = new System.Drawing.Point(191, 3);
            this.RightMirrorPicture.Margin = new System.Windows.Forms.Padding(0);
            this.RightMirrorPicture.Name = "RightMirrorPicture";
            this.RightMirrorPicture.Size = new System.Drawing.Size(182, 196);
            this.RightMirrorPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RightMirrorPicture.TabIndex = 1;
            this.RightMirrorPicture.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.MainTableLayout.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.RGBButton, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(194, 211);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(567, 46);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // RGBButton
            // 
            this.RGBButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RGBButton.Location = new System.Drawing.Point(192, 3);
            this.RGBButton.Name = "RGBButton";
            this.RGBButton.Size = new System.Drawing.Size(183, 40);
            this.RGBButton.TabIndex = 0;
            this.RGBButton.Text = "RGB";
            this.RGBButton.UseVisualStyleBackColor = true;
            this.RGBButton.Click += new System.EventHandler(this.RGBButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.LoadButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.ResetButton, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 211);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(185, 46);
            this.tableLayoutPanel3.TabIndex = 15;
            // 
            // LoadButton
            // 
            this.LoadButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoadButton.Location = new System.Drawing.Point(3, 3);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(86, 40);
            this.LoadButton.TabIndex = 0;
            this.LoadButton.Text = "Wczytaj";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResetButton.Location = new System.Drawing.Point(95, 3);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(87, 40);
            this.ResetButton.TabIndex = 1;
            this.ResetButton.Text = "Resetuj";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // GrayButton
            // 
            this.GrayButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrayButton.Location = new System.Drawing.Point(767, 211);
            this.GrayButton.Name = "GrayButton";
            this.GrayButton.Size = new System.Drawing.Size(186, 46);
            this.GrayButton.TabIndex = 16;
            this.GrayButton.Text = "Szarość";
            this.GrayButton.UseVisualStyleBackColor = true;
            this.GrayButton.Click += new System.EventHandler(this.GrayButton_Click);
            // 
            // NegativeButton
            // 
            this.NegativeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NegativeButton.Location = new System.Drawing.Point(3, 471);
            this.NegativeButton.Name = "NegativeButton";
            this.NegativeButton.Size = new System.Drawing.Size(185, 46);
            this.NegativeButton.TabIndex = 17;
            this.NegativeButton.Text = "Negatyw";
            this.NegativeButton.UseVisualStyleBackColor = true;
            this.NegativeButton.Click += new System.EventHandler(this.NegativeButton_Click);
            // 
            // SepiaButton
            // 
            this.SepiaButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SepiaButton.Location = new System.Drawing.Point(576, 471);
            this.SepiaButton.Name = "SepiaButton";
            this.SepiaButton.Size = new System.Drawing.Size(185, 46);
            this.SepiaButton.TabIndex = 18;
            this.SepiaButton.Text = "Sepia";
            this.SepiaButton.UseVisualStyleBackColor = true;
            this.SepiaButton.Click += new System.EventHandler(this.SepiaButton_Click);
            // 
            // RandomPixelsButton
            // 
            this.RandomPixelsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RandomPixelsButton.Location = new System.Drawing.Point(767, 471);
            this.RandomPixelsButton.Name = "RandomPixelsButton";
            this.RandomPixelsButton.Size = new System.Drawing.Size(186, 46);
            this.RandomPixelsButton.TabIndex = 19;
            this.RandomPixelsButton.Text = "Losowe piksele";
            this.RandomPixelsButton.UseVisualStyleBackColor = true;
            this.RandomPixelsButton.Click += new System.EventHandler(this.RandomPixelsButton_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.MirrorButton, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(194, 471);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(376, 46);
            this.tableLayoutPanel4.TabIndex = 20;
            // 
            // MirrorButton
            // 
            this.MirrorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MirrorButton.Location = new System.Drawing.Point(97, 3);
            this.MirrorButton.Name = "MirrorButton";
            this.MirrorButton.Size = new System.Drawing.Size(182, 40);
            this.MirrorButton.TabIndex = 0;
            this.MirrorButton.Text = "Lustrzane odbicie";
            this.MirrorButton.UseVisualStyleBackColor = true;
            this.MirrorButton.Click += new System.EventHandler(this.MirrorButton_Click);
            // 
            // inputPictureFile
            // 
            this.inputPictureFile.FileName = "openFileDialog1";
            this.inputPictureFile.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 520);
            this.Controls.Add(this.MainTableLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MainTableLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OriginalPicture)).EndInit();
            this.RGBTableLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RedPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrayPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NegativePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SepiaPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RandomPixelsPicture)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LeftMirrorPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightMirrorPicture)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayout;
        private System.Windows.Forms.PictureBox OriginalPicture;
        private System.Windows.Forms.TableLayoutPanel RGBTableLayout;
        private System.Windows.Forms.PictureBox RedPicture;
        private System.Windows.Forms.PictureBox GreenPicture;
        private System.Windows.Forms.PictureBox BluePicture;
        private System.Windows.Forms.PictureBox GrayPicture;
        private System.Windows.Forms.PictureBox NegativePicture;
        private System.Windows.Forms.PictureBox SepiaPicture;
        private System.Windows.Forms.PictureBox RandomPixelsPicture;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox LeftMirrorPicture;
        private System.Windows.Forms.PictureBox RightMirrorPicture;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button RGBButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button GrayButton;
        private System.Windows.Forms.Button NegativeButton;
        private System.Windows.Forms.Button SepiaButton;
        private System.Windows.Forms.Button RandomPixelsButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button MirrorButton;
        private System.Windows.Forms.OpenFileDialog inputPictureFile;
    }
}


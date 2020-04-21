using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        private Bitmap _originalPicture;

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if(inputPictureFile.ShowDialog() == DialogResult.OK)
            {
                _originalPicture = new Bitmap(inputPictureFile.FileName);

                OriginalPicture.Image = _originalPicture;
                RedPicture.Image = _originalPicture;
                GreenPicture.Image = _originalPicture;
                BluePicture.Image = _originalPicture;
                GrayPicture.Image = _originalPicture;
                NegativePicture.Image = _originalPicture;
                LeftMirrorPicture.Image = _originalPicture;
                SepiaPicture.Image = _originalPicture;
                RandomPixelsPicture.Image = _originalPicture;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            OriginalPicture.Image = _originalPicture;
            RedPicture.Image = _originalPicture;
            GreenPicture.Image = _originalPicture;
            BluePicture.Image = _originalPicture;
            GrayPicture.Image = _originalPicture;
            NegativePicture.Image = _originalPicture;
            LeftMirrorPicture.Image = _originalPicture;
            RightMirrorPicture.Image = null;
            SepiaPicture.Image = _originalPicture;
            RandomPixelsPicture.Image = _originalPicture;
        }

        private void RGBButton_Click(object sender, EventArgs e)
        {
            var rImage = new Bitmap(_originalPicture);
            var gImage = new Bitmap(_originalPicture);
            var bImage = new Bitmap(_originalPicture);

            for (int x = 0; x < _originalPicture.Width; x++)
            {
                for (int y = 0; y < _originalPicture.Height; y++)
                {
                    var currentPixel = _originalPicture.GetPixel(x, y);
                    rImage.SetPixel(x, y, Color.FromArgb(currentPixel.R, 0, 0));
                    gImage.SetPixel(x, y, Color.FromArgb(0, currentPixel.G, 0));
                    bImage.SetPixel(x, y, Color.FromArgb(0, 0, currentPixel.B));
                }
            }

            RedPicture.Image = rImage;
            GreenPicture.Image = gImage;
            BluePicture.Image = bImage;
        }

        private void GrayButton_Click(object sender, EventArgs e)
        {
            var grayImage = new Bitmap(_originalPicture);

            for (int x = 0; x < _originalPicture.Width; x++)
            {
                for (int y = 0; y < _originalPicture.Height; y++)
                {
                    var currentPixel = _originalPicture.GetPixel(x, y);
                    var mono = (currentPixel.R + currentPixel.G + currentPixel.B) / 3;
                    grayImage.SetPixel(x, y, Color.FromArgb(mono, mono, mono));
                }
            }

            GrayPicture.Image = grayImage;
        }

        private void NegativeButton_Click(object sender, EventArgs e)
        {
            var negativeImage = new Bitmap(_originalPicture);

            for (int x = 0; x < _originalPicture.Width; x++)
            {
                for (int y = 0; y < _originalPicture.Height; y++)
                {
                    var currentPixel = _originalPicture.GetPixel(x, y);
                    var negative = Color.FromArgb(255 - currentPixel.R, 255 - currentPixel.G, 255 - currentPixel.B);
                    negativeImage.SetPixel(x, y, negative);
                }
            }

            NegativePicture.Image = negativeImage;
        }

        private void MirrorButton_Click(object sender, EventArgs e)
        {
            var mirroredImage = new Bitmap(_originalPicture);

            for (int x = 0; x < _originalPicture.Width; x++)
            {
                for (int y = 0; y < _originalPicture.Height; y++)
                {
                    var currentPixel = _originalPicture.GetPixel(x, y);
                    mirroredImage.SetPixel(mirroredImage.Width - x - 1, y, currentPixel);
                }
            }

            RightMirrorPicture.Image = mirroredImage;
        }

        private void SepiaButton_Click(object sender, EventArgs e)
        {
            var sepiaImage = new Bitmap(_originalPicture);

            for (int x = 0; x < _originalPicture.Width; x++)
            {
                for (int y = 0; y < _originalPicture.Height; y++)
                {
                    var currentPixel = sepiaImage.GetPixel(x, y);
                    int r, g, b;

                    r = Math.Min(255, (int)((.393 * currentPixel.R) + (.769 * currentPixel.G) + (.189 * currentPixel.B)));
                    g = Math.Min(255, (int)((.349 * currentPixel.R) + (.686 * currentPixel.G) + (.168 * currentPixel.B)));
                    b = Math.Min(255, (int)((.272 * currentPixel.R) + (.534 * currentPixel.G) + (.131 * currentPixel.B)));

                    sepiaImage.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            SepiaPicture.Image = sepiaImage;
        }

        private void RandomPixelsButton_Click(object sender, EventArgs e)
        {
            var randomImage = new Bitmap(_originalPicture);

            var random = new Random();

            for (int x = 0; x < _originalPicture.Width; x++)
            {
                for (int y = 0; y < _originalPicture.Height; y++)
                {
                    var randomColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                    randomImage.SetPixel(x, y, randomColor);
                }
            }

            RandomPixelsPicture.Image = randomImage;
        }
    }
}

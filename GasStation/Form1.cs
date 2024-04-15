using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasStation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Image RecolorImage(PictureBox pictureBox, double percentAnimation)
        {
            Bitmap original = new Bitmap(pictureBox.Image, pictureBox.Width, pictureBox.Height);
            using (Graphics g = Graphics.FromImage(original))
            {
                ImageAttributes imageAttributes = CreateColorTable();
                Rectangle coloredRectangle = CreateColoredRectangle(pictureBox, percentAnimation);
                Bitmap croppedImage = this.Crop(original, coloredRectangle);

                g.DrawImage(
                    croppedImage,
                    coloredRectangle,
                    0, 0,
                    coloredRectangle.Width, coloredRectangle.Height,
                    GraphicsUnit.Pixel,
                    imageAttributes

                    );
                return original;
            }
        }
        private static ImageAttributes CreateColorTable()
        {
            ImageAttributes imageAttributes = new ImageAttributes();
            ColorMap colorMap = new ColorMap();
            colorMap.OldColor = Color.FromArgb(51, 51, 51);
            colorMap.NewColor = Color.FromArgb(0, 255, 0);
            ColorMap[] remapTable = {  colorMap };

            imageAttributes.SetRemapTable(remapTable, ColorAdjustType.Bitmap);
            return imageAttributes;
        }

        private static Rectangle CreateColoredRectangle(PictureBox pictureBox, double percentAnimation)
        {
            int heightAnimation = (int)(percentAnimation * pictureBox.Height);
            Rectangle coloredRectangle = new Rectangle(
                new Point(0, pictureBox.Height - heightAnimation),
                new Size(pictureBox.Width, heightAnimation)
                );
            return coloredRectangle; 
        }
    }

    private Bitmap Crop(Bitmap original, Rectangle coloredRectangle)
    {
        Bitmap cropped = new Bitmap(coloredRectangle.Width, coloredRectangle.Height);
        using (Graphics g = Graphics.FromImage(cropped))
        {
            g.DrawImage(original, -coloredRectangle.X, -coloredRectangle.Y);
            return cropped;
        }
    }
}

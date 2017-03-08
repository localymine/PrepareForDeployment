using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrepareForDeployment
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            this.MouseWheel += new MouseEventHandler(pictureBox_MouseWheel);
        }

        private void pictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            // mouse scroll up
            if (e.Delta > 0)
            {
                Console.WriteLine("up");
                ZoomInOut(true);
            }

            // mouse scroll down
            if (e.Delta < 0)
            {
                Console.WriteLine("down");
                ZoomInOut(false);
            }
            
            // throw new NotImplementedException();
        }

        private void ZoomInOut(bool zoom)
        {
            //Zoom ratio by which the images will be zoomed by default
            int zoomRatio = 10;
            //Set the zoomed width and height
            int widthZoom = pictureBox.Width * zoomRatio / 100;
            int heightZoom = pictureBox.Height * zoomRatio / 100;
            //zoom = true --> zoom in
            //zoom = false --> zoom out
            if (!zoom)
            {
                widthZoom *= -1;
                heightZoom *= -1;
            }
            //Add the width and height to the picture box dimensions
            pictureBox.Width += widthZoom;
            pictureBox.Height += heightZoom;

        }
    }
}

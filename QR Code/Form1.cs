using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video.DirectShow;
using System.IO;
using ZXing;
using ZXing.Aztec;
using AForge.Video;

namespace QR_Code
{
    public partial class Form1 : Form
    {
        FilterInfoCollection camcollection;
        VideoCaptureDevice camdisplay;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            camcollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

        }

        private void camerabox_Click(object sender, EventArgs e)
        {
            

        }

        private void newcamdisplay(object sender, NewFrameEventArgs eventArgs)
        {
            camerabox.Image = (Bitmap)eventArgs.Frame.Clone();

        }

        private void buttonstart_Click(object sender, EventArgs e)
        {
            camdisplay = new VideoCaptureDevice(camcollection[1].MonikerString);
            camdisplay.NewFrame += newcamdisplay;
            camdisplay.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BarcodeReader QRread = new BarcodeReader();

        }
    }
}

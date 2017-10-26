using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Kinect;

namespace kinect_oplevering
{
    public partial class Form1 : Form
    {
        private KinectSensor kinect;
        //Depth Frame
        //private WriteableBitmap bitmap;
        private ushort[] depthFrameData = null;
        private byte[] depthPixels = null;
        public Form1()
        {
            InitializeComponent();
            kinect = KinectSensor.GetDefault();
            kinect.Open();


        }

    private void buttonConnect_Click(object sender, EventArgs e)
    {

    }
}
}

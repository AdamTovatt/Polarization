using Polarization.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polarization
{
    public partial class Form1 : Form
    {
        double dt;
        Axis axis;
        Wave wave;
        Graph graph;
        Thread drawThread;

        Button bt;
        Label lbl;

        Graphics graphics;

        private DateTime lastDrawTime;
        private double timeScale = 1;

        /*
        MyScrollbar viewrSb;
        MyScrollbar viewtetaSb;
        MyScrollbar viewfiSb;
        MyScrollbar frq1Sb;
        MyScrollbar frq2Sb;
        MyScrollbar wL1Sb;
        MyScrollbar wL2Sb;
        MyScrollbar amp1Sb;
        MyScrollbar amp2Sb;
        MyScrollbar ph1Sb;
        MyScrollbar ph2Sb;
        MyScrollbar zmaxSb;
        MyScrollbar zminSb;
        */

        public Form1()
        {
            InitializeComponent();
            lastDrawTime = DateTime.UtcNow;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double[] array = { -1.0, -1.0, -1.0, 1.0, 1.0, 1.0 };
            this.axis = new Axis(array);
            (this.wave = new Wave(Color.Red, Color.Blue, 0.2, Vector.UnitX, Vector.UnitZ, 0.25, 1.0, 0.0, array)).add(new Wave(Color.Blue, Color.Orange, 0.2, Vector.UnitY, Vector.UnitZ, 0.25, 1.0, 1.5707963267948966, array));
            int n = pictureBox.Width;
            int n2 = pictureBox.Height;
            this.graph = new Graph(n, n2, this.axis, this.wave, new Vector(5.0, 7.1, 5.0));

            ApplySliderValues();

            graph.update();
        }

        private void ApplySliderValues()
        {
            wave.a[0] = 0;
            wave.a[1] = 0.3;
            wave.d[0] = 3.141592653589793 * 0;
            wave.d[1] = 3.141592653589793 * 0;
            wave.k[0] = 6.283185307179586 / 0.25;
            wave.k[1] = 6.283185307179586 / 0.25;
            wave.w[0] = 6.283185307179586 * 1;
            wave.w[1] = 6.283185307179586 * 1;
            axis.bb[2] = -1;
            wave.bb[2] = -1;
            axis.bb[5] = 1;
            wave.bb[5] = 1;
            double value = 3;
            double a = 3.141592653589793 * 0.4;
            double n = 3.141592653589793 * 0.2;
            graph.view = new Vector(value * Math.Sin(a) * Math.Sin(n), value * Math.Cos(a), value * Math.Sin(a) * Math.Cos(n));

            Task.Run(() =>
            {
                while (true)
                {
                    Thread.Sleep(1);
                    graph.update((DateTime.UtcNow - lastDrawTime).TotalSeconds * timeScale);
                    pictureBox.Invoke(new Action(() => { pictureBox.Refresh(); }));
                    lastDrawTime = DateTime.UtcNow;
                }
            });
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            graph.draw(e.Graphics);
        }
    }
}

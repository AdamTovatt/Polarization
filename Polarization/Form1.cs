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
    public partial class PolarizationLab : Form
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

        private double pictureStartWidth;
        private double pictureStartHeight;
        private double formStartWidth;
        private double formStartHeight;

        private bool isRunning;
        private CancellationTokenSource tokenSource;
        private Task updateThread;

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

        public PolarizationLab()
        {
            InitializeComponent();
            lastDrawTime = DateTime.UtcNow;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureStartWidth = pictureBox.Width;
            pictureStartHeight = pictureBox.Height;
            formStartWidth = Width;
            formStartHeight = Height;

            double[] array = { -1.0, -1.0, -1.0, 1.0, 1.0, 1.0 };
            axis = new Axis(array);

            wave = new Wave(Color.Red, Color.Blue, 0.2, Vector.UnitX, Vector.UnitZ, 0.25, 1.0, 0.0, array);
            wave.add(new Wave(Color.Blue, Color.Orange, 0.2, Vector.UnitY, Vector.UnitZ, 0.25, 1.0, 1.5707963267948966, array));

            InitGraph();

            UpdateComponentSizes();

            timeScaleLabel.Text = timeScale.ToString("0.0");
            UpdateSliderValueLabels();

            StartSimulation();

            Task.Run(() => { RenderView(); });
        }

        private void UpdateSliderValueLabels()
        {
            amplitude1Label.Text = string.Format("Amplitude: {0}", (amplitude1TrackBar.Value / 100.0).ToString("0.00"));
            amplitude2Label.Text = string.Format("Amplitude: {0}", (amplitude2TrackBar.Value / 100.0).ToString("0.00"));

            phase1Label.Text = string.Format("Phase: {0} π", (phase1TrackBar.Value / 100.0).ToString("0.00"));
            phase2Label.Text = string.Format("Phase: {0} π", (phase2TrackBar.Value / 100.0).ToString("0.00"));

            waveLength1Label.Text = string.Format("Wavelength: {0}", (waveLength1TrackBar.Value / 100.0).ToString("0.00"));
            waveLength2Label.Text = string.Format("Wavelength: {0}", (waveLength2TrackBar.Value / 100.0).ToString("0.00"));

            frequency1Label.Text = string.Format("Frequency: {0} Hz", (frequency1TrackBar.Value / 10.0).ToString("0.00"));
            frequency2Label.Text = string.Format("Frequency: {0} Hz", (frequency2TrackBar.Value / 10.0).ToString("0.00"));

            zMinLabel.Text = string.Format("zmin: {0}", (zMinTrackBar.Value / -100.0).ToString("0.00"));
            zMaxLabel.Text = string.Format("zmax: {0}", (zMaxTrackBar.Value / 100.0).ToString("0.00"));
             
            viewRLabel.Text = string.Format("r: {0}", (viewRTrackBar.Value / 1.0).ToString("0.00"));
            viewTetaLabel.Text = string.Format("teta: {0} π", (viewTetaTrackBar.Value / 100.0).ToString("0.00"));
            viewFiLabel.Text = string.Format("fi: {0} π", (viewFiTrackBar.Value / 100.0).ToString("0.00"));

            zoomLabel.Text = string.Format("zoom: {0}", (zoomTrackBar.Value / 10.0).ToString("0.00"));
        }

        private void ApplySliderValues()
        {
            wave.a[0] = (amplitude1TrackBar.Value / 100.0);
            wave.a[1] = (amplitude2TrackBar.Value / 100.0);
            wave.d[0] = 3.141592653589793 * (phase1TrackBar.Value / 100.0);
            wave.d[1] = 3.141592653589793 * (phase2TrackBar.Value / 100.0);
            wave.k[0] = 6.283185307179586 / (waveLength1TrackBar.Value / 100.0);
            wave.k[1] = 6.283185307179586 / (waveLength2TrackBar.Value / 100.0);
            wave.w[0] = 6.283185307179586 * (frequency1TrackBar.Value / 10.0);
            wave.w[1] = 6.283185307179586 * (frequency2TrackBar.Value / 10.0);
            axis.bb[2] = (zMinTrackBar.Value / -100.0);
            wave.bb[2] = (zMinTrackBar.Value / -100.0);
            axis.bb[5] = (zMaxTrackBar.Value / 100.0);
            wave.bb[5] = (zMaxTrackBar.Value / 100.0);
            graph.Zoom = (2.2 - (zoomTrackBar.Value / 10.0));
            double value = (viewRTrackBar.Value / 1.0);
            double a = 3.141592653589793 * (viewTetaTrackBar.Value / 100.0);
            double n = 3.141592653589793 * (viewFiTrackBar.Value / 100.0);
            graph.view = new Vector(value * Math.Sin(a) * Math.Sin(n), value * Math.Cos(a), value * Math.Sin(a) * Math.Cos(n));
            graph.UpdateView();
        }

        private void InitGraph()
        {
            graph = new Graph(pictureBox.Width, pictureBox.Height, this.axis, this.wave, new Vector(1, 1, 1));
            ApplySliderValues();
        }

        private void StartSimulation()
        {
            if (!isRunning)
            {
                lastDrawTime = DateTime.UtcNow;
                tokenSource = new CancellationTokenSource();
                updateThread = Task.Run(() => { Simulate(tokenSource.Token); });
            }
        }

        private void StopSimulation()
        {
            tokenSource.Cancel();
        }

        private void RenderView()
        {
            while(true)
            {
                Thread.Sleep(1);
                pictureBox.Invoke(new Action(() => { pictureBox.Refresh(); }));
            }
        }

        private void Simulate(CancellationToken cancellationToken)
        {
            isRunning = true;
            while (!cancellationToken.IsCancellationRequested)
            {
                Thread.Sleep(1);
                graph.Update((DateTime.UtcNow - lastDrawTime).TotalSeconds * timeScale);
                lastDrawTime = DateTime.UtcNow;
            }
            isRunning = false;
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            graph.Draw(e.Graphics);
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void UpdateComponentSizes()
        {
            double widthDifference = formStartWidth - pictureStartWidth;
            double heightDifference = formStartHeight - pictureStartHeight;
            pictureBox.Width = (int)(Width - widthDifference);
            pictureBox.Height = (int)(Height - heightDifference);
            middlePanel.Width = pictureBox.Width;
            middlePanel.Height = Height - 40;
            InitGraph();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            UpdateComponentSizes();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {

        }

        private void timeScaleTrackBar_Scroll(object sender, EventArgs e)
        {
            timeScale = Math.Pow((timeScaleTrackBar.Value / 100d), 2);
            timeScaleLabel.Text = timeScale.ToString("0.00");
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartSimulation();
            ApplySliderValues();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            StopSimulation();
            ApplySliderValues();
        }

        private void amplitude1TrackBar_Scroll(object sender, EventArgs e)
        {
            UpdateSliderValueLabels();
            ApplySliderValues();
        }

        private void waveLength1TrackBar_Scroll(object sender, EventArgs e)
        {
            UpdateSliderValueLabels();
            ApplySliderValues();
        }

        private void frequency1TrackBar_Scroll(object sender, EventArgs e)
        {
            UpdateSliderValueLabels();
            ApplySliderValues();
        }

        private void phase1TrackBar_Scroll(object sender, EventArgs e)
        {
            UpdateSliderValueLabels();
            ApplySliderValues();
        }

        private void viewRTrackBar_Scroll(object sender, EventArgs e)
        {
            UpdateSliderValueLabels();
            ApplySliderValues();
        }

        private void viewTetaTrackBar_Scroll(object sender, EventArgs e)
        {
            UpdateSliderValueLabels();
            ApplySliderValues();
        }

        private void viewFiTrackBar_Scroll(object sender, EventArgs e)
        {
            UpdateSliderValueLabels();
            ApplySliderValues();
        }

        private void amplitude2TrackBar_Scroll(object sender, EventArgs e)
        {
            UpdateSliderValueLabels();
            ApplySliderValues();
        }

        private void waveLength2TrackBar_Scroll(object sender, EventArgs e)
        {
            UpdateSliderValueLabels();
            ApplySliderValues();
        }

        private void frequency2TrackBar_Scroll(object sender, EventArgs e)
        {
            UpdateSliderValueLabels();
            ApplySliderValues();
        }

        private void phase2TrackBar_Scroll(object sender, EventArgs e)
        {
            UpdateSliderValueLabels();
            ApplySliderValues();
        }

        private void zMinTrackBar_Scroll(object sender, EventArgs e)
        {
            UpdateSliderValueLabels();
            ApplySliderValues();
        }

        private void zMaxTrackBar_Scroll(object sender, EventArgs e)
        {
            UpdateSliderValueLabels();
            ApplySliderValues();
        }

        private void zoomTrackBar_Scroll(object sender, EventArgs e)
        {
            UpdateSliderValueLabels();
            ApplySliderValues();
        }
    }
}

import java.awt.GridLayout;
import java.awt.Component;
import java.awt.Panel;
import java.awt.LayoutManager;
import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Font;
import java.awt.event.AdjustmentEvent;
import java.awt.event.ActionEvent;
import java.awt.Label;
import java.awt.Button;
import java.awt.event.AdjustmentListener;
import java.awt.event.ActionListener;
import java.applet.Applet;

// 
// Decompiled by Procyon v0.5.36
// 

public class PolarizationLab extends Applet implements Runnable, ActionListener, AdjustmentListener
{
    double dt;
    Axis axis;
    Wave wave;
    Graph graph;
    Thread drawThread;
    MyCanvas canvas;
    Button bt;
    Label lbl;
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
    
    public PolarizationLab() {
        this.dt = 0.05;
    }
    
    public void actionPerformed(final ActionEvent actionEvent) {
        if (actionEvent.getActionCommand().equals("Start")) {
            this.start();
        }
        else if (actionEvent.getActionCommand().equals("Stop")) {
            this.stop();
        }
    }
    
    public void adjustmentValueChanged(final AdjustmentEvent adjustmentEvent) {
        this.readScrollbars();
        this.graph.update();
        if (this.drawThread == null) {
            this.canvas.repaint();
        }
    }
    
    public void init() {
        final int height = this.getSize().height;
        final int width = this.getSize().width;
        final Font font = new Font("SansSerif", 1, 24);
        final Font font2 = new Font("SansSerif", 1, 14);
        this.setBackground(Color.white);
        this.setLayout(new BorderLayout());
        final Panel comp = new Panel();
        final Panel comp2 = new Panel();
        final Panel comp3 = new Panel();
        final Panel comp4 = new Panel();
        comp.add(this.lbl = new Label("Polarization Lab"));
        this.lbl.setFont(font);
        comp4.add(this.bt = new Button("Start"));
        this.bt.setActionCommand(this.bt.getLabel());
        this.bt.addActionListener(this);
        comp4.add(this.bt = new Button("Stop"));
        this.bt.setActionCommand(this.bt.getLabel());
        this.bt.addActionListener(this);
        comp2.setLayout(new GridLayout(9, 1));
        comp2.add(this.lbl = new Label("x - Component", 1));
        this.lbl.setFont(font2);
        comp2.add(this.amp1Sb = new MyScrollbar("Amplitude ", 0.2, 0.0, 0.5, 50, this));
        comp2.add(this.wL1Sb = new MyScrollbar("Wavelength ", 0.25, 0.1, 1.0, 100, this));
        comp2.add(this.frq1Sb = new MyScrollbar("Frequency ", 1.0, 0.0, 10.0, 100, " Hz", this));
        comp2.add(this.ph1Sb = new MyScrollbar("Phase ", 0.0, 0.0, 2.0, 100, " Pi", this));
        comp2.add(this.lbl = new Label("View", 1));
        this.lbl.setFont(font2);
        comp2.add(this.viewrSb = new MyScrollbar("r = ", 3.0, 1.0, 100.0, 100, this));
        comp2.add(this.viewtetaSb = new MyScrollbar("teta = ", 0.4, 0.0, 1.0, 100, " Pi", this));
        comp2.add(this.viewfiSb = new MyScrollbar("fi = ", 0.2, 0.0, 2.0, 200, " Pi", this));
        comp3.setLayout(new GridLayout(9, 1));
        comp3.add(this.lbl = new Label("y - Component", 1));
        this.lbl.setFont(font2);
        comp3.add(this.amp2Sb = new MyScrollbar("Amplitude ", 0.2, 0.0, 0.5, 50, this));
        comp3.add(this.wL2Sb = new MyScrollbar("Wavelength ", 0.25, 0.1, 1.0, 100, this));
        comp3.add(this.frq2Sb = new MyScrollbar("Frequency ", 1.0, 0.0, 10.0, 100, " Hz", this));
        comp3.add(this.ph2Sb = new MyScrollbar("Phase ", 0.5, 0.0, 2.0, 100, " Pi", this));
        comp3.add(this.lbl = new Label("Axis limits", 1));
        this.lbl.setFont(font2);
        comp3.add(this.zminSb = new MyScrollbar("zmin = ", -1.0, 0.0, -1.0, 100, this));
        comp3.add(this.zmaxSb = new MyScrollbar("zmax = ", 1.0, 0.0, 1.0, 100, this));
        this.add("North", comp);
        this.add("West", comp2);
        this.add("East", comp3);
        this.add("South", comp4);
        final double[] array = { -1.0, -1.0, -1.0, 1.0, 1.0, 1.0 };
        this.axis = new Axis(array);
        (this.wave = new Wave(0.2, Vector.X, Vector.Z, 0.25, 1.0, 0.0, array)).add(new Wave(0.2, Vector.Y, Vector.Z, 0.25, 1.0, 1.5707963267948966, array));
        final int n = width - comp2.getPreferredSize().width - comp3.getPreferredSize().width;
        final int n2 = height - comp.getPreferredSize().height - comp4.getPreferredSize().height;
        this.graph = new Graph(n, n2, this.axis, this.wave, new Vector(5.0, 7.1, 5.0));
        this.add("Center", this.canvas = new MyCanvas(n, n2, this.graph));
        this.readScrollbars();
        this.graph.update();
    }
    
    void readScrollbars() {
        this.wave.a[0] = this.amp1Sb.getValue();
        this.wave.a[1] = this.amp2Sb.getValue();
        this.wave.d[0] = 3.141592653589793 * this.ph1Sb.getValue();
        this.wave.d[1] = 3.141592653589793 * this.ph2Sb.getValue();
        this.wave.k[0] = 6.283185307179586 / this.wL1Sb.getValue();
        this.wave.k[1] = 6.283185307179586 / this.wL2Sb.getValue();
        this.wave.w[0] = 6.283185307179586 * this.frq1Sb.getValue();
        this.wave.w[1] = 6.283185307179586 * this.frq2Sb.getValue();
        this.axis.bb[2] = this.zminSb.getValue();
        this.wave.bb[2] = this.zminSb.getValue();
        this.axis.bb[5] = this.zmaxSb.getValue();
        this.wave.bb[5] = this.zmaxSb.getValue();
        final double value = this.viewrSb.getValue();
        final double a = 3.141592653589793 * this.viewtetaSb.getValue();
        final double n = 3.141592653589793 * this.viewfiSb.getValue();
        this.graph.view = new Vector(value * Math.sin(a) * Math.sin(n), value * Math.cos(a), value * Math.sin(a) * Math.cos(n));
    }
    
    public void run() {
        while (this.drawThread != null) {
            try {
                Thread.sleep((int)(this.dt * 1000.0));
            }
            catch (InterruptedException ex) {}
            this.graph.update(this.dt);
            this.canvas.repaint();
        }
    }
    
    public void start() {
        if (this.drawThread == null) {
            (this.drawThread = new Thread(this)).start();
        }
    }
    
    public void stop() {
        this.drawThread = null;
    }
}

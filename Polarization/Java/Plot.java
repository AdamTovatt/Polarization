import java.awt.GridLayout;
import java.awt.Component;
import java.awt.Panel;
import java.awt.LayoutManager;
import java.awt.BorderLayout;
import java.text.NumberFormat;
import java.awt.event.AdjustmentEvent;
import java.awt.event.ActionEvent;
import java.awt.Label;
import java.awt.Scrollbar;
import java.awt.Button;
import java.awt.event.AdjustmentListener;
import java.awt.event.ActionListener;
import java.applet.Applet;

// 
// Decompiled by Procyon v0.5.36
// 

public class Plot extends Applet implements Runnable, ActionListener, AdjustmentListener
{
    double dt;
    Axis axis;
    Wave wave;
    Graph graph;
    Thread drawThread;
    MyCanvas canvas;
    Button bt;
    Scrollbar viewrSb;
    Scrollbar viewtetaSb;
    Scrollbar viewfiSb;
    Scrollbar frq1Sb;
    Scrollbar frq2Sb;
    Scrollbar wL1Sb;
    Scrollbar wL2Sb;
    Scrollbar amp1Sb;
    Scrollbar amp2Sb;
    Scrollbar ph1Sb;
    Scrollbar ph2Sb;
    Scrollbar zmaxSb;
    Scrollbar zminSb;
    Label viewrLbl;
    Label viewtetaLbl;
    Label viewfiLbl;
    Label frq1Lbl;
    Label frq2Lbl;
    Label wL1Lbl;
    Label wL2Lbl;
    Label amp1Lbl;
    Label amp2Lbl;
    Label ph1Lbl;
    Label ph2Lbl;
    Label zmaxLbl;
    Label zminLbl;
    
    public Plot() {
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
        final NumberFormat numberInstance = NumberFormat.getNumberInstance();
        numberInstance.setMaximumFractionDigits(2);
        final double number = 0.5 * this.amp1Sb.getValue() / 100.0;
        this.amp1Lbl.setText("Amplitude " + numberInstance.format(number));
        this.wave.a[0] = number;
        final double number2 = 0.5 * this.amp2Sb.getValue() / 100.0;
        this.amp2Lbl.setText("Amplitude " + numberInstance.format(number2));
        this.wave.a[1] = number2;
        final double number3 = 2 * this.ph1Sb.getValue() / 100.0;
        this.ph1Lbl.setText("Phase " + numberInstance.format(number3) + " Pi");
        this.wave.d[0] = 3.141592653589793 * number3;
        final double number4 = 2 * this.ph2Sb.getValue() / 100.0;
        this.ph2Lbl.setText("Phase " + numberInstance.format(number4) + " Pi");
        this.wave.d[1] = 3.141592653589793 * number4;
        final double number5 = this.wL1Sb.getValue() / 100.0;
        this.wL1Lbl.setText("Wavelength " + numberInstance.format(number5));
        this.wave.k[0] = 6.283185307179586 / number5;
        final double number6 = this.wL2Sb.getValue() / 100.0;
        this.wL2Lbl.setText("Wavelength " + numberInstance.format(number6));
        this.wave.k[1] = 6.283185307179586 / number6;
        final double number7 = 10 * this.frq1Sb.getValue() / 100.0;
        this.frq1Lbl.setText("Frequency " + numberInstance.format(number7) + " Hz");
        this.wave.w[0] = 6.283185307179586 * number7;
        final double number8 = 10 * this.frq2Sb.getValue() / 100.0;
        this.frq2Lbl.setText("Frequency " + numberInstance.format(number8) + " Hz");
        this.wave.w[1] = 6.283185307179586 * number8;
        final double number9 = this.zminSb.getValue() / 100.0;
        this.zminLbl.setText("zmin = " + numberInstance.format(number9));
        this.axis.bb[2] = number9;
        this.wave.bb[2] = number9;
        final double number10 = this.zmaxSb.getValue() / 100.0;
        this.zmaxLbl.setText("zmax = " + numberInstance.format(number10));
        this.axis.bb[5] = number10;
        this.wave.bb[5] = number10;
        final double number11 = this.viewrSb.getValue();
        final double number12 = this.viewtetaSb.getValue() / 100.0;
        final double number13 = this.viewfiSb.getValue() / 100.0;
        this.viewrLbl.setText("r = " + numberInstance.format(number11));
        this.viewtetaLbl.setText("teta = " + numberInstance.format(number12) + " Pi");
        this.viewfiLbl.setText("fi = " + numberInstance.format(number13) + " Pi");
        final double a = 3.141592653589793 * number12;
        final double n = 3.141592653589793 * number13;
        this.graph.view = new Vector(number11 * Math.sin(a) * Math.sin(n), number11 * Math.cos(a), number11 * Math.sin(a) * Math.cos(n));
        this.graph.update();
        if (this.drawThread == null) {
            this.canvas.repaint();
        }
    }
    
    public void init() {
        final int height = this.getHeight();
        final int width = this.getWidth();
        this.setLayout(new BorderLayout());
        final Panel comp = new Panel();
        final Panel comp2 = new Panel();
        final Panel comp3 = new Panel();
        final Panel comp4 = new Panel();
        comp.add(new Label(" Interference of two plane waves"));
        comp4.add(this.bt = new Button("Start"));
        this.bt.setActionCommand(this.bt.getLabel());
        this.bt.addActionListener(this);
        comp4.add(this.bt = new Button("Stop"));
        this.bt.setActionCommand(this.bt.getLabel());
        this.bt.addActionListener(this);
        comp2.setLayout(new GridLayout(16, 1));
        comp2.add(new Label("x - Component", 1));
        comp2.add(this.amp1Lbl = new Label("Amplitude 0.2"));
        comp2.add(this.amp1Sb = new Scrollbar(0, 40, 0, 0, 101));
        this.amp1Sb.addAdjustmentListener(this);
        comp2.add(this.wL1Lbl = new Label("Wavelength 0.25"));
        comp2.add(this.wL1Sb = new Scrollbar(0, 25, 0, 10, 101));
        this.wL1Sb.addAdjustmentListener(this);
        comp2.add(this.frq1Lbl = new Label("Frequency 1 Hz"));
        comp2.add(this.frq1Sb = new Scrollbar(0, 10, 0, 0, 101));
        this.frq1Sb.addAdjustmentListener(this);
        comp2.add(this.ph1Lbl = new Label("Phase 0"));
        comp2.add(this.ph1Sb = new Scrollbar(0, 0, 0, 0, 101));
        this.ph1Sb.addAdjustmentListener(this);
        comp2.add(new Label("View", 1));
        comp2.add(this.viewrLbl = new Label("r = 10"));
        comp2.add(this.viewrSb = new Scrollbar(0, 10, 0, 1, 101));
        this.viewrSb.addAdjustmentListener(this);
        comp2.add(this.viewtetaLbl = new Label("teta = 0.25 Pi"));
        comp2.add(this.viewtetaSb = new Scrollbar(0, 25, 0, 0, 101));
        this.viewtetaSb.addAdjustmentListener(this);
        comp2.add(this.viewfiLbl = new Label("fi = 0.25 Pi"));
        comp2.add(this.viewfiSb = new Scrollbar(0, 25, 0, 0, 201));
        this.viewfiSb.addAdjustmentListener(this);
        comp3.setLayout(new GridLayout(16, 1));
        comp3.add(new Label("y - Component", 1));
        comp3.add(this.amp2Lbl = new Label("Amplitude 0.2"));
        comp3.add(this.amp2Sb = new Scrollbar(0, 40, 0, 0, 101));
        this.amp2Sb.addAdjustmentListener(this);
        comp3.add(this.wL2Lbl = new Label("Wavelength 0.25"));
        comp3.add(this.wL2Sb = new Scrollbar(0, 25, 0, 10, 101));
        this.wL2Sb.addAdjustmentListener(this);
        comp3.add(this.frq2Lbl = new Label("Frequency 1 Hz"));
        comp3.add(this.frq2Sb = new Scrollbar(0, 10, 0, 0, 101));
        this.frq2Sb.addAdjustmentListener(this);
        comp3.add(this.ph2Lbl = new Label("Phase 0"));
        comp3.add(this.ph2Sb = new Scrollbar(0, 0, 0, 0, 101));
        this.ph2Sb.addAdjustmentListener(this);
        comp3.add(new Label("Axis limits", 1));
        comp3.add(this.zminLbl = new Label("zmin = -1"));
        comp3.add(this.zminSb = new Scrollbar(0, -100, 0, -100, 1));
        this.zminSb.addAdjustmentListener(this);
        comp3.add(this.zmaxLbl = new Label("zmax = 1"));
        comp3.add(this.zmaxSb = new Scrollbar(0, 101, 0, 0, 101));
        this.zmaxSb.addAdjustmentListener(this);
        this.add("North", comp);
        this.add("West", comp2);
        this.add("East", comp3);
        this.add("South", comp4);
        final double[] array = { -1.0, -1.0, -1.0, 1.0, 1.0, 1.0 };
        this.axis = new Axis(array);
        (this.wave = new Wave(0.2, Vector.X, Vector.Z, 0.25, 1.0, 0.0, array)).add(new Wave(0.2, Vector.Y, Vector.Z, 0.25, 1.0, 0.0, array));
        this.graph = new Graph(width / 2, height / 2, this.axis, this.wave, new Vector(5.0, 7.1, 5.0));
        this.add("Center", this.canvas = new MyCanvas(width / 2, height / 2, this.graph));
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

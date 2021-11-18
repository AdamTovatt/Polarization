import java.awt.Component;
import java.awt.LayoutManager;
import java.awt.GridLayout;
import java.awt.event.AdjustmentListener;
import java.awt.Scrollbar;
import java.awt.Label;
import java.text.NumberFormat;
import java.awt.Panel;

// 
// Decompiled by Procyon v0.5.36
// 

class MyScrollbar extends Panel
{
    int n;
    NumberFormat nf;
    Label lbl;
    Scrollbar sb;
    String string1;
    String string2;
    double scale;
    
    public MyScrollbar(final String s, final double n, final double n2, final double n3, final int n4, final AdjustmentListener adjustmentListener) {
        this(s, n, n2, n3, n4, "", adjustmentListener);
    }
    
    public MyScrollbar(final String string1, final double n, final double n2, final double n3, final int n4, final String string2, final AdjustmentListener l) {
        this.setLayout(new GridLayout(2, 1));
        (this.nf = NumberFormat.getNumberInstance()).setMaximumFractionDigits(2);
        this.n = n4;
        this.string1 = string1;
        this.string2 = string2;
        this.scale = n3 / n4;
        (this.sb = new Scrollbar(0, (int)(n4 * n / n3), 0, (int)(n4 * n2 / n3), n4 + 1)).addAdjustmentListener(l);
        this.lbl = new Label();
        this.updateLabel();
        this.add(this.lbl);
        this.add(this.sb);
    }
    
    public double getValue() {
        this.updateLabel();
        return this.scale * this.sb.getValue();
    }
    
    public void updateLabel() {
        this.lbl.setText(String.valueOf(this.string1) + this.nf.format(this.scale * this.sb.getValue()) + this.string2);
    }
}

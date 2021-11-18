import java.awt.Color;

// 
// Decompiled by Procyon v0.5.36
// 

class Axis implements ObjectToDraw
{
    double[] bb;
    Polygon[] p;
    Color[] c;
    
    public Axis(final double[] bb) {
        this.bb = new double[6];
        this.p = new Polygon[1];
        this.c = new Color[1];
        this.bb = bb;
        this.c[0] = Color.black;
        this.update();
    }
    
    public Color[] color() {
        return this.c;
    }
    
    public Polygon[] data() {
        return this.p;
    }
    
    public void update() {
        this.p[0] = new Polygon(new Vector[] { new Vector(this.bb[0], 0.0, 0.0), new Vector(this.bb[3], 0.0, 0.0), new Vector(0.0, 0.0, 0.0), new Vector(0.0, this.bb[1], 0.0), new Vector(0.0, this.bb[4], 0.0), new Vector(0.0, 0.0, 0.0), new Vector(0.0, 0.0, this.bb[2]), new Vector(0.0, 0.0, this.bb[5]) });
    }
    
    public void update(final double n) {
    }
}

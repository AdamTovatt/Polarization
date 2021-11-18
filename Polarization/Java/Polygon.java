// 
// Decompiled by Procyon v0.5.36
// 

class Polygon
{
    Vector[] r;
    
    public Polygon(final Vector[] r) {
        this.r = r;
    }
    
    public double[] boundingBox() {
        final double[] array = { Math.exp(1000.0), Math.exp(1000.0), Math.exp(1000.0), -Math.exp(1000.0), -Math.exp(1000.0), -Math.exp(1000.0) };
        for (int i = 0; i < this.r.length; ++i) {
            array[0] = Math.min(array[0], this.r[i].x);
            array[1] = Math.min(array[1], this.r[i].y);
            array[2] = Math.min(array[2], this.r[i].z);
            array[3] = Math.max(array[3], this.r[i].x);
            array[4] = Math.max(array[4], this.r[i].y);
            array[5] = Math.max(array[5], this.r[i].z);
        }
        return array;
    }
    
    public int[] intx() {
        final int[] array = new int[this.r.length];
        for (int i = 0; i < this.r.length; ++i) {
            array[i] = (int)this.r[i].x;
        }
        return array;
    }
    
    public int[] inty() {
        final int[] array = new int[this.r.length];
        for (int i = 0; i < this.r.length; ++i) {
            array[i] = (int)this.r[i].y;
        }
        return array;
    }
    
    public int[] intz() {
        final int[] array = new int[this.r.length];
        for (int i = 0; i < this.r.length; ++i) {
            array[i] = (int)this.r[i].z;
        }
        return array;
    }
    
    public int length() {
        return this.r.length;
    }
    
    public Polygon pixel(final Vector vector, final Vector vector2) {
        final Vector[] array = new Vector[this.r.length];
        for (int i = 0; i < this.r.length; ++i) {
            array[i] = this.r[i].subtract(vector);
            array[i] = new Vector((double)Math.round(array[i].x * vector2.x), (double)Math.round(array[i].y * vector2.y), (double)Math.round(array[i].z * vector2.z));
        }
        return new Polygon(array);
    }
    
    public Polygon project(final Vector vector) {
        final Vector[] array = new Vector[this.r.length];
        final Vector normalize = vector.normalize();
        final double abs = vector.abs();
        for (int i = 0; i < this.r.length; ++i) {
            final double mult = this.r[i].mult(normalize);
            array[i] = this.r[i].subtract(normalize.scale(mult)).scale(1.0 / (1.0 - mult / abs));
        }
        return new Polygon(array);
    }
    
    public Polygon rotate(final Vector vector) {
        final Vector[] array = new Vector[this.r.length];
        final Vector normalize = vector.normalize();
        final Vector normalize2 = normalize.subtract(Vector.Y.scale(normalize.mult(Vector.Y))).normalize();
        Vector vector2;
        if (normalize2.abs() != 0.0) {
            vector2 = Vector.Y.prod(normalize2);
        }
        else {
            vector2 = Vector.X;
        }
        final Vector vector3 = normalize;
        final Vector prod = vector3.prod(vector2);
        for (int i = 0; i < this.r.length; ++i) {
            array[i] = new Vector(this.r[i].mult(vector2), this.r[i].mult(prod), this.r[i].mult(vector3));
        }
        return new Polygon(array);
    }
    
    public double[] x() {
        final double[] array = new double[this.r.length];
        for (int i = 0; i < this.r.length; ++i) {
            array[i] = this.r[i].x;
        }
        return array;
    }
    
    public double[] y() {
        final double[] array = new double[this.r.length];
        for (int i = 0; i < this.r.length; ++i) {
            array[i] = this.r[i].y;
        }
        return array;
    }
    
    public double[] z() {
        final double[] array = new double[this.r.length];
        for (int i = 0; i < this.r.length; ++i) {
            array[i] = this.r[i].z;
        }
        return array;
    }
}

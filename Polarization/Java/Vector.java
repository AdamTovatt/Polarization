// 
// Decompiled by Procyon v0.5.36
// 

class Vector
{
    double x;
    double y;
    double z;
    static Vector X;
    static Vector Y;
    static Vector Z;
    
    static {
        Vector.X = new Vector(1.0, 0.0, 0.0);
        Vector.Y = new Vector(0.0, 1.0, 0.0);
        Vector.Z = new Vector(0.0, 0.0, 1.0);
    }
    
    public Vector(final double x, final double y, final double z) {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    
    public double abs() {
        return Math.sqrt(this.x * this.x + this.y * this.y + this.z * this.z);
    }
    
    public Vector add(final Vector vector) {
        final Vector vector2 = new Vector(0.0, 0.0, 0.0);
        vector2.x = this.x + vector.x;
        vector2.y = this.y + vector.y;
        vector2.z = this.z + vector.z;
        return vector2;
    }
    
    public double mult(final Vector vector) {
        return this.x * vector.x + this.y * vector.y + this.z * vector.z;
    }
    
    public Vector normalize() {
        Vector scale = new Vector(0.0, 0.0, 0.0);
        if (this.abs() != 0.0) {
            scale = this.scale(1.0 / this.abs());
        }
        return scale;
    }
    
    public Vector prod(final Vector vector) {
        final Vector vector2 = new Vector(0.0, 0.0, 0.0);
        vector2.x = this.y * vector.z - this.z * vector.y;
        vector2.y = this.z * vector.x - this.x * vector.z;
        vector2.z = this.x * vector.y - this.y * vector.x;
        return vector2;
    }
    
    public Vector scale(final double n) {
        final Vector vector = new Vector(0.0, 0.0, 0.0);
        vector.x = n * this.x;
        vector.y = n * this.y;
        vector.z = n * this.z;
        return vector;
    }
    
    public Vector subtract(final Vector vector) {
        final Vector vector2 = new Vector(0.0, 0.0, 0.0);
        vector2.x = this.x - vector.x;
        vector2.y = this.y - vector.y;
        vector2.z = this.z - vector.z;
        return vector2;
    }
}

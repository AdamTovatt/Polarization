import java.awt.Color;

// 
// Decompiled by Procyon v0.5.36
// 

interface ObjectToDraw
{
    Color[] color();
    
    Polygon[] data();
    
    void update();
    
    void update(final double p0);
}

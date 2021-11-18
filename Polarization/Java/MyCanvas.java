import java.awt.image.ImageObserver;
import java.awt.Graphics;
import java.awt.Image;
import java.awt.Canvas;

// 
// Decompiled by Procyon v0.5.36
// 

class MyCanvas extends Canvas
{
    Graph graph;
    Image offScrImg;
    
    public MyCanvas(final int width, final int height, final Graph graph) {
        this.setSize(width, height);
        this.graph = graph;
    }
    
    public void paint(final Graphics graphics) {
        this.graph.draw(graphics);
    }
    
    public void update(final Graphics graphics) {
        final int width = this.getSize().width;
        final int height = this.getSize().height;
        if (this.offScrImg == null) {
            this.offScrImg = this.createImage(width, height);
        }
        final Graphics graphics2 = this.offScrImg.getGraphics();
        graphics2.setColor(this.getBackground());
        graphics2.fillRect(0, 0, width, height);
        this.paint(graphics2);
        graphics.drawImage(this.offScrImg, 0, 0, this);
        graphics2.dispose();
    }
}

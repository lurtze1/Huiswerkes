package Week3;

import javax.swing.*;
import java.awt.*;

/**
 * Created by lurtze1 on 19-Sep-16.
 */
class MyPanel extends JPanel {

    public MyPanel() {
        setBorder(BorderFactory.createLineBorder(Color.black));
    }

    public Dimension getPreferredSize() {
        return new Dimension(1200, 1200);
    }

    public void paintComponent(Graphics g) {
        super.paintComponent(g);
        g.setColor(Color.black);
        this.paintHTree(g, 600, 500, 300, 1, true);
    }

    public void paintHTree(Graphics g, int startX, int startY, int Length, int MinimumLength, boolean Angled){
        if(Length > MinimumLength){
            if(Angled){
                Angled = false;
                g.drawLine(startX , startY, startX+Length, startY);
                g.drawLine(startX , startY, startX-Length, startY);
                paintHTree(g,startX+Length, startY, (int) (Length/Math.sqrt(2)), MinimumLength, Angled);
                paintHTree(g,startX-Length, startY, (int) (Length/Math.sqrt(2)), MinimumLength, Angled);
            } else {
                Angled = true;
                g.drawLine(startX , startY, startX, startY+Length);
                g.drawLine(startX , startY, startX, startY-Length);
                paintHTree(g,startX, startY+Length, (int) (Length/Math.sqrt(2)), MinimumLength, Angled);
                paintHTree(g,startX, startY-Length, (int) (Length/Math.sqrt(2)), MinimumLength, Angled);
            }
        }
    }
}

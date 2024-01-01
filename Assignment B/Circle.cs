using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Assignment_B
{
    public class Circle : PictureBox
    {
        private int x;
        private int y;
        private int radius;
      
        // create circle objects
        public Circle(int posX, int posY, int width, int height, Pen pen, Color color, PictureBox parent)
        {
            x = posX;
            y = posY;
            radius = width;
            radius = height;
            
          
            Graphics myGraphics = parent.CreateGraphics();
            var circle = new PictureBox();


            circle.Size = new Size(radius, radius);
            circle.Location = new Point(x, y);
            circle.Visible = false;
            
            // if circle doesn't have intersections with existing circles
            if (!Intersect(x, y))
            {
                parent.Controls.Add(circle);

                Rectangle filledcircle = new Rectangle(x, y, radius, radius);
                myGraphics.FillEllipse(new SolidBrush(color), filledcircle);
                Rectangle contour = new Rectangle(x, y, radius, radius);
                myGraphics.DrawEllipse(pen, contour);
            }
            // if circle does have intersections with existing circles
            else if (Intersect(x, y))
            {
                Random rando = new Random();
                do
                {
                    x = rando.Next(10, parent.Size.Width - 200);
                    y = rando.Next(10, parent.Size.Height - 200);
                    circle.Location = new Point(x, y);
                   
                } while (Intersect(x, y));
                
                circle.Location = new Point(x, y);
                parent.Controls.Add(circle);

                Rectangle filledcircle = new Rectangle(x, y, radius, radius);
                myGraphics.FillEllipse(new SolidBrush(color), filledcircle);
                Rectangle contour = new Rectangle(x, y, radius, radius);
                myGraphics.DrawEllipse(pen, contour);
            }

            Thread.Sleep(20);
        }

        // calculates the distance between 2 points
        public int PointDistance(int x, int y, int x2, int y2)
        {
            return (int)(Math.Sqrt((x - x2) * (x - x2) + (y - y2) * (y - y2)));
        }


        // calculates if any intersection is possible
        Circle[] circles = Form1.GetCircles();
        private bool Intersect(int newX, int newY)
        {
            foreach (Circle circle in circles)
            {
                if(circle != null)
                {
                    foreach (Circle newCircle in circles)
                    {
                        if (newCircle != null && newCircle != circle && circle != null)
                        {
                            int lastX = circle.x;
                            int lastY = circle.y;
                      
                            if ((newCircle != this) && (newCircle.PointDistance(newX, newY, lastX, lastY) <= radius))
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

       
    }
}

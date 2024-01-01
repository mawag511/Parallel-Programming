using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Assignment_B
{
    public partial class Form1 : Form
    {
        // import 1000 circles
        static Circle[] circles = new Circle[1000];

        public Form1()
        {
            InitializeComponent();
        }

        static List<Circle> allCircles = new List<Circle>();

        DateTime end;
        TimeSpan diff;
        DateTime begin;

        // function that creates random circles
        public void CreateCircles(int divisor)
        {
            Random rando = new Random();
            int radius = 15;
            int borderX = pictureBox1.Size.Width;
            int borderY = pictureBox1.Size.Height;
           
            for (int i = 0; i < divisor; i++)
            {
                int x = rando.Next(10, borderX-radius*2);
                int y = rando.Next(10, borderY-radius*2);
                Color penColor = Color.FromArgb(rando.Next(0, 255), rando.Next(0, 255), rando.Next(0, 255), rando.Next(0, 255));
                Pen contour = new Pen(Color.Black, 1);

                // for sequential
                //circles[i] = new Circle(x, y, radius, radius, contour, penColor, pictureBox1);
                //allCircles.Add(circles[i]);
                //countTB.Invalidate();
                //countTB.Update();
                //countTB.Text = allCircles.Count.ToString();


                //for parallel 
                this.Invoke((MethodInvoker)delegate ()
                {
                    circles[i] = new Circle(x, y, radius, radius, contour, penColor, pictureBox1);
                    allCircles.Add(circles[i]);
                    countTB.Invalidate();
                    countTB.Update();
                    countTB.Text = allCircles.Count.ToString();
                });



                if (int.Parse(countTB.Text) == circles.Length)
                {
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        startstop.Enabled = true;
                        restart.Enabled = true;
                        durationTB.Visible = true;
                        end = DateTime.Now;
                        diff = end.Subtract(begin);
                        durationLabel.Visible = true;
                        durationTB.Text = diff.ToString();
                    });
                   
                }
            }
        }

        // divides the task into workers (5 / 20 / 100)
        public void Workers()
        {
            begin = DateTime.Now;
            int workers = 5;
            //int workers = 20;
            //int workers = 100;

            int divisor = circles.Length / workers;
           
            for (int i = 0; i < workers; i++)
            {
                CreateCircles(divisor);
            }
        }


        // divides the task into workers (5 / 20 / 100) and works in parallel
        public void WorkersParallel()
        {
            begin = DateTime.Now;
            int workers = 5;
            //int workers = 20;
            //int workers = 100;

            int divisor = circles.Length / workers;
            Thread[] threads = new Thread[workers];
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(() => { CreateCircles(divisor); });
                threads[i].Start();
            }

        }

        
       
        // start button
        private void startstop_Click(object sender, EventArgs e)
        {
            startstop.Enabled = false;
            restart.Enabled = false;
            //Workers();
            WorkersParallel();
         
        }


        // clear button
        private void restart_Click(object sender, EventArgs e)
        {
            for (int ix = pictureBox1.Controls.Count - 1; ix >= 0; ix--)
            {
                if (pictureBox1.Controls[ix] is PictureBox)
                {
                    pictureBox1.Controls[ix].Dispose();
                }
            }
          
            pictureBox1.Invalidate();
            countTB.Text = "0";
            durationTB.Text = "0";
            durationLabel.Visible = false;
            durationTB.Visible = false;

            allCircles.Clear();
        }


        // get all circles 
        public static Circle[] GetCircles()
        {
            Circle[] newCircleArray = allCircles.ToArray();
            return newCircleArray;
        }

       
    }
}

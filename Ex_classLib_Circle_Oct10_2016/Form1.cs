//Polina Vargot
//Lab_Nov_02_2016
//C#
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CircularShapesLib;

namespace Ex_classLib_Circle_Oct10_2016
{
    ///lab assignment(turn in both the zipped project and its
    ///document version
    ///
    ///rework the circularshape project
    ///
    ///create a Library for your circular shapes
    ///define an abstract class CircularShape
    ///set the area and volume methods as abstract
    ///define child classes: Circle, Cylinder, Cone
    ///
    ///in Form1: Define a method Display that takes a CircularShape
    ///Add 3 buttons to allow you to create random circles, 
    ///cylinders and cones, then use the display method to display
    ///the data of the given shape to a richtextbox
    ///
    /// (of course you need to add code to the Display method)
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //display method
        public void Display(CircularShape ci)
        {
            richTextBox1.AppendText(ci.GetType().Name + ":\n" +
                    "Radius: " + ci.Radius + "\n" +
                    "Height: "+ ci.Height + "\n" +
                    "Side: " + ci.Side + "\n" +
                    "Perimeter: " + ci.Perimeter().ToString("f2") + "\n" +
                    "Area: " + ci.Area().ToString("f2") + "\n" +
                    "Volume: " + ci.Volume().ToString("f2") + "\n\n");
        }
        //button for circle
        private void btnCircle_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            double rad = rand.Next(2,20);
            Circle circ = new Circle(rad);
            Display(circ);
        }
        //button for cyllinder
        
        private void btnCyllinder_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            double rad = rand.Next(2, 20);
            double hei = rand.Next(2, 20);
            Cyllinder cyl = new Cyllinder(rad, hei);
            Display(cyl);
        }     
        //button for cone
        private void btnCone_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            double rad = rand.Next(2, 20);
            double hei = rand.Next(2, 20);
            double sid = rand.Next(2, 20);
            Cone con = new Cone(rad, hei, sid);
            Display(con);
        }              
    }
}

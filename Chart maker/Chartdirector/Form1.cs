using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ChartDirector;

namespace Chartdirector
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //The data for the bar chart
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
           


           
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        
           
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string[] lbls = textBox2.Text.Split(',');
            string[] vals = textBox1.Text.Split(',');

            double[] newdata = new double[vals.Length];

            for (int i = 0; i < vals.Length; i++)
            {
                newdata[i] = double.Parse(vals[i]);
            }


            //Create a XYChart object of size 250 x 250 pixels
            XYChart c = new XYChart(int.Parse(textBox3.Text), int.Parse(textBox4.Text));

            //Set the plotarea at (30, 20) and of size 200 x 200 pixels
            c.setPlotArea(30, 20, int.Parse(textBox3.Text) - 50, int.Parse(textBox4.Text) - 50);

            //Add a bar chart layer using the given data
            c.addBarLayer(newdata);

            //Set the x axis labels using the given labels
            c.xAxis().setLabels(lbls);

            //output the chart
            winChartViewer1.Chart = c;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();

            sv.Filter = "jpg files|*.jpg";
            if (sv.ShowDialog() == DialogResult.OK)
            {
                winChartViewer1.Image.Save(sv.FileName);
            }
        }
    }
}

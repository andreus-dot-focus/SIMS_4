using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMS_4
{
    public partial class Form1 : Form
    {
        const double k = 0.02;
        int days = 0;
        double price;
        double euro = 0;
        double rub = 10000;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();

            chart1.Series[0].Points.Clear();
            price = (double)edEuro.Value;
            chart1.Series[0].Points.AddXY(0, price);

            priceValueLabel.Text = Math.Round(price, 2).ToString();
            rubValueLabel.Text = rub.ToString();
            euroValueLabel.Text = euro.ToString();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            days++;
            price = price * (1 + k * (rnd.NextDouble() - 0.5));

            chart1.Series[0].Points.AddXY(days, price);
            daysValueLabel.Text = days.ToString();

            priceValueLabel.Text = Math.Round(price, 2).ToString();
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            double sum = Convert.ToInt32(buyTB.Text) * price;
            if (rub - sum >= 0) {
                rub -= sum;
                euro += Convert.ToInt32(buyTB.Text);
            } 

            rubValueLabel.Text = Math.Round(rub, 2).ToString();
            euroValueLabel.Text = Math.Round(euro, 2).ToString();
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            double sum = Convert.ToInt32(sellTB.Text);

            if (euro - sum >= 0) {
                euro -= sum;
                rub += Convert.ToInt32(sellTB.Text) * price;
            } 

            rubValueLabel.Text = Math.Round(rub, 2).ToString();
            euroValueLabel.Text = Math.Round(euro, 2).ToString();
        }
    }
}

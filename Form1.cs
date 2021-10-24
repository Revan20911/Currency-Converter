using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    class Conversions
    {
        private double USD = 1.00;
        private double JPY = 0.01;
        private double CND = 0.75;
        private double GBP = 1.25;
        private double currency;

        

        public double Currency { get { return currency; } set { currency = value; }  }


        public double GetUSD()
        {
            return USD;
        }
        public void SetUSD(double USD)
        {
            this.USD = USD;
        }

        public double GetJPY()
        {
            return JPY;
        }
        public void SetJPY(double JPY)
        {
            this.JPY = JPY;
        }

        public double GetCND()
        {
            return CND;
        }
        public void SetCND(double CND)
        {
            this.CND = CND;
        }

        public double GetGBP()
        {
            return GBP;
        }

        public void SetGBP(double GBP)
        {
            this.GBP = GBP;
        }


    

    }


    public partial class Form1 : Form
    {

        private double Converted;

        

        public Form1()
        {
            InitializeComponent();
        }

        public double getCurrency()

        {
           double c = new Conversions().Currency;

           double.TryParse(maskedTextBox1.Text, out c);
           return c;
        
        }

        


        private void Convert_Click(object sender, EventArgs e)
        {
            var con = new Conversions();
            

            

            switch (comboBox1.Text)
            {
                case "USD":
                    Converted = getCurrency() * con.GetUSD();
                    maskedTextBox2.Text = Converted.ToString();
                    break;
                case "CND":
                    Converted = getCurrency() * con.GetCND();
                    maskedTextBox2.Text = Converted.ToString();
                    break;
                case "JPY":
                    Converted = getCurrency() * con.GetJPY();
                    maskedTextBox2.Text = Converted.ToString();
                    break;
                case "GBP":
                    Converted = getCurrency() * con.GetGBP();
                    maskedTextBox2.Text = Converted.ToString();
                    break;
                default:
                    break;
            }


        }

        private void Clear_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();

        }
    }
}

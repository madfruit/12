using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
            System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
        }

        private void buttoncompute_Click(object sender, EventArgs e)
        {
            if(!double.TryParse(textBoxx.Text, out double x))
            {
                MessageBox.Show("Помилка введення x!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxx.Text = "";
                return;
            }
            x = Convert.ToDouble(textBoxx.Text);
            if(!double.TryParse(textBoxy.Text, out double y))
            {
                MessageBox.Show("Помилка введення y!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxy.Text = "";
                return;
            }
            y = Convert.ToDouble(textBoxy.Text);
            if(!double.TryParse(textBoxz.Text, out double z))
            {
                MessageBox.Show("Помилка введення z!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxz.Text = "";
                return;
            }
            z = Convert.ToDouble(textBoxz.Text);
            double s = (2 * Math.Cos(x * x) - 0.5) / (0.5 + Math.Sin(Math.Pow(y, 2 - z))) + z * z / (7 - z / 3.0);
            textBoxr.Text = s.ToString("F2");
        }
    }
}

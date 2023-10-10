using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace CalculatorWFA
{
    public partial class Form1 : Form
    {
        float NUMBER1;
        float NUMBER2;
        string SECIM;
        float result;

        SoundPlayer player = new SoundPlayer(@"pocosound.wav");
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonAll(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            calcTXTBOX.Text += button.Text;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            calcTXTBOX.Clear();
        }

        private void btnBERABER_Click(object sender, EventArgs e)
        {
            NUMBER2 = float.Parse(calcTXTBOX.Text);

            if (SECIM.Equals("+"))
                result = NUMBER1 + NUMBER2;
            if (SECIM.Equals("-"))
                result = NUMBER1 - NUMBER2;
            if (SECIM.Equals("*"))
                result = NUMBER1 * NUMBER2;
            if (SECIM.Equals("/"))
                result = NUMBER1 / NUMBER2;
            calcTXTBOX.Text = result + " ";
        }

        private void btnUSTEGELME_Click(object sender, EventArgs e)
        {
            SECIM = "+";
            NUMBER1 = float.Parse(calcTXTBOX.Text);

            calcTXTBOX.Clear();
        }

        private void btnCIXMA_Click(object sender, EventArgs e)
        {
            SECIM = "-";
            NUMBER1 = float.Parse(calcTXTBOX.Text);

            calcTXTBOX.Clear();
        }

        private void btnVURMA_Click(object sender, EventArgs e)
        {
            SECIM = "*";
            NUMBER1 = float.Parse(calcTXTBOX.Text);

            calcTXTBOX.Clear();
        }

        private void btnBOLME_Click(object sender, EventArgs e)
        {
            SECIM = "/";
            NUMBER1 = float.Parse(calcTXTBOX.Text);

            calcTXTBOX.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            player.Play();
        }
    }
}

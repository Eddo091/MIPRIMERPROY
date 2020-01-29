using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIPRIMERPROY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnprocess_Click(object sender, EventArgs e)
        {
            sbyte num1 = sbyte.Parse(txtnum1.Text);
            sbyte num2 = sbyte.Parse(txtnum2.Text);
            int resp = 0;
            if (optSuma.Checked) {
                resp = num1 + num2;

            }
            if (optResta.Checked) {
                resp = num1 - num2;
            }
            if (optMult.Checked)
            {
                resp = num1 * num2;
            
            }

            if (optDiv.Checked)
            {
                resp = num1 / num2;
            }
            lblRespuesta.Text = "Respuesta: "+ resp;
        }
    }
}

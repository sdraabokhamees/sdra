using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDRA_s_CALCULATOR200419_
{
    public partial class Calculatorform : Form
    {
        private double firstNumber;
        private double secondNumber;
        private string operation;
        public Calculatorform()
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }




    
}

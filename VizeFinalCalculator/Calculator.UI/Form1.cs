using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator.Business.Concrete;

namespace Calculator.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ExamManager examManager = new ExamManager();
        private void btnCalculateFKA_Click(object sender, EventArgs e)
        {
            tbxAlmanizGerekenFinalPuani.Text = examManager.FinaldenKacAlmaliyim(float.Parse(tbxGecmePuani.Text),
                float.Parse(tbxVizePuani.Text),
                Convert.ToInt32((tbxVizeOrani.Text))).ToString();
        }
    }
}

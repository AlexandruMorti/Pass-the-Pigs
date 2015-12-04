using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PassThePigs.Lib;

namespace PassThePigs.WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pig pig1 = new Pig();
            Pig pig2 = new Pig();

            pig1.Roll();
            pig2.Roll();

            label1.Text = Pig.GetPositionName(pig1.Position);
            label2.Text = Pig.GetPositionName(pig2.Position);
        }
    }
}

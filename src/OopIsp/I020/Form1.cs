using I020.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I020
{
    public partial class Form1 : Form
    {
        private IPrint _print = new Z02();
        private IFax _fax = new Z02();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _print.Print();
            _fax.Fax();
        }
    }
}

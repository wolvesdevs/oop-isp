using I030.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I030
{
    public partial class Form1 : Form
    {
        List<CharaBase> _charas = new List<CharaBase>();

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            _charas.Add(new Yusya());
            _charas.Add(new Senshi());
            _charas.Add(new MurabitoA());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //_charas.ForEach(chara => e.Graphics.FillRectangle(new SolidBrush(chara.Color), chara.X, chara.Y, 30, 30));
            foreach (var chara in _charas)
            {
                e.Graphics.FillRectangle(new SolidBrush(chara.Color), chara.X, chara.Y, 30, 30);
            }
        }
    }
}

﻿using I030.Objects;
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
        private CharaBase _selectedChara;
        List<CharaBase> _charas = new List<CharaBase>();

        private CharaBase _yusya = new Yusya();
        private CharaBase _senshi = new Senshi();
        private CharaBase _murabitoA = new MurabitoA();

        public Form1()
        {
            _selectedChara = _yusya;

            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            _charas.Add(_yusya);
            _charas.Add(_senshi);
            _charas.Add(_murabitoA);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //_charas.ForEach(chara => e.Graphics.FillRectangle(new SolidBrush(chara.Color), chara.X, chara.Y, 30, 30));
            foreach (var chara in _charas)
            {
                e.Graphics.FillRectangle(new SolidBrush(chara.Color), chara.X, chara.Y, 30, 30);
            }
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            _selectedChara.Right();
            panel1.Refresh();
        }

        private void SenshiButton_Click(object sender, EventArgs e)
        {
            _selectedChara = _senshi;
        }
    }
}

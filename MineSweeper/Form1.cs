using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 21; i++)
            {
                Button btn = new Button();
                btn.Width = 38;
                btn.Height = 38;
                btn.FlatStyle = FlatStyle.Popup;
                btn.Margin = new Padding(0);
                flowLayoutPanel1.Controls.Add(btn);
            }
        }
       
    }
}

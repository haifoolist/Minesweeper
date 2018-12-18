/*
* 1. 根据MintNumber的数量随机生成雷
* 2. 将这些雷随机放到生成的位置
*/


using System;
using System.Windows.Forms;

namespace MineSweeper
{
    public enum Status { None, Mine, Number }
   
    public partial class Form1 : Form
    {
        public int MintNumber = 3;

        public Form1()
        {
            InitializeComponent();
            GenerateAll();
        }
        /// <summary>
        /// 生成棋盘
        /// </summary>
        private void GenerateAll()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button btn = new Button();
                    btn.Width = 38;
                    btn.Height = 38;
                    btn.FlatStyle = FlatStyle.Popup;
                    btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                 | System.Windows.Forms.AnchorStyles.Left)
                 | System.Windows.Forms.AnchorStyles.Right)));
                    btn.Margin = new Padding(0);
                    tableLayoutPanel1.Controls.Add(btn, i, j);
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    int ran = new Random().Next(0, 3);
                    if (ran == 1)
                    {
                        btn.Tag = "我是雷";
                      
                    }
                    else
                    {
                        btn.Tag = "我不是雷";
                    }
                   
                    
                    btn.Click += Btn_Click;
                }
            }
        }

        private void Btn_Click(object sender, System.EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Tag.ToString() == "我是雷")
            {
                btn.BackgroundImage = Properties.Resources.Mine_;
            }
           
        }
    }
    public class Block
    {
        private Status status;
        public Button buttons;

        public Status Status {

            get
            {
                return status;
            }
            set
            {
                switch (value)
                {
                    case Status.None:
                        break;
                    case Status.Mine:
                        break;
                    case Status.Number:
                        break;
                    default:
                        break;
                }
                status = value;
            }

        }
    }
}

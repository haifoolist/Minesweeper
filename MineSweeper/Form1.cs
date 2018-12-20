/*
* 1. 根据MintNumber的数量随机生成雷
* 2. 将这些雷随机放到生成的位置
*/


using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MineSweeper
{
    public enum Status { None, Mine, Number }
   
    public partial class Form1 : Form
    {
        public int MintNumber = 3;
        List<Button> buttons = new List<Button>();
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
            SeedMines();
            ForeachAll();
        }

        private void ForeachAll()
        {
            foreach (var item in buttons)
            {
                Block btnBlock = item.Tag as Block;
                if (btnBlock._blockType == Block.BlockType.Mine)
                {
                    continue;
                }
                Pos left = new Pos(btnBlock._pos.X-1,btnBlock._pos.Y) ;
                Pos left_up = new Pos(btnBlock._pos.X - 1, btnBlock._pos.Y - 1);
            }
        }

        public void SeedMines()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button btn = new Button(); 
                    btn.FlatStyle = FlatStyle.Popup;
                    btn.Anchor = (((((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right)));
                    btn.Margin = new Padding(0);
                    tableLayoutPanel1.Controls.Add(btn, i, j);
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    int ran = new Random().Next(0, 100);
                    if (ran > 50)
                    {
                        btn.Tag = new Block(new Pos(i,j),Block.BlockType.Mine);

                    }
                    else
                    {
                        btn.Tag = new Block(new Pos(i, j));
                    }
                    btn.Click += Btn_Click;
                    buttons.Add(btn);
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
        public enum BlockType { None, Number, Mine }
        public BlockType _blockType;
        public Pos _pos;
        public Block (Pos pos,BlockType blockType = BlockType.None)
        {
            _pos = pos;

            _blockType = blockType; 
        }
    }
    /// <summary>
    ///位置包装
    /// </summary>
    public class Pos
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Pos(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}

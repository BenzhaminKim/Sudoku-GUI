using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sudokuGUI
{
    public partial class Form1 : Form
    {
        Sudoku sudoku = new Sudoku();
        static string storedBtn;
        private int m=0,s=0,ms=0;
        private string ticks;

        public Form1()
        {
            InitializeComponent();
            CreateButton();
            timer1.Start();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button10_Click(object sender, EventArgs e)
        {
            CreateButton();
        }
        public void CreateButton()
        {
            string sudokuNumber;
            sudoku.Generator();
            tableLayoutPanel1.Controls.Clear();
            m = 0;s = 0;ms = 0;
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    sudokuNumber = Convert.ToString(sudoku.mat[row, col]);

                    Button button1 = new Button();
                    button1.Name = "button_" + (row.ToString()) + (col.ToString());
                    button1.Width = 70;
                    button1.Height = 49;
                    if (sudokuNumber == "0") { button1.Text = " ";
                        button1.Click += new EventHandler(this.DynamicButton_Click);
                    }
                    else {
                        button1.Text = sudokuNumber;
                        button1.BackColor = Color.Ivory;
                    }
                    button1.Font = new Font("Georgia", 16);
                    tableLayoutPanel1.Controls.Add(button1);
                }
            }
        }

        private void DynamicButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string s = btn.Name;
            if(btn.Text == " ")
            {
                btn.Text = storedBtn;
            }
            else
            {
                btn.Text = " ";
            }
           
           
        }

        public void changeTextBtn(object sender)
        {
            Button btn = sender as Button;
            
        }

        private void AnswerBtn_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Clear();
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    Button button = new Button();
                    button.Width = 70;
                    button.Height = 49;
                    button.Text = Convert.ToString(sudoku.copyMat[row, col]);
                    button.Font = new Font("Georgia", 16);
                    tableLayoutPanel1.Controls.Add(button);
                }
            }
           
        }

        private void buttonClicked(object sender, EventArgs e)
        {
            storedBtn = Tools.GetText(sender);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            storedBtn = Tools.GetText(sender);
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            storedBtn = Tools.GetText(sender);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            storedBtn = Tools.GetText(sender);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            storedBtn = Tools.GetText(sender);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            storedBtn = Tools.GetText(sender);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            storedBtn = Tools.GetText(sender);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            storedBtn = Tools.GetText(sender);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            storedBtn = Tools.GetText(sender);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            storedBtn = Tools.GetText(sender);
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            ms++;
            if(ms >= 60)
            {
                ms = 0;
                s++;
            }
            if(s >= 60)
            {
                m++;
                s = 0;
            }
            ticks = $"{m}:{s}:{ms}"; 
            labelTimer.Text = ticks;
        }
    }
}

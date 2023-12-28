using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2 {
    public partial class Form1 : Form {

        enum Operators
        {
            None,
            Add,
            Subtract,
            Multiply,
            Divide,
        }

        Operators currentOpt = Operators.None;
        double firstOpr = 0;
        double secondOpr = 0;

        bool optFlag = false;
        bool isNumInputting = false;

        StringBuilder strNum = new StringBuilder();

        public Form1()
        {
            InitializeComponent();

            Display.Text = "";
        }

        void calculate ()
        {
            try
            {
                    switch (currentOpt)
                {
                    case Operators.Add:
                        firstOpr += secondOpr;
                        break;
                    case Operators.Subtract:
                        firstOpr -= secondOpr;
                        break;
                    case Operators.Multiply:
                        firstOpr *= secondOpr;
                        break;
                    case Operators.Divide:
                        firstOpr /= secondOpr;
                        break;
                }
            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
                clear();
                return;
            }

            Display.Text = firstOpr.ToString();
        }

        void BtnInput(object obj)
        {
            Button btn = (Button)obj;

            isNumInputting = true;

            Display.Text += btn.Text;
            strNum.Append(btn.Text);
        }
        void optInput(object obj)
        {
            Button btn = (Button)obj;

            if (optFlag)
            {
                secondOpr = Int32.Parse(strNum.ToString());
                strNum.Clear();

                calculate();
            }
            else
            {
                firstOpr = Int32.Parse(strNum.ToString());
                strNum.Clear();
            }

            optFlag = true;
            isNumInputting = false;

            Display.Text += " " + btn.Text + " ";
        }

        void clear()
        {

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            BtnInput(sender);
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            BtnInput(sender);
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            BtnInput(sender);
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            BtnInput(sender);
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
                BtnInput(sender);
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            BtnInput(sender);
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            BtnInput(sender);
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            BtnInput(sender);
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            BtnInput(sender);
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            BtnInput(sender);
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            if (!isNumInputting)
                return;

            optInput(sender);
            currentOpt = Operators.Divide;
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            if (!isNumInputting)
                return;

            optInput(sender);
            currentOpt = Operators.Multiply;
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            if (!isNumInputting)
                return;

            optInput(sender);
            currentOpt = Operators.Subtract;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!isNumInputting)
                return;

            optInput(sender);
            currentOpt = Operators.Add;
        }

        private void BtnPoint_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnAllClear_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            
        }
    }
}

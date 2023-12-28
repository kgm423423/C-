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

        bool isNumInputting = false;
        bool optFlag = false;
        bool resultFlag = false;
        bool minus = false;
        bool pointFlag = false;
        bool isPointInputting = false;

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
                        if (firstOpr == 0 || secondOpr == 0) {
                            throw new Exception("ZeroDevisonError");
                        }
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

            if (resultFlag)
                clear();

            isNumInputting = true;
            if (pointFlag)
                isPointInputting = true;


            Display.Text += btn.Text;
            strNum.Append(btn.Text);
        }
        void optInput(object obj)
        {
            

            if (optFlag)
            {
                secondOpr = Int32.Parse(strNum.ToString());
                strNum.Clear();

                calculate();
            }
            else
            {
                if (!resultFlag)
                {
                    firstOpr = Double.Parse(strNum.ToString());
                    strNum.Clear();
                }
            }
    
            isNumInputting = false;
            optFlag = true;
            resultFlag = false;
            minus = false;
            pointFlag  = false;    
            isPointInputting = false;

            Display.Text += " " + btn.Text + " ";
        }

        void clear()
        {
            currentOpt = Operators.None;
            firstOpr = 0;
            secondOpr = 0;

            isNumInputting = false;
            optFlag = false;
            resultFlag = false;
            minus = false;
            pointFlag = false;
            isPointInputting = false;

            strNum.Clear();
            Display.Text = "";
        }

        bool optCheck()
        {
            return !isNumInputting || pointFlag && !isPointInputting ? true : false;
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
            if (optCheck())
                return;

            optInput(sender);
            currentOpt = Operators.Divide;
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            if (optCheck())
                return;

            optInput(sender);
            currentOpt = Operators.Multiply;
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            if (!isNumInputting && !minus)
            {
                strNum.Append("-");
                Display.Text += "-";

                minus = true;

                return;
            }

            if (optCheck())
                return;

            optInput(sender);
            currentOpt = Operators.Subtract;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (optCheck())
                return;

            optInput(sender);
            currentOpt = Operators.Add;
        }

        private void BtnPoint_Click(object sender, EventArgs e)
        {
            if (!isNumInputting || pointFlag)
                return;
            if (resultFlag)
            {
                clear();
                return;
            }
                

            pointFlag = true;
            isPointInputting = false;

            strNum.Append(".");
            Display.Text += ".";
        }

        private void BtnAllClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            if (optCheck() || !optFlag && !resultFlag)
                return;

            if (!resultFlag)
            {
                secondOpr = Double.Parse(strNum.ToString());
                strNum.Clear();
            }
                
            optFlag = false;
            resultFlag = true;
            pointFlag = false;
            isPointInputting = false;

            calculate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode) {
                case Keys.D0:

                    break;
            
                }
        }
    }
}

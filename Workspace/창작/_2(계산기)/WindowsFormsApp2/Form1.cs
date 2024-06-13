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

        Operators currentOpt;
        double firstOpr;
        double secondOpr;

        bool isNumInputting;
        bool optFlag;
        bool resultFlag;
        bool minus;
        bool pointFlag;
        bool isPointInputting;

        StringBuilder strNum = new StringBuilder();

        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            clear();
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

        void BtnInput<T>(object obj)
        {
            string btnText;
            if (typeof(T) == typeof(Button))
            {
                Button btn = (Button)obj;
                btnText = btn.Text;
            }
            else { btnText = (string)obj; }

            if (resultFlag)
                clear();

            isNumInputting = true;
            if (pointFlag)
                isPointInputting = true;


            Display.Text += btnText;
            strNum.Append(btnText);

            label1.Focus();
        }
        void optInput<T>(object obj)
        {
            string btnText;
            if (typeof(T) == typeof(Button))
            {
                Button btn = (Button)obj;
                btnText = btn.Text;
            }
            else { btnText = (string)obj; }

            if (btnText == "-" && !isNumInputting && !minus)
            {
                strNum.Append("-");
                Display.Text += "-";

                minus = true;

                return;
            }
            else if (!isNumInputting || pointFlag && !isPointInputting)
                return;

            if (optFlag)
            {
                secondOpr = Double.Parse(strNum.ToString());
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

            switch (btnText)
            {
                case "+":
                    currentOpt = Operators.Add;
                    break;
                case "-":
                    currentOpt = Operators.Subtract;
                    break;
                case "×":
                    currentOpt = Operators.Multiply;
                    break;
                case "÷":
                    currentOpt = Operators.Divide;
                    break;
            }
    
            isNumInputting = false;
            optFlag = true;
            resultFlag = false;
            minus = false;
            pointFlag  = false;    
            isPointInputting = false;

            Display.Text += " " + btnText + " ";

            label1.Focus();
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

        void result()
        {
            if (!isNumInputting || pointFlag && !isPointInputting || !optFlag && !resultFlag)
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
            label1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            BtnInput<Button>(sender);
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            BtnInput<Button>(sender);
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            BtnInput<Button>(sender);
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            BtnInput<Button>(sender);
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            BtnInput<Button>(sender);
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            BtnInput<Button>(sender);
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            BtnInput<Button>(sender);
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            BtnInput<Button>(sender);
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            BtnInput<Button>(sender);
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            BtnInput<Button>(sender);
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            optInput<Button>(sender);
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            optInput<Button>(sender);
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            optInput<Button>(sender);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            optInput<Button>(sender);
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
            result();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode) {
                case Keys.D0:
                    BtnInput<string>("0");
                    break;
                case Keys.D1:
                    BtnInput<string>("1");
                    break;
                case Keys.D2:
                    BtnInput<string>("2");
                    break;
                case Keys.D3:
                    BtnInput<string>("3");
                    break;
                case Keys.D4:
                    BtnInput<string>("4");
                    break;
                case Keys.D5:
                    BtnInput<string>("5");
                    break;
                case Keys.D6:
                    BtnInput<string>("6");
                    break;
                case Keys.D7:
                    BtnInput<string>("7");
                    break;
                case Keys.D8:
                    BtnInput<string>("8");
                    break;
                case Keys.D9:
                    BtnInput<string>("9");
                    break;
                case Keys.Oemplus:
                    optInput<string>("+");
                    break;
                case Keys.OemMinus:
                    optInput<string>("-");
                    break;
                case Keys.Multiply:
                    optInput<string>("×");
                    break;
                case Keys.Divide:
                    optInput<string>("÷");
                    break;
                case Keys.Enter:
                    result();
                    break;
            }
        }
    }
}

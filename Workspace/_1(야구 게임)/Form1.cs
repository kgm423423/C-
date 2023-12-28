using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Workspace
{
    public partial class Form1 : Form
    {
        int[] findNumArr = new int[4];
        int chance;

        bool isGamePlaying = false;


        public Form1()
        {
            InitializeComponent();
        }
        bool DebugNum(TextBox numBox)
        {
            int num;
            try
            {
                num = Int32.Parse(numBox.Text);
            }
            catch
            { return false; }
            if (num >= 10 || num <= 0) { return false;  }

            return true;
        }

        char CheckInput(TextBox numBox, int index)
        {
            int num = Int32.Parse(numBox.Text);
            bool check = false;
            index--;

            for(int i=0;i<findNumArr.Length; i++)
            {
                if (findNumArr[i] == num)
                {
                    check = true;
                    if (i == index)
                    {
                        return 'S';
                    }
                }
            }

            return check ? 'B' : 'O';
        }

        void ClearNumBox()
        {
            NumBox1.Text = "";
            NumBox2.Text = "";
            NumBox3.Text = "";
            NumBox4.Text = "";

            return;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            bool b = false;

            for (int i = 0; i < findNumArr.Length; b = false)
            {
                findNumArr[i] = rand.Next(1, 10);
                for (int j = 0; j < i; j++)
                    if (findNumArr[i] == findNumArr[j]) {
                        b = true;
                        break;
                    }

                if (b)
                    continue;
                i++;
            }

            ClearNumBox();
            NumList.Items.Clear();
            chance = 0;
            isGamePlaying = true;
            Display.Text = "맞힐 숫자를 입력하세요.";
        }

        private void InputBtn_Click(object sender, EventArgs e)
        {
            if (!isGamePlaying)
            {
                MessageBox.Show("게임을 시작해 주세요.");
                ClearNumBox();
                return;
            }
            if (!DebugNum(NumBox1) || !DebugNum(NumBox2) || !DebugNum(NumBox3) || !DebugNum(NumBox4))
            {
                MessageBox.Show("입력값 오류 다시 입력하세요.");
                ClearNumBox();
                return;
            }

            char[] sumArr = new char[4];
            bool win = true;

            sumArr[0] = CheckInput(NumBox1, 1);
            sumArr[1] = CheckInput(NumBox2, 2);
            sumArr[2] = CheckInput(NumBox3, 3);
            sumArr[3] = CheckInput(NumBox4, 4);

            NumList.Items.Add(NumBox1.Text + sumArr[0]
                              + NumBox2.Text + sumArr[1]
                              + NumBox3.Text + sumArr[2]
                              + NumBox4.Text + sumArr[3]);

            chance++;

            for(int i=0;i<4;i++)
            {
                if (sumArr[i] != 'S')
                {
                    win = false;
                    break;
                }
            }

            if (win)
            {
                Display.Text = "승리하였습니다.";

                int i = 0;
                foreach(int num in ScoreList.Items)
                {
                    if (chance <= num) {
                        break;
                    }
                    i++;
                }
                ScoreList.Items.Insert(i, chance);

                isGamePlaying = false;
                return;
            }
            else
            {
                Display.Text = "시도 횟수 : " + chance;
            }

            ClearNumBox();
        }

        private void NumList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThisIsNewProjectILikeIt
{
    public partial class Form1 : Form
    {
        int curIndex = 0, tempIndex=-1;
        ArrayList array = new ArrayList();
        String textcon,cmpStr="";
        ArrayList undoArr = new ArrayList();
        ArrayList redoArr = new ArrayList();
        bool inProgress = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Equals("") || textBox2.Text.Equals(""))
            {
                MessageBox.Show("내용이나 검색어를 입력해주세요", "오류");
                return;
            }
            findCount.Visible = false;
            textcon = richTextBox1.Text;
            array.Clear();
            if (textcon.Contains(cmpStr))
            {  
                richTextBox1.SelectAll();
                richTextBox1.SelectionColor = Color.Black;
                int startIndex = 0, count = 0; curIndex = 0;    
                while (true)
                {
                    if (textcon.IndexOf(cmpStr, startIndex) == -1) break;
                    curIndex = textcon.IndexOf(cmpStr, startIndex);
                    richTextBox1.Select(curIndex, cmpStr.Length);
                    richTextBox1.SelectionColor = Color.Red;
                    array.Add(curIndex);
                    startIndex = curIndex+1;
                    count++;
                }
                findResult.Visible = true;
                findResult.Text = "찾은 갯수 : " + count;   
            }
            else
            {
                MessageBox.Show("탐색 실패", "ERROR");
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (array.Count.Equals(0)) return;
            if (curIndex != Convert.ToInt32(array[array.Count - 1]))
            {
                int start = Convert.ToInt32(array[array.IndexOf(curIndex) + 1]);
                //MessageBox.Show(start.ToString(), "test");
                richTextBox1.Select(start, cmpStr.Length); richTextBox1.Select();
                curIndex = start;
            }
            else
            {
                richTextBox1.Select();
            }
            findCount.Visible = true;
            findCount.Text = (array.IndexOf(curIndex) + 1).ToString() + "/" + array.Count;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmpStr.Equals("")||!richTextBox1.Text.Contains(cmpStr))
            {
                MessageBox.Show("바꿀 문자가 없습니다!", "오류");
                return;
            }
            richTextBox1.Text=richTextBox1.Text.Replace(cmpStr,tbReplace.Text);
            richTextBox1.SelectAll();
            richTextBox1.SelectionColor = Color.Black;
            findCount.Visible = false;
            findResult.Text = "찾은 갯수 : " + 0;
        }   

        private void btnPast_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void btnFuture_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            cmpStr = textBox2.Text;
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt)
            {
               // richTextBox1.Lines[2].
                //MessageBox.Show(richTextBox1.GetLineFromCharIndex(80).ToString(),"hi");
            }
            if (e.Control && e.KeyCode==Keys.D)
            {
                /*MessageBox.Show(richTextBox1.GetFirstCharIndexOfCurrentLine().ToString(),"안물1");
                MessageBox.Show(richTextBox1.Lines[0].Length.ToString(), "안물2");
                MessageBox.Show(richTextBox1.Text[richTextBox1.GetFirstCharIndexOfCurrentLine()].ToString(), "hi");*/
                int firstIndex = richTextBox1.GetFirstCharIndexOfCurrentLine();
                int line = richTextBox1.GetLineFromCharIndex(firstIndex);
                int lineLength= richTextBox1.Lines[line].Length;
                String content = "";
                for(int i = firstIndex; i < lineLength+firstIndex; i++)
                {
                    content += richTextBox1.Text[i];
                }
                richTextBox1.Text=richTextBox1.Text.Insert(firstIndex, content+"\n");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                Btn1_Clicked(null,null);
            }
        }

        private void cbAll_CheckedChanged(object sender, EventArgs e)
        {
            switch (cbAll.Checked)
            {
                case true:
                    label5.Visible = true; label6.Visible = true;
                    button2.Visible = true; tbReplace.Visible = true;
                    break;

                case false:
                    label5.Visible = false; label6.Visible = false;
                    button2.Visible = false; tbReplace.Visible = false;
                    break;
            }
        }


        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (array.Count.Equals(0)) return;
            if (curIndex != Convert.ToInt32(array[0]))
            {
                int start = Convert.ToInt32(array[array.IndexOf(curIndex) - 1]);
                //MessageBox.Show(start.ToString(), "test");
                richTextBox1.Select(start, cmpStr.Length); richTextBox1.Select();
                curIndex = start;
            }
            else
            {
                richTextBox1.Select();
            }
            findCount.Visible = true;
            findCount.Text = (array.IndexOf(curIndex) + 1).ToString() + "/" + array.Count;
        }
    }
}

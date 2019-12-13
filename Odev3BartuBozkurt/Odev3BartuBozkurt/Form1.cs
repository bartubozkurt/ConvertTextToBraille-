using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev3BartuBozkurt
{
    public partial class Form1 : Form
    {

        List<string> Braille = new List<string>(new string[]{
            "⠁",
            "⠃",
            "⠉",
            "⠙",
            "⠑",
            "⠋",
            "⠛",
            "⠓",
            "⠊",
            "⠚",
            "⠅",
            "⠇",
            "⠍",
            "⠝",
            "⠕",
            "⠏",
            "⠟",
            "⠗",
            "⠎",
            "⠞",
            "⠥",
            "⠧",
            "⠺",
            "⠭",
            "⠽",
            "⠵",
            "  ",


            "⠠⠁",
            "⠠⠃",
            "⠠⠉",
            "⠠⠙",
            "⠠⠑",
            "⠠⠋",
            "⠠⠛",
            "⠠⠓",
            "⠠⠊",
            "⠠⠚",
            "⠠⠅",
            "⠠⠇",
            "⠠⠍",
            "⠠⠝",
            "⠠⠕",
            "⠠⠏",
            "⠠⠟",
            "⠠⠗",
            "⠠⠎",
            "⠠⠞",
            "⠠⠥",
            "⠠⠧",
            "⠠⠺",
            "⠠⠭",
            "⠠⠽",
            "⠠⠵",

            "⠼⠁",
            "⠼⠃",
             "⠼⠉",
            "⠼⠙",
            "⠼⠑",
            "⠼⠋",
            "⠼⠛",
            "⠼⠓",
             "⠼⠊",
             "⠼⠚",

            "⠂",
            "⠲",
            "⠖",
            "⠈⠁",
            "⠸⠹",
            "⠈⠎",
            "⠨⠴",
            "⠈⠢",
            "⠈⠯",
            "⠐⠔",

            "⠐⠣",
            "⠐⠜",
            "⠨⠣",
            "⠨⠜",
            "⠸⠣",
            "⠸⠜",
            "⠨⠤",

            "⠤",
            "⠐⠖",
            "⠸⠌",
            "⠐⠶",

            "|",
            "⠒",
            "⠆",
            "⠈⠣",
            "⠈⠜",
        });
        List<string> Alfabe = new List<string>(new String[]
        {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f",
            "g",
            "h",
            "i",
            "j",
            "k",
            "l",
            "m",
            "n",
            "o",
            "p",
            "q",
            "r",
            "s",
            "t",
            "u",
            "v",
            "w",
            "x",
            "y",
            "z",
            " ",


            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X", 
            "Y",
            "Z",

           "1",
           "2",
           "3",
           "4",
           "5",
           "6",
           "7",
           "8",
           "9",
           "0",

            ",", 
            ".",
            "!",
            "@",
            "#",
            "$",
            "%",
            "^",
            "&",
            "*",

           "(",
           ")",
           "[",
           "]",
           "{",
           "}",
           "_",

           "-",
           "+",
           "/",
           "=",

           "|",
           ":",
           ";",
           "<",
           ">",
          });         
        public Form1()
        {
            InitializeComponent();
        }

        private void hakkındaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Hakkında ek = new Hakkında();
            ek.ShowDialog();
        }

        private void hakkındaToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            string metin;
            metin = textBox1.Text.ToLower();

            int i = 0;
            while (i < metin.Count())
            {
                int harf = Alfabe.FindIndex(item => item == metin[i].ToString());
                richTextBox1.Text = richTextBox1.Text + Braille[harf].ToString(); ;
                i++;
            }



        }

        private void çeviriToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           textBox1.Clear();
           richTextBox1.Clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        //Constructors
        public Form1()
        {
            InitializeComponent();
        }
        //Edit- Refaktor - Extract 
        //Yazdığım kodlar seçiliyken yukarıdakileri seçip method olarak tüm yazdıklarımı oluşturabilirim.
        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateButtons();

        }

        private void GenerateButtons()
        {
            Button[,] buttons = new Button[8, 8];
            //Buton nesnesini oluşturduk
            //buttons.GetUpperBound(0)
            //0. BOYUT 1 BOYUT
            //BUTTON[O. BOYUT, 1. BOYUT] --->>>>> 0. Boyut en fazla 7 indisine kadar gelir 0,1,2,3,4,5,6,7 geldiği zaman işlemler durur.

            int top = 0;
            int left = 0;

            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    left += 50;
                    buttons[i, j].Top = top;
                    this.Controls.Add(buttons[i, j]);
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                }

                top += 50;
                left = 0;
            }
            //this.Controls.Add(buttons);//Bu butonu ekrana koy.
        }
    }
}

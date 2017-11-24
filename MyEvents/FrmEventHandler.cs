using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyEvents_CSharp;

namespace MyEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.buttonX.Click += buttonX_Click;
            this.buttonX.Click += new EventHandler(aaa);//指向方法位置
            //eventhandler括號後的方法要是帶有參數object sender, EventArgs e



        }
        private void buttonX_Click(object sender,EventArgs e)
        {
            MessageBox.Show("button x click");
        }
        void aaa(object sender, EventArgs e)
        {
            MessageBox.Show("aaa");
        }
     
    }
}

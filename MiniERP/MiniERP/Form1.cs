using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniERP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PenalOff();             //  모든 패널 off
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Enroll_Click(object sender, EventArgs e)
        {
            MenuPenalAble(sender);
        }

        void MenuPenalAble(object sender)
        {
            PenalOff();
            string btnName = ((Button)sender).Text;

            switch (btnName)
            {
                case "기초등록":
                    panel_Enroll.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void PenalOff()
        {
            panel_Enroll.Visible = false;
        }
    }
}

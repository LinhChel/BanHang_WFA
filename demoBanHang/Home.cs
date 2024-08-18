﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace demoBanHang
{
    public partial class Home : Form
    {
        string form1_username;
        public Home(string username)
        {
            InitializeComponent();
            lblUsername.Text = "Xin Chào " + username;
            form1_username = username;
            pHome.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QLSP qlsp = new QLSP() { TopLevel = false, TopMost = true };
            qlsp.FormBorderStyle = FormBorderStyle.None;// ko hiển thị viền
                                                        //Nếu tồn tại form khác trong panel => remove form đó đi
            if (pHome.Controls.Count > 0)
            {
                pHome.Controls.RemoveAt(0);
            }
            pHome.Controls.Add(qlsp);
            qlsp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QLTK qltk = new QLTK() { TopLevel = false, TopMost = true };
            qltk.FormBorderStyle = FormBorderStyle.None;
            if (pHome.Controls.Count > 0)
            {
                pHome.Controls.RemoveAt(0);
            }
            pHome.Controls.Add(qltk);
            qltk.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BanHang banHang = new BanHang(form1_username);
            banHang.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LichSuGD ls = new LichSuGD() { TopLevel = false, TopMost = true };
            ls.FormBorderStyle = FormBorderStyle.None;
            if (pHome.Controls.Count > 0)
            {
                pHome.Controls.RemoveAt(0);
            }
            pHome.Controls.Add(ls);
            ls.Show();
        }
    }
}

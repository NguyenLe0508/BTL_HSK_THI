using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanDienThoai
{
    public partial class QuanLyCuaHangDienThoai : Form
    {
        public QuanLyCuaHangDienThoai()
        {
            InitializeComponent();
        }

        private void QuanLyCuaHangDienThoai_Load(object sender, EventArgs e)
        {
            //Set màu nền MDI parent
            foreach (Control ctl in this.Controls)
            {
                if (ctl is MdiClient)
                {
                    ctl.BackColor = Color.White;
                }
            }

            //Hiện thị số lần đăng nhập của tài khoản đang đăng nhập
            //label1.Text = "Số lần đăng nhập " + new AccountDao().showTime(Program.accountId);

            //if (Program.role.Equals("Nhân viên"))
            //{
            //    toolStripMenuItemQuanLy.Visible = false;
            //    toolStripMenuItemThongKe.Visible = false;
            //}
        }

        private void toolStripMenuItemQuanLy_Click(object sender, EventArgs e)
        {
            QuanLy quanLy = new QuanLy();
            quanLy.MdiParent = this;
            quanLy.Dock = DockStyle.Fill;
            quanLy.Show();
        }

        private void toolStripMenuItemDangXuat_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void toolStripMenuItemBanHang_Click(object sender, EventArgs e)
        {
            BanHang banHang = new BanHang();
            banHang.MdiParent = this;
            banHang.Dock = DockStyle.Fill;
            banHang.Show();
        }

        private void ToolStripMenuItemTKNV_Click(object sender, EventArgs e)
        {
            ThongKeNhanvien thongKeNhanvien = new ThongKeNhanvien();
            thongKeNhanvien.MdiParent = this;
            thongKeNhanvien.Dock = DockStyle.Fill;
            thongKeNhanvien.Show();
        }

       
     

       
    }
}

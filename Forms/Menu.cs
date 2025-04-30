using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Class.KetNoi.Ketnoi();

            panelMenu.BackColor = Color.FromArgb(245, 245, 255);
            // Duyệt qua tất cả control trong panelMenu
            foreach (Control ctrl in panelMenu.Controls)
            {
                // Nếu là GroupBox thì xử lý riêng
                if (ctrl is GroupBox group)
                {
                    group.ForeColor = Color.MidnightBlue;
                    group.BackColor = Color.Transparent;
                    // Duyệt các nút bên trong GroupBox
                    foreach (Control btn in group.Controls)
                    {
                        if (btn is Button button)
                        {
                            FormatButton(button);
                        }
                    }
                }
            }

            foreach (Control btn in grbDM.Controls)
            {
                if (btn is Button button)
                {
                    FormatButton(button);
                }
            }
            panelNhansu.BackColor = Color.FromArgb(245, 245, 255);
            foreach (Control btn in panelNhansu.Controls)
            {
                if (btn is Button button)
                {
                    FormatButton(button);
                }
            }
        }

        private void FormatButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = SystemColors.GradientActiveCaption;  // 🎨 Màu xanh hệ thống
            btn.ForeColor = Color.DarkSlateGray;
            btn.Font = new Font("Arial", 9F, FontStyle.Bold);

            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(178, 235, 242); // hover
        }
    }
   }


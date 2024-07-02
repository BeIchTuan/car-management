using CSM_Project.Forms.Admin;
using CSM_Project.Forms.Customer;
using MySql.Data.MySqlClient;
using Mysqlx.Session;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CSM_Project
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
            LblVanish();
        }

        private void nameBox_Enter(object sender, EventArgs e)
        {
            userImage.Image = redundantData.ReplaceColor((Image)userImage.Image.Clone(),Color.FromArgb(102,102,102),Color.White);
            lockImage.Image = redundantData.ReplaceColor((Image)lockImage.Image.Clone(), Color.White, Color.FromArgb(102, 102, 102));

            if (nameBox.Text == "Tài khoản")
            {
                nameBox.Text = "";
            }
            namePnl.BorderStyle = BorderStyle.FixedSingle;
            namePnl.BackColor = Color.FromArgb(34, 36, 49);
            nameBox.BackColor = Color.FromArgb(34, 36, 49);
            nameBox.ForeColor = Color.White;
            userImage.BackColor = Color.FromArgb(34, 36, 49);
            lockImage.BackColor = Color.White;
            LblVanish();

        }
        private void nameBox_Leave(object sender, EventArgs e)
        {
            userImage.Image = redundantData.ReplaceColor((Image)userImage.Image.Clone(),Color.White,Color.FromArgb(102, 102, 102));

            if (nameBox.Text == "")
            {
                nameBox.Text = "Tài khoản";
            }
            namePnl.BackColor = Color.White;
            nameBox.BackColor = Color.White;
            nameBox.ForeColor = Color.Black;
            userImage.BackColor = Color.White;

        }
        private void pinBox_Enter(object sender, EventArgs e)
        {
            lockImage.Image = redundantData.ReplaceColor((Image)lockImage.Image.Clone(),Color.Silver,Color.White);
            userImage.Image = redundantData.ReplaceColor((Image)userImage.Image.Clone(), Color.White, Color.FromArgb(102, 102, 102));

            if (pinBox.Text == "Mật khẩu")
            {
                pinBox.Text = "";
                pinBox.PasswordChar = '*';
            }
            pinPnl.BorderStyle = BorderStyle.FixedSingle;
            pinPnl.BackColor = Color.FromArgb(34, 36, 49);
            pinBox.BackColor = Color.FromArgb(34, 36, 49);
            pinBox.ForeColor = Color.White;
            lockImage.BackColor = Color.FromArgb(34, 36, 49);
            userImage.BackColor = Color.White;
            LblVanish();
        }
        private void pinBox_Leave(object sender, EventArgs e)
        {
            lockImage.Image = redundantData.ReplaceColor((Image)lockImage.Image.Clone(),Color.White, Color.FromArgb(102, 102, 102));
            if (pinBox.Text == "")
            {
                pinBox.Text = "Mật khẩu";
                pinBox.PasswordChar = '\0';
            }
            pinPnl.BackColor = Color.White;
            pinBox.BackColor = Color.White;
            pinBox.ForeColor = Color.Black;
            lockImage.BackColor = Color.White;
        }
        private void logBtn_MouseEnter(object sender, EventArgs e)
        {
            logBtn.FlatAppearance.BorderColor = Color.Blue;
            logBtn.FlatAppearance.BorderSize = 1;
            logBtn.BackColor = Color.FromArgb(34, 36, 49);
            //logBtn.ForeColor = Color.Blue;
        }

        private void logBtn_MouseLeave(object sender, EventArgs e)
        {
            logBtn.BackColor = Color.Blue;
            //logBtn.ForeColor = Color.Blue;
        }



        private void exitBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void exitBtn_MouseEnter(object sender, EventArgs e)
        {
            exitBtn.BackColor = Color.Red;
            exitBtn.ForeColor = Color.White;
        }

        private void exitBtn_MouseLeave(object sender, EventArgs e)
        {
            exitBtn.BackColor = Color.Transparent;
            exitBtn.ForeColor = Color.White;
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            string username = nameBox.Text;
            string password = pinBox.Text;
            string hashedPassword = HashPassword(password);

            string query = "SELECT * FROM NGUOIDUNG " +
                    "LEFT JOIN NHANVIEN NV ON NV.MaNV = NGUOIDUNG.MaNV " +
                    "LEFT JOIN ChuXe CX ON CX.MaCX = NGUOIDUNG.MaCX " +
                    "WHERE username = @username AND password = @password";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@username", username),
                new MySqlParameter("@password", hashedPassword)
            };
        }

        private void OpenFormBasedOnRole(string role)
        {
            
        }


        private void LblVisible()
        {

        }
        private void LblVanish()
        {
            nameErrorIcon.Visible = false;
            pinErrorIcon.Visible = false;
        }

        private void nameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void pinBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DangKi registerForm = new DangKi();
            registerForm.ShowDialog();
        }
    }
}


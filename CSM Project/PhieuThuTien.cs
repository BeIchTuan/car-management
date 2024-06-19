using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSM_Project
{
    public partial class PheuThuTien : Form
    {
       

        public PheuThuTien()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void pictureVanish()
        {
            
        }
        private void startChecker()
        {
            
        }

       
        
        private void exitBtn_MouseEnter(object sender, EventArgs e)
        {
            exitBtn.BackColor = Color.Red;
            exitBtn.ForeColor = Color.White;
        }
        private void exitBtn_MouseLeave(object sender, EventArgs e)
        {
            exitBtn.BackColor = Color.Transparent;
            exitBtn.ForeColor = Color.Red;
        }

       
        private void backBtn_MouseClick(object sender, MouseEventArgs e)
        {
            
            this.Hide();
        }
        private void backBtn_MouseEnter(object sender, EventArgs e)
        {
            backBtn.BackColor = Color.FromArgb(34, 36, 49);
        }
        private void backBtn_MouseLeave(object sender, EventArgs e)
        {
            backBtn.BackColor = Color.Transparent;
        }


        private void sellBtn_MouseEnter(object sender, EventArgs e)
        {
            ThemBtn.BackColor = Color.FromArgb(34, 36, 49);
        }
        private void sellBtn_MouseLeave(object sender, EventArgs e)
        {
            ThemBtn.BackColor = Color.FromArgb(77, 74, 82);
        }
        private void sellBtn_MouseClick(object sender, MouseEventArgs e)
        {
                    
        }

      
        
        // This Block Contains the code for when does the focus comes into the textboxes
        private void nameBox_Enter(object sender, EventArgs e)
        {
            
        }
        private void nameBox_Leave(object sender, EventArgs e)
        {
            
        }

        private void cnicBox_Enter(object sender, EventArgs e)
        {
            
        }
        private void cnicBox_Leave(object sender, EventArgs e)
        {

        }

        private void addressBox_Enter(object sender, EventArgs e)
        {
            
        }
        private void addressBox_Leave(object sender, EventArgs e)
        {

        }

        private void contactBox_Enter(object sender, EventArgs e)
        {

        }
        private void contactBox_Leave(object sender, EventArgs e)
        {
            
        }




        //this code will help in validating the input

        private void nameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void cnicBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void contactBox_KeyPress(object sender, KeyPressEventArgs e)
        {
                      
        }

        private void addressBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void cnicBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }


        private string idGenerator(string id)
        {
            string digits,letters;
            letters = "COD";
            if (id == string.Empty)
            {
                digits = "000";
            }
            else
            {
                digits = new string(id.Where(char.IsDigit).ToArray());
            }
            int number;
            int.TryParse(digits, out number);
            string new_id = letters + (++number).ToString("D4");
            
            return new_id;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

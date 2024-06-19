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
    public partial class ThemNhanVien : Form
    {

        public ThemNhanVien()
        {
            InitializeComponent();
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
            exitBtn.ForeColor = Color.White;
        }

       
        private void exitBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void backBtn_MouseClick(object sender, EventArgs e)
        {

        }
        private void backBtn_MouseEnter(object sender, EventArgs e)
        {
            
        }
        private void backBtn_MouseLeave(object sender, EventArgs e)
        {
            
        }


        private void sellBtn_MouseEnter(object sender, EventArgs e)
        {
            
        }
        private void sellBtn_MouseLeave(object sender, EventArgs e)
        {
            
        }
        private void sellBtn_MouseClick(object sender, MouseEventArgs e)
        {
                    
        }
          
           
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
            

    }
}

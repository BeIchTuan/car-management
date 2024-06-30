using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSM_Project
{
   
    public partial class PhieuSuaChua : Form
    {
       
        
        public PhieuSuaChua()
        {
            InitializeComponent();       
        }
       
        private void gridFill()
        {
            
        }
        private void fireEmp()
        {
                        
        }
        private void rehireEmp()
        {
         
        }

        private void hireEmpPanel_MouseEnter(object sender, EventArgs e)
        {
            
        }
        private void hireEmpPanel_MouseLeave(object sender, EventArgs e)
        {
            
        }
        private void hireEmpPanel_MouseClick(object sender, MouseEventArgs e)
        {
            
        }



        private void updateEmpPanel_MouseEnter(object sender, EventArgs e)
        {
            
        }
        private void updateEmpPanel_MouseLeave(object sender, EventArgs e)
        {
            
        }
        private void updateEmpPanel_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
       


        private void firEmpPanel_MouseEnter(object sender, EventArgs e)
        {
            
        }
        private void firEmpPanel_MouseLeave(object sender, EventArgs e)
        {
            
        }
        private void firEmpPanel_MouseClick(object sender, MouseEventArgs e)
        {
            fireEmp();
        }




        private void rehireEmpPanel_MouseEnter(object sender, EventArgs e)
        {
            
        }
        private void rehireEmpPanel_MouseLeave(object sender, EventArgs e)
        {
            
        }



        private void exitBtn_MouseEnter(object sender, EventArgs e)
        {
            exitBtn.BackColor = Color.Red;
            exitBtn.ForeColor = Color.White;
        }
        private void exitBtn_MouseLeave(object sender, EventArgs e)
        {
            exitBtn.BackColor = Color.White;
            exitBtn.ForeColor = Color.Red;
        }
        private void exitBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
        
        private void backBtn_MouseEnter(object sender, EventArgs e)
        {
            backBtn.BackColor = Color.FromArgb(34, 36, 49);
        }
        private void backBtn_MouseLeave(object sender, EventArgs e)
        {
            backBtn.BackColor = Color.Transparent;
        }
        private void backBtn_MouseClick(object sender, MouseEventArgs e)
        {
            
            this.Hide();
        }

        private void empGrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void rehireEmpPanel_MouseClick(object sender, MouseEventArgs e)
        {
            rehireEmp();
        }

   

        private void empControl_Load(object sender, EventArgs e)
        {

        }

        private void empGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hireEmpPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void updateEmpPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
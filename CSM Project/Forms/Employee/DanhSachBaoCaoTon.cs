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
    public partial class DanhSachBaoCaoTon : Form
    {
        
        public DanhSachBaoCaoTon()
        {
            InitializeComponent();
            purchGridFill();       
        }
            
        private void purchGridFill()
        {
            
        }

        private void salesGridFill()
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sellCarPanel_MouseClick(object sender, MouseEventArgs e)
        {
            salesGridFill();
        }

        private void buyCarPanel_MouseClick(object sender, MouseEventArgs e)
        {
            purchGridFill();
        }

        private void exitBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void viewCarGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void viewCarGrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void sellCarPanel_MouseEnter(object sender, EventArgs e)
        {
            sellCarPanel.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void sellCarPanel_MouseLeave(object sender, EventArgs e)
        {
            sellCarPanel.BackColor = Color.Transparent;
        }

        private void buyCarPanel_MouseEnter(object sender, EventArgs e)
        {
            buyCarPanel.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void buyCarPanel_MouseLeave(object sender, EventArgs e)
        {
            buyCarPanel.BackColor = Color.Transparent;
        }

        private void backBtn_MouseEnter(object sender, EventArgs e)
        {
            backBtn.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void backBtn_MouseLeave(object sender, EventArgs e)
        {
            backBtn.BackColor = Color.Transparent;
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

        private void backBtn_MouseClick(object sender, MouseEventArgs e)
        {
                       
        }

        private void buyCarPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}

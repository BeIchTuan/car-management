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
    public partial class BaoCaoTon : Form
    {
       //
        public BaoCaoTon()
        {
            InitializeComponent();            
        }

        private void gridFill()
        {
            
        }



        void checkSale()
        {
            
        }

        void checkPurch()
        {
            
        }

        private void cashCollector()
        {
            
        }

        private void sellCarPanel_MouseClick(object sender, MouseEventArgs e)
        {
            checkSale();
        }

        private void buyCarPanel_MouseClick(object sender, MouseEventArgs e)
        {
            checkPurch();
        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            gridFill();
        }

        private void backBtn_MouseClick(object sender, MouseEventArgs e)
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

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            

        }

        private void backBtn_MouseEnter(object sender, EventArgs e)
        {
            backBtn.BackColor = Color.FromArgb(34, 36, 49);
           
        }

        private void viewCarGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void backBtn_MouseLeave(object sender, EventArgs e)
        {
            backBtn.BackColor = Color.Transparent;

        }

        private void viewCarGrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
                        
        }
    }
}

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
    public partial class DanhSachXe : Form
    {
       
        public DanhSachXe()
        {
            InitializeComponent();
            
            this.CenterToScreen();
        }
        
        private void backBtn_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void exitBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void viewCarGrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void gridFill()
        {
            redundantData.con.Open();
            SqlCommand viewCarCmd = new SqlCommand("select * from CAR", redundantData.con);
            SqlDataAdapter viewCarAdapter = new SqlDataAdapter(viewCarCmd);
            DataSet carData = new DataSet();
            viewCarAdapter.Fill(carData);

            viewCarGrid.Rows.Clear();
            for (int i = 0; i < (carData.Tables[0].Rows.Count); i++)
            {
                string ID = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[0]);
                string Name = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[1]);
                string Model = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[2]);
                string Company = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[3]);
                string Status = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[4]);
                string Price = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[5]);

                DataGridViewRow pushData = new DataGridViewRow();
                pushData.CreateCells(viewCarGrid);
                pushData.Cells[0].Value = Name;
                pushData.Cells[1].Value = Model;
                pushData.Cells[2].Value = Company;
                pushData.Cells[3].Value = Price;
                pushData.Cells[4].Value = Status;
                pushData.Cells[5].Value = ID;

                viewCarGrid.Rows.Add(pushData);

            }

            redundantData.con.Close();
        }

        private void viewAvailable()
        {
            redundantData.con.Open();
            SqlCommand viewCarCmd = new SqlCommand("select * from CAR where car_status = 'Available'", redundantData.con);
            SqlDataAdapter viewCarAdapter = new SqlDataAdapter(viewCarCmd);
            DataSet carData = new DataSet();
            viewCarAdapter.Fill(carData);

            viewCarGrid.Rows.Clear();
            for (int i = 0; i < (carData.Tables[0].Rows.Count); i++)
            {
                string ID = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[0]);
                string Name = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[1]);
                string Model = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[2]);
                string Company = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[3]);
                string Status = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[4]);
                string Price = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[5]);

                DataGridViewRow pushData = new DataGridViewRow();
                pushData.CreateCells(viewCarGrid);
                pushData.Cells[0].Value = Name;
                pushData.Cells[1].Value = Model;
                pushData.Cells[2].Value = Company;
                pushData.Cells[3].Value = Price;
                pushData.Cells[4].Value = Status;
                pushData.Cells[5].Value = ID;

                viewCarGrid.Rows.Add(pushData);

            }
            redundantData.con.Close();
        }

        private void viewSold()
        {
            redundantData.con.Open();
            SqlCommand viewCarCmd = new SqlCommand("select * from CAR where car_status = 'Sold'", redundantData.con);
            SqlDataAdapter viewCarAdapter = new SqlDataAdapter(viewCarCmd);
            DataSet carData = new DataSet();
            viewCarAdapter.Fill(carData);

            viewCarGrid.Rows.Clear();
            for (int i = 0; i < (carData.Tables[0].Rows.Count); i++)
            {
                string ID = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[0]);
                string Name = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[1]);
                string Model = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[2]);
                string Company = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[3]);
                string Status = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[4]);
                string Price = Convert.ToString(carData.Tables[0].Rows[i].ItemArray[5]);

                DataGridViewRow pushData = new DataGridViewRow();
                pushData.CreateCells(viewCarGrid);
                pushData.Cells[0].Value = Name;
                pushData.Cells[1].Value = Model;
                pushData.Cells[2].Value = Company;
                pushData.Cells[3].Value = Price;
                pushData.Cells[4].Value = Status;
                pushData.Cells[5].Value = ID;

                viewCarGrid.Rows.Add(pushData);

            }
            redundantData.con.Close();
        }

        private void buyCar()
        {
            
        }

        private void carSell()
        {
            
        }

        private void sellCarPanel_MouseClick(object sender, MouseEventArgs e)
        {
            carSell();
        }

        private void buyCarPanel_MouseClick(object sender, MouseEventArgs e)
        {
            buyCar();
        }

        private void viewSoldPanel_MouseClick(object sender, MouseEventArgs e)
        {
            viewSold();
        }

        private void viewAvailPanel_MouseClick(object sender, MouseEventArgs e)
        {
            viewAvailable();
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

        private void viewSoldPanel_MouseEnter(object sender, EventArgs e)
        {
            viewSoldPanel.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void viewSoldPanel_MouseLeave(object sender, EventArgs e)
        {
            viewSoldPanel.BackColor = Color.Transparent;
        }

        private void viewAvailPanel_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void viewAvailPanel_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void backBtn_MouseEnter(object sender, EventArgs e)
        {
            backBtn.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void backBtn_MouseLeave(object sender, EventArgs e)
        {
            backBtn.BackColor = Color.Transparent;
        }

        private void viewCarGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSM_Project.Forms.Customer
{
    public partial class MenuCustomer : Form
    {
        public MenuCustomer()
        {
            InitializeComponent();
        }

        public string TenNguoiDung
        {
            get { return customerName.Text; }
            set { customerName.Text = value; } //Label để hiển thị Họ tên người dùng
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_Final
{
    public partial class Home_Page : Form
    {
        public Home_Page()
        {
            InitializeComponent();
        }
        
       
        private void sign_in_btn_Click(object sender, EventArgs e)
        {
            AdminPanelForm AdminPanel = new AdminPanelForm();
            AdminPanel.ShowDialog();
        }

     
        
       
        
    }
}

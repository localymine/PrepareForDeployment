using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrepareForDeployment
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {

            convert_lists();

        }

        private string[] convert_lists()
        {
            string[] list_files = { "" };

            System.Diagnostics.Debug.WriteLine(rtb_list_files.Text);


            return list_files;
        }
    }
}

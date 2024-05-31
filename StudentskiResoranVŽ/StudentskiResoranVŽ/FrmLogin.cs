using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskiResoranVŽ
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if(username == "" || password == "")    
            {
                MessageBox.Show("Popunite sva polja!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
            else if (username == "student" && password == "student")
            {
                Hide();
                FrmStudent frmStudent = new FrmStudent();
                frmStudent.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Pogrešno korisničko ime ili lozina!", "Neuspjela prijava", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

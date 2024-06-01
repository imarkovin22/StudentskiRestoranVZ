using StudentskiResoranVŽ.Repositories;
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

        private UserRepository _userRepository;

        public FrmLogin()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Popunite sva polja!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var user = _userRepository.GetUserByUsernameAndPassword(username, password);

                if (user != null)
                {
                    Hide();
                    FrmStudent frmStudent = new FrmStudent(user.UserId); // Pass user ID to FrmStudent
                    frmStudent.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Pogrešno korisničko ime ili lozinka!", "Neuspjela prijava", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

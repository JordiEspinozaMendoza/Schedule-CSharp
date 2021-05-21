using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Schedule_library.Views;
using SystemAccess;
namespace Schedule_library.Views
{
    public partial class Register :Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLoginRegister login = new FormLoginRegister();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == textBox3.Text)
                {
                    SystemAccess.Register register = new SystemAccess.Register(textBox1.Text, textBox2.Text);
                    register.EncryptPassword();
                    register.RegisterUser();
                    if (register.complete)
                    {
                        this.Hide();
                        FormLoginRegister login = new FormLoginRegister();
                        login.Show();
                    }
                }
                else
                    MessageBox.Show("Ambas contraseñas deben de coincidir");
            }catch(Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }
    }
}

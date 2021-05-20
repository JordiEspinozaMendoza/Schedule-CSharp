using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemAccess;
namespace Schedule_library.Views
{
    public partial class FormLoginRegister : Form
    {
        public FormLoginRegister()
        {
            InitializeComponent();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login(textBox1.Text, textBox2.Text);
            login.LoginUser();
            if (login.DecryptPassword())
            {
                Layout layout = new Layout(login.idUser);
                this.Hide();
                layout.Show();
            }
                
            else
                MessageBox.Show("Ingresa un nombre de usuario o contraseña valido");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Schedule_library.Views
{
    public partial class RegisterItem : Form
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-6QMNAK5;Initial Catalog = Schedule; integrated security=true");
        public int idUser;
        public RegisterItem(int idUser)
        {
            InitializeComponent();
            this.idUser = idUser;

        }
        public void RegisterStatement()
        {
            connection.Open();
            String query = $"INSERT INTO ScheduleItem (name, phone, birth, socialNetwork, _idUser) VALUES ('{textBoxName.Text}', '{textBoxPhone.Text}', '{dateTimePicker1.Value}', '{textBoxSocialNet.Text}', {this.idUser})";
            try
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Contacto agregado correctamente");
            }catch(Exception err)
            {
                MessageBox.Show(err.Message);
                MessageBox.Show(query);
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            RegisterStatement();
        }
    }
}

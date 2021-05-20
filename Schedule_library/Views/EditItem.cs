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
    public partial class EditItem : Form
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-6QMNAK5;Initial Catalog = Schedule; integrated security=true");
        public int idUser;
        List<List<Object>> items;

        public EditItem(int idUser)
        {
            InitializeComponent();
            this.idUser = idUser;
            SelectStatement();
        }
        public void SelectStatement()
        {
            connection.Open();
            String query = $"SELECT * FROM ScheduleItem WHERE _idUser={this.idUser}";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader sqlDataReader = null;

            List<List<Object>> response = new List<List<Object>>();
            try
            {
                sqlDataReader = command.ExecuteReader();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            while (sqlDataReader.Read())
            {
                List<Object> temp = new List<Object>();

                for (int i = 0; i < 2; i++)
                {
                    temp.Add(sqlDataReader[i]);
                }

                response.Add(temp);
            }

            connection.Close();
            this.items = response;
            foreach (var item in this.items)
            {
                comboBox1.Items.Add(new ListItem { Name = item[1].ToString(), Value = item[0] });
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                String query = $"SELECT * FROM ScheduleItem WHERE _idItem={int.Parse(((ListItem)comboBox1.SelectedItem).Value.ToString())}";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader sqlDataReader = null;
                try
                {
                    sqlDataReader = command.ExecuteReader();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }
                while (sqlDataReader.Read())
                {
                    textBoxName.Text = sqlDataReader[1].ToString();
                    textBoxPhone.Text = sqlDataReader[2].ToString();
                    dateTimePicker1.Value = DateTime.Parse(sqlDataReader[3].ToString());
                    textBoxSocialNet.Text = sqlDataReader[4].ToString();
                }
                connection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                String query = $"UPDATE ScheduleItem SET name='{textBoxName.Text}', phone='{textBoxPhone.Text}', birth='{dateTimePicker1.Value}', socialNetwork='{textBoxSocialNet.Text}' WHERE _idItem='{int.Parse(((ListItem)comboBox1.SelectedItem).Value.ToString())}'";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Contacto actualizado correctamente");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                String query = $"DELETE FROM ScheduleItem WHERE _idItem='{int.Parse(((ListItem)comboBox1.SelectedItem).Value.ToString())}'";

                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Contacto eliminado correctamente");

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}

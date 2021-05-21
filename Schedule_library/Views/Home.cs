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
    public partial class Home : Form
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-6QMNAK5;Initial Catalog = Schedule; integrated security=true");
        public int idUser;

        public Home(int idUser)
        {
            InitializeComponent();
            this.idUser = idUser;
            SelectStatementDatatable();
        }
        public void SelectStatementDatatable()
        {
            connection.Open();
            String query = $"SELECT * FROM ScheduleItem WHERE _idUser={this.idUser}";
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }
    }
}

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
namespace Schedule_library.Views
{
    public partial class Layout : Form
    {
        private Form actualChildForm;
        public int idUser;
        public Layout(int idUser)
        {
            InitializeComponent();
            this.idUser = idUser;
            OpenChildForm(new RegisterItem(this.idUser));
        }
        private void OpenChildForm(Form childForm)
        {
            if (actualChildForm != null)
            {
                actualChildForm.Close();
            }
            actualChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BackColor = Color.FromArgb(247, 248, 251);

            panelChild.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RegisterItem(this.idUser));
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EditItem(this.idUser));
        }
    }
}

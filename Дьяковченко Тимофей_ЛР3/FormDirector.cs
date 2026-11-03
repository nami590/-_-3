using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using АлекссевАртём_ЛР3.Model;

namespace АлекссевАртём_ЛР3
{
    public partial class FormDirector : Form
    {
        public FormDirector()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormParent_Load(object sender, EventArgs e)
        {
            ModellF model = new ModellF();
            //Используя ранее заполненное статическое поле формы авторизации заполняем эту форму данными
            labelNames.Text = FormAutorization.Enter_User.First_Name + " " + FormAutorization.Enter_User.Second_Name;
            labelRole.Text = model.Roles.First(x => x.ID == FormAutorization.Enter_User.RoleID).Name;
            pictureBox1.Image = Image.FromFile(@"Photo\" + FormAutorization.Enter_User.Pictures);
        }
    }
}

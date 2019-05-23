using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Personform : Form
    {
        private Person P;
        public Personform(Person p)
        {
            InitializeComponent();
            P = p;
            tbfirstname.Text = p.Firstname;
            tblastname.Text = p.Lastname;
            tbphone.Text = p.Phone;
        }

        private void Personform_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(DialogResult==DialogResult.OK)
            {
                if(tblastname.Text.Trim()=="")
                {
                    MessageBox.Show("Необходимо ввести фамилию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tblastname.Focus();
                    e.Cancel = true;
                    return;
                }
                P.Firstname = tbfirstname.Text;
                P.Lastname = tblastname.Text;
                P.Phone = tbphone.Text;
            }
        }
    }
}

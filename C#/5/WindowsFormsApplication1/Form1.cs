using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butadd_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            Personform f = new Personform(p);
            f.Text = "Добавление";
            if(f.ShowDialog()==DialogResult.OK)
            {
                listBox1.Items.Add(p);
            }
        }

        private void butdelete_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.Firstname = tbfirstname.Text;
            p.Lastname = tblastname.Text;
            p.Phone = tbphone.Text;
            Personform f = new Personform(p);
            f.Text = "Изменение";
            if (f.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox1.Items.Add(p);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person p = (Person)listBox1.SelectedItem;
            if(p==null)
            {
                tbfirstname.Text = "";
                tblastname.Text = "";
                tbphone.Text = "";
            }
            else
            {
                tbfirstname.Text = p.Firstname;
                tblastname.Text = p.Lastname;
                tbphone.Text = p.Phone;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            if (sd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(sd.FileName, FileMode.Create);
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    Person p = (Person)listBox1.Items[i];
                    p.SaveToStream(fs);
                }
                fs.Close();
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            if(od.ShowDialog()==DialogResult.OK)
            {
                FileStream fs = new FileStream(od.FileName, FileMode.Open);
                listBox1.Items.Clear();
                while(fs.Position<fs.Length)
                {
                    Person p = new Person();
                    p.LoadFromStream(fs);
                    listBox1.Items.Add(p);

                }
                listBox1.SelectedItem=null;
                fs.Close();
            }
        }
    }
}

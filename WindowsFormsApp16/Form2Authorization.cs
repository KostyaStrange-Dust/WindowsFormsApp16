using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp16.FolderName;

namespace WindowsFormsApp16
{
    public partial class Form2Authorization : Form
    {
        public Form2Authorization()
        {
            InitializeComponent();
        }

        private void Form2Authorization_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model1 model = new Model1();
            if (model.UsersHash.ToList().Any(x =>
            x.Login == textBox1.Text &&
            x.Password == SHA256Builder.ConvertToHash(textBox2.Text)))
            {
                MessageBox.Show("Пользователь найден!");
                return;
            }
            MessageBox.Show("Пользоваетль не найден!");
        }
    }
}

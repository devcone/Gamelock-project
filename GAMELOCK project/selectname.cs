using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GAMELOCK_project.Properties;
namespace GAMELOCK_project
{
    public partial class selectname : Form
    {
        public selectname()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            Settings.Default["username"] = name;
            Settings.Default.Save();
            this.Close();
        }

        private void selectname_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passpro
{
    public partial class AddPass : Form
    {
        public AddPass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckPro passClass = new CheckPro();
            CheckPro.passStruct pass = new CheckPro.passStruct();
            pass.no = textBox1.Text;
            pass.passType = textBox2.Text;
            pass.passUserName = textBox3.Text;
            pass.passPassword = textBox4.Text;
            passClass.insertPass(pass);
            Main form = (Main)this.Owner;
            CheckPro check = new CheckPro();
            
            List<CheckPro.passStruct> list = check.readPassFill();
            form.dataGridView1.DataSource = list;
            //form.Show();
            this.Close();
        }
    }
}

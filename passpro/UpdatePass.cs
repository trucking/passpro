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
    public partial class UpdatePass : Form
    {
        CheckPro.passStruct ps = new CheckPro.passStruct();
        public UpdatePass()
        {
            InitializeComponent();
        }
        public UpdatePass(string obj)
        {
            string[] item = obj.Split('\t');
            System.Diagnostics.Debug.WriteLine(obj);
            this.ps.no = item[0];
            this.ps.passType = item[1];
            this.ps.passUserName = item[2];
            this.ps.passPassword = item[3];
            
            InitializeComponent();
            this.textBox1.Text = item[0];
            this.textBox1.ReadOnly = true;
            this.textBox2.Text = item[1];
            this.textBox2.ReadOnly = true;
            this.textBox3.Text = item[2];
            this.textBox4.Text = item[3];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckPro passClass = new CheckPro();
            CheckPro.passStruct pass = new CheckPro.passStruct();
            pass.no = textBox1.Text;
            pass.passType = textBox2.Text;
            pass.passUserName = textBox3.Text;
            pass.passPassword = textBox4.Text;
            passClass.updatePassFill(this.ps,pass);
            Main form = (Main)this.Owner;
            CheckPro check = new CheckPro();
            
            List<CheckPro.passStruct> list = check.readPassFill();
            form.dataGridView1.DataSource = list;
            //form.Show();
            this.Close();
        }
    }
}

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

namespace passpro
{
    public partial class ChangeKey : Form
    {
        public ChangeKey()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("请输入密钥", "提示",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            FileStream fs = new FileStream("./key", FileMode.Truncate,FileAccess.ReadWrite);
            fs.Close();
            CheckPro cp = new CheckPro();
            cp.createKey(textBox1.Text);
            this.Close();
        }
    }
}

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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void 新增密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPass addPass = new AddPass();
            addPass.Show(this);
        }

        private void 修改密钥ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeKey changeKey = new ChangeKey();
            changeKey.Show();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            CheckPro check = new CheckPro();
            CheckPro.passStruct passStruct = new CheckPro.passStruct();
            List<CheckPro.passStruct> list = check.readPassFill();           
            dataGridView1.DataSource = list;            
        }        
    }
}

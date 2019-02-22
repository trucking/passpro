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
            
            List<CheckPro.passStruct> list = check.readPassFill();           
            dataGridView1.DataSource = list;
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                string no = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                MessageBox.Show(no);
            }else
            {
                MessageBox.Show("请选中需要修改的行！");
            }
        }

        private void 删除密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string no = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                CheckPro checkPro = new CheckPro();
                CheckPro.passStruct ps = new CheckPro.passStruct();
                ps.no = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                ps.passType = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                ps.passUserName = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                ps.passPassword = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                checkPro.deletePass(ps);
                this.refresh();
            }
            else
            {
                MessageBox.Show("请选中需要修改的行！");
            }
        }

        private void refresh()
        {
            CheckPro check = new CheckPro();
            List<CheckPro.passStruct> list = check.readPassFill();
            dataGridView1.DataSource = list;
        }
    }
}

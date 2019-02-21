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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            CheckPro checkPro = new CheckPro();
            if (checkPro.checkKeyFile() == false)
            {
                label1.Font = new Font(label1.Font.Name, 10);
                label1.Location = new Point(2, 35);
                Label lab = new Label();
                lab.Location = new Point(50, 5);
                lab.Size = new Size(300, 20);
                lab.Text = "首次使用请牢记您设置的密钥";
                this.Controls.Add(lab);
                this.label1.Text = "请输入您的密钥";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckPro checkPro = new CheckPro();
            if (checkPro.checkKeyFile())
            {
                if (checkPro.checkKeyValue(textBox1.Text))
                {
                    Main main = new Main();
                    main.Show();
                    CheckPro.KEY = textBox1.Text;
                    this.Hide();
                }else
                {
                    MessageBox.Show("密钥错误");
                }
            }
            else
            {
                checkPro.createKey(textBox1.Text);
                this.Hide();   //先隐藏主窗体
                login login = new login(); //重新实例化此窗体
                login.ShowDialog();//已模式窗体的方法重新打开
                this.Close();//原窗体关闭
            }
        }
    }

}

namespace passpro
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.新增密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密钥ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passusername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.删除密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增密码ToolStripMenuItem,
            this.修改密码ToolStripMenuItem,
            this.删除密码ToolStripMenuItem,
            this.修改密钥ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(477, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 新增密码ToolStripMenuItem
            // 
            this.新增密码ToolStripMenuItem.Name = "新增密码ToolStripMenuItem";
            this.新增密码ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.新增密码ToolStripMenuItem.Text = "新增密码";
            this.新增密码ToolStripMenuItem.Click += new System.EventHandler(this.新增密码ToolStripMenuItem_Click);
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click);
            // 
            // 修改密钥ToolStripMenuItem
            // 
            this.修改密钥ToolStripMenuItem.Name = "修改密钥ToolStripMenuItem";
            this.修改密钥ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.修改密钥ToolStripMenuItem.Text = "修改密钥";
            this.修改密钥ToolStripMenuItem.Click += new System.EventHandler(this.修改密钥ToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.passType,
            this.passusername,
            this.password});
            this.dataGridView1.Location = new System.Drawing.Point(13, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(452, 235);
            this.dataGridView1.TabIndex = 1;
            // 
            // no
            // 
            this.no.DataPropertyName = "no";
            this.no.HeaderText = "序号";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            // 
            // passType
            // 
            this.passType.DataPropertyName = "passType";
            this.passType.HeaderText = "密码类型";
            this.passType.Name = "passType";
            this.passType.ReadOnly = true;
            // 
            // passusername
            // 
            this.passusername.DataPropertyName = "passUserName";
            this.passusername.HeaderText = "用户名";
            this.passusername.Name = "passusername";
            this.passusername.ReadOnly = true;
            // 
            // password
            // 
            this.password.DataPropertyName = "passPassword";
            this.password.HeaderText = "密码";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            // 
            // 删除密码ToolStripMenuItem
            // 
            this.删除密码ToolStripMenuItem.Name = "删除密码ToolStripMenuItem";
            this.删除密码ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.删除密码ToolStripMenuItem.Text = "删除密码";
            this.删除密码ToolStripMenuItem.Click += new System.EventHandler(this.删除密码ToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 295);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "密码查看";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新增密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密钥ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn passType;
        private System.Windows.Forms.DataGridViewTextBoxColumn passusername;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.ToolStripMenuItem 删除密码ToolStripMenuItem;
    }
}


namespace WinformLanguageChange
{
    partial class MainForm
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
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.MenuProject = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProjectItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProjectItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProjectItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProjectItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuManage = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuManageItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuManageItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuManageItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuManageItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelpItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelpItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.IndexForm = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonGo = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.StatuBarItem1 = new System.Windows.Forms.ToolStripLabel();
            this.StatuBarItem2 = new System.Windows.Forms.ToolStripLabel();
            this.StatuBarItem3 = new System.Windows.Forms.ToolStripLabel();
            this.StatuBarItem4 = new System.Windows.Forms.ToolStripLabel();
            this.Menu.SuspendLayout();
            this.IndexForm.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuProject,
            this.MenuManage,
            this.MenuHelp});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(809, 25);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // MenuProject
            // 
            this.MenuProject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuProjectItem1,
            this.MenuProjectItem2,
            this.MenuProjectItem3,
            this.MenuProjectItem4});
            this.MenuProject.Name = "MenuProject";
            this.MenuProject.Size = new System.Drawing.Size(44, 21);
            this.MenuProject.Text = "项目";
            // 
            // MenuProjectItem1
            // 
            this.MenuProjectItem1.Name = "MenuProjectItem1";
            this.MenuProjectItem1.Size = new System.Drawing.Size(100, 22);
            this.MenuProjectItem1.Text = "新建";
            // 
            // MenuProjectItem2
            // 
            this.MenuProjectItem2.Name = "MenuProjectItem2";
            this.MenuProjectItem2.Size = new System.Drawing.Size(100, 22);
            this.MenuProjectItem2.Text = "打开";
            // 
            // MenuProjectItem3
            // 
            this.MenuProjectItem3.Name = "MenuProjectItem3";
            this.MenuProjectItem3.Size = new System.Drawing.Size(100, 22);
            this.MenuProjectItem3.Text = "保存";
            // 
            // MenuProjectItem4
            // 
            this.MenuProjectItem4.Name = "MenuProjectItem4";
            this.MenuProjectItem4.Size = new System.Drawing.Size(100, 22);
            this.MenuProjectItem4.Text = "退出";
            // 
            // MenuManage
            // 
            this.MenuManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuManageItem1,
            this.MenuManageItem2,
            this.MenuManageItem3,
            this.MenuManageItem4});
            this.MenuManage.Name = "MenuManage";
            this.MenuManage.Size = new System.Drawing.Size(44, 21);
            this.MenuManage.Text = "管理";
            // 
            // MenuManageItem1
            // 
            this.MenuManageItem1.Name = "MenuManageItem1";
            this.MenuManageItem1.Size = new System.Drawing.Size(180, 22);
            this.MenuManageItem1.Text = "登录";
            // 
            // MenuManageItem2
            // 
            this.MenuManageItem2.Name = "MenuManageItem2";
            this.MenuManageItem2.Size = new System.Drawing.Size(180, 22);
            this.MenuManageItem2.Text = "注销";
            // 
            // MenuManageItem3
            // 
            this.MenuManageItem3.Name = "MenuManageItem3";
            this.MenuManageItem3.Size = new System.Drawing.Size(180, 22);
            this.MenuManageItem3.Text = "修改密码";
            // 
            // MenuManageItem4
            // 
            this.MenuManageItem4.Name = "MenuManageItem4";
            this.MenuManageItem4.Size = new System.Drawing.Size(180, 22);
            this.MenuManageItem4.Text = "用户管理";
            // 
            // MenuHelp
            // 
            this.MenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuHelpItem1,
            this.MenuHelpItem2});
            this.MenuHelp.Name = "MenuHelp";
            this.MenuHelp.Size = new System.Drawing.Size(44, 21);
            this.MenuHelp.Text = "帮助";
            // 
            // MenuHelpItem1
            // 
            this.MenuHelpItem1.Name = "MenuHelpItem1";
            this.MenuHelpItem1.Size = new System.Drawing.Size(180, 22);
            this.MenuHelpItem1.Text = "帮助内容";
            // 
            // MenuHelpItem2
            // 
            this.MenuHelpItem2.Name = "MenuHelpItem2";
            this.MenuHelpItem2.Size = new System.Drawing.Size(180, 22);
            this.MenuHelpItem2.Text = "关于";
            // 
            // IndexForm
            // 
            this.IndexForm.Controls.Add(this.groupBox2);
            this.IndexForm.Controls.Add(this.groupBox1);
            this.IndexForm.Controls.Add(this.buttonStop);
            this.IndexForm.Controls.Add(this.buttonGo);
            this.IndexForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IndexForm.Location = new System.Drawing.Point(0, 25);
            this.IndexForm.Name = "IndexForm";
            this.IndexForm.Size = new System.Drawing.Size(809, 441);
            this.IndexForm.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(420, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox1";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(88, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(324, 332);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 0;
            this.buttonStop.Text = "button1";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(26, 332);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 23);
            this.buttonGo.TabIndex = 0;
            this.buttonGo.Text = "button1";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatuBarItem1,
            this.StatuBarItem2,
            this.StatuBarItem3,
            this.StatuBarItem4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(809, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // StatuBarItem1
            // 
            this.StatuBarItem1.Name = "StatuBarItem1";
            this.StatuBarItem1.Size = new System.Drawing.Size(44, 22);
            this.StatuBarItem1.Text = "用户名";
            // 
            // StatuBarItem2
            // 
            this.StatuBarItem2.Name = "StatuBarItem2";
            this.StatuBarItem2.Size = new System.Drawing.Size(96, 22);
            this.StatuBarItem2.Text = "toolStripLabel1";
            // 
            // StatuBarItem3
            // 
            this.StatuBarItem3.Name = "StatuBarItem3";
            this.StatuBarItem3.Size = new System.Drawing.Size(96, 22);
            this.StatuBarItem3.Text = "toolStripLabel1";
            // 
            // StatuBarItem4
            // 
            this.StatuBarItem4.Name = "StatuBarItem4";
            this.StatuBarItem4.Size = new System.Drawing.Size(96, 22);
            this.StatuBarItem4.Text = "toolStripLabel1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 466);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.IndexForm);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.IndexForm.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem MenuProject;
        private System.Windows.Forms.ToolStripMenuItem MenuProjectItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuProjectItem2;
        private System.Windows.Forms.ToolStripMenuItem MenuProjectItem3;
        private System.Windows.Forms.ToolStripMenuItem MenuProjectItem4;
        private System.Windows.Forms.ToolStripMenuItem MenuManage;
        private System.Windows.Forms.ToolStripMenuItem MenuManageItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuManageItem2;
        private System.Windows.Forms.ToolStripMenuItem MenuManageItem3;
        private System.Windows.Forms.ToolStripMenuItem MenuManageItem4;
        private System.Windows.Forms.ToolStripMenuItem MenuHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuHelpItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuHelpItem2;
        private System.Windows.Forms.Panel IndexForm;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel StatuBarItem1;
        private System.Windows.Forms.ToolStripLabel StatuBarItem2;
        private System.Windows.Forms.ToolStripLabel StatuBarItem3;
        private System.Windows.Forms.ToolStripLabel StatuBarItem4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonGo;
    }
}


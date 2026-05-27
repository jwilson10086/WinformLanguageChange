using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformLanguageChange
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Localization.HasLanguage)
            {
                Localization.LoadLanguage("zh");
                Program.RefreshLanguage(this);
                Program.RefreshMenuLanguage(this.Menu);
                Program.RefreshStatusStripLanguage(this.toolStrip1);
            }
            else
            {
                Localization.LoadLanguage("en");
                Program.RefreshLanguage(this);
                Program.RefreshMenuLanguage(this.Menu);
                Program.RefreshStatusStripLanguage(this.toolStrip1);
            }
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            if (Localization.HasLanguage)
            {
                Localization.HasLanguage = false;
                MainForm_Load(sender, e);
            }
            else
            {
                Localization.HasLanguage = true;
                MainForm_Load(sender, e);
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            UpdateDialogLanguage();
        }
        private void UpdateDialogLanguage()
        {
            // 假设有一个对话框显示用户信息
            string dialogText = Localization.Dialog["1004"]; // 获取对应语言的文本
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            // 显示对话框
            MessageBox.Show(dialogText, Localization.Dialog["0006"],MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}

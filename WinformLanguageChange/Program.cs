using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WinformLanguageChange
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AddForm();
            if (!Localization.LoadLanguage("zh"))
            {
                MessageBox.Show("语言文件加载失败！将显示英文", "错误", MessageBoxButtons.OK);
                Localization.HasLanguage = false;
            }
            else
            {
                Localization.HasLanguage = true;
            }
            Application.Run(new MainForm());
        }

        private static void AddForm()
        {
            Localization.AddForm("MainForm");
            Localization.AddForm("UserLoginForm");
            //Localization.AddForm("UserManageForm");
            //Localization.AddForm("ChangPasswordForm");
        }

        //  更新窗体语言
        public static void RefreshLanguage(Form form)
        {
            form.Text = Localization.Forms[form.Name][form.Name];
            SetControlsLanguage(form, Localization.Forms[form.Name]);
        }

        //  设置窗体控件语言
        public static void SetControlsLanguage(Control control, Dictionary<string, string> obj)
        {
            foreach (Control child in control.Controls)
            {
                string text = string.Empty;
                if (obj.TryGetValue(child.Name, out text))
                {
                    child.Text = text;
                }
                if (child.HasChildren)
                {
                    SetControlsLanguage(child, obj);
                }
            }
        }

        //Refresh the menu language
        public static void RefreshMenuLanguage(MenuStrip menuStrip)
        {
            foreach (ToolStripMenuItem item in menuStrip.Items)
            {
                item.Text = Localization.Menu[item.Name];

                foreach (ToolStripMenuItem subItem in item.DropDownItems)
                {
                    if (subItem is ToolStripMenuItem)
                    {
                        string text = string.Empty;
                        if (Localization.Menu.TryGetValue(subItem.Name, out text))
                        {
                            subItem.Text = text;
                        }
                    }
                }
            }
        }

        //Refresh the status strip language
        public static void RefreshStatusStripLanguage(ToolStrip statusStrip)
        {
            foreach (ToolStripItem item in statusStrip.Items)
            {
                if (item is ToolStripLabel)
                {
                    string text = string.Empty;
                    if (Localization.ToolBar.TryGetValue(item.Name, out text))
                    {
                        item.Text = text;
                    }
                }
            }
        }
    }
}

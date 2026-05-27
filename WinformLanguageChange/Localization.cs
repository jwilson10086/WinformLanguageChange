using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Microsoft.SqlServer.Server;

namespace WinformLanguageChange
{
    /// <summary>
    /// 本地化类
    /// </summary>
    public static class Localization
    {
        #region Property
        public static string Language { get; set; }
        public static bool HasLanguage { get; set; }
        #endregion

        #region Attribute
        private static Dictionary<string, Dictionary<string, string>> forms =
            new Dictionary<string, Dictionary<string, string>>();
        private static Dictionary<string, string> menu = new Dictionary<string, string>();
        private static Dictionary<string, string> toolbar = new Dictionary<string, string>();
        private static Dictionary<string, string> dialog = new Dictionary<string, string>();

        #endregion

        #region Method
        public static void AddForm(string formName)
        {
            forms.Add(formName, new Dictionary<string, string>());
        }

        public static bool LoadLanguage(string language)
        {
            string path = string.Empty;
            Localization.Language = "English";

            menu.Clear();
            toolbar.Clear();
            dialog.Clear();
            //exceptioin.Clear();
            foreach (Dictionary<string, string> form in forms.Values)
            {
                form.Clear();
            }

            switch (language)
            {
                case "zh":
                    path = Application.StartupPath + "\\resources\\language-zh.xml";
                    break;
                case "en":
                    path = Application.StartupPath + "\\resources\\language-en.xml";
                    break;
                default:
                    path = Application.StartupPath + "\\resources\\language-zh.xml";
                    break;
            }

            return readLanguage(path);
        }
        #endregion

        #region Funcyion
        /// <summary>
        /// 读取语言文件
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private static bool readLanguage(string path)
        {
            XmlReader reader;
            try
            {
                reader = XmlReader.Create(path);
            }
            catch (Exception)
            {
                return false;
            }

            //beging to parase
            try
            {
                reader.ReadToFollowing("AirControl");
                Localization.Language = reader.GetAttribute("language");

                paraseXml(reader, "Menu", menu);
                paraseXml(reader, "ToolBar", toolbar);
                foreach (string formName in forms.Keys)
                {
                    paraseXml(reader, formName, forms[formName]);
                }
                paraseXml(reader, "Dialog", dialog);
                //paraseXml(reader, "Exception", exception);
            }
            catch (Exception ex)
            {
                int errorCode = Marshal.GetLastWin32Error();
                Win32Exception win32Ex = new Win32Exception(errorCode);
                MessageBox.Show("Error description: " + win32Ex.NativeErrorCode + "," + win32Ex.Message + "," + ex.Message);
                return false;
            }
            finally
            {
                reader.Close();
            }

            return true;
        }

        /// <summary>
        /// 解析xml文件
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="name"></param>
        /// <param name="dic"></param>
        private static void paraseXml(XmlReader reader, string item, Dictionary<string, string> dic)
        {
            //Get the attribute key and value
            reader.ReadToFollowing(item);
            XmlReader subReader = reader.ReadSubtree();
            while (subReader.Read())
            {
                if (subReader.NodeType == XmlNodeType.Element && subReader.Name == "Item")
                {
                    dic.Add(subReader.GetAttribute("key"), subReader.GetAttribute("value"));
                }
            }
        }
        #endregion

        #region Property
        public static Dictionary<string, string> Menu
        {
            get { return menu; }
            private set { }
        }
        public static Dictionary<string, string> ToolBar
        {
            get { return toolbar; }
            private set { }
        }
        public static Dictionary<string, Dictionary<string, string>> Forms
        {
            get { return forms; }
            private set { }
        }
        public static Dictionary<string, string> Dialog
        {
            get { return dialog; }
            private set { }
        }
        #endregion
    }
}

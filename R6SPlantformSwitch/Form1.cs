using System;
/*
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
*/
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace R6SPlantformSwitch
{
    public partial class Form1 : Form
    {
        string pLocalFilePath;
        string pSaveFilePath;
        R6SPlantformSwitch.IniFiles ini;
        public Form1()
        {
            InitializeComponent();
            if(!File.Exists(Application.StartupPath + @"\config.ini"))
            {
                try
                {
                    FileStream fs = File.Create(Application.StartupPath + @"\config.ini");
                    fs.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("配置文件创建失败，原因是：\n" + e.Message, "创建失败");
                }
                ini = new R6SPlantformSwitch.IniFiles(Application.StartupPath + @"\config.ini");
                ini.IniWriteValue("selection", "platform", "");
                ini.IniWriteValue("location", "game_folder", "");
            }
            else
            {
                ini = new R6SPlantformSwitch.IniFiles(Application.StartupPath + @"\config.ini");
                try
                {
                    gameFolderLoc.Text = ini.IniReadValue("location", "game_folder").Replace("/", @"\");
                    pSaveFilePath = gameFolderLoc.Text + "defaultargs.dll";

                    string platform = ini.IniReadValue("selection", "platform");
                    UplayRadio.Checked = false;
                    SteamRadio.Checked = false;
                    if (platform == "steam")
                    {
                        SteamRadio.Checked = true;
                    }
                    else if (platform == "uplay")
                    {
                        UplayRadio.Checked = true;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // pSaveFilePath = "defaultargs.dll";
            if (pSaveFilePath == "" || pSaveFilePath == null)
            {
                MessageBox.Show("文件目标位置不可用！", "目标错误");
            }
            else if (File.Exists(pLocalFilePath))
            {
                File.Copy(pLocalFilePath, pSaveFilePath, true);
                MessageBox.Show("成功替换文件！\n已从[" + pLocalFilePath + "]\n替换到[" + pSaveFilePath + "]。", "成功");
            }
            else if (pLocalFilePath == "")
            {
                MessageBox.Show("请选择平台！", "目标错误");
            }
            else
            {
                MessageBox.Show("未找到需替换文件！请重新下载！", "缺少必要文件");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.UplayRadio.Checked == true)
            {
                pLocalFilePath = Application.StartupPath + @"\uplay.dll";
                ini.IniWriteValue("selection", "platform", "uplay");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.SteamRadio.Checked == true)
            {
                pLocalFilePath = Application.StartupPath + @"\steam.dll";
                ini.IniWriteValue("selection", "platform", "steam");
            }
        }

        private void gameFolderLoc_TextChanged(object sender, EventArgs e)
        {
            gameFolderLoc.Text = gameFolderLoc.Text.Replace("/", @"\");
            pSaveFilePath = gameFolderLoc.Text + "defaultargs.dll";
            ini.IniWriteValue("location", "game_folder", gameFolderLoc.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            gameFolderBrowser.Description = "请选择文件夹";
            gameFolderBrowser.RootFolder = Environment.SpecialFolder.MyComputer;
            gameFolderBrowser.ShowNewFolderButton = true;
            if (gameFolderLoc.Text.Length > 0)
            {
                gameFolderBrowser.SelectedPath = gameFolderLoc.Text;
            }
            if (gameFolderBrowser.ShowDialog() == DialogResult.OK)
            {
                gameFolderLoc.Text = gameFolderBrowser.SelectedPath;
            }
            pSaveFilePath = gameFolderLoc.Text + "defaultargs.dll";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Instructions formIns = new Instructions();
            formIns.ShowDialog();
        }
    }
    public class IniFiles
    {
        string inipath;

        public IniFiles(string path)
        {
            inipath = path;
        }

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        
        public void IniWriteValue(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, this.inipath);
        }
        public string IniReadValue(string Section, string Key)
        {
            StringBuilder temp = new StringBuilder(500);
            int i = GetPrivateProfileString(Section, Key, "", temp, 500, this.inipath);
            return temp.ToString();
        }
        public bool ExistINIFile()
        {
            return File.Exists(inipath);
        }
    }
}

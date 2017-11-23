using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SyncFiles
{
    public partial class f_Main : Form
    {

        bool _sync;

        List<_FileInf> fileInf = new List<_FileInf>();

        List<string> files = new List<string>();
        List<string> dirs = new List<string>();

        public f_Main()
        {
            InitializeComponent();
            tb_FirstPath.Text = MainSettings.Default.firstPath;
            tb_SecondPath.Text = MainSettings.Default.secondPath;
            _sync = false;
        }

        private void f_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainSettings.Default.firstPath = tb_FirstPath.Text;
            MainSettings.Default.secondPath = tb_SecondPath.Text;
            MainSettings.Default.Save();
        }

        #region Обработчики кнопок
        private void b_Sync_Click(object sender, EventArgs e){_ChangeSync();}
        private void b_fp_choose_Click(object sender, EventArgs e)
        {
            folderBrowser.ShowDialog();
            tb_FirstPath.Text = folderBrowser.SelectedPath;
            folderBrowser.Dispose();
        }
        private void b_sp_choose_Click(object sender, EventArgs e)
        {
            folderBrowser.ShowDialog();
            tb_SecondPath.Text = folderBrowser.SelectedPath;
            folderBrowser.Dispose();
        }
        #endregion Обработчики кнопок

        private void _ChangeSync()
        {
            if (_isSync())
            {
                b_Sync.ForeColor = Color.Green;
                b_Sync.Text = "Start Sync";
                tb_SecondPath.Enabled = tb_FirstPath.Enabled = b_sp_choose.Enabled = b_fp_choose.Enabled = true;
                timer.Enabled = _sync = false;
            }
            else
            {
                b_Sync.ForeColor = Color.Red;
                b_Sync.Text = "Stop Sync";
                tb_SecondPath.Enabled = tb_FirstPath.Enabled = b_sp_choose.Enabled = b_fp_choose.Enabled = false;
                timer.Enabled = _sync = true;
            }
        }
        public bool _isSync(){ if (_sync) return true; else return false; }
        public bool _isFirstSync()
        {
            if (tb_FirstPath.Text == MainSettings.Default.firstPath)
                if (tb_SecondPath.Text == MainSettings.Default.secondPath) return false; else return true;
            else return true;
        }

        private void filesOnDir(string path)
        {
            try
            {
                string[] fRoot = Directory.GetFiles(path);
                if(fRoot.Length != 0)
                {
                    foreach (string s in fRoot)
                    {
                        FileInfo f = new FileInfo(s);
                        _FileInf fin = new _FileInf();

                        files.Add(s);
                        lb_files.Items.Add(s);
                        lb_files.Items.Add(f.Length);
                        fileInf.Add(new _FileInf { p = s, s = f.Length });
                        Application.DoEvents();
                    }
                }
            }
            catch (IOException e)
            {
            }
        }

        private void dirsOnDir(string path)
        {
            try
            {
                string[] dRoot = Directory.GetDirectories(path);
                if (dRoot.Length != 0)
                {
                    foreach (string s in dRoot)
                    {
                        dirs.Add(s);
                        lb_files.Items.Add(s);
                        Application.DoEvents();
                    }
                    for(int i = 0; i<dRoot.Length ; i++)
                    {
                        dirsOnDir(dRoot[i]);
                        filesOnDir(dRoot[i]);
                        Application.DoEvents();
                    }
                }
            }catch(IOException e)
            {
            }
        }

        private void FirstRun(){filesOnDir(tb_FirstPath.Text); dirsOnDir(tb_FirstPath.Text); }

        public void Sync(object sender, EventArgs e)
        {
            timer.Enabled = false;
            if (_isFirstSync()) FirstRun();

            using (Stream stream = File.Open("E:\\test.cnet", FileMode.Create))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                bformatter.Serialize(stream, fileInf);
            }

            MainSettings.Default.firstPath = tb_FirstPath.Text;
            MainSettings.Default.secondPath = tb_SecondPath.Text;
            MainSettings.Default.Save();

            timer.Enabled = true;
        }
    }

    [Serializable]
    class _FileInf
    {
        public long s { set; get; }
        public string p { set; get; }
    }
}

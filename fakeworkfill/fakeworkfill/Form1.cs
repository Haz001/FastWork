using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security;


namespace fakeworkfill
{
    public partial class Form1 : Form
    {
        public bool gn_b = true;
        public string fd_path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public Form1()
        {
            InitializeComponent();
        }

        private void gn_t_btn_Click(object sender, EventArgs e)
        {
            gn_b = true;
            gn_f_btn.BackColor = Color.Red;
            gn_t_btn.BackColor = Color.Lime;
        }

        private void gn_f_btn_Click(object sender, EventArgs e)
        {
            gn_b = false;
            gn_t_btn.BackColor = Color.Red;
            gn_f_btn.BackColor = Color.Lime;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void browse_btn_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (Directory.Exists(folderBrowserDialog1.SelectedPath)) 
                    fd_path = folderBrowserDialog1.SelectedPath;
                Folder_path_tb.Text = fd_path;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Folder_path_tb.Text = fd_path;
        }
        public ulong count = 1;
        private void genfiles_btn_Click(object sender, EventArgs e)
        {
            if ((nb_fs_tb.Text != "") && (nb_fs_tb.Text != null)){
                try
                {
                    count = Convert.ToUInt64(nb_fs_tb.Text);
                    ulong x = 1;
                    
                    while (x <= count)
                    {
                        string tmp_n = (fd_path+"\\" + random_string(_rn.Next(3,15)) +".docx");
                        if (!System.IO.File.Exists(tmp_n))
                        {
                            System.IO.StreamWriter sw = new System.IO.StreamWriter(tmp_n);
                            
                            sw.Write(random_string(_rn.Next(1000,70000)));
                            sw.Close();
                            x++;
                        }
                                                
                        
                        
                    }
                    
                    MessageBox.Show(x-1+" files made of the "+count+" specified");
                }
                catch (Exception error)
                {
                    Clipboard.SetText( error.Message.ToString());
                    if ((error.Message.ToString() == "Input string was not in a correct format.")||(error.Message.ToString() == "Value was either too large or too small for a UInt64."))
                        MessageBox.Show("Number input is not a number between 0 and " + ulong.MaxValue, "Input error");
                    else
                        MessageBox.Show(error.Message.ToString(), "Error with prep");
                }
            }
        }
        Random _rn = new Random();
        public string random_string(int ln)
        {
            
            string temp = "";
            int i = 0;
            while (i < ln)
            {
                if(_rn.Next(0,2) == 1)
                    temp += ((char)_rn.Next(65, 90));
                else
                    temp += ((char)_rn.Next(97, 122));
                i++;
            }
            
            return temp;
        }
    }
}

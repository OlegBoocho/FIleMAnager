using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int k = 0, k2 = 0;
            String[] str = new String[250000], str2 = new String[250000], s;
            s = Directory.GetDirectories(Directory.GetCurrentDirectory());
            for (int i = 0; i < s.Length; i++)
            {
                str[k] = s[i];
                k++;
            }
            for (int i = 0; i < k; i++)
            {
                String h = Path.GetFullPath(str[i]); ;
                try
                {
                    s = Directory.GetDirectories(h);
                    if (s.Length != 0) {
                    for (int j = 0; j < s.Length; j++)
                    {
                        str[k] = s[j];
                        k++;
                    }
                }
                }
                catch(System.UnauthorizedAccessException)
                {
                    
                }
                
            }
            try { 
            s = Directory.GetFiles(Directory.GetCurrentDirectory());
            if (s.Length != 0)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    str2[k2] = s[j];
                    k2++;
                }
            }
                }
                catch(System.UnauthorizedAccessException)
                {
                    
                }

            for (int i = 0; i < k; i++)
            {
                try
                {
                    String h = Path.GetFullPath(str[i]);
                    s = Directory.GetFiles(h);
                    if (s.Length != 0)
                    {

                        for (int j = 0; j < s.Length; j++)
                        {
                            str2[k2] = s[j];
                            k2++;
                        }
                    }
                }
                catch (System.UnauthorizedAccessException)
                {

                }
            }
            for (int i = 0; i < k; i++)
            {
                listBox1.Items.Add(str[i]);
            }
            for (int i = 0; i < k2; i++)
            {
                listBox2.Items.Add(str2[i]);
            }
        }

      /*  private void button1_Click(object sender, EventArgs e)
        {
            string ExePath = System.Windows.Forms.Application.ExecutablePath;
            RegistryKey reg;
            reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
            
                    reg.SetValue("FileShpion", ExePath);
            reg.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ExePath = System.Windows.Forms.Application.ExecutablePath;
            RegistryKey reg;
            reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");

            reg.DeleteValue("FileShpion");
            reg.Close();
        }*/
    }
}

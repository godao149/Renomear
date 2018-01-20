using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renomear;
using System.IO;
using System.Configuration;

namespace WindowsFormsApp7
{
    public partial class frmConfiguracao : Form
    {
        public frmConfiguracao()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmConfiguracao_Load(object sender, EventArgs e)
        {


            // txtAdmDominio.DataBindings.Add("Enable", checkBoxCredDominio, "Checked");
            //txtSenhaDominio.DataBindings.Add("Enable", checkBoxCredDominio, "Checked");


        }

        private void button_OK_Config(object sender, EventArgs e)
        {
            //Botao OK
            // Form1 adm = new Form1();
            SetConfig("txtAdm", txtAdm.Text);
            SetConfig("txtSenha", txtSenha.Text);
            SetConfig("txtAdmDominio", txtAdmDominio.Text);
            SetConfig("txtSenhaDominio", txtSenhaDominio.Text);
            //string txtSenha = System.Configuration.ConfigurationManager.AppSettings["txtSenha"];
            //  cmdRenomear cmd = new cmdRenomear();


            // cmd.textbox = adm;
            //cmdRenomear cmdRenomear = new cmdRenomear();
            //   StreamReader sr = new StreamReader(adm.caminho);
            // sr.Dispose();
            //sr.Close();
            this.Close();

        }

        public static void SetConfig(string key, string value)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;
            if (settings[key] == null)
            {
                settings.Add(key, value);
            }
            else
            {
                settings[key].Value = value;
            }
            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxCredDominio_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCredDominio.Checked)
            {
                txtAdmDominio.Enabled = true;
                txtSenhaDominio.Enabled = true;
            }
            else
            {
                txtAdmDominio.Enabled = false;
                txtSenhaDominio.Enabled = false;

            }
        }
    }
}

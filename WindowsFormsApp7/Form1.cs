using System;
using System.Windows.Forms;
using System.IO;
using WindowsFormsApp7;
using System.ComponentModel;

namespace Renomear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string administrador;
        public string password;
        public string admDominio;
        public string senhaDominio;
        public Form1(string adm, string senha, string admDom, string domSenha)
        {
            InitializeComponent();
            administrador = adm;
            password = senha;
            admDom = admDominio;
            senhaDominio = domSenha;
        }

        public string caminho = Path.GetTempPath() + "tempRename.txt";

        OpenFileDialog ofd = new OpenFileDialog();
        private void button_Procurar(object sender, EventArgs e)
        {
            frmConfiguracao config = new frmConfiguracao();
            cmdRenomear Renomear = new cmdRenomear();

            Renomear.Procurar();
            // GC.Collect();
            txtQtd.Text = ("");

            //numeroLinhas = System.IO.File.ReadAllLines(caminho).Length;
            txtQtd.Text = Renomear.numeroLinhas.ToString();

            frmConfiguracao.SetConfig("txtPrefixo", txtPrefixo.Text);
            frmConfiguracao.SetConfig("txtQtd", txtQtd.Text);


        }
        public string prefixo;
        public string Qtd;

        private void button_Shutdown(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(caminho);

            cmdRenomear renomear = new cmdRenomear();
            renomear.Log.Show();
            string listaIP = string.Empty;
            var listaNome = renomear.CriarListaNome();
            progressBar1.Value = 0;
            progressBar1.Maximum = listaNome.Count;
            //listaIP = sr.ReadLine();
            foreach (string lst in listaNome)
            {
                listaIP = sr.ReadLine();
                // var getname = renomear.GetName(listaIP);

                // if (string.IsNullOrEmpty(listaIP.ToString())) continue;

                //var linhaIp = sr.ReadLine();

                if (string.IsNullOrEmpty(listaIP)) { progressBar1.Value += 1; continue; };

                renomear.mount(listaIP.ToString());
                renomear.ShutdownComMensagem(listaIP.ToString());
                renomear.umount(listaIP.ToString());

                //renomear.RebootComMensagem(linhaIp);
                progressBar1.Value = progressBar1.Value + 1;
                lbldesc.Text = listaIP;



            }
            //Shutdown em massa

        }

        private void txtPrefixo_TextChanged(object sender, EventArgs e)
        {
            txtPrefixo.MaxLength = 15;
        }


        private void button1_Click_2(object sender, EventArgs e)
        {
            frmConfiguracao frmConfiguracao = new frmConfiguracao();
            frmConfiguracao.ShowDialog();
        }
        public void ChamarRenomeadDominio()
        {

            cmdRenomear cmdRenomear = new cmdRenomear();

            var listaNome = cmdRenomear.CriarListaNome();
            StreamReader sr = new StreamReader(caminho);
            //int i = 0;
            progressBar1.Value = 0;
            progressBar1.Maximum = listaNome.Count;

            foreach (var lista in listaNome)
            {

                var linhaIp = sr.ReadLine();

                var getname = cmdRenomear.GetName(linhaIp);

                if (string.IsNullOrEmpty(getname)) { progressBar1.Value += 1; continue; };

                var log = cmdRenomear.RenameRemotePCDominio(linhaIp, lista);

                cmdRenomear.Reboot(linhaIp, log);
                progressBar1.Value = progressBar1.Value + 1;
                lbldesc.Text = linhaIp + " /" + getname + " / " + lista;

            }
        }
        public void ExecutionEngineException()
        {

            cmdRenomear cmdRenomear = new cmdRenomear();

            var listaNome = cmdRenomear.CriarListaNome();
            StreamReader sr = new StreamReader(caminho);
            //int i = 0;
            progressBar1.Value = 0;
            progressBar1.Maximum = listaNome.Count;

            foreach (var lista in listaNome)
            {

                var linhaIp = sr.ReadLine();

                var getname = cmdRenomear.GetName(linhaIp);

                if (string.IsNullOrEmpty(getname)) { progressBar1.Value += 1; continue; }

                var log = cmdRenomear.RenameRemotePC(linhaIp, getname, lista);

                cmdRenomear.Reboot(linhaIp, log);
                progressBar1.Value = progressBar1.Value + 1;
                lbldesc.Text = linhaIp + " /" + getname + " / " + lista;

            }



            sr.Close();

        }

        //public void test()
        //{

        //    cmdRenomear cmdRenomear = new cmdRenomear();

        //    var listaNome = cmdRenomear.CriarListaNome();
        //    StreamReader sr = new StreamReader(caminho);
        //    // int i = 0;
        //    progressBar1.Value = 0;
        //    progressBar1.Maximum = listaNome.Count;

        //    foreach (var lista in listaNome)
        //    {

        //        var linhaIp = sr.ReadLine();
        //        var getname = cmdRenomear.GetName(linhaIp);

        //        if (string.IsNullOrEmpty(getname)) continue;
        //        var log = cmdRenomear.RenameRemotePC(linhaIp, getname, lista);

        //        cmdRenomear.Reboot(linhaIp, log);
        //        progressBar1.Value = progressBar1.Value + 1;
        //        lbldesc.Text = linhaIp + " /" + getname + " / " + lista;

        //    }



        //    sr.Close();

        //}


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker1_ProgressChanged(object sender,
            ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // TODO: do something with final calculation.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmConfiguracao config = new frmConfiguracao();
            config.ShowDialog();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button_Renomear(object sender, EventArgs e)
        {

            //timer1.Enabled = true;
            if (rdoSemDominio.Checked)
                ExecutionEngineException();
            else if (rdoDominio.Checked)
            {
                ChamarRenomeadDominio();
            }
        }

        private void button_Reiniciar(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(caminho);

            cmdRenomear renomear = new cmdRenomear();
            renomear.Log.Show();
            string listaIP = string.Empty;
            var listaNome = renomear.CriarListaNome();
            progressBar1.Value = 0;
            progressBar1.Maximum = listaNome.Count;
            //listaIP = sr.ReadLine();
            foreach (string lst in listaNome)
            {
                listaIP = sr.ReadLine();
                // var getname = renomear.GetName(listaIP);

                // if (string.IsNullOrEmpty(listaIP.ToString())) continue;

                //var linhaIp = sr.ReadLine();


                if (string.IsNullOrEmpty(listaIP)) { progressBar1.Value += 1; continue; }

                renomear.mount(listaIP.ToString());
                renomear.RebootComMensagem(listaIP.ToString());
                renomear.umount(listaIP.ToString());

                //renomear.RebootComMensagem(linhaIp);
                progressBar1.Value = progressBar1.Value + 1;
                lbldesc.Text = listaIP;



            }
        }

        private void button_Abortar(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(caminho);

            cmdRenomear renomear = new cmdRenomear();
            renomear.Log.Show();
            string listaIP = string.Empty;
            var listaNome = renomear.CriarListaNome();
            progressBar1.Value = 0;
            progressBar1.Maximum = listaNome.Count;
            //listaIP = sr.ReadLine();
            foreach (string lst in listaNome)
            {
                listaIP = sr.ReadLine();
                // var getname = renomear.GetName(listaIP);

                // if (string.IsNullOrEmpty(listaIP.ToString())) continue;

                //var linhaIp = sr.ReadLine();


                if (string.IsNullOrEmpty(listaIP)) { progressBar1.Value += 1; continue; }

                renomear.mount(listaIP.ToString());
                renomear.AnularDesligamentoComMensagem(listaIP.ToString());
                renomear.umount(listaIP.ToString());

                //renomear.RebootComMensagem(linhaIp);
                progressBar1.Value = progressBar1.Value + 1;
                lbldesc.Text = listaIP;

            }
        }

        private void lbldesc_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using Renomear;
using System.Management;
using System.Configuration;


namespace WindowsFormsApp7
{
    class cmdRenomear
    {

        public int numeroLinhas;


        public string text;

        frmLog log = new frmLog();

        public frmLog RenameRemotePCDominio(String ip, String newName)
        {
            string txtAdm = GetConfig("txtAdm");
            string txtSenha = GetConfig("txtSenha");
            string txtAdmDom = GetConfig("txtAdmDominio");
            string txtSenhaDom = GetConfig("txtSenhaDominio");
            try
            {
                Process rename = new Process();
                rename.StartInfo.FileName = "netdom.exe ";

                string argumento = " renamecomputer " + ip + " /NewName:" + newName + " /usero:" + txtAdm + " /passwordo:" + txtSenha + " /userd:"+ txtAdmDom+" /passwordd:"+txtSenhaDom+ " /reboot:15 /force";
                rename.StartInfo.Arguments = argumento;
                rename.StartInfo.CreateNoWindow = true;
                rename.StartInfo.UseShellExecute = false;
                rename.StartInfo.RedirectStandardOutput = true;
                rename.StartInfo.RedirectStandardInput = true;

                rename.StartInfo.RedirectStandardError = true;
                rename.Start();
  //              text = string.Empty;
                text += " \nIP " + ip+"\n";
                text += rename.StandardOutput.ReadToEnd();
                text += rename.StandardError.ReadToEnd();

                //frmLog log = new frmLog(text);
                log.Refresh();
                log.Show();
                log.richLog.Text = text.ToString();
                log.Refresh();
                rename.Close();
                return log;
                //Shutdown();

            }
            catch (ManagementException err)
            {

                MessageBox.Show("An error occurred while trying to execute the WMI method: " + err.Message);
                return null;
            }
            catch (UnauthorizedAccessException unauthorizedErr)
            {
                MessageBox.Show("Connection error (user name or password might be incorrect): " + unauthorizedErr.Message);
                return null;
            }

        }

        public frmLog RenameRemotePC(String ip, String oldName, String newName)
        {

            try
            {
                string txtAdm = GetConfig("txtAdm");
                string txtSenha = GetConfig("txtSenha");
                Process rename = new Process();
                rename.StartInfo.FileName = "wmic.exe";

                string argumento = " /node:" + ip + " /user:" + txtAdm + " /password:" + txtSenha + " computersystem where name=" + "'" + oldName + "'" + " call rename " + "'" + newName + "'";
                rename.StartInfo.Arguments = argumento;
                rename.StartInfo.CreateNoWindow = true;
                rename.StartInfo.UseShellExecute = false;
                rename.StartInfo.RedirectStandardOutput = true;
                rename.StartInfo.RedirectStandardInput = true;

                rename.StartInfo.RedirectStandardError = true;
                rename.Start();
//                text = string.Empty;
                text += " \nIP " + ip + "\n";
                text += rename.StandardOutput.ReadToEnd();
                text += rename.StandardError.ReadToEnd();

                //frmLog log = new frmLog(text);
                log.Refresh();
                log.Show();
                log.richLog.Text = text.ToString();
                log.Refresh();
                rename.Close();
                return log;
                //Shutdown();

            }
            catch (ManagementException err)
            {

                MessageBox.Show("An error occurred while trying to execute the WMI method: " + err.Message);
                return null;
            }
            catch (UnauthorizedAccessException unauthorizedErr)
            {
                MessageBox.Show("Connection error (user name or password might be incorrect): " + unauthorizedErr.Message);
                return null;
            }

        }
        public void Reboot(string ip, frmLog log)
        {
            string txtAdm = GetConfig("txtAdm");
            string txtSenha = GetConfig("txtSenha");
            Process reboot = new Process();
            reboot.StartInfo.FileName = "wmic.exe";

            string argumentoReboot = " /node:" + ip + " /user:" + txtAdm + " /password:" + txtSenha + " OS where Primary=True call Reboot";
            reboot.StartInfo.Arguments = argumentoReboot;
            reboot.StartInfo.CreateNoWindow = true;
            reboot.StartInfo.UseShellExecute = false;
            reboot.StartInfo.RedirectStandardOutput = true;
            reboot.StartInfo.RedirectStandardInput = true;

            reboot.StartInfo.RedirectStandardError = true;
            reboot.Start();
            //text = string.Empty;
            text += " \nIP " + ip + "\n";
            text += reboot.StandardOutput.ReadToEnd();
            text += reboot.StandardError.ReadToEnd();

            log.Refresh();
            log.richLog.Text = text.ToString();
            log.Refresh();
            reboot.Close();
        }
        public void RebootComMensagem(string ip)
        {

            // string txtAdm = GetConfig("txtAdm");
            // string txtSenha = GetConfig("txtSenha");
            Form1 menu = new Form1();
            var segundos = menu.txtTempo.Text;
            string mensagem = menu.richMensagem.Text;

            Process reboot = new Process();
            reboot.StartInfo.FileName = "shutdown.exe";
            //shutdown -f -r -t 50 -m \\172.16.2.50 -c "diriri na pera"
            string argumentoReboot = " -f -r -t " + segundos + " -m \\\\" + ip + " -c " + "\"" + mensagem + "\"";
            reboot.StartInfo.Arguments = argumentoReboot;
            reboot.StartInfo.CreateNoWindow = true;
            reboot.StartInfo.UseShellExecute = false;
            reboot.StartInfo.RedirectStandardOutput = true;
            reboot.StartInfo.RedirectStandardInput = true;

            reboot.StartInfo.RedirectStandardError = true;
            reboot.Start();
            //text = string.Empty;
            text += " \nIP " + ip + "\n";
            text += reboot.StandardOutput.ReadToEnd();
            text += reboot.StandardError.ReadToEnd();

            log.Refresh();
            log.richLog.Text = text.ToString();
            log.Refresh();
            reboot.Close();


        }
      
      


        public bool mount(string ip)
        {
            string txtAdm = GetConfig("txtAdm");
            string txtSenha = GetConfig("txtSenha");
            try
            {
                Process mount = new Process();
                string ipc = "\\\\ipc$ /user:";
                mount.StartInfo.FileName = "net";
                ipc.Replace("\\\\", "\"");
                //argumentoMount.Replace('s', 'a');

                //string argumentoMount = string.Format("use \\\{0}\\\\ipc$ /user:{1} {2}", ip, txtAdm, txtSenha);
                string argumentoMount = "use \\\\" + ip + "\\ipc$" + " /user:" + txtAdm + " " + txtSenha;
                //argumentoMount.Replace(@"J", @"\");

                //string vartexto = "\";
                //vartexto = vartexto.Replace(@"\\", @"\\\");

                //editcomando("cmd.txt");
                //  lercomando("cmd.txt");

                mount.StartInfo.Arguments = argumentoMount;
                mount.StartInfo.CreateNoWindow = true;
                mount.StartInfo.UseShellExecute = false;
                mount.StartInfo.RedirectStandardOutput = true;
                mount.StartInfo.RedirectStandardInput = true;

                mount.StartInfo.RedirectStandardError = true;
                mount.Start();
                text += " \nIP " + ip + "\n";
                text += mount.StandardOutput.ReadToEnd();
                text += mount.StandardError.ReadToEnd();

                Log.Refresh();
                Log.richLog.Text = text.ToString();
                Log.Refresh();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public void umount(string ip)
        {
            string txtAdm = GetConfig("txtAdm");
            string txtSenha = GetConfig("txtSenha");
            Process mount = new Process();

            mount.StartInfo.FileName = "net";
            string argumentoMount = " use \\\\" + ip + "\\ipc$ /delete";
            mount.StartInfo.Arguments = argumentoMount;
            mount.StartInfo.CreateNoWindow = true;
            mount.StartInfo.UseShellExecute = false;
            mount.StartInfo.RedirectStandardOutput = true;
            mount.StartInfo.RedirectStandardInput = true;

            mount.StartInfo.RedirectStandardError = true;
            mount.Start();
            text += " \nIP " + ip + "\n";
            text += mount.StandardOutput.ReadToEnd();
            text += mount.StandardError.ReadToEnd();

            Log.Refresh();
            Log.richLog.Text = text.ToString();
            Log.Refresh();
        }

        public void ShutdownComMensagem(string ip)
        {
            Form1 menu = new Form1();
            var segundos = menu.txtTempo.Text;
            string mensagem = menu.richMensagem.Text;
            Process shutdown = new Process();
            shutdown.StartInfo.FileName = "shutdown.exe";
            //frmLog log = new frmLog();
            //shutdown -f -s -t 50 -m \\172.16.2.50 -c "diriri na pera"
            string argumentoShutdown = " /f /s /t " + segundos + " -m \\\\" + ip + " /c " + "\"" + mensagem + "\"";
            shutdown.StartInfo.Arguments = argumentoShutdown;
            shutdown.StartInfo.CreateNoWindow = true;
            shutdown.StartInfo.UseShellExecute = false;
            shutdown.StartInfo.RedirectStandardOutput = true;
            shutdown.StartInfo.RedirectStandardInput = true;

            shutdown.StartInfo.RedirectStandardError = true;
            shutdown.Start();
            //text = string.Empty;
            text += " \nIP " + ip + "\n";
            text += shutdown.StandardOutput.ReadToEnd();
            text += shutdown.StandardError.ReadToEnd();

            log.Refresh();
            log.richLog.Text = text.ToString();
            log.Refresh();
            shutdown.Close();
        }


        public void AnularDesligamentoComMensagem(string ip)
        {
            Form1 menu = new Form1();
            //var segundos = menu.txtTempo.Text;
            //string mensagem = menu.richMensagem.Text;
            Process AnularDesligamento = new Process();
            AnularDesligamento.StartInfo.FileName = "shutdown.exe";
            //frmLog log = new frmLog();
            //shutdown -f -s -t 50 -m \\172.16.2.50 -c "diriri na pera"
            string argumentoReboot = " -a -m \\\\" + ip;
            AnularDesligamento.StartInfo.Arguments = argumentoReboot;
            AnularDesligamento.StartInfo.CreateNoWindow = true;
            AnularDesligamento.StartInfo.UseShellExecute = false;
            AnularDesligamento.StartInfo.RedirectStandardOutput = true;
            AnularDesligamento.StartInfo.RedirectStandardInput = true;

            AnularDesligamento.StartInfo.RedirectStandardError = true;
            AnularDesligamento.Start();
            //text = string.Empty;
            text += " \nIP " + ip + "\n";
            text += AnularDesligamento.StandardOutput.ReadToEnd();
            text += AnularDesligamento.StandardError.ReadToEnd();

            log.Refresh();
            log.richLog.Text = text.ToString();
            log.Refresh();
            AnularDesligamento.Close();
        }



        //        public 
        public string GetName(string ip)
        {

            try
            {

                string txtAdm = GetConfig("txtAdm");
                string txtSenha = GetConfig("txtSenha");

                ConnectionOptions connOpt = new ConnectionOptions
                {
                    Username = txtAdm,
                    Password = txtSenha
                };
                // ManagementScope mScope = new ManagementScope("\\\\yourIPOrMachineName\\root\\CIMV2", connOpt);

                ManagementScope scope = new ManagementScope("\\\\" + ip + "\\root\\cimv2", connOpt);
                scope.Connect();
                ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);
                ManagementObjectCollection queryCollection = searcher.Get();
                string nome = string.Empty;
                foreach (ManagementObject m in queryCollection)
                {
                    // Display the remote computer information
                    // http://msdn.microsoft.com/en-us/library/aa394239(v=vs.85).aspx - list of available attributes
                    Console.WriteLine("Uptime : {0}", m["LastBootUpTime"]);

                    Console.WriteLine("Computer Name : {0}", m["csname"]);
                    nome = m["csname"].ToString();
                }
                queryCollection.Dispose();

                return nome;

            }
            catch (System.Runtime.InteropServices.COMException)
            {
                MessageBox.Show("Firewall Remoto Ativo da maquina " + ip + ", Serviço de RPC Bloqueado ou Host inativo.");
            }
            //this.Close();
            return "";

        }

        public static string GetConfig(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public void Procurar()
        {

            Form1 menu = new Form1();
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Cursor Files|*.txt";
            ofd.Title = "Selecione o arquivo";
           
            //StreamWriter lista;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                
                StreamWriter sw = new StreamWriter(menu.caminho);
                StreamReader sr = new StreamReader(ofd.FileName);
                //lista = File.CreateText(menu.caminho);
                sw.WriteLine(sr.ReadToEnd());

                try
                {

                    sr.Close();
                    sw.Close();
                    sr.Dispose();
                    sw.Dispose();


                    numeroLinhas = File.ReadAllLines(menu.caminho).Length;
                }

                catch (Exception e)
                {
                    MessageBox.Show("" + e);
                    sr.Close();
                    sw.Close();
                    sr.Dispose();
                    sw.Dispose();

                }
                finally
                {
                    sr.Close();
                    sw.Close();
                    sr.Dispose();
                    sw.Dispose();
                }
            }
        }
        public string ListaNome = System.IO.Path.GetTempPath() + "ListaNome.txt";

        public frmLog Log { get => log; set => log = value; }

        public void novoNome()
        {
            string prefixo = GetConfig("txtPrefixo");
            int Qtd = Convert.ToInt32(GetConfig("txtQtd"));
            var nome = string.Empty;
            StreamWriter sw = new StreamWriter(ListaNome);
            int numero;
            //int test = Convert.ToInt32(Qtd);
            for (var i = 0; i <= Qtd - 1; i++)
            {
                //System.Threading.Thread.Sleep(500);
                numero = Convert.ToInt32(i + 1);
                if (numero > 9)
                {
                    sw.WriteLine(prefixo + "-" + numero.ToString());
                }
                else
                {
                    sw.WriteLine(prefixo + "-" + 0 + numero.ToString());
                }
            }
            //return nome;
            sw.Close();
        }

        public List<string> CriarListaNome()
        {
            string prefixo = GetConfig("txtPrefixo");
            int Qtd = Convert.ToInt32(GetConfig("txtQtd"));
            var retorno = new List<string>();
            //StreamWriter sw = new StreamWriter(ListaNome);

            //int test = Convert.ToInt32(Qtd);
            for (var i = 1; i <= Qtd; i++)
            {


                if (i > 9)
                {
                    retorno.Add(prefixo + "-" + i.ToString());
                }
                else
                {
                    retorno.Add(prefixo + "-" + 0 + i.ToString());
                }
            }
            return retorno;

        }







    }
}

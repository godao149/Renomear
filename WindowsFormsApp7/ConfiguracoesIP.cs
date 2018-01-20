using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renomear;

namespace WindowsFormsApp7
{
    class ConfiguracoesIP
    {
        public string valido;
        
        public bool ValidateIPv4(string ipString)
        {
            if (String.IsNullOrWhiteSpace(ipString))
            {
                return false;
            }

            string[] splitValues = ipString.Split('.');
            if (splitValues.Length != 4)
            {
                return false;
            }

            byte tempForParsing;

            return splitValues.All(r => byte.TryParse(r, out tempForParsing));


        }
        public static string GetMachineNameFromIPAddress(string ipAdress)
        {
            string machineName = string.Empty;
            try
            {
                IPHostEntry hostEntry = Dns.GetHostEntry(ipAdress);

                machineName = hostEntry.HostName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("");                // Machine not found...
            }
            return machineName;
        }

        public static string GetIPAddressFromMachineName(string machineName)
        {
            string ipAdress = string.Empty;
            try
            {
                IPAddress[] ipAddresses = Dns.GetHostAddresses(machineName);

                IPAddress ip = ipAddresses[1];

                ipAdress = ip.ToString();
            }
            catch (Exception ex)
            {
                // Machine not found...
            }
            return ipAdress;
        }

        public bool Verifica(string ip)
        {
          //   ren = new Renomear();
            //ConfiguraçõesIP config = new ConfiguraçõesIP();
            //bool validador;
            try
            {
                if (ValidateIPv4(ip))
                {
                     this.valido = ip;
                    return true;
                }
                else MessageBox.Show("Ip Inválido");
                return false;
            }
            catch
            {
                MessageBox.Show("Erro na validacao de IP");
                return false;
            }



        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serial_checker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            AllocConsole();
            InitializeComponent();


            /* --- Disk -------------------------------------------------------------------------------------------------- */
            diskLabel.Text = "";

            ManagementObjectSearcher diskSearcher = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_DiskDrive");
            foreach (ManagementObject disk in diskSearcher.Get())
            {
                diskLabel.Text += $"{(string)disk["SerialNumber"]}\n".Replace(" ", "");
            }
            /* ----------------------------------------------------------------------------------------------------------- */


            /* Motherboard ------------------------------------------------------------------------------------------------------ */
            motherboardLabel.Text = "";

            ManagementObjectSearcher motherboardSearcher = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_BaseBoard");
            foreach (ManagementObject motherboard in motherboardSearcher.Get())
            {
                motherboardLabel.Text += $"{(string)motherboard["SerialNumber"]}\n";
            }
            /* ------------------------------------------------------------------------------------------------------------------ */


            /* SMBios ---------------------------------------------------------------------------------------------------------- */
            BiosLabel.Text = "";

            ManagementObjectSearcher BiosSearcher = new ManagementObjectSearcher("SELECT UUID FROM Win32_ComputerSystemProduct");
            foreach (ManagementObject Bios in BiosSearcher.Get())
            {
                BiosLabel.Text += $"{(string)Bios["UUID"]}\n";
            }
            /* ----------------------------------------------------------------------------------------------------------------- */


            /* GPU ----------------------------------------------------------------------------------------------------------- */
            GPULabel.Text = "";

            ManagementObjectSearcher GPUSearcher = new ManagementObjectSearcher("SELECT PNPDeviceID FROM Win32_VideoController");
            foreach (ManagementObject GPU in GPUSearcher.Get())
            {
                GPULabel.Text += $"{(string)GPU["PNPDeviceID"]}\n";
            }
            /* --------------------------------------------------------------------------------------------------------------- */


            /* RAM ----------------------------------------------------------------------------------------------------------- */
            RAMLabel.Text = "";

            ManagementObjectSearcher RAMSearcher = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_PhysicalMemory");
            foreach (ManagementObject RAM in RAMSearcher.Get())
            {
                RAMLabel.Text += $"{(string)RAM["SerialNumber"]}\n";
            }
            /* --------------------------------------------------------------------------------------------------------------- */


            /* CPU ----------------------------------------------------------------------------------------------------- */
            CPULabel.Text = "";

            ManagementObjectSearcher CPUSearcher = new ManagementObjectSearcher("SELECT ProcessorId FROM Win32_Processor");
            foreach (ManagementObject CPU in CPUSearcher.Get())
            {
                CPULabel.Text += $"{(string)CPU["ProcessorId"]}\n";
            }
            /* --------------------------------------------------------------------------------------------------------- */


            /* IP ---------------------------------- */
            IPLabel.Text = "";
            IPLabel.Text += $"{GetLocalIPAddress()}\n";
            /* ------------------------------------- */


            /* Mac Address ---------------------------------- */
            MacAddressLabel.Text = "";

            ManagementObjectSearcher AdapterSearcher = new ManagementObjectSearcher("SELECT MacAddress FROM Win32_NetworkAdapter WHERE PNPDeviceID like '%%PCI%%' AND AdapterTypeID='0'");
            foreach (ManagementObject adapter in AdapterSearcher.Get())
            {
                MacAddressLabel.Text += $"{(string)adapter["MacAddress"]}\n";
            }
            /* ------------------------------------- */
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }

            return "";
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void copyButton_Click(object sender, EventArgs e)
        {
            string serials = "";

            serials += "- Disk:\n";
            serials += diskLabel.Text;
            serials += "\n";

            serials += "- Motherboard:\n";
            serials += motherboardLabel.Text;
            serials += "\n";

            serials += "- Bios:\n";
            serials += BiosLabel.Text;
            serials += "\n";

            serials += "- GPU:\n";
            serials += GPULabel.Text;
            serials += "\n";

            serials += "- RAM:\n";
            serials += RAMLabel.Text;
            serials += "\n";

            serials += "- CPU:\n";
            serials += CPULabel.Text;
            serials += "\n";

            serials += "- IP:\n";
            serials += IPLabel.Text;
            serials += "\n";

            serials += "- Mac Address:\n";
            serials += MacAddressLabel.Text;

            Clipboard.SetText(serials);
        }
    }
}

using System.Management;

namespace PcSpecs
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            string info = $"{GetCPUInfo()}\n{GetRAMInfo()}\n{GetGPUInfo()}\n{GetDiskInfo()}\n{GetMotherboardInfo()}";
            infoTextBox.Text = info.Replace("\r\n", "\n").Replace("\n", Environment.NewLine); ;
        }

        private static string GetCPUInfo()
        {
            string cpuInfo = "CPU Information:\n";
            using (var searcher = new ManagementObjectSearcher("select Name, NumberOfCores, NumberOfLogicalProcessors, MaxClockSpeed from Win32_Processor"))
            {
                foreach (var obj in searcher.Get())
                {
                    cpuInfo += $"Name: {obj["Name"]}\n";
                    cpuInfo += $"Cores: {obj["NumberOfCores"]}\n";
                    cpuInfo += $"Logical Processors: {obj["NumberOfLogicalProcessors"]}\n";
                    cpuInfo += $"Max Clock Speed: {obj["MaxClockSpeed"]} MHz\n";
                }
            }
            return cpuInfo + "\n";
        }

        private static string GetRAMInfo()
        {
            string ramInfo = "RAM Information:\n";
            using (var searcher = new ManagementObjectSearcher("select Capacity, Speed, Manufacturer from Win32_PhysicalMemory"))
            {
                foreach (var obj in searcher.Get())
                {
                    ramInfo += $"Capacity: {Convert.ToInt64(obj["Capacity"]) / (1024 * 1024 * 1024)} GB\n";
                    ramInfo += $"Speed: {obj["Speed"]} MHz\n";
                    ramInfo += $"Manufacturer: {obj["Manufacturer"]}\n";
                }
            }
            return ramInfo + "\n";
        }

        private static string GetGPUInfo()
        {
            string gpuInfo = "GPU Information:\n";
            using (var searcher = new ManagementObjectSearcher("select Name, AdapterRAM, DriverVersion from Win32_VideoController"))
            {
                foreach (var obj in searcher.Get())
                {
                    gpuInfo += $"Name: {obj["Name"]}\n";
                    gpuInfo += $"Memory: {Convert.ToInt64(obj["AdapterRAM"]) / (1024 * 1024)} MB\n";
                    gpuInfo += $"Driver Version: {obj["DriverVersion"]}\n";
                }
            }
            return gpuInfo + "\n";
        }

        private static string GetDiskInfo()
        {
            string diskInfo = "Disk Information:\n";
            using (var searcher = new ManagementObjectSearcher("select Model, Size, InterfaceType from Win32_DiskDrive"))
            {
                foreach (var obj in searcher.Get())
                {
                    diskInfo += $"Model: {obj["Model"]}\n";
                    diskInfo += $"Size: {Convert.ToInt64(obj["Size"]) / (1024 * 1024 * 1024)} GB\n";
                    diskInfo += $"Interface Type: {obj["InterfaceType"]}\n";
                }
            }
            return diskInfo + "\n";
        }

        private static string GetMotherboardInfo()
        {
            string motherboardInfo = "Motherboard Information:\n";
            using (var searcher = new ManagementObjectSearcher("select Product, Manufacturer, SerialNumber from Win32_BaseBoard"))
            {
                foreach (var obj in searcher.Get())
                {
                    motherboardInfo += $"Manufacturer: {obj["Manufacturer"]}\n";
                    motherboardInfo += $"Product: {obj["Product"]}\n";
                    motherboardInfo += $"Serial Number: {obj["SerialNumber"]}\n";
                }
            }
            return motherboardInfo + "\n";
        }

        private void copyToClipboardButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(infoTextBox.Text);
            MessageBox.Show("Copied to clipboard.");
        }
    }
}

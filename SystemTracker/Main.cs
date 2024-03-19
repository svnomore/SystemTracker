using System.Diagnostics;
using System.Management;
using Microsoft.VisualBasic.Devices;

namespace SystemTracker
{
    public partial class Main : Form
    {
        private const string appversion = "v0.1";

        private PerformanceCounter cpuCounter = new("Processor", "% Processor Time", "_Total");
        private PerformanceCounter physicalMemoryCounter = new("Memory", "Available Bytes");
        private PerformanceCounter virtualMemoryCounter = new("Memory", "Committed Bytes");

        private readonly string MachineName = Environment.MachineName;
        private int decimalPlaces = 2;

        public Main()
        {
            InitializeComponent();
            InitializeCPUInfo();
            InitializeMemoryInfo();
            InitializeOtherInfo();
        }


        private void Main_Load(object sender, EventArgs e)
        {
            CycleTimer_Tick(null, null);
            cycleTimer.Start();
        }

        private void InitializeCPUInfo()
        {
            cpuCounter.ReadOnly = true;
            ManagementObjectSearcher searcher = new("SELECT * FROM Win32_Processor");
            foreach (ManagementObject obj in searcher.Get().Cast<ManagementObject>())
            {
                string processorName = obj["Name"].ToString();
                CPUNameText.Text = $"CPU Name: {processorName}";
            }
            cpuCounter.NextValue();
        }

        private void InitializeMemoryInfo()
        {
            long totalPhysicalMemory = (long)new ComputerInfo().TotalPhysicalMemory;
            MemoryTotalText.Text = "Memory Total: " + totalPhysicalMemory / (1024 * 1024) + " MB";
        }

        private void InitializeOtherInfo()
        {
            Text = $"SystemTracker {appversion} - {MachineName}";
        }

        private void CycleTimer_Tick(object? sender, EventArgs? e)
        {
            float cpuUsage = cpuCounter.NextValue();
            float roundedValue = (float)Math.Round(cpuUsage, decimalPlaces);
            CPUUsageText.Text = $"CPU Usage: {roundedValue}%";

            float availablePhysicalMemory = physicalMemoryCounter.NextValue();
            float virtualMemory = virtualMemoryCounter.NextValue();
            MemoryFreeText.Text = "Memory Free: " + Math.Round(availablePhysicalMemory / (1024f * 1024f), decimalPlaces) + " MB";
            MemoryVirtualText.Text = ("Virtual Memory: " + Math.Round(virtualMemory / (1024f * 1024f), decimalPlaces) + " MB");
        }
    }
}
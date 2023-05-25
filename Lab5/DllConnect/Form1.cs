using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;


namespace DllConnect
{
    public partial class Form1 : Form
    {
        private string InfinitySortDllPath = $@"{Environment.CurrentDirectory}\InfinitySort.dll";
        private string MatheDllPAth = $@"{Environment.CurrentDirectory}\Mathe.dll";
        private Type InfinitySortType;
        private object InfinitySortClass;
        public Form1()
        {
            InitializeComponent();
            try
            {
                string message = Interface.Interface.SayGreetings();
                MessageBox.Show(message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }

        private void buttonLoadDll_Click(object sender, EventArgs e)
        {
            var currentProcess = Process.GetCurrentProcess();
            var count = currentProcess.Modules.Cast<ProcessModule>().Count(module => module.FileName == InfinitySortDllPath);
            
            if (count != 0) return;

            Assembly InfinitySortDll;
            try
            {
                InfinitySortDll = Assembly.LoadFile(InfinitySortDllPath);
                 MessageBox.Show("InfinitySort.dll is connected.");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                throw;
            }

            InfinitySortType = InfinitySortDll.GetType("InfinitySort.InfinitySort");
            InfinitySortClass = Activator.CreateInstance(InfinitySortType);
        }

        private void buttonStartMultiThreading_Click(object sender, EventArgs e)
        {
            if (InfinitySortClass != null)
            {
                InfinitySortType.InvokeMember("Thread", BindingFlags.InvokeMethod, Type.DefaultBinder, InfinitySortClass, new object[] { });
            }
            else
            {
                MessageBox.Show("You need to connect a library!");
            }
        }
        private void buttonCheckCalculations_Click(object sender, EventArgs e)
        {
            var currentProcess1 = Process.GetCurrentProcess();
            var check = currentProcess1.Modules.Cast<ProcessModule>().Count(module => module.FileName == MatheDllPAth);

            if (check != 0) return;
            try
            {
                int messageMath = Mathe.Mathe.Calculate();
                MessageBox.Show($"The result of the calculation 4 + 4 * 4 = {messageMath.ToString()}");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                throw;
            }
        }
        private void buttonCheckMath_Click(object sender, EventArgs e) => MessageBox.Show($"The result of the calculation: Cos(45) = {Math.Cos(45)}");

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        
    }
}
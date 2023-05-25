using System;
using System.Diagnostics;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Text;
using System.Threading;

namespace Create
{
    internal class Program
    {
        static void Main(string[] args)
        {
			MemoryMappedFile mmf = MemoryMappedFile.CreateFromFile(@"g:\Data.data", FileMode.OpenOrCreate, "Numbers", 30 * 4);
			Mutex mut = new Mutex(false, "NumbMutex");
			var myAccessor = mmf.CreateViewAccessor();
			var stream = mmf.CreateViewStream();
			int[] valueToWrite = new int[30];
			Random rnd = new Random();
			for (int i = 0; i < valueToWrite.Length; i++)
			{
				valueToWrite[i] = rnd.Next(10, 100);
			}
			try
			{
				mut.WaitOne();
				myAccessor.WriteArray(0, valueToWrite, 0, valueToWrite.Length);
			}
			finally
			{
				mut.ReleaseMutex();
			}
			Console.WriteLine(Environment.CurrentDirectory);
			Process pr2 = new Process();
			Process pr3 = new Process();
			pr2.StartInfo.FileName = $@"G:\Study\3 grade\1 semen\SIS\Lab1\Visual\bin\Debug\task02.exe";
			pr3.StartInfo.FileName = $@"G:\Study\3 grade\1 semen\SIS\Lab1\Sort\bin\Debug\Sort.exe";
			pr2.Start();
			pr3.Start();

			Console.WriteLine("\nTo sort, press \"Enter\", make sure you see visualization window!");
			Console.WriteLine("\nTYou can also use a sort program to sort the array in parallel");
			Console.ReadLine();

			Console.WriteLine("The sorting process is underway, you can view the process in the visualization window");
			var handle = stream.SafeMemoryMappedViewHandle;
			unsafe
			{
				byte* pointer = null;
				handle.AcquirePointer(ref pointer);
				var size = 4 * 30;

				for (int i = 0; i < size - 4; i += 4)
				{
					for (int j = 4 + i; j < size; j += 4)
					{
						try
						{
							mut.WaitOne();

							int first = *(pointer + j),
								second = *(pointer + i);
							if (first > second)
							{
								int temp;
								temp = *(pointer + j);
								*(pointer + j) = *(pointer + i);
								*(pointer + i) = (byte)temp;
							}
						}
						finally
						{
							mut.ReleaseMutex();
						}
						Thread.Sleep(100);
					}
				}
			}
			Console.WriteLine("Sorting complete to close all applications press Enter");
			Console.ReadLine();
			try
			{
				pr2.Kill();
			}
			catch
			{
				Console.WriteLine("Visualization window is closed");
			}
			try
			{
				pr3.Kill();
			}
			catch
			{
				Console.WriteLine("Sort program is closed");
			}
			Console.WriteLine("Work completed, you can close window: press \"Enter\"");
			Console.ReadLine();
		}
    }
}

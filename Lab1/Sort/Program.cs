using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
			while (true)
			{
				try
				{
					MemoryMappedFile mmf = MemoryMappedFile.OpenExisting("Numbers");
					Mutex mut = Mutex.OpenExisting("NumbMutex");
					Console.WriteLine("Press Enter to sort");
					Console.ReadLine();
					Console.WriteLine("There is a sorting...");

					var stream = mmf.CreateViewStream();
					var handle = stream.SafeMemoryMappedViewHandle;
					unsafe
					{
						byte* pointer = null;
						handle.AcquirePointer(ref pointer);
						var size = 4 * 30;

						for (int i = size - 4; i >= 0; i -= 4)
						{
							for (int j = size - 4; j >= 4; j -= 4)
							{
								try
								{
									mut.WaitOne();
									if (*(pointer + j) < *(pointer + j - 4))
									{
										int temp;
										temp = *(pointer + j);
										*(pointer + j) = *(pointer + j - 4);
										*(pointer + j - 4) = (byte)temp;
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
					Console.WriteLine("Work completed, you can close window: press \"Enter\"");

					Console.ReadLine();

				}
				catch (FileNotFoundException)
				{
					Console.WriteLine("Error, create program is not running");
					Console.ReadLine();
				}
				catch (WaitHandleCannotBeOpenedException)
				{
					Console.WriteLine("Error, restart create program");
					Console.ReadLine();
				}
			}
		}
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task02
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Visualize();
			timer1.Enabled = true;
			timer1.Start();
		}
		MemoryMappedFile mmf = MemoryMappedFile.OpenExisting("Numbers");
		Mutex mut = Mutex.OpenExisting("NumbMutex");



		public void Visualize()
		{
			
				try
				{
					mut.WaitOne();
					string text = "";
					var stream = mmf.CreateViewStream();
					var handle = stream.SafeMemoryMappedViewHandle;
					unsafe
					{
						byte* pointer = null;
						handle.AcquirePointer(ref pointer);
						var size = 4 * 30;

						for (int i = 0; i < size; i += 4)
						{
							text += *(pointer + i) + ": ";
							for (int j = 0; j < *(pointer + i); j++)
								text += "*";
							text += "\n";
						}
						labelInf.Text = text;
					}
				}
				finally
				{
					mut.ReleaseMutex();
				}
				
			
			
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			Visualize();
		}
	}
}

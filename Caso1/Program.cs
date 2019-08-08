using System;
using System.Diagnostics;
using System.Threading;

namespace Caso1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Process currentProcess = Processo.GetActiveProcess();
                if (currentProcess != null)
                {
                    Console.WriteLine(currentProcess.MainWindowTitle);
                    Thread.Sleep(1000);
                }
            }
        }
    }
}

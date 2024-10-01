using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Starting CPU and Memory load...");

        // Start CPU load
        for (int i = 0; i < Environment.ProcessorCount / 4; i++) // Adjust the number of threads
        {
            Thread cpuThread = new Thread(new ThreadStart(CpuLoad));
            cpuThread.IsBackground = true;
            cpuThread.Start();
        }

        // Start Memory load
        Thread memoryThread = new Thread(new ThreadStart(MemoryLoad));
        memoryThread.IsBackground = true;
        memoryThread.Start();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static void CpuLoad()
    {
        while (true)
        {
            // Busy loop to consume CPU
            for (int i = 0; i < 10000000; i++)
            {
                // Do some calculations
                double value = Math.Sqrt(i);
            }
        }
    }

    static void MemoryLoad()
    {
        while (true)
        {
            byte[] memory = new byte[1024 * 1024 * 327]; // Allocate 327 MB
            Thread.Sleep(1000); // Sleep for 1 second
        }
    }
}

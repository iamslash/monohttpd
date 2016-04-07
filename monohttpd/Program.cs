using System;
using System.Threading;

namespace monohttpd
{
	class MainClass
	{
		// usage:
		// 	mono monohttpd 127.0.0.1 8080
		public static void Main (string[] args)
		{
			if (args == null || args.Length != 2)
			{
				Console.WriteLine("usage) mono monohttpd.exe <ip> <port>");
				Console.WriteLine("");
				Console.WriteLine("example) mono monohttpd.exe 127.0.0.1 8080");
			}

			string ip 	= args [0];
			int port 	= int.Parse(args[1]);	

			int MaxThreadsCount = Environment.ProcessorCount * 2;
			ThreadPool.SetMaxThreads(MaxThreadsCount, MaxThreadsCount);
			ThreadPool.SetMinThreads(2, 2);
			new HttpServer(ip, port);
		}
	}
}

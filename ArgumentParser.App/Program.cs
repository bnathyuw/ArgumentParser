using System;

namespace ArgumentParser.App
{
	static class Program
	{
		static void Main(string[] args)
		{
			try
			{
				var arg = new Args("l,p#,d*", args);
				var logging = arg.GetBoolean('l');
				var port = arg.GetInt('p');
				var directory = arg.GetString('d');

				Console.WriteLine("Logging : {0}", logging);
				Console.WriteLine("Port : {0}", port);
				Console.WriteLine("Directory : {0}", directory);
			}
			catch (Args.ArgsException e)
			{
				Console.WriteLine("Argument error: {0}", e.Message);
			}
			finally
			{
				Console.Read();
			}
		}
	}

}

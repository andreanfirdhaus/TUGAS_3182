/*
 * Created by SharpDevelop.
 * User: Acer Aspire
 * Date: 16/03/2020
 * Time: 20:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TheSuperComputer
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			Monitor lgMonitor = new Monitor("1200x600",true,32);
			Printer hpPrinter = new Printer("HP","MP102",50);
			
			Vga nVdiaVga = new Vga("Nvidia",2054,2054);
			Ram samsungRam = new Ram("DDR4",5000,5000);
			Processor intelProcessor = new Processor();
			intelProcessor.setCache(254);
			intelProcessor.setCore(8);
			intelProcessor.setSeries("Core i7 8th Gen");
			
			Computer computer = new
				Computer.Builder(samsungRam,nVdiaVga,intelProcessor)
				.withMonitor(lgMonitor)
				.withPrinter(hpPrinter)
				.build();
			Console.WriteLine(computer.ToString());
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
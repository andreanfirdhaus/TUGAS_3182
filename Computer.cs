/*
 * Created by SharpDevelop.
 * User: Acer Aspire
 * Date: 16/03/2020
 * Time: 20:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TheSuperComputer
{

		public Computer()
		{
			private Monitor monitor;
			private Printer printer;
			private Processor processor;
			private Ram ram;
			private Vga vga;
		}
		
		private Computer(UriBuilder builder){
			this.monitor = builder.monitor;
			this.processor = builder.processor;
			this.printer = builder.printer;
			this Ram = builder.ram;
			this.vga = builder.vga;
		}
		
		public override string ToString()
		{
			 return $"Monitor spec: {this.monitor}\n"+
			 		$"processor spec: {this.processor}\n"+
			 		$"Printer spec: {this.printer}\n"+
			 		$"Vga spec: {this.vga}\n"+
			 		$"Ram spec: {this.Ram}\n";
			 	
		}
		
		public class Builder{
			public Monitor monitor;
			public Printer printer;
			public Processor processor;
			public Ram ram;
			public Vga vga;
		}
		
		public Builder(Ram ram, Vga vga, Processor processor){
			this.ram = ram;
			this.vga = vga;
			this.processor = processor;
		}
		
		
		public Builder withMonitor(Monitor monitor){
			this.withMonitor = monitor;
			return this;
		}
		
		public Builder withPrinter(Printer printer){
			this.withPrinter = printer;
			return this;
		}
		
		public Computer build(){
			return new Computer(this);
		}
}

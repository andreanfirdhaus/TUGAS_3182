/*
 * Created by SharpDevelop.
 * User: Acer Aspire
 * Date: 16/03/2020
 * Time: 20:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TheSuperComputer
{

		public Vga()
		{
			private String brand;
			private int graphicsClock;
			private int memoryClock;
		}
		
		public String getBrand(){
			return this.brand;
		}
		
		public int getGraphicsClock(){
			return this.graphiclock;
		}
		
		public int getMemoryclock(){
			return this.memoryClock;
		}
		
		public override string ToString()
		{
			 return $"Vga brand: {this.brand}; Vga clock graphics: {this.graphicsClock}; Vga clock memory: {this.memoryClock}";
		}
}

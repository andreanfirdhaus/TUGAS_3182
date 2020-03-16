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
		public Printer()
		{
			private String brand;
			private String series;
			private int ppm;
			
			public Printer(String brand, String series, int ppm){
				this.brand = brand;
				this.series = series;
				this ppm = ppm;
			}
			
			public String getBrand(){
				return this.brand;
			}
			
			public String getSeries(){
				return this.series;
			}
			
			public int getPpm(){
				return this.ppm;
			}
			
			public override string ToString()
			{
				return $"printer brand: {this.brand}, printer series: {this.series}, printer paper per minuts(ppm): {this.ppm};
			}

		}
}

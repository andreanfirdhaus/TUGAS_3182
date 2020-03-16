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

		public Monitor()
		{
			Private String resolution;
			private Boolean supportHdmi;
			private double size;
			
			public Monitor(stringresolution, Boolean supportHdmi, double size;
			               this.resolution = resolution;
			               this.supportHdmi;
			               this.size = sizeof;
		}
		
		private String getResolution(){
			return this.Resolution;
		}
		
		private Boolean issupportHdmi(){
			return this.issupportHdmi;
		}
		
		private double getsize(){
			return this,size;
		}
		public override string ToString()
		{
			return $"Monitor resolution: {resolution}; Monitor support Hdmi: {supportHdmi}; Monitor dimensi: {size} inch";
			
		}

}

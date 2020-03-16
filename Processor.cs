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

		public Processor()
		{
			private String series;
			private int core;
			private int cache;
			
			public void setSeries(String series){
				this.series = series;
			}
			
			public String getSeries(){
				returrn this.series;
			}
			
			public void setCore(int core){
				this.core = core;
			}
			
			public int getCore(){
				return this.core;
			}
			
			public void setCache(int cache){
				this.cache = cache;
			}
			
			public int getCache(){
				return this.cache
			}
			
			public override string ToString()
			{
				 return $"processor series: {this.series}; processor core: {this.core}; processor cache: {this.cache)";
			}

		}
}

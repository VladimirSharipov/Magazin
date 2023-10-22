﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Magazin.Controller
{
    public static class Helper
    {
		static string? LocalPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
		static string? LocalDerictoriPath = Path.Combine(LocalPath, "Logs");
        public async static  Task Erorr(string text)
        {
			string txt = $"[{DateTime.Now}] [Erorr]: \r\n [{text}]";
			await Task.Run(() =>
			{
				string path = Path.Combine(LocalDerictoriPath, $"Erorr_{DateTime.Now.ToString()}.txt");
				if (!Directory.Exists(LocalDerictoriPath))
				{
					Directory.CreateDirectory(LocalDerictoriPath);
				}
				if (!File.Exists(path))
				{
					File.Create(path).Close();

				}
				using (StreamWriter a = new StreamWriter(path, true))
				{

					a.AutoFlush = true;
					a.WriteLine(txt);
				}
			});
			
			//using (FileStream m = File.OpenWrite(path))
			//{
			//	string r = $"{DateTime.Now}  {error}\r\n{metod}";
			//	using (StreamWriter sr = new(m))
			//	{
			//		sr.WriteLine(r);
			//	}

			//}
		}
		public async static Task Info(string text )
        {
			string txt = $"{DateTime.Now} [info]: {text}";
			await Task.Run(() =>
			{
				string path = Path.Combine(LocalDerictoriPath,$"Info_{DateTime.Now:dd.MM.yyyy}.txt");
				if(!Directory.Exists(LocalDerictoriPath))
				{
					Directory.CreateDirectory(LocalDerictoriPath);
				}
				if(!File.Exists(path)) 
				{
					File.Create(path).Close();
					
				}
					using(StreamWriter a =  new StreamWriter(path,true))
					{

						a.AutoFlush = true;
						a.WriteLine(txt);
					}
			});
			
		}
	}
}

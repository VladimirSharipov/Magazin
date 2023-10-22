using Magazin.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Magazin.Controller
{
	public static class ControllerAPI
	{
		public  async static Task<List<DrugsModel>> SerchDrugs(string Name)
		{
			List<DrugsModel> a = new List<DrugsModel>();
			await Task.Run(() => 
			{

				string url = $"https://tasnif.soliq.uz/api/cl-api/integration-mxik/search?search_text={Name}";
				string resultJson = "";
				try
				{
					ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
					HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
					request.KeepAlive = true;
					request.Credentials = CredentialCache.DefaultCredentials;
					using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
					{
						using (Stream responseStream = response.GetResponseStream())
						{
							using (StreamReader reader = new StreamReader(responseStream))
							{
								resultJson = reader.ReadToEnd();
								if (!string.IsNullOrEmpty(resultJson))
								{
									var parset = JsonConvert.DeserializeObject<ResultModel>(resultJson);
									a = parset.data;
								}

							}
						}
					}
				}
				catch (Exception ex)
				{
					Task.Run(async () =>
					{
						await Helper.Erorr($"{ex.Message},{ex.StackTrace}");

					});
					///integration-mxik/get/history/time
					///https://tasnif.soliq.uz/api/cl-api/integration-mxik/get/history/time=
				}

			});
			
			return a;
		}
		public async static Task<List<SerchTimeTovarModel>> GetSerchTime(DateTime end, DateTime start)
		{
			List<SerchTimeTovarModel> a = new();
			await Task.Run(() =>
			{
			string resultJson = "";
			long c, b;
			DateTime x = new(1970, 01, 01, 0, 0, 0);
			TimeSpan tm1 = start - x;
			TimeSpan tm2 = end - x;
			c = Convert.ToInt64(tm1.TotalSeconds) * 1000;
			b = Convert.ToInt64(tm2.TotalSeconds) * 1000;
			string url = $"https://tasnif.soliq.uz/api/cl-api/integration-mxik/get/history/time?endDate={c}&startDate={b}";
			try
			{
				ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
				httpWebRequest.KeepAlive = true;
				httpWebRequest.Credentials = CredentialCache.DefaultCredentials;
				using (HttpWebResponse response = (HttpWebResponse)httpWebRequest.GetResponse())
				{
					using (Stream resp = httpWebRequest.GetRequestStream())
					{
						using (StreamReader reader = new StreamReader(resp))
						{
							resultJson = reader.ReadToEnd();
							if (!string.IsNullOrEmpty(resultJson))
							{
								var parset = JsonConvert.DeserializeObject<ResultHistori>(resultJson);
								a = parset.data;
							}

						}
					}
				}
			}
			catch (Exception ex)
			{
				///Controldb.metod(ex.Message);
				Task.Run(async () =>
				{
				await	Helper.Erorr($"{ex.Message},{ex.StackTrace}");
				
				});
					
			}
			});
			return a;

		}
	}
	
}

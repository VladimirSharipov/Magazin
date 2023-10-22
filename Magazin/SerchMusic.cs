using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using Magazin.Model;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazin
{
	public partial class SerchMusic : Form
	{
		public SerchMusic()
		{
			InitializeComponent();
		}

		private async void btnGetMusic_Click(object sender, EventArgs e)
		{
			string data = await GetHtml("https://mp3xa.cc/hits/");
			List<TrakModel> list = await GetTrakList(data) ;

			await GetMusic(list);
		}
		public async Task<string> GetHtml(string url)
		{ 
			string result =string.Empty;
			await Task.Run(() =>
			{
				HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
				using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
				{
					using (Stream stream = response.GetResponseStream())
					{
						using (StreamReader reader = new StreamReader(stream, Encoding.GetEncoding(response.CharacterSet)))
						{
							result = reader.ReadToEnd();
						}
					}
				}
			});
			return result;
		}
		public async Task<List<TrakModel>> GetTrakList(string html)
		{
			List<TrakModel> result = new();
			await Task.Run(() =>
			{
				
				IHtmlDocument a = new HtmlParser().ParseDocument(html);
				foreach (var element in a.QuerySelectorAll("div"))
				{
					if (element.OuterHtml.Substring(0, 25).Contains("<div class=\"plyr-item\""))
					{
						TrakModel model = new TrakModel();
						IHtmlDocument x = new HtmlParser().ParseDocument(element.OuterHtml);
						string baseUrl = x.QuerySelectorAll("link").FirstOrDefault().GetAttribute("href");
						model.BaseUrl = baseUrl;
						foreach (var d in x.QuerySelectorAll("a"))
						{
							if (d.OuterHtml.Contains("<a href=\"/singer"))
								model.Name = d.TextContent;
							//d.GetAttribute("href");
							else if (d.OuterHtml.Contains("<a href=\"/hits"))
							{
								model.MusicName = d.TextContent;
								break;

							}

						}
						foreach (var m in x.QuerySelectorAll("div"))
						{
							if (m.OuterHtml.Substring(0, 25).Contains("<div class=\"maudio\""))
							{
								string Listiningurl = m.QuerySelectorAll("a").FirstOrDefault().GetAttribute("data-url");
								//TrakModel model = new TrakModel();
								//IHtmlDocument x = new HtmlParser().ParseDocument(element.OuterHtml);
								//var h = m.OuterHtml.Substring(0, 25).Contains("<div class=\"audio - control\"");
								model.UrlAudio = Listiningurl;
								break;
							}

						}
						result.Add(model);
					}



				}
			});
			
			return result;
		}
		public async  Task GetMusic(List<TrakModel> result)
		{
			await Task.Run(async() =>
			{
				string html = string.Empty;
				foreach (var model in result)
				{
					html =  await GetHtml(model.BaseUrl);
					IHtmlDocument y = new HtmlParser().ParseDocument(html);
					foreach (var a in y.QuerySelectorAll("a"))
					{
						if (a.OuterHtml.Contains("<a itemprop=\"contentUrl\" href=\"https:"))
						{
							model.UrlDowload = a.GetAttribute("href");

						}

					}
				}
			});
			dataGridView1.DataSource = result;

		}

		private async void btnDonwload_Click(object sender, EventArgs e)
		{
			string downloadUrl = String.Empty;
			downloadUrl = dataGridView1.CurrentRow.Cells[nameof(TrakModel.UrlDowload)].Value.ToString();

			string Name = dataGridView1.CurrentRow.Cells[nameof(TrakModel.MusicName)].Value.ToString();
			Zaproc(downloadUrl, Name);
			MessageBox.Show("a");
		}

		private async void btnAudio_Click(object sender, EventArgs e)
		{
			string Audio = string.Empty;
			Audio  = dataGridView1.CurrentRow.Cells[nameof(TrakModel.UrlAudio)].Value.ToString();
			string Name = dataGridView1.CurrentRow.Cells[nameof(TrakModel.MusicName)].Value.ToString();
			await Zaproc(Audio, Name);
			MessageBox.Show("b");

		}
		public async Task Zaproc(string url,string Name)
		{
			WebClient client = new();

			client.DownloadFileAsync(new Url(url), $"C:\\Users\\user\\{Name}.mp3");
		}
	}
}

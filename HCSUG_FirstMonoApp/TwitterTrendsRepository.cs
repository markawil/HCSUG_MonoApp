using System;
using System.Net;
using System.Collections.Generic;
using System.Json;

namespace HCSUG_FirstMonoApp
{
	public class TwitterTrendsRepository
	{
		public TwitterTrendsRepository ()
		{

		}

		public Trend[] GetTwitterTrends ()
		{
			string urlApi = "http://api.twitter.com/1/trends/1.json";
			string reply = String.Empty;
			using (var wc = new WebClient()) {
				reply = wc.DownloadString (urlApi);
			}

			List<Trend> listToReturn = new List<Trend> ();
			var headNode = JsonArray.Parse (reply);
			var trendsNode = JsonArray.Parse (headNode [0].ToString ());
			var trends = trendsNode ["trends"];

			foreach (var v in trends) {
				var nodes = JsonArray.Parse (v.ToString ());
				var name = nodes ["name"];
				var trend = new Trend ();
				trend.Name = name;
				var url = nodes ["url"];
				trend.Url = url;
				listToReturn.Add (trend);
			}

			return listToReturn.ToArray ();
		}
	}
}


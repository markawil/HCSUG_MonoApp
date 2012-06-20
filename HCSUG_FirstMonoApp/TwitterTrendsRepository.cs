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

		public string[] GetTwitterTrends ()
		{
			string urlApi = "http://api.twitter.com/1/trends/1.json";
			string reply = String.Empty;
			using (var wc = new WebClient()) {
				reply = wc.DownloadString (urlApi);
			}

			List<string> listToReturn = new List<string> ();
			var headNode = JsonArray.Parse (reply);
			var trendsNode = JsonArray.Parse (headNode [0].ToString ());
			var trends = trendsNode ["trends"];

			foreach (var v in trends) {
				var nodes = JsonArray.Parse (v.ToString ());
				var name = nodes ["name"];
				listToReturn.Add (name);
			}

			return listToReturn.ToArray ();
		}
	}
}


using System;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;



namespace CafeBytes.XamarinExemplo.Http
{
	public class FormProvider
	{

		private HttpClient _client;
		public Uri BaseAddress { get; private set; }

		public FormProvider ()
		{
			BaseAddress = new Uri ("http://hmgcemig2.hmg.c2m2.take.io/CafeBytes/");
			_client = new HttpClient();
			_client.BaseAddress = BaseAddress;
			_client.Timeout = new TimeSpan(0, 3, 0);
		}

		public async Task<string> RegisterUser(Uri uri, object objToPost)
		{
			var body = SerializeToString(objToPost);
			var content = new StringContent(body, Encoding.UTF8, "text/json");

			var response = await _client.PostAsync(uri, content);

			return response;
		}

		protected string SerializeToString(Object obj)
		{
			return JsonConvert.SerializeObject(obj);
		}
	}
}

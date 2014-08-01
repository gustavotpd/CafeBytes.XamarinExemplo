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
           
            _client = new HttpClient();
            _client.BaseAddress = BaseAddress;
            _client.Timeout = new TimeSpan(0, 3, 0);
        }

		public async Task<string> RegisterUser(string name, string email)
        {
			string baseAddress = "http://hmgcemig2.hmg.c2m2.take.io/CafeBytes/?name={0}&email={1}";

			var baseAddressWithParams = String.Format (baseAddress, name, email);

			Uri uri = new Uri (baseAddressWithParams);

			var response = await _client.GetAsync(uri);

			return await response.Content.ReadAsStringAsync ();
        }

        protected string SerializeToString(Object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}

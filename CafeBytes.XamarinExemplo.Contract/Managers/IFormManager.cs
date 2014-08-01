using System;
using System.Threading.Tasks;

namespace CafeBytes.XamarinExemplo.Contract
{
	public interface IFormManager
	{
		Task<string> RegisterUser (Person user);
	}
}
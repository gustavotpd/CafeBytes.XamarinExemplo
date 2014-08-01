using System;
using System.Threading.Tasks;

namespace CafeBytes.XamarinExemplo.Contract
{
	public interface IFormManager
	{
		Task RegisterUser (Person user);
	}
}
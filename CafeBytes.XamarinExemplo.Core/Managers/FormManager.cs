﻿using System;
using System.Threading.Tasks;
using CafeBytes.XamarinExemplo.Contract;
using CafeBytes.XamarinExemplo.Http;

namespace CafeBytes.XamarinExemplo.Core
{
	public class FormManager : IFormManager
	{

		private readonly FormProvider _formProvider;

		public FormManager ()
		{
			_formProvider = new FormProvider ();
		}


		public Task RegisterUser (Person user)
		{
			_formProvider.RegisterUser (new Uri(),user);
		}
	}
}


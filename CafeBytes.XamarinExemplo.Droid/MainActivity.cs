using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace CafeBytes.Demo.Droid
{
	[Activity (Label = "CafeBytes.XamarinExemplo.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		private EditText _name;
		private EditText _email;
		private Button _submitButton;
		private ImageView _logo;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			_logo = FindViewById<ImageView> (Resource.Id.imageView1);
			_name = FindViewById<EditText> (Resource.Id.nameEditText);
			_email = FindViewById<EditText> (Resource.Id.emailEditText);

			_logo.SetBackgroundResource (Resource.Drawable.logo);

			// Get our button from the layout resource,
			// and attach an event to it
			_submitButton = FindViewById<Button> (Resource.Id.submitButton);
			
			_submitButton.Click += SendData;
		}

		public void SendData(object sender, EventArgs e)
		{

		}
	}
}



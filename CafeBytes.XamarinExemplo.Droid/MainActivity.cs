using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using CafeBytes.XamarinExemplo.Droid;
using CafeBytes.XamarinExemplo.Core;
using CafeBytes.XamarinExemplo.Contract;

namespace CafeBytes.Demo.Droid
{
	[Activity (Label = "CafeBytes.XamarinExemplo.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		private ProgressDialog _progressDialog;
		private EditText _name;
		private EditText _email;
		private Button _submitButton;
		private ImageView _logo;
		private IFormManager _manager;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			_manager = new FormManager ();

			_logo = FindViewById<ImageView> (Resource.Id.imageView1);
			_name = FindViewById<EditText> (Resource.Id.nameEditText);
			_email = FindViewById<EditText> (Resource.Id.emailEditText);

			_logo.SetBackgroundResource (Resource.Drawable.logo);

			// Get our button from the layout resource,
			// and attach an event to it
			_submitButton = FindViewById<Button> (Resource.Id.submitButton);
			
			_submitButton.Click += SendData;

			_progressDialog = new ProgressDialog(this);
			_progressDialog.SetTitle(this.Resources.GetString(Resource.String.register));
			_progressDialog.SetMessage(this.Resources.GetString(Resource.String.send_data));
			_progressDialog.SetProgressStyle (ProgressDialogStyle.Spinner);
		}

		public async void SendData(object sender, EventArgs e)
		{
			_progressDialog.Show();

			var name = _name.Text;
			var email = _email.Text;

			Person user = new Person (name, email);

			var res = await _manager.RegisterUser (user);
			_progressDialog.Hide();
			ShowDialog (res);
		}


		public void ShowDialog(string message)
		{
			AlertDialog alertDialog = new AlertDialog.Builder(this).Create();
			alertDialog.SetTitle(this.Resources.GetString(Resource.String.send_data));
			alertDialog.SetMessage(message);
			alertDialog.Show();
		}
	}
}



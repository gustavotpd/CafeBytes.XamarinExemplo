using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using CafeBytes.XamarinExemplo.Core;
using CafeBytes.XamarinExemplo.Contract;

namespace CafeBytes.XamarinExemplo.iOS
{
	public partial class CafeBytes_XamarinExemplo_iOSViewController : UIViewController
	{
		private IFormManager _manager;

		public CafeBytes_XamarinExemplo_iOSViewController (IntPtr handle) : base (handle)
		{
			_manager = new FormManager ();

		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

		[Action ("Enviar_TouchUpInside:")]

		async void Enviar_TouchUpInside (UIButton sender)
		{
			Person person = new Person (NameTextField.Text, EmailTextField.Text);
			var res = await _manager.RegisterUser(person);

			UIAlertView alert = new UIAlertView();
			alert.Message = res;
			alert.Title = "Cadastro";
			alert.Show();
			alert.DismissWithClickedButtonIndex (-1, true);


		}

		#endregion
	}
}


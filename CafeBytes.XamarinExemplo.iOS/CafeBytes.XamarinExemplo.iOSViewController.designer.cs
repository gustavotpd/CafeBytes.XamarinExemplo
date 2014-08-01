// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace CafeBytes.XamarinExemplo.iOS
{
	[Register ("CafeBytes_XamarinExemplo_iOSViewController")]
	partial class CafeBytes_XamarinExemplo_iOSViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField EmailTextField { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton Enviar { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField NameTextField { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (EmailTextField != null) {
				EmailTextField.Dispose ();
				EmailTextField = null;
			}
			if (Enviar != null) {
				Enviar.Dispose ();
				Enviar = null;
			}
			if (NameTextField != null) {
				NameTextField.Dispose ();
				NameTextField = null;
			}
		}
	}
}

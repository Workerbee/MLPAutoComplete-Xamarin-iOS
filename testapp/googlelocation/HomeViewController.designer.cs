// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace googlelocation
{
	[Register ("HomeViewController")]
	partial class HomeViewController
	{
		[Outlet]
		MLPAutoComplete.MLPAutoCompleteTextField autoTextField { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (autoTextField != null) {
				autoTextField.Dispose ();
				autoTextField = null;
			}
		}
	}
}

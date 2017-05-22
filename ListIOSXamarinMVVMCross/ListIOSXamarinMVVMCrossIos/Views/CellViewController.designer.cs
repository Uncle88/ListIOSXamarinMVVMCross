// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace ListIOSXamarinMVVMCrossIos.Views
{
	[Register ("CellViewController")]
	partial class CellViewController
	{
		[Outlet]
		UIKit.UITextField cellName { get; set; }

		[Outlet]
		UIKit.UITextField cellSurname { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (cellName != null) {
				cellName.Dispose ();
				cellName = null;
			}

			if (cellSurname != null) {
				cellSurname.Dispose ();
				cellSurname = null;
			}
		}
	}
}

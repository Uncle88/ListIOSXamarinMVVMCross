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
	[Register ("CollectionViewController")]
	partial class CollectionViewController
	{
		[Outlet]
		UIKit.UICollectionView CollectionPersons { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (CollectionPersons != null) {
				CollectionPersons.Dispose ();
				CollectionPersons = null;
			}
		}
	}
}

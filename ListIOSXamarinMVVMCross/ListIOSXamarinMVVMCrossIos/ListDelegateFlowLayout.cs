using System;
using System.Drawing;
using Foundation;
using UIKit;
using ListIOSXamarinMVVMCross.Model;
using System.Collections.Generic;
using CoreGraphics;

namespace ListIOSXamarinMVVMCrossIos
{
    public class ListDelegateFlowLayout : UICollectionViewDelegateFlowLayout
    {
        // this is the override that allows you to dynamically size UICollectionView items
        public override CGSize GetSizeForItem(UICollectionView collectionView, UICollectionViewLayout layout, NSIndexPath indexPath)
        {
            return new CGSize(325, 40);
            //return new SizeF(
            //    width: UIScreen.MainScreen.Bounds.Width, // Set the width to whatever you want. In this case, it's the screen width.
            //    height: Persons[indexPath.Row].Height // Set the item height
            //);
        }
    }
}

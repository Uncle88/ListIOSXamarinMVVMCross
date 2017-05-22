using System;
namespace ListIOSXamarinMVVMCrossIos
{
    public class ThingDelegateFlowLayout : UICollectionViewDelegateFlowLayout
    {
        List<Thing> Things;

        public ThingDelegateFlowLayout(List<Thing> things)
        {
            Things = things;
        }

        // this is the override that allows you to dynamically size UICollectionView items
        public override SizeF GetSizeForItem(UICollectionView collectionView, UICollectionViewLayout layout, NSIndexPath indexPath)
        {
            return new SizeF(
                width: UIScreen.MainScreen.Bounds.Width, // Set the width to whatever you want. In this case, it's the screen width.
                height: Things[indexPath.Row].Height // Set the item height
            );
        }
    }
}

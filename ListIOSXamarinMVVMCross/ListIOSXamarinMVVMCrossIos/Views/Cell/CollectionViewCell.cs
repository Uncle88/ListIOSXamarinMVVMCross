using System;
using Foundation;
using MvvmCross.Binding.iOS.Views;
using UIKit;
using MvvmCross.Binding.BindingContext;
using ListIOSXamarinMVVMCross.Model;

namespace ListIOSXamarinMVVMCrossIos.Cell
{
    public partial class CollectionViewCell : MvxCollectionViewCell
    {
        public static readonly NSString Key = new NSString("CollectionViewCell");
        public static readonly UINib Nib;

        static CollectionViewCell()
        {
            Nib = UINib.FromName("CollectionViewCell", NSBundle.MainBundle);
        }

        protected CollectionViewCell(IntPtr handle) : base(handle)
        {
            this.DelayBind(() =>
            {
                var set = this.CreateBindingSet<CollectionViewCell, Person>();
                set.Bind(cellName).To(vm => vm.Name);
                set.Bind(cellSurname).To(vm => vm.Surname);
                set.Apply();
            });
        }
    }
}

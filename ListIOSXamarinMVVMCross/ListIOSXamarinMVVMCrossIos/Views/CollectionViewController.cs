using System;
using ListIOSXamarinMVVMCross.ViewModels;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Views;
using UIKit;
using MvvmCross.Binding.BindingContext;
using ListIOSXamarinMVVMCrossIos.Cell;
using MvvmCross.Binding.iOS.Views;
using ListIOSXamarinMVVMCross.Model;
using System.Drawing;
using System.Collections.Generic;

namespace ListIOSXamarinMVVMCrossIos.Views
{
    public partial class CollectionViewController : MvxViewController
    {
        public CollectionViewController() : base("CollectionViewController", null)
        {
        }

        public new ListViewModel ViewModel
        {
            get { return (ListViewModel)base.ViewModel; }
            set { base.ViewModel = (IMvxViewModel)value; }
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var layout = new UICollectionViewFlowLayout();
            layout.SectionInset = new UIEdgeInsets(UIScreen.MainScreen.ApplicationFrame.Height - 0, 0, 0, 0);
            layout.ItemSize = new SizeF((float)UIScreen.MainScreen.Bounds.Width, 100f);

            var collectionView = new UICollectionView(UIScreen.MainScreen.ApplicationFrame, layout);
            collectionView.Source = new UICollectionViewSource();

            CollectionPersons.RegisterNibForCell(CollectionViewCell.Nib, CollectionViewCell.Key);
            var sourse = new MvxCollectionViewSource(CollectionPersons, CollectionViewCell.Key);
            CollectionPersons.Source = sourse;
            var set = this.CreateBindingSet<CollectionViewController, ListViewModel>();
            set.Bind(sourse).For(s => s.ItemsSource).To(vm => vm.Persons);
            set.Apply();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}


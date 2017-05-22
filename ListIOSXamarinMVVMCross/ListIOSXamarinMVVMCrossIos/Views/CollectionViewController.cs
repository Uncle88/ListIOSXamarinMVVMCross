using ListIOSXamarinMVVMCross.ViewModels;
using ListIOSXamarinMVVMCrossIos.Cell;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Views;

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

            CollectionPersons.RegisterNibForCell(CollectionViewCell.Nib, CollectionViewCell.Key);
            var sourse = new MvxCollectionViewSource(CollectionPersons, CollectionViewCell.Key);
            CollectionPersons.Source = sourse;
            CollectionPersons.Delegate = new ListDelegateFlowLayout();
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


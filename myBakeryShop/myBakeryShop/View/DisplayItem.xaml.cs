using myBakeryShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace myBakeryShop
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DisplayItem : ContentPage
	{
       

		public DisplayItem ()
		{
			InitializeComponent ();

            BindingContext = new DisplayItemVM();
            


        }




        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {


            var h_container = BindingContext as DisplayItemVM;

            MenueItems.BeginRefresh();

            if (String.IsNullOrWhiteSpace(e.NewTextValue))
            {

                MenueItems.ItemsSource = h_container.itemlist;
            }
            
            else
               
            MenueItems.ItemsSource = h_container.itemlist.Where(i => i.ItemName.ToLower().Contains(e.NewTextValue)); 

            MenueItems.EndRefresh();


        }

        private async void MenueItems_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedItem = e.SelectedItem as Item;

           await  Navigation.PushAsync(new ItemDetails(selectedItem.ItemName , selectedItem.Image , selectedItem.Calories , selectedItem.Price, selectedItem.Discription));

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("","Added to the wish list","Ok");
        }
    }
}
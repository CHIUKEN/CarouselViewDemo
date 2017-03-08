using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CarouselViewDemo
{
	public partial class HomePage : ContentPage
	{
		public HomePage()
		{
			InitializeComponent();
			BindingContext = new HomeViewModel();
		}

		public void CarouseItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var item = e.SelectedItem as DataModel;
			if (item == null)
			{
				return;
			}
			lbl.Text = item.Name;
		}
	}
}

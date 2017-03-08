using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace CarouselViewDemo
{
	public class HomeViewModel 
	{
		public ObservableCollection<DataModel> Datamodels{ get; set; }
		public string str { get; set; }
		public HomeViewModel()
		{
			Datamodels = new ObservableCollection<DataModel>();
			Datamodels.Add(new DataModel()
			{
				Name = "櫻花1",
				ImageUrl = "http://pic.pimg.tw/sinea100/1390465910-2545708497.jpg",
			});
			Datamodels.Add(new DataModel()
			{
				Name = "櫻花2",
				ImageUrl = "http://tw10005.tw.tranews.com/Show/images/Column/8938_1.jpg",
			});
			Datamodels.Add(new DataModel()
			{
				Name = "櫻花3",
				ImageUrl = "http://blossom.tw.tranews.com/Show/images/Column/8936_1.jpg",
			});
			Datamodels.Add(new DataModel()
			{
				Name = "櫻花4",
				ImageUrl = "https://farm8.staticflickr.com/7375/16175048917_696be50c12_b.jpg",
			});

		}



	}

	public class DataModel
	{
		public string Name { get; set; }
		public string ImageUrl { get; set; }
	}
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Realms;
using Xam.Realm.Model.Entity;

namespace Xam.Realm
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
	    protected override void OnAppearing()
	    {
	        base.OnAppearing();
	        var RealmDB = Realms.Realm.GetInstance();

	        var vEmpId = RealmDB.All<Note>().Count() + 1;
	        var vEmployee = new Note()
	        {
	            ID = vEmpId,
                Text = "note text"
                ,Category = new Category()
	            {
                    ID = RealmDB.All<Category>().Count() + 1,
                    Name = "Category name"
                }
	        };
	        RealmDB.Write(() => {
	            vEmployee = RealmDB.Add(vEmployee);
	        });


            var allNotes = new List<Note>(RealmDB.All<Note>());
	        notesListView.ItemsSource = allNotes;
	    }
	}
}


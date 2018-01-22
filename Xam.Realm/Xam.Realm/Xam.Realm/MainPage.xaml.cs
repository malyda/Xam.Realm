using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Realms;

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
	        };
	        RealmDB.Write(() => {
	            vEmployee = RealmDB.Add(vEmployee);
	        });


            var allNotes = RealmDB.All<Note>();
	        notesListView.ItemsSource = allNotes;
	    }
	}
}


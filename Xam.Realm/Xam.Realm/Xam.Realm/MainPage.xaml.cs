using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Realms;
using Xam.Realm.Model.DataAccess.Repository;
using Xam.Realm.Model.Entity;

namespace Xam.Realm
{
	public partial class MainPage : ContentPage
	{
	    private ObservableCollection<Note> _notes;
        public ObservableCollection<Note> Notes {
            get => _notes;
            set
            {
                _notes = value;
                OnPropertyChanged("Notes");
            }
        }
		public MainPage()
		{
			InitializeComponent();
		    this.BindingContext = this;	    
        }
	    protected override void OnAppearing()
	    {
	        base.OnAppearing();
	        
	        
            NoteRepository noteRepository = new NoteRepository();
            
	        Note note = new Note()
	        {
	            //ID = 1,
	            Text = "cleared text"
	        };

            Category category = new Category()
	        {
	            Name = "Category name"
	        };

	        note.Category = category;

            noteRepository.AddNote(note);

	        
            Notes = new ObservableCollection<Note>(noteRepository.GetAllNotes());
        }
	}
}


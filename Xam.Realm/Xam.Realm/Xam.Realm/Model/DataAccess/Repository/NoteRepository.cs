using System.Collections.Generic;
using System.Linq;
using Realms;
using Xam.Realm.Model.Entity;

namespace Xam.Realm.Model.DataAccess.Repository
{
    class NoteRepository
    {
        private readonly Realms.Realm RealmDB = Realms.Realm.GetInstance();
        public void AddNote(Note note)
        {
            if(note.ID == 0) note.ID = RealmDB.All<Note>().Count() + 1;
            RealmDB.Write(() => {
                RealmDB.Add(note, update: true);
            });
        }

        public List<Note> GetAllNotes()
        {
            return new List<Note>(RealmDB.All<Note>());
        }

        public void UpdateNote(Note note)
        {

        }
    }
}

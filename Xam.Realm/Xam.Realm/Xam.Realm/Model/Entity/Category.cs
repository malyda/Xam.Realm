using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Xam.Realm.Model.Entity
{
    public class Category: RealmObject
    {
        [PrimaryKey]
        public int ID { get; set; } 
        public string Name { get; set; }
        
        public IList<Note> Notes { get; }

        public override string ToString()
        {
            return $"ID: {ID}, Name {Name}";
        }
    }
}

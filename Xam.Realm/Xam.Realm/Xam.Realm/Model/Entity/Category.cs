using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Xam.Realm.Model.Entity
{
    class Category: RealmObject
    {
        [PrimaryKey]
        public long ID { get; set; }
        public string Name { get; set; }
        
        public IList<Note> Notes { get; }

        public override string ToString()
        {
            return $"ID: {ID}, Name {Name}";
        }
    }
}

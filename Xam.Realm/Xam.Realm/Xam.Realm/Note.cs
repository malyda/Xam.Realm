using System;
using System.Collections.Generic;
using System.Text;
using Realms;

namespace Xam.Realm
{
    class Note: RealmObject
    {
        [PrimaryKey]
        public long ID { get; set; }
        public string Text { get; set; }

        public override string ToString()
        {
            return $"ID: {ID}, Text {Text}";
        }
    }
}

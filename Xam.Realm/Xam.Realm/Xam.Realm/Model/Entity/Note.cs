using Realms;

namespace Xam.Realm.Model.Entity
{
    class Note: RealmObject
    {
        [PrimaryKey]
        public long ID { get; set; }
        public string Text { get; set; }

        public Category Category { get; set; }

        public override string ToString()
        {
            return $"ID: {ID}, Text {Text}";
        }
    }
}

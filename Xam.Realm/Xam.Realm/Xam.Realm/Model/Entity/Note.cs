using Realms;

namespace Xam.Realm.Model.Entity
{
    public class Note: RealmObject
    {
        [PrimaryKey]
        public int ID { get; set; }
        public string Text { get; set; }

        public Category Category { get; set; }

        public override string ToString()
        {
            return $"ID: {ID}, Text {Text}, Category {Category.Name}";
        }
    }
}

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FreeCourseServices.Catalog.Models
{
    public class Category
    {
        [BsonId] //This statement as a real Id value provides by MongoDB
        [BsonRepresentation(BsonType.ObjectId)] // This statement provides give type the prop.
        public string Id { get; set; }
        public string Name { get; set; }
    }
}

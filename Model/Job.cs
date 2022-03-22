using MongoDB.Bson.Serialization.Attributes;


namespace job_portal.Model
{
    public class Job
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

          public string Image { get; set; }
         public string  Rating { get; set; }
         public string Title { get; set; }

        public string Position  { get; set; }
        public string Place { get; set; }
          public  string  Date { get; set; }

        public string loc { get; set; }


        public string Day { get; set; }

        public string Header1 { get; set; }


        public string description1 { get; set; }

        public string Header2 { get; set; }

        public string description2 { get; set; }
          
        public string list1 { get; set; }


        public string list2 { get; set; }





    }
}

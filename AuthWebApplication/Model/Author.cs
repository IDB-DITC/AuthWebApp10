
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace AuthWebApplication.Model
{
    //[JsonSerializable(typeof(Author))]
    public class Author
    {
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false)]

        public string AuthorName { get; set; } = default!;
        public string? Photo { get; set; }
        public IList<Book> Books { get; set; } = new List<Book>();
    }

    public class Book
    {
        [Key]
        [Required(AllowEmptyStrings = false)]
        public string ISBN { get; set; } = default!;
        [Required(AllowEmptyStrings = false)]
        public string Title { get; set; } = default!;
        public int Edition { get; set; } = 1;
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true, HtmlEncode = true)]

        [Column(TypeName = "date")]
        [JsonConverter(typeof(DateTimeConverter))]
        //[JsonPropertyName("publishDate")]

        public DateTime PublishDate { get; set; }
        [EnumDataType(typeof(Genre))]

        public Genre Genre { get; set; }
        public int AuthorId { get; set; }
        public bool Available { get; set; } = true;
        public Author? Author { get; set; }


    }

    //public class DateFormatConverter : IsoDateTimeConverter
    //{
    //    public DateFormatConverter(string format)
    //    {
    //        base.ConvertToString()
    //        DateTimeFormat = format;
    //    }
    //}
    public class DateTimeConverter : JsonConverter<DateTime>
    {
        public string DateTimeFormat { get; set; } = "yyyy-MM-dd";

        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return DateTime.ParseExact(reader.GetString()!, DateTimeFormat, null);
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString(DateTimeFormat));
        }
    }

    public enum Genre
    {
        Fiction,
        NonFiction,
        ScienceFiction,
        Fantasy,
        Mystery,
        Biography,
        History,
        Romance
    }


}

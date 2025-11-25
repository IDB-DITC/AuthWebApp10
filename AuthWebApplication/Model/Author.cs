
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


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
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Column(TypeName = "date")]
    public DateTime PublishDate { get; set; }
    [EnumDataType(typeof(Genre))]
    public Genre Genre { get; set; }
    public int AuthorId { get; set; }
    public bool Available { get; set; } = true;
    public Author? Author { get; set; }
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

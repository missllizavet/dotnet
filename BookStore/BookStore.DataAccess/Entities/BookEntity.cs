using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.DataAccess.Entities;

[Table("Books")] 
public class BookEntity: BaseEntity
{
    public string Title { get; set; }
    public string Authors { get; set; }
    public string Genres { get; set; }
    public int Price { get; set; }
    public string Discription { get; set; }

    public int AuthorId { get; set; }
    public AuthorEntity Author { get; set; }
    
    public int GenreId { get; set; }
    public GenreEntity Genre { get; set; }
    
    public virtual ICollection<OrderItemEntity> OrderItems { get; set; }
    
}
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.DataAccess.Entities;

[Table("Genres")] 
public class GenreEntity: BaseEntity
{
    public string Name { get; set; }
    public virtual ICollection<BookEntity> Books { get; set; }
}
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.DataAccess.Entities;

[Table("Authors")] 
public class AuthorEntity: BaseEntity
{
    public string Name { get; set; }
    public virtual ICollection<BookEntity> Books { get; set; }
}
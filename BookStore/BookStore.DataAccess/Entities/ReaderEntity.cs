using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.DataAccess.Entities;

[Table("Readers")] 
public class ReaderEntity: BaseEntity
{
    public string Email { get; set; }
    public string Surname { get; set; }
    public string Login { get; set; }
    public string PasswordHash { get; set; }
    public bool Isconfirmed{ get; set; }
    public string Favoritegenres{ get; set; }
    
    public int UserId { get; set; }
    public UserEntity User { get; set; }
}
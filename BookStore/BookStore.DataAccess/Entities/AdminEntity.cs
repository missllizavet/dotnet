using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.DataAccess.Entities;

[Table("Admins")] 
public class AdminEntity: BaseEntity
{
    public string Permissions { get; set; }
    
    public int UserId { get; set; }
    public UserEntity User { get; set; }
}
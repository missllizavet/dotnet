using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.DataAccess.Entities;

[Table("Users")] 
public class UserEntity: BaseEntity
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Login { get; set; }
    public string PasswordHash { get; set; }
    
    public virtual ICollection<AdminEntity> Admins { get; set; } // Added
    public virtual ICollection<OrderEntity> Orders { get; set; } // Added
    public virtual ICollection<ReaderEntity> Readers { get; set; }
    
}
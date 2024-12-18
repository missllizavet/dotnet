using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.DataAccess.Entities

/*
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
}*/

{
    [Table("Users")]
    public class UserEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public string PasswordHash { get; set; }
        
        public virtual ICollection<OrderEntity> Orders { get; set; }
    }

    public class ReaderEntity : UserEntity
    {
        public string Email { get; set; }
        public bool Isconfirmed{ get; set; }
        public string Favoritegenres{ get; set; }
    }

    public class AdminEntity : UserEntity
    {
        public string Permissions { get; set; }
    }
    
    
}
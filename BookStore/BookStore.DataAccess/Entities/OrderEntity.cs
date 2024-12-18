using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.DataAccess.Entities;

[Table("Orders")] 
public class OrderEntity: BaseEntity
{
    public DateTime OrderDate { get; set; }
    public string TotalAmount { get; set; }
    public string Status { get; set; }
    
    public int UserId { get; set; }
    public UserEntity User { get; set; } 
    public virtual ICollection<OrderItemEntity> OrderItems { get; set; }
    
    //public virtual ICollection<OrderItemEntity> OrderItems { get; set; }
}


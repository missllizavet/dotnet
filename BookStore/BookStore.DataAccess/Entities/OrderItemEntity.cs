using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.DataAccess.Entities;

[Table("OrdersItem")] 
public class OrderItemEntity: BaseEntity
{
    public string Quantity { get; set; }

    public int OrderId { get; set; }
    public OrderEntity Order { get; set; }
    
    public int UserId { get; set; }
    public UserEntity User { get; set; }
    
    public int BookId { get; set; }
    public BookEntity Book { get; set; }
    
    public int AuthorId { get; set; }
    public AuthorEntity Author{ get; set; }
    
    public int GenreId { get; set; }
    public GenreEntity Genre { get; set; }
    
    
  
}
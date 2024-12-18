namespace BookStore.DataAccess.Entities;

public class BaseEntity
{
    /*public int Id { get; set; }
    public Guid ExternalId { get; set; }
    public DateTime ModificationTime { get; set; }
    public DateTime CreationTime { get; set; }  */
    
    public int Id { get; set; }
    public Guid ExternalId { get; set; } = Guid.NewGuid();
    public DateTime ModificationTime { get; set; } = DateTime.Now;
    public DateTime CreationTime { get; set; } = DateTime.Now;
}
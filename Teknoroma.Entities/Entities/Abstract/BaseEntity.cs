namespace Teknoroma.Entities.Entities.Abstract
{
    public abstract class BaseEntity
    {
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }

        protected BaseEntity()
        {
            Id = Guid.NewGuid().ToString();
            CreatedAt = DateTime.Now;
        }
    }
}

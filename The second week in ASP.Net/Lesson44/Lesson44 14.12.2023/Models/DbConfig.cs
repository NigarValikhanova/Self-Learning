namespace Lesson40_04._12._2023.Models
{
    public class DbConfig
    {
        public int Id { get; set; }
        public Guid GuidId { get; set; }
        public DbConfig() 
        {
            GuidId = Guid.NewGuid();
        }
    }
}

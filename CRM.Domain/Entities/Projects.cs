
namespace CRM.Domain.Entities
{
    public class Projects
    {
        public decimal ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal ClientId { get; set; }
    }
}

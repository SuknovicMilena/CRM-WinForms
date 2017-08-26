

namespace CRM.Desktop.Views
{
    public interface IAddProjectView : IView
    {
        string ProjectName { get; set; }
        string Description { get; set; }
        string Category { get; set; }
    }
}

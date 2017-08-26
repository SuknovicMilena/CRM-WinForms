namespace CRM.Desktop.Views
{
    public interface IContactAddView: IView
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Role { get; set; }
        string Email { get; set; }
        string Phone { get; set; }
        string Address { get; set; }
        string City { get; set; }
        string ZipCode { get; set; }
        string State { get; set; }
    }
}

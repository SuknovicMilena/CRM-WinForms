namespace CRM.Desktop.Views
{
    public interface IClientAddView : IView
    {
        string ClientName { get; set; }
        string Address { get; set; }
        string City { get; set; }
        string ZipCode { get; set; }
        string State { get; set; }
        string PhoneNumber { get; set; }
        string Website { get; set; }
        string Notes { get; set; }

    }
}

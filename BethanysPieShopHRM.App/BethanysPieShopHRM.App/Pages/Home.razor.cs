using BethanysPieShopHRM.App.Components.Widgets;

namespace BethanysPieShopHRM.App.Pages
{
    public partial class Home
    {
        public List<Type> Widgets { get; set; } = [typeof(EmployeeCountWidget), typeof(InboxWidget)];
    }
}

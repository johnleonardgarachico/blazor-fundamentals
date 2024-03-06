using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.App.Components
{
    public partial class EmployeeCard
    {
        [Parameter]
        public Employee Employee { get; set; } = default!;

        [Parameter]
        public EventCallback<Employee> EmployeeQuickViewClicked { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; } = default!;

        public void NavigateToDetails(Employee selectedEmployee)
        {
            // We can write more code here (as needed)

            // That way we can have more control on how our navigation works
            // For example, check if the user is allowed to navigate to the details page

            NavigationManager.NavigateTo($"/employeedetail/{selectedEmployee.EmployeeId}");
        }
    }
}

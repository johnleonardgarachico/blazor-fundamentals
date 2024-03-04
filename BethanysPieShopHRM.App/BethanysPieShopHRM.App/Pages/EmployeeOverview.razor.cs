﻿using BethanysPieShopHRM.App.Models;
using BethanysPieShopHRM.Shared.Domain;

namespace BethanysPieShopHRM.App.Pages
{
    public partial class EmployeeOverview
    {
        public List<Employee>? Employees { get; set; } = default!;

        private Employee? _selectedEmployee;

        override protected void OnInitialized()
        {
            Employees = MockDataService.Employees;
        }

        public void ShowQuickViewPopup(Employee selectedEmployee)
        {
            _selectedEmployee = selectedEmployee;
        }
    }
}

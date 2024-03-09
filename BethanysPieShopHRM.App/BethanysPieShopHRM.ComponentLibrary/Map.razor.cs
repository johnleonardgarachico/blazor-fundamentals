using BethanysPieShopHRM.Shared.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BethanysPieShopHRM.ComponentLibrary
{
    public partial class Map
    {
        private string elementId = $"map-{Guid.NewGuid():D}";

        [Inject]
        public IJSRuntime JSRuntime { get; set; }

        [Parameter]
        public double Zoom { get; set; }

        [Parameter]
        public List<Marker> Markers { get; set; }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            /*var isDeliveryMapUndefined = true;

            while (isDeliveryMapUndefined)
            {
                await Task.Delay(1000);

                isDeliveryMapUndefined = !(await JSRuntime.InvokeAsync<bool>("eval", "typeof deliveryMap !== 'undefined'"));
            }*/

            await JSRuntime.InvokeVoidAsync("deliveryMap.showOrUpdate", elementId, Markers);
        }
    }
}

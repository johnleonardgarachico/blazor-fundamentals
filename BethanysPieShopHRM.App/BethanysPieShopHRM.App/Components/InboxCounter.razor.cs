using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.App.Components
{
    public partial class InboxCounter
    {
        private int MessageCount { get; set; }

        [Inject]
        public ApplicationState ApplicationState { get; set; }

        protected override void OnInitialized()
        {
            MessageCount = new Random().Next();
            ApplicationState.NumberOfMessages = MessageCount;
        }
    }
}

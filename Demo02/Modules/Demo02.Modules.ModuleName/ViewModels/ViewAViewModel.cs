using Demo02.Core.Mvvm;
using Demo02.Interfaces;
using Prism.Navigation.Regions;

namespace Demo02.Modules.ModuleName.ViewModels
{
    public class ViewAViewModel : RegionViewModelBase , IRegionMemberLifetime
    {
        private readonly IRegionManager _regionManager;

        private string _message;

        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public bool KeepAlive => true;

        public ViewAViewModel(IRegionManager regionManager, IMessageService messageService) : base(regionManager)
        {
            Message = messageService.GetMessage();
            _regionManager = regionManager;
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            //do something
        }
    }
}

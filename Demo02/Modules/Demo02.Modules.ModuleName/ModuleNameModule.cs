using System.Windows;
using Demo02.Core;
using Demo02.Core.Events;
using Demo02.Modules.ModuleName.Views;
using Prism.Events;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Navigation.Regions;

namespace Demo02.Modules.ModuleName
{
    public class ModuleNameModule : IModule
    {
        
        private readonly IRegionManager _regionManager;

        public ModuleNameModule(IRegionManager regionManager)
        {
            
            _regionManager = regionManager;
            
        }

        /// <summary>
        /// 在模块初始化时执行的逻辑
        /// </summary>
        /// <param name="containerProvider"></param>
        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.AnnRegion, "AnnView");
            _regionManager.RegisterViewWithRegion(RegionNames.ContentRegion, "HomeView");
            _regionManager.RegisterViewWithRegion(RegionNames.LeftDrawerRegion, "LeftDrawerView");
            _regionManager.RegisterViewWithRegion(RegionNames.PopupRegion, "LoginView");
            _regionManager.RegisterViewWithRegion(RegionNames.TitleRegion, "TitleView");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<AnnView>();
            containerRegistry.RegisterForNavigation<BookShelfView>();
            containerRegistry.RegisterForNavigation<HomeView>();
            containerRegistry.RegisterForNavigation<LeftDrawerView>();
            containerRegistry.RegisterForNavigation<LoginView>();
            containerRegistry.RegisterForNavigation<TitleView>();
            containerRegistry.RegisterForNavigation<ViewA>();
            
        }
    }
}
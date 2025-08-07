using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Demo02.Core;
using Demo02.Core.Events;
using Demo02.Core.Mvvm;
using Demo02.Modules.ModuleName.Views;
using DryIoc;
using DryIoc.ImTools;
using Prism.Commands;
using Prism.Events;
using Prism.Ioc;
using Prism.Navigation;
using Prism.Navigation.Regions;

namespace Demo02.Modules.ModuleName.ViewModels
{
    public class LeftDrawerViewModel : RegionViewModelBase, IRegionMemberLifetime
    {
        #region 字段

        private readonly IRegionManager _regionManager;

        


        #endregion

        #region 属性

        public bool KeepAlive => true;

        #endregion

        #region 命令

        public DelegateCommand<string> DelegateCommand { get; set; }

        #endregion

        #region 函数

        public LeftDrawerViewModel(IRegionManager regionManager) : base(regionManager)
        {
            _regionManager = regionManager;

            DelegateCommand = new DelegateCommand<string>(DelegateMethod);
        }

        private void DelegateMethod(string command)
        {
            switch (command)
            {
                case "HomeView":
                    RegionToView("HomeView");
                    break;
                case "ViewA":
                    RegionToView("ViewA");
                    break;
                default:
                    //RegionToView("ViewA");
                    break;
            }
        }

        public void RegionToView(string viewName)
        {
            _regionManager.RequestNavigate(RegionNames.ContentRegion,viewName);
        }

        #endregion
    }
}

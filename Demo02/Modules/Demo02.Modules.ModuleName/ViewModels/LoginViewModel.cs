using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Demo02.Core.Mvvm;
using Demo02.Modules.ModuleName.Views;
using Prism.Commands;
using Prism.Ioc;
using Prism.Navigation.Regions;

namespace Demo02.Modules.ModuleName.ViewModels
{
    public class LoginViewModel : RegionViewModelBase
    {
        #region 字段

        private readonly IContainerExtension _container;

        private readonly IRegionManager _regionManager;

        #endregion

        #region 属性

        private string account;

        public string Account
        {
            get { return account; }
            set { SetProperty(ref account,value); }
        }


        #endregion

        #region 命令

        public DelegateCommand<PasswordBox> LoginCommand { get; set; }

        #endregion

        #region 函数

        public LoginViewModel(IContainerExtension container, IRegionManager regionManager) : base(regionManager)
        {
            _container = container;
            _regionManager = regionManager;
            LoginCommand = new DelegateCommand<PasswordBox>(LoginMethod);
        }

        /// <summary>
        /// 登录函数
        /// </summary>
        /// <param name="box"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void LoginMethod(PasswordBox box)
        {
            if (box == null)
            {
                MessageBox.Show("box is null");
            }
            else 
            {
                if (string.IsNullOrEmpty(Account) || string.IsNullOrEmpty(box.Password))
                {
                    MessageBox.Show("账号或密码不能为空");
                }
                else 
                {
                    if(Account.Equals("1") && box.Password.Equals("1"))
                    {
                        //new MainWindow().Show();
                        var window = _container.Resolve<MainWindow>();
                        window.Show();
                        Application.Current.MainWindow.Close();
                    }
                    else
                    {
                        MessageBox.Show("账号或密码错误");
                    }
                }
            }
        }

        #endregion
    }
}

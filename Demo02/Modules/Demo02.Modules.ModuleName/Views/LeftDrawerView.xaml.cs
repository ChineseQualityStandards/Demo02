using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CommonServiceLocator;
using Demo02.Core;
using Prism.Commands;
using Prism.Navigation.Regions;

namespace Demo02.Modules.ModuleName.Views
{
    /// <summary>
    /// MainWindow的左抽屉页
    /// </summary>
    public partial class LeftDrawerView : UserControl
    {
        private IRegionManager RegionManager { get; set; }

        public LeftDrawerView()
        {
            InitializeComponent();
            
        }
    }
}

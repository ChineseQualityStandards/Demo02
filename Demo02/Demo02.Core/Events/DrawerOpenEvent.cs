using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Events;

namespace Demo02.Core.Events
{
    /// <summary>
    /// 关于DrawerHost控件中Drawer的事件
    /// </summary>
    public class DrawerOpenEvent : PubSubEvent<bool>
    {
    }
}

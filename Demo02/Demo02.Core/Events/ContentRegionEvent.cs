using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Events;

namespace Demo02.Core.Events
{
    /// <summary>
    /// 关于ContentRegion导航的事件
    /// </summary>
    public class ContentRegionEvent : PubSubEvent<string>
    {
    }
}

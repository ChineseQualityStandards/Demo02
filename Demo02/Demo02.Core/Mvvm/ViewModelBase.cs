using Prism.Mvvm;
using Prism.Navigation;

namespace Demo02.Core.Mvvm
{
    public abstract class ViewModelBase : BindableBase, IDestructible
    {
        /// <summary>
        /// ViewModelBase构造函数
        /// </summary>
        protected ViewModelBase()
        {

        }

        /// <summary>
        /// 销毁函数
        /// </summary>
        public virtual void Destroy()
        {

        }
    }
}

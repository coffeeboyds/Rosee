using System.Threading;
using MvvmCross.Core.ViewModels;
using Rosee.Core.Properties;

namespace Rosee.Core
{
    public class BaseViewModelUtility
    {
        private CancellationTokenSource CancelationTokenSource { get; set; } = new CancellationTokenSource();

        public CancellationToken Token
        {
            get
            {
                return this.CancelationTokenSource.Token;
            }
        }

        public virtual void Cancel()
        {
            this.CancelationTokenSource.Cancel();
            this.CancelationTokenSource = new CancellationTokenSource();
        }

        public string this[string index]
        {
            get
            {
                return StringLookup(index);
            }
        }

        public static string GetString(string index)
        {
            return StringLookup(index);
        }

        public static string StringLookup(string s)
        {
            if (s.StartsWith("fa_"))
            {
                return FontAwesome.ResourceManager.GetString(s);
            }
            else
            {
                return Resources.ResourceManager.GetString(s);
            }
        }
    }

    public class BaseViewModel : MvxViewModel
    {
        public BaseViewModel()
        {
            BaseViewModelUtility = new BaseViewModelUtility();
        }

        protected BaseViewModelUtility BaseViewModelUtility { get; private set; }
    }

    public abstract class BaseViewModelParameter<TParameter> : MvxViewModel<TParameter> where TParameter : class
    {
        private CancellationTokenSource CancelationTokenSource { get; set; } = new CancellationTokenSource();

        public BaseViewModelParameter()
        {
            BaseViewModelUtility = new BaseViewModelUtility();
        }

        protected BaseViewModelUtility BaseViewModelUtility { get; private set; }

        protected TParameter Parameter { get; set; }

        public void ViewCreated()
        {

        }

        public void ViewAppearing()
        {

        }

        public void ViewAppeared()
        {

        }

        public void ViewDisappearing()
        {

        }

        public void ViewDisappeared()
        {

        }

        public void ViewDestroy()
        {

        }

        public void Init(IMvxBundle parameters)
        {

        }

        public void ReloadState(IMvxBundle state)
        {

        }

        public void Start()
        {

        }

        public void SaveState(IMvxBundle state)
        {

        }
    }
}

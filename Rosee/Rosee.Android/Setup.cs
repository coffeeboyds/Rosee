﻿using Android.Content;
using MvvmCross.Platform.Platform;
using MvvmCross.Core.ViewModels;
using MvvmCross.Binding.Bindings.Target.Construction;
using MvvmCross.Droid.Platform;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace Rosee.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext)
            : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            this.RegisterDependencies();
            
            return new Core.App();
        }

        //protected override IEnumerable<Assembly> AndroidViewAssemblies => new List<Assembly>(base.AndroidViewAssemblies)
        //{
        //    typeof(Android.Support.Design.Widget.NavigationView).Assembly,
        //    typeof(Android.Support.Design.Widget.FloatingActionButton).Assembly,
        //    typeof(Android.Support.V7.Widget.Toolbar).Assembly,
        //    typeof(Android.Support.V4.Widget.DrawerLayout).Assembly,
        //    typeof(Android.Support.V4.View.ViewPager).Assembly,
        //    typeof(MvvmCross.Droid.Support.V7.RecyclerView.MvxRecyclerView).Assembly
        //};

        /// <summary>
        /// Fill the Binding Factory Registry with bindings from the support library.
        /// </summary>
        protected override void FillTargetFactories(IMvxTargetBindingFactoryRegistry registry)
        {
            MvxAppCompatSetupHelper.FillTargetFactories(registry);
            base.FillTargetFactories(registry);
        }

        /// <summary>
        /// This is very important to override. The default view presenter does not know how to show fragments!
        /// </summary>
        //protected override IMvxAndroidViewPresenter CreateViewPresenter()
        //{
        //    var mvxFragmentsPresenter = new MvxFragmentsPresenter(AndroidViewAssemblies);
        //    Mvx.RegisterSingleton<IMvxAndroidViewPresenter>(mvxFragmentsPresenter);

        //    return mvxFragmentsPresenter;
        //}

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

        private void RegisterDependencies()
        {
            //Mvx.ConstructAndRegisterSingleton<IMyService, MyService>();
        }
    }
}

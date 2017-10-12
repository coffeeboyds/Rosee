using System;
using Android.Widget;
using MvvmCross.Binding.Droid.Target;
using MvvmCross.Binding;
using Android.Graphics;

namespace Rosee.Droid.CustomBindings
{
    public class StyleTextViewBinding : MvxAndroidTargetBinding
    {
        readonly TextView _textView;

        public StyleTextViewBinding(TextView textView) : base(textView)
        {
            _textView = textView;
        }

        #region implemented abstract members of MvxConvertingTargetBinding
        protected override void SetValueImpl(object target, object value)
        {
            var font = Typeface.CreateFromAsset(_textView.Context.Assets, value.ToString());
            _textView.Typeface = font;
        }
        #endregion

        public override Type TargetType
        {
            get { return typeof(string); }
        }

        public override MvxBindingMode DefaultMode
        {
            get { return MvxBindingMode.OneWay; }
        }
    }
}
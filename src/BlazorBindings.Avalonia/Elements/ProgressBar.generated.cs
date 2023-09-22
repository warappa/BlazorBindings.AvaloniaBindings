// <auto-generated>
//     This code was generated by a BlazorBindings.Avalonia component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>



#pragma warning disable CA2252

namespace BlazorBindings.AvaloniaBindings.Elements
{
    /// <summary>
    /// A control used to indicate the progress of an operation.
    /// </summary>
    public partial class ProgressBar : BlazorBindings.AvaloniaBindings.Elements.Primitives.RangeBase
    {
        static ProgressBar()
        {
            RegisterAdditionalHandlers();
        }

        /// <summary>
        /// Gets or sets a value indicating whether the progress bar shows the actual value or a generic, continues progress indicator (indeterminate state).
        /// </summary>
        [Parameter] public bool? IsIndeterminate { get; set; }
        /// <summary>
        /// Gets or sets the orientation of the <see cref="T:Avalonia.Controls.ProgressBar" />.
        /// </summary>
        [Parameter] public global::Avalonia.Layout.Orientation? Orientation { get; set; }
        /// <summary>
        /// Gets or sets the format string applied to the internally calculated progress text before it is shown.
        /// </summary>
        [Parameter] public string ProgressTextFormat { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether progress text will be shown.
        /// </summary>
        [Parameter] public bool? ShowProgressText { get; set; }

        public new AC.ProgressBar NativeControl => (AC.ProgressBar)((BindableObject)this).NativeControl;

        protected override AC.ProgressBar CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(IsIndeterminate):
                    if (!Equals(IsIndeterminate, value))
                    {
                        IsIndeterminate = (bool?)value;
                        NativeControl.IsIndeterminate = IsIndeterminate ?? (bool)AC.ProgressBar.IsIndeterminateProperty.GetDefaultValue(AC.ProgressBar.IsIndeterminateProperty.OwnerType);
                    }
                    break;
                case nameof(Orientation):
                    if (!Equals(Orientation, value))
                    {
                        Orientation = (global::Avalonia.Layout.Orientation?)value;
                        NativeControl.Orientation = Orientation ?? (global::Avalonia.Layout.Orientation)AC.ProgressBar.OrientationProperty.GetDefaultValue(AC.ProgressBar.OrientationProperty.OwnerType);
                    }
                    break;
                case nameof(ProgressTextFormat):
                    if (!Equals(ProgressTextFormat, value))
                    {
                        ProgressTextFormat = (string)value;
                        NativeControl.ProgressTextFormat = ProgressTextFormat;
                    }
                    break;
                case nameof(ShowProgressText):
                    if (!Equals(ShowProgressText, value))
                    {
                        ShowProgressText = (bool?)value;
                        NativeControl.ShowProgressText = ShowProgressText ?? (bool)AC.ProgressBar.ShowProgressTextProperty.GetDefaultValue(AC.ProgressBar.ShowProgressTextProperty.OwnerType);
                    }
                    break;

                default:
                    base.HandleParameter(name, value);
                    break;
            }
        }

        static partial void RegisterAdditionalHandlers();
    }
}

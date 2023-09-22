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
    /// A Toggle Switch control.
    /// </summary>
    public partial class ToggleSwitch : BlazorBindings.AvaloniaBindings.Elements.Primitives.ToggleButton
    {
        static ToggleSwitch()
        {
            RegisterAdditionalHandlers();
        }

        /// <summary>
        /// Gets or Sets the <see cref="T:Avalonia.Animation.Transitions" /> of switching knob.
        /// </summary>
        [Parameter] public global::Avalonia.Animation.Transitions KnobTransitions { get; set; }
        /// <summary>
        /// Gets or Sets the Content that is displayed when in the Off State.
        /// </summary>
        [Parameter] public object OffContent { get; set; }
        /// <summary>
        /// Gets or Sets the <see cref="T:Avalonia.Controls.Templates.IDataTemplate" /> used to display the <see cref="P:Avalonia.Controls.ToggleSwitch.OffContent" />.
        /// </summary>
        [Parameter] public AC.Templates.IDataTemplate OffContentTemplate { get; set; }
        /// <summary>
        /// Gets or Sets the Content that is displayed when in the On State.
        /// </summary>
        [Parameter] public object OnContent { get; set; }
        /// <summary>
        /// Gets or Sets the <see cref="T:Avalonia.Controls.Templates.IDataTemplate" /> used to display the <see cref="P:Avalonia.Controls.ToggleSwitch.OnContent" />.
        /// </summary>
        [Parameter] public AC.Templates.IDataTemplate OnContentTemplate { get; set; }

        public new AC.ToggleSwitch NativeControl => (AC.ToggleSwitch)((BindableObject)this).NativeControl;

        protected override AC.ToggleSwitch CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(KnobTransitions):
                    if (!Equals(KnobTransitions, value))
                    {
                        KnobTransitions = (global::Avalonia.Animation.Transitions)value;
                        NativeControl.KnobTransitions = KnobTransitions;
                    }
                    break;
                case nameof(OffContent):
                    if (!Equals(OffContent, value))
                    {
                        OffContent = (object)value;
                        NativeControl.OffContent = OffContent;
                    }
                    break;
                case nameof(OffContentTemplate):
                    if (!Equals(OffContentTemplate, value))
                    {
                        OffContentTemplate = (AC.Templates.IDataTemplate)value;
                        NativeControl.OffContentTemplate = OffContentTemplate;
                    }
                    break;
                case nameof(OnContent):
                    if (!Equals(OnContent, value))
                    {
                        OnContent = (object)value;
                        NativeControl.OnContent = OnContent;
                    }
                    break;
                case nameof(OnContentTemplate):
                    if (!Equals(OnContentTemplate, value))
                    {
                        OnContentTemplate = (AC.Templates.IDataTemplate)value;
                        NativeControl.OnContentTemplate = OnContentTemplate;
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

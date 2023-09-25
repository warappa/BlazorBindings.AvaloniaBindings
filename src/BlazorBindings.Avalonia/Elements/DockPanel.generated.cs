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
    /// A panel which arranges its children at the top, bottom, left, right or center.
    /// </summary>
    public partial class DockPanel : Panel
    {
        static DockPanel()
        {
            RegisterAdditionalHandlers();
        }

        /// <summary>
        /// Gets or sets a value which indicates whether the last child of the <see cref="T:Avalonia.Controls.DockPanel" /> fills the remaining space in the panel.
        /// </summary>
        [Parameter] public bool? LastChildFill { get; set; }

        public new AC.DockPanel NativeControl => (AC.DockPanel)((BindableObject)this).NativeControl;

        protected override AC.DockPanel CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(LastChildFill):
                    if (!Equals(LastChildFill, value))
                    {
                        LastChildFill = (bool?)value;
                        NativeControl.LastChildFill = LastChildFill ?? (bool)AC.DockPanel.LastChildFillProperty.GetDefaultValue(AC.DockPanel.LastChildFillProperty.OwnerType);
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
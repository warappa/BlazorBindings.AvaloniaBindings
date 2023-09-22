// <auto-generated>
//     This code was generated by a BlazorBindings.Avalonia component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using AM = Avalonia.Media;
using BlazorBindings.AvaloniaBindings.Elements;

#pragma warning disable CA2252

namespace BlazorBindings.AvaloniaBindings.Elements.Media
{
    /// <summary>
    /// Describes how an area is painted.
    /// </summary>
    public abstract partial class Brush : BlazorBindings.AvaloniaBindings.Elements.Animation.Animatable
    {
        static Brush()
        {
            RegisterAdditionalHandlers();
        }

        /// <summary>
        /// Gets or sets the opacity of the brush.
        /// </summary>
        [Parameter] public double? Opacity { get; set; }
        /// <summary>
        /// Gets or sets the transform of the brush.
        /// </summary>
        [Parameter] public AM.ITransform Transform { get; set; }
        /// <summary>
        /// Gets or sets the origin of the brush <see cref="P:Avalonia.Media.Brush.Transform" />
        /// </summary>
        [Parameter] public global::Avalonia.RelativePoint? TransformOrigin { get; set; }

        public new AM.Brush NativeControl => (AM.Brush)((BindableObject)this).NativeControl;


        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(Opacity):
                    if (!Equals(Opacity, value))
                    {
                        Opacity = (double?)value;
                        NativeControl.Opacity = Opacity ?? (double)AM.Brush.OpacityProperty.GetDefaultValue(AM.Brush.OpacityProperty.OwnerType);
                    }
                    break;
                case nameof(Transform):
                    if (!Equals(Transform, value))
                    {
                        Transform = (AM.ITransform)value;
                        NativeControl.Transform = Transform;
                    }
                    break;
                case nameof(TransformOrigin):
                    if (!Equals(TransformOrigin, value))
                    {
                        TransformOrigin = (global::Avalonia.RelativePoint?)value;
                        NativeControl.TransformOrigin = TransformOrigin ?? (global::Avalonia.RelativePoint)AM.Brush.TransformOriginProperty.GetDefaultValue(AM.Brush.TransformOriginProperty.OwnerType);
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

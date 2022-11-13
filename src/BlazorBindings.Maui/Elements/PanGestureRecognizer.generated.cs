// <auto-generated>
//     This code was generated by a BlazorBindings.Maui component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using BlazorBindings.Core;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BlazorBindings.Maui.Elements
{
    public partial class PanGestureRecognizer : GestureRecognizer
    {
        static PanGestureRecognizer()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public int? TouchPoints { get; set; }
        [Parameter] public EventCallback<MC.PanUpdatedEventArgs> OnPanUpdated { get; set; }

        public new MC.PanGestureRecognizer NativeControl => (MC.PanGestureRecognizer)((BindableObject)this).NativeControl;

        protected override MC.PanGestureRecognizer CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(TouchPoints):
                    if (!Equals(TouchPoints, value))
                    {
                        TouchPoints = (int?)value;
                        NativeControl.TouchPoints = TouchPoints ?? (int)MC.PanGestureRecognizer.TouchPointsProperty.DefaultValue;
                    }
                    break;
                case nameof(OnPanUpdated):
                    if (!Equals(OnPanUpdated, value))
                    {
                        void NativeControlPanUpdated(object sender, MC.PanUpdatedEventArgs e) => InvokeEventCallback(OnPanUpdated, e);

                        OnPanUpdated = (EventCallback<MC.PanUpdatedEventArgs>)value;
                        NativeControl.PanUpdated -= NativeControlPanUpdated;
                        NativeControl.PanUpdated += NativeControlPanUpdated;
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
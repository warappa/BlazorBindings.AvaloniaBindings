// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using AC = AlohaKit.Controls;
using BlazorBindings.Core;
using BlazorBindings.Maui.Elements;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BlazorBindings.Maui.Elements.AlohaKit
{
    public partial class Slider : BlazorBindings.Maui.Elements.GraphicsView
    {
        static Slider()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public double Maximum { get; set; }
        [Parameter] public double Minimum { get; set; }
        [Parameter] public AC.SliderDrawable SliderDrawable { get; set; }
        [Parameter] public double Value { get; set; }
        [Parameter] public EventCallback<double> ValueChanged { get; set; }

        public new AC.Slider NativeControl => (AC.Slider)((Element)this).NativeControl;

        protected override MC.Element CreateNativeElement() => new AC.Slider();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(Maximum):
                    if (!Equals(Maximum, value))
                    {
                        Maximum = (double)value;
                        NativeControl.Maximum = Maximum;
                    }
                    break;
                case nameof(Minimum):
                    if (!Equals(Minimum, value))
                    {
                        Minimum = (double)value;
                        NativeControl.Minimum = Minimum;
                    }
                    break;
                case nameof(SliderDrawable):
                    if (!Equals(SliderDrawable, value))
                    {
                        SliderDrawable = (AC.SliderDrawable)value;
                        NativeControl.SliderDrawable = SliderDrawable;
                    }
                    break;
                case nameof(Value):
                    if (!Equals(Value, value))
                    {
                        Value = (double)value;
                        NativeControl.Value = Value;
                    }
                    break;
                case nameof(ValueChanged):
                    if (!Equals(ValueChanged, value))
                    {
                        void NativeControlValueChanged(object sender, MC.ValueChangedEventArgs e) => ValueChanged.InvokeAsync(NativeControl.Value);

                        ValueChanged = (EventCallback<double>)value;
                        NativeControl.ValueChanged -= NativeControlValueChanged;
                        NativeControl.ValueChanged += NativeControlValueChanged;
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

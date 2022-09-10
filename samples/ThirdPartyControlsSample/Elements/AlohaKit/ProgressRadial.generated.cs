//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a BlazorBindings.Maui component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AC = AlohaKit.Controls;
using BlazorBindings.Core;
using BlazorBindings.Maui.Elements;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using Microsoft.Maui.Graphics;
using System.Threading.Tasks;

namespace BlazorBindings.Maui.Elements.AlohaKit
{
    public partial class ProgressRadial : BlazorBindings.Maui.Elements.GraphicsView
    {
        static ProgressRadial()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public AC.ProgressRadialDirection Direction { get; set; }
        [Parameter] public double FontSize { get; set; }
        [Parameter] public int Maximum { get; set; }
        [Parameter] public int Minimum { get; set; }
        [Parameter] public Color ProgressColor { get; set; }
        [Parameter] public AC.ProgressRadialDrawable ProgressRadialDrawable { get; set; }
        [Parameter] public Color StrokeColor { get; set; }
        [Parameter] public Color TextColor { get; set; }
        [Parameter] public int Value { get; set; }
        [Parameter] public EventCallback<int> ValueChanged { get; set; }

        public new AC.ProgressRadial NativeControl => (AC.ProgressRadial)((Element)this).NativeControl;

        protected override MC.Element CreateNativeElement() => new AC.ProgressRadial();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(Direction):
                    if (!Equals(Direction, value))
                    {
                        Direction = (AC.ProgressRadialDirection)value;
                        NativeControl.Direction = Direction;
                    }
                    break;
                case nameof(FontSize):
                    if (!Equals(FontSize, value))
                    {
                        FontSize = (double)value;
                        NativeControl.FontSize = FontSize;
                    }
                    break;
                case nameof(Maximum):
                    if (!Equals(Maximum, value))
                    {
                        Maximum = (int)value;
                        NativeControl.Maximum = Maximum;
                    }
                    break;
                case nameof(Minimum):
                    if (!Equals(Minimum, value))
                    {
                        Minimum = (int)value;
                        NativeControl.Minimum = Minimum;
                    }
                    break;
                case nameof(ProgressColor):
                    if (!Equals(ProgressColor, value))
                    {
                        ProgressColor = (Color)value;
                        NativeControl.ProgressColor = ProgressColor;
                    }
                    break;
                case nameof(ProgressRadialDrawable):
                    if (!Equals(ProgressRadialDrawable, value))
                    {
                        ProgressRadialDrawable = (AC.ProgressRadialDrawable)value;
                        NativeControl.ProgressRadialDrawable = ProgressRadialDrawable;
                    }
                    break;
                case nameof(StrokeColor):
                    if (!Equals(StrokeColor, value))
                    {
                        StrokeColor = (Color)value;
                        NativeControl.StrokeColor = StrokeColor;
                    }
                    break;
                case nameof(TextColor):
                    if (!Equals(TextColor, value))
                    {
                        TextColor = (Color)value;
                        NativeControl.TextColor = TextColor;
                    }
                    break;
                case nameof(Value):
                    if (!Equals(Value, value))
                    {
                        Value = (int)value;
                        NativeControl.Value = Value;
                    }
                    break;
                case nameof(ValueChanged):
                    if (!Equals(ValueChanged, value))
                    {
                        void NativeControlValueChanged(object sender, MC.ValueChangedEventArgs e) => ValueChanged.InvokeAsync(NativeControl.Value);

                        ValueChanged = (EventCallback<int>)value;
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
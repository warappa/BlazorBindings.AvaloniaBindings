// <auto-generated>
//     This code was generated by a BlazorBindings.Maui component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using BlazorBindings.Core;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using Microsoft.Maui;
using System;
using System.Threading.Tasks;

namespace BlazorBindings.Maui.Elements
{
    public partial class Editor : InputView
    {
        static Editor()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public MC.EditorAutoSizeOption? AutoSize { get; set; }
        [Parameter] public int? CursorPosition { get; set; }
        [Parameter] public MC.FontAttributes? FontAttributes { get; set; }
        [Parameter] public bool? FontAutoScalingEnabled { get; set; }
        [Parameter] public string FontFamily { get; set; }
        [Parameter] public double? FontSize { get; set; }
        [Parameter] public TextAlignment? HorizontalTextAlignment { get; set; }
        [Parameter] public bool? IsTextPredictionEnabled { get; set; }
        [Parameter] public int? SelectionLength { get; set; }
        [Parameter] public TextAlignment? VerticalTextAlignment { get; set; }
        [Parameter] public EventCallback OnCompleted { get; set; }

        public new MC.Editor NativeControl => (MC.Editor)((BindableObject)this).NativeControl;

        protected override MC.Editor CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(AutoSize):
                    if (!Equals(AutoSize, value))
                    {
                        AutoSize = (MC.EditorAutoSizeOption?)value;
                        NativeControl.AutoSize = AutoSize ?? (MC.EditorAutoSizeOption)MC.Editor.AutoSizeProperty.DefaultValue;
                    }
                    break;
                case nameof(CursorPosition):
                    if (!Equals(CursorPosition, value))
                    {
                        CursorPosition = (int?)value;
                        NativeControl.CursorPosition = CursorPosition ?? (int)MC.Editor.CursorPositionProperty.DefaultValue;
                    }
                    break;
                case nameof(FontAttributes):
                    if (!Equals(FontAttributes, value))
                    {
                        FontAttributes = (MC.FontAttributes?)value;
                        NativeControl.FontAttributes = FontAttributes ?? (MC.FontAttributes)MC.Editor.FontAttributesProperty.DefaultValue;
                    }
                    break;
                case nameof(FontAutoScalingEnabled):
                    if (!Equals(FontAutoScalingEnabled, value))
                    {
                        FontAutoScalingEnabled = (bool?)value;
                        NativeControl.FontAutoScalingEnabled = FontAutoScalingEnabled ?? (bool)MC.Editor.FontAutoScalingEnabledProperty.DefaultValue;
                    }
                    break;
                case nameof(FontFamily):
                    if (!Equals(FontFamily, value))
                    {
                        FontFamily = (string)value;
                        NativeControl.FontFamily = FontFamily;
                    }
                    break;
                case nameof(FontSize):
                    if (!Equals(FontSize, value))
                    {
                        FontSize = (double?)value;
                        NativeControl.FontSize = FontSize ?? (double)MC.Editor.FontSizeProperty.DefaultValue;
                    }
                    break;
                case nameof(HorizontalTextAlignment):
                    if (!Equals(HorizontalTextAlignment, value))
                    {
                        HorizontalTextAlignment = (TextAlignment?)value;
                        NativeControl.HorizontalTextAlignment = HorizontalTextAlignment ?? (TextAlignment)MC.Editor.HorizontalTextAlignmentProperty.DefaultValue;
                    }
                    break;
                case nameof(IsTextPredictionEnabled):
                    if (!Equals(IsTextPredictionEnabled, value))
                    {
                        IsTextPredictionEnabled = (bool?)value;
                        NativeControl.IsTextPredictionEnabled = IsTextPredictionEnabled ?? (bool)MC.Editor.IsTextPredictionEnabledProperty.DefaultValue;
                    }
                    break;
                case nameof(SelectionLength):
                    if (!Equals(SelectionLength, value))
                    {
                        SelectionLength = (int?)value;
                        NativeControl.SelectionLength = SelectionLength ?? (int)MC.Editor.SelectionLengthProperty.DefaultValue;
                    }
                    break;
                case nameof(VerticalTextAlignment):
                    if (!Equals(VerticalTextAlignment, value))
                    {
                        VerticalTextAlignment = (TextAlignment?)value;
                        NativeControl.VerticalTextAlignment = VerticalTextAlignment ?? (TextAlignment)MC.Editor.VerticalTextAlignmentProperty.DefaultValue;
                    }
                    break;
                case nameof(OnCompleted):
                    if (!Equals(OnCompleted, value))
                    {
                        void NativeControlCompleted(object sender, EventArgs e) => InvokeAsync(() => OnCompleted.InvokeAsync());

                        OnCompleted = (EventCallback)value;
                        NativeControl.Completed -= NativeControlCompleted;
                        NativeControl.Completed += NativeControlCompleted;
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

// <auto-generated>
//     This code was generated by a BlazorBindings.Maui component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using BlazorBindings.Core;
using BlazorBindings.Maui.Elements;
using MC = Microsoft.Maui.Controls;
using MCM = Material.Components.Maui;
using Microsoft.AspNetCore.Components;
using Microsoft.Maui.Graphics;
using System.Threading.Tasks;

#pragma warning disable CA2252

namespace BlazorBindings.Maui.Elements.Material.Components
{
    public partial class MDTextField : SKTouchCanvasView
    {
        static MDTextField()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public Color ActiveIndicatorColor { get; set; }
        [Parameter] public int? ActiveIndicatorHeight { get; set; }
        [Parameter] public float? ActiveIndicatorOpacity { get; set; }
        [Parameter] public Color BackgroundColour { get; set; }
        [Parameter] public Color CaretColor { get; set; }
        [Parameter] public int? CaretPosition { get; set; }
        [Parameter] public string FontFamily { get; set; }
        [Parameter] public bool? FontItalic { get; set; }
        [Parameter] public float? FontSize { get; set; }
        [Parameter] public int? FontWeight { get; set; }
        [Parameter] public Color ForegroundColor { get; set; }
        [Parameter] public string IconData { get; set; }
        [Parameter] public global::IconPacks.Material.IconKind? IconKind { get; set; }
        [Parameter] public global::SkiaSharp.SKPicture IconSource { get; set; }
        [Parameter] public bool? InternalFocus { get; set; }
        [Parameter] public bool? IsError { get; set; }
        [Parameter] public bool? IsOutline { get; set; }
        [Parameter] public string LabelText { get; set; }
        [Parameter] public Color LabelTextColor { get; set; }
        [Parameter] public float? LabelTextOpacity { get; set; }
        [Parameter] public Color OutlineColor { get; set; }
        [Parameter] public int? OutlineWidth { get; set; }
        [Parameter] public global::Topten.RichTextKit.TextRange? SelectionTextRange { get; set; }
        [Parameter] public MCM.Tokens.Shape? Shape { get; set; }
        [Parameter] public Color StateLayerColor { get; set; }
        [Parameter] public string SupportingText { get; set; }
        [Parameter] public Color SupportingTextColor { get; set; }
        [Parameter] public float? SupportingTextOpacity { get; set; }
        [Parameter] public string Text { get; set; }
        [Parameter] public Color TrailingIconColor { get; set; }
        [Parameter] public string TrailingIconData { get; set; }
        [Parameter] public global::IconPacks.Material.IconKind? TrailingIconKind { get; set; }
        [Parameter] public global::SkiaSharp.SKPicture TrailingIconSource { get; set; }
        [Parameter] public EventCallback<string> TextChanged { get; set; }
        [Parameter] public EventCallback<global::SkiaSharp.Views.Maui.SKTouchEventArgs> OnTrailingIconClicked { get; set; }

        public new MCM.TextField NativeControl => (MCM.TextField)((BindableObject)this).NativeControl;

        protected override MCM.TextField CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(ActiveIndicatorColor):
                    if (!Equals(ActiveIndicatorColor, value))
                    {
                        ActiveIndicatorColor = (Color)value;
                        NativeControl.ActiveIndicatorColor = ActiveIndicatorColor;
                    }
                    break;
                case nameof(ActiveIndicatorHeight):
                    if (!Equals(ActiveIndicatorHeight, value))
                    {
                        ActiveIndicatorHeight = (int?)value;
                        NativeControl.ActiveIndicatorHeight = ActiveIndicatorHeight ?? (int)MCM.TextField.ActiveIndicatorHeightProperty.DefaultValue;
                    }
                    break;
                case nameof(ActiveIndicatorOpacity):
                    if (!Equals(ActiveIndicatorOpacity, value))
                    {
                        ActiveIndicatorOpacity = (float?)value;
                        NativeControl.ActiveIndicatorOpacity = ActiveIndicatorOpacity ?? (float)MCM.TextField.ActiveIndicatorOpacityProperty.DefaultValue;
                    }
                    break;
                case nameof(BackgroundColour):
                    if (!Equals(BackgroundColour, value))
                    {
                        BackgroundColour = (Color)value;
                        NativeControl.BackgroundColour = BackgroundColour;
                    }
                    break;
                case nameof(CaretColor):
                    if (!Equals(CaretColor, value))
                    {
                        CaretColor = (Color)value;
                        NativeControl.CaretColor = CaretColor;
                    }
                    break;
                case nameof(CaretPosition):
                    if (!Equals(CaretPosition, value))
                    {
                        CaretPosition = (int?)value;
                        NativeControl.CaretPosition = CaretPosition ?? (int)MCM.TextField.CaretPositionProperty.DefaultValue;
                    }
                    break;
                case nameof(FontFamily):
                    if (!Equals(FontFamily, value))
                    {
                        FontFamily = (string)value;
                        NativeControl.FontFamily = FontFamily;
                    }
                    break;
                case nameof(FontItalic):
                    if (!Equals(FontItalic, value))
                    {
                        FontItalic = (bool?)value;
                        NativeControl.FontItalic = FontItalic ?? (bool)MCM.TextField.FontItalicProperty.DefaultValue;
                    }
                    break;
                case nameof(FontSize):
                    if (!Equals(FontSize, value))
                    {
                        FontSize = (float?)value;
                        NativeControl.FontSize = FontSize ?? (float)MCM.TextField.FontSizeProperty.DefaultValue;
                    }
                    break;
                case nameof(FontWeight):
                    if (!Equals(FontWeight, value))
                    {
                        FontWeight = (int?)value;
                        NativeControl.FontWeight = FontWeight ?? (int)MCM.TextField.FontWeightProperty.DefaultValue;
                    }
                    break;
                case nameof(ForegroundColor):
                    if (!Equals(ForegroundColor, value))
                    {
                        ForegroundColor = (Color)value;
                        NativeControl.ForegroundColor = ForegroundColor;
                    }
                    break;
                case nameof(IconData):
                    if (!Equals(IconData, value))
                    {
                        IconData = (string)value;
                        NativeControl.IconData = IconData;
                    }
                    break;
                case nameof(IconKind):
                    if (!Equals(IconKind, value))
                    {
                        IconKind = (global::IconPacks.Material.IconKind?)value;
                        NativeControl.IconKind = IconKind ?? (global::IconPacks.Material.IconKind)MCM.TextField.IconKindProperty.DefaultValue;
                    }
                    break;
                case nameof(IconSource):
                    if (!Equals(IconSource, value))
                    {
                        IconSource = (global::SkiaSharp.SKPicture)value;
                        NativeControl.IconSource = IconSource;
                    }
                    break;
                case nameof(InternalFocus):
                    if (!Equals(InternalFocus, value))
                    {
                        InternalFocus = (bool?)value;
                        NativeControl.InternalFocus = InternalFocus ?? (bool)MCM.TextField.InternalFocusProperty.DefaultValue;
                    }
                    break;
                case nameof(IsError):
                    if (!Equals(IsError, value))
                    {
                        IsError = (bool?)value;
                        NativeControl.IsError = IsError ?? (bool)MCM.TextField.IsErrorProperty.DefaultValue;
                    }
                    break;
                case nameof(IsOutline):
                    if (!Equals(IsOutline, value))
                    {
                        IsOutline = (bool?)value;
                        NativeControl.IsOutline = IsOutline ?? (bool)MCM.TextField.IsOutlineProperty.DefaultValue;
                    }
                    break;
                case nameof(LabelText):
                    if (!Equals(LabelText, value))
                    {
                        LabelText = (string)value;
                        NativeControl.LabelText = LabelText;
                    }
                    break;
                case nameof(LabelTextColor):
                    if (!Equals(LabelTextColor, value))
                    {
                        LabelTextColor = (Color)value;
                        NativeControl.LabelTextColor = LabelTextColor;
                    }
                    break;
                case nameof(LabelTextOpacity):
                    if (!Equals(LabelTextOpacity, value))
                    {
                        LabelTextOpacity = (float?)value;
                        NativeControl.LabelTextOpacity = LabelTextOpacity ?? (float)MCM.TextField.LabelTextOpacityProperty.DefaultValue;
                    }
                    break;
                case nameof(OutlineColor):
                    if (!Equals(OutlineColor, value))
                    {
                        OutlineColor = (Color)value;
                        NativeControl.OutlineColor = OutlineColor;
                    }
                    break;
                case nameof(OutlineWidth):
                    if (!Equals(OutlineWidth, value))
                    {
                        OutlineWidth = (int?)value;
                        NativeControl.OutlineWidth = OutlineWidth ?? (int)MCM.TextField.OutlineWidthProperty.DefaultValue;
                    }
                    break;
                case nameof(SelectionTextRange):
                    if (!Equals(SelectionTextRange, value))
                    {
                        SelectionTextRange = (global::Topten.RichTextKit.TextRange?)value;
                        NativeControl.SelectionTextRange = SelectionTextRange ?? (global::Topten.RichTextKit.TextRange)MCM.TextField.SelectionTextRangeProperty.DefaultValue;
                    }
                    break;
                case nameof(Shape):
                    if (!Equals(Shape, value))
                    {
                        Shape = (MCM.Tokens.Shape?)value;
                        NativeControl.Shape = Shape ?? (MCM.Tokens.Shape)MCM.TextField.ShapeProperty.DefaultValue;
                    }
                    break;
                case nameof(StateLayerColor):
                    if (!Equals(StateLayerColor, value))
                    {
                        StateLayerColor = (Color)value;
                        NativeControl.StateLayerColor = StateLayerColor;
                    }
                    break;
                case nameof(SupportingText):
                    if (!Equals(SupportingText, value))
                    {
                        SupportingText = (string)value;
                        NativeControl.SupportingText = SupportingText;
                    }
                    break;
                case nameof(SupportingTextColor):
                    if (!Equals(SupportingTextColor, value))
                    {
                        SupportingTextColor = (Color)value;
                        NativeControl.SupportingTextColor = SupportingTextColor;
                    }
                    break;
                case nameof(SupportingTextOpacity):
                    if (!Equals(SupportingTextOpacity, value))
                    {
                        SupportingTextOpacity = (float?)value;
                        NativeControl.SupportingTextOpacity = SupportingTextOpacity ?? (float)MCM.TextField.SupportingTextOpacityProperty.DefaultValue;
                    }
                    break;
                case nameof(Text):
                    if (!Equals(Text, value))
                    {
                        Text = (string)value;
                        NativeControl.Text = Text;
                    }
                    break;
                case nameof(TrailingIconColor):
                    if (!Equals(TrailingIconColor, value))
                    {
                        TrailingIconColor = (Color)value;
                        NativeControl.TrailingIconColor = TrailingIconColor;
                    }
                    break;
                case nameof(TrailingIconData):
                    if (!Equals(TrailingIconData, value))
                    {
                        TrailingIconData = (string)value;
                        NativeControl.TrailingIconData = TrailingIconData;
                    }
                    break;
                case nameof(TrailingIconKind):
                    if (!Equals(TrailingIconKind, value))
                    {
                        TrailingIconKind = (global::IconPacks.Material.IconKind?)value;
                        NativeControl.TrailingIconKind = TrailingIconKind ?? (global::IconPacks.Material.IconKind)MCM.TextField.TrailingIconKindProperty.DefaultValue;
                    }
                    break;
                case nameof(TrailingIconSource):
                    if (!Equals(TrailingIconSource, value))
                    {
                        TrailingIconSource = (global::SkiaSharp.SKPicture)value;
                        NativeControl.TrailingIconSource = TrailingIconSource;
                    }
                    break;
                case nameof(TextChanged):
                    if (!Equals(TextChanged, value))
                    {
                        void NativeControlTextChanged(object sender, MC.TextChangedEventArgs e)
                        {
                            var value = NativeControl.Text;
                            Text = value;
                            InvokeEventCallback(TextChanged, value);
                        }

                        TextChanged = (EventCallback<string>)value;
                        NativeControl.TextChanged -= NativeControlTextChanged;
                        NativeControl.TextChanged += NativeControlTextChanged;
                    }
                    break;
                case nameof(OnTrailingIconClicked):
                    if (!Equals(OnTrailingIconClicked, value))
                    {
                        void NativeControlTrailingIconClicked(object sender, global::SkiaSharp.Views.Maui.SKTouchEventArgs e) => InvokeEventCallback(OnTrailingIconClicked, e);

                        OnTrailingIconClicked = (EventCallback<global::SkiaSharp.Views.Maui.SKTouchEventArgs>)value;
                        NativeControl.TrailingIconClicked -= NativeControlTrailingIconClicked;
                        NativeControl.TrailingIconClicked += NativeControlTrailingIconClicked;
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

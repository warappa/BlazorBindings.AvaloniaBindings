// <auto-generated>
//     This code was generated by a BlazorBindings.Maui component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using BlazorBindings.Core;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace BlazorBindings.Maui.Elements
{
    public partial class BaseShellItem : NavigableElement
    {
        static BaseShellItem()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public MC.ImageSource FlyoutIcon { get; set; }
        [Parameter] public bool? FlyoutItemIsVisible { get; set; }
        [Parameter] public MC.ImageSource Icon { get; set; }
        [Parameter] public bool? IsEnabled { get; set; }
        [Parameter] public bool? IsVisible { get; set; }
        [Parameter] public string Route { get; set; }
        [Parameter] public string Title { get; set; }
        [Parameter] public EventCallback OnAppearing { get; set; }
        [Parameter] public EventCallback OnDisappearing { get; set; }

        public new MC.BaseShellItem NativeControl => (MC.BaseShellItem)((BindableObject)this).NativeControl;

        protected override MC.BaseShellItem CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(FlyoutIcon):
                    if (!Equals(FlyoutIcon, value))
                    {
                        FlyoutIcon = (MC.ImageSource)value;
                        NativeControl.FlyoutIcon = FlyoutIcon;
                    }
                    break;
                case nameof(FlyoutItemIsVisible):
                    if (!Equals(FlyoutItemIsVisible, value))
                    {
                        FlyoutItemIsVisible = (bool?)value;
                        NativeControl.FlyoutItemIsVisible = FlyoutItemIsVisible ?? default;
                    }
                    break;
                case nameof(Icon):
                    if (!Equals(Icon, value))
                    {
                        Icon = (MC.ImageSource)value;
                        NativeControl.Icon = Icon;
                    }
                    break;
                case nameof(IsEnabled):
                    if (!Equals(IsEnabled, value))
                    {
                        IsEnabled = (bool?)value;
                        NativeControl.IsEnabled = IsEnabled ?? (bool)MC.BaseShellItem.IsEnabledProperty.DefaultValue;
                    }
                    break;
                case nameof(IsVisible):
                    if (!Equals(IsVisible, value))
                    {
                        IsVisible = (bool?)value;
                        NativeControl.IsVisible = IsVisible ?? (bool)MC.BaseShellItem.IsVisibleProperty.DefaultValue;
                    }
                    break;
                case nameof(Route):
                    if (!Equals(Route, value))
                    {
                        Route = (string)value;
                        NativeControl.Route = Route;
                    }
                    break;
                case nameof(Title):
                    if (!Equals(Title, value))
                    {
                        Title = (string)value;
                        NativeControl.Title = Title;
                    }
                    break;
                case nameof(OnAppearing):
                    if (!Equals(OnAppearing, value))
                    {
                        void NativeControlAppearing(object sender, EventArgs e) => InvokeAsync(() => OnAppearing.InvokeAsync());

                        OnAppearing = (EventCallback)value;
                        NativeControl.Appearing -= NativeControlAppearing;
                        NativeControl.Appearing += NativeControlAppearing;
                    }
                    break;
                case nameof(OnDisappearing):
                    if (!Equals(OnDisappearing, value))
                    {
                        void NativeControlDisappearing(object sender, EventArgs e) => InvokeAsync(() => OnDisappearing.InvokeAsync());

                        OnDisappearing = (EventCallback)value;
                        NativeControl.Disappearing -= NativeControlDisappearing;
                        NativeControl.Disappearing += NativeControlDisappearing;
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

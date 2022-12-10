// <auto-generated>
//     This code was generated by a BlazorBindings.Maui component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using BlazorBindings.Core;
using BlazorBindings.Maui.Elements.Handlers;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.Maui;
using System.Threading.Tasks;

namespace BlazorBindings.Maui.Elements
{
    /// <summary>
    /// An element capable of scrolling if its Content requires.
    /// </summary>
    public partial class ScrollView : BlazorBindings.Maui.Elements.Compatibility.Layout
    {
        static ScrollView()
        {
            ElementHandlerRegistry.RegisterPropertyContentHandler<ScrollView>(nameof(ChildContent),
                (renderer, parent, component) => new ContentPropertyHandler<MC.ScrollView>((x, value) => x.Content = (MC.View)value));
            RegisterAdditionalHandlers();
        }

        /// <summary>
        /// Gets or sets a value that controls when the horizontal scroll bar is visible.
        /// </summary>
        /// <value>
        /// A value that controls when the horizontal scroll bar is visible.
        /// </value>
        [Parameter] public ScrollBarVisibility? HorizontalScrollBarVisibility { get; set; }
        /// <summary>
        /// Gets or sets the scrolling direction of the ScrollView.
        /// </summary>
        [Parameter] public ScrollOrientation? Orientation { get; set; }
        /// <summary>
        /// Gets or sets a value that controls when the vertical scroll bar is visible.
        /// </summary>
        /// <value>
        /// A value that controls when the vertical scroll bar is visible.
        /// </value>
        [Parameter] public ScrollBarVisibility? VerticalScrollBarVisibility { get; set; }
        /// <summary>
        /// Gets or sets a <see cref="T:Microsoft.Maui.Controls.View" /> to display in the <see cref="T:Microsoft.Maui.Controls.ScrollView" />.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.Maui.Controls.View" /> that is displayed.
        /// </value>
        [Parameter] public RenderFragment ChildContent { get; set; }
        [Parameter] public EventCallback<MC.ScrolledEventArgs> OnScrolled { get; set; }

        public new MC.ScrollView NativeControl => (MC.ScrollView)((BindableObject)this).NativeControl;

        protected override MC.ScrollView CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(HorizontalScrollBarVisibility):
                    if (!Equals(HorizontalScrollBarVisibility, value))
                    {
                        HorizontalScrollBarVisibility = (ScrollBarVisibility?)value;
                        NativeControl.HorizontalScrollBarVisibility = HorizontalScrollBarVisibility ?? (ScrollBarVisibility)MC.ScrollView.HorizontalScrollBarVisibilityProperty.DefaultValue;
                    }
                    break;
                case nameof(Orientation):
                    if (!Equals(Orientation, value))
                    {
                        Orientation = (ScrollOrientation?)value;
                        NativeControl.Orientation = Orientation ?? (ScrollOrientation)MC.ScrollView.OrientationProperty.DefaultValue;
                    }
                    break;
                case nameof(VerticalScrollBarVisibility):
                    if (!Equals(VerticalScrollBarVisibility, value))
                    {
                        VerticalScrollBarVisibility = (ScrollBarVisibility?)value;
                        NativeControl.VerticalScrollBarVisibility = VerticalScrollBarVisibility ?? (ScrollBarVisibility)MC.ScrollView.VerticalScrollBarVisibilityProperty.DefaultValue;
                    }
                    break;
                case nameof(ChildContent):
                    ChildContent = (RenderFragment)value;
                    break;
                case nameof(OnScrolled):
                    if (!Equals(OnScrolled, value))
                    {
                        void NativeControlScrolled(object sender, MC.ScrolledEventArgs e) => InvokeEventCallback(OnScrolled, e);

                        OnScrolled = (EventCallback<MC.ScrolledEventArgs>)value;
                        NativeControl.Scrolled -= NativeControlScrolled;
                        NativeControl.Scrolled += NativeControlScrolled;
                    }
                    break;

                default:
                    base.HandleParameter(name, value);
                    break;
            }
        }

        protected override void RenderAdditionalElementContent(RenderTreeBuilder builder, ref int sequence)
        {
            base.RenderAdditionalElementContent(builder, ref sequence);
            RenderTreeBuilderHelper.AddContentProperty(builder, sequence++, typeof(ScrollView), ChildContent);
        }

        static partial void RegisterAdditionalHandlers();
    }
}

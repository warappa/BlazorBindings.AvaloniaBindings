// <auto-generated>
//     This code was generated by a BlazorBindings.Avalonia component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using ACP = Avalonia.Controls.Primitives;
using BlazorBindings.AvaloniaBindings.Elements;

#pragma warning disable CA2252

namespace BlazorBindings.AvaloniaBindings.Elements.Primitives
{
    /// <summary>
    /// An <see cref="T:Avalonia.Controls.ItemsControl" /> that maintains a selection.
    /// </summary>
    public partial class SelectingItemsControl<T> : BlazorBindings.AvaloniaBindings.Elements.ItemsControl<T>
    {
        static SelectingItemsControl()
        {
            RegisterAdditionalHandlers();
        }

        /// <summary>
        /// Gets or sets a value indicating whether to automatically scroll to newly selected items.
        /// </summary>
        [Parameter] public bool? AutoScrollToSelectedItem { get; set; }
        /// <summary>
        /// Gets or sets a value that specifies whether a user can jump to a value by typing.
        /// </summary>
        [Parameter] public bool? IsTextSearchEnabled { get; set; }
        /// <summary>
        /// Gets or sets the index of the selected item.
        /// </summary>
        [Parameter] public int? SelectedIndex { get; set; }
        /// <summary>
        /// Gets or sets the selected item.
        /// </summary>
        [Parameter] public object SelectedItem { get; set; }
        /// <summary>
        /// Gets or sets the value of the selected item, obtained using <see cref="P:Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueBinding" />
        /// </summary>
        [Parameter] public object SelectedValue { get; set; }
        /// <summary>
        /// Gets the <see cref="T:Avalonia.Data.IBinding" /> instance used to obtain the <see cref="P:Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValue" /> property
        /// </summary>
        [Parameter] public global::Avalonia.Data.IBinding SelectedValueBinding { get; set; }
        /// <summary>
        /// Gets or sets a value which indicates whether to wrap around when the first or last item is reached.
        /// </summary>
        [Parameter] public bool? WrapSelection { get; set; }
        [Parameter] public EventCallback<AC.SelectionChangedEventArgs> OnSelectionChanged { get; set; }

        public new ACP.SelectingItemsControl NativeControl => (ACP.SelectingItemsControl)((AvaloniaObject)this).NativeControl;

        protected override ACP.SelectingItemsControl CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(AutoScrollToSelectedItem):
                    if (!Equals(AutoScrollToSelectedItem, value))
                    {
                        AutoScrollToSelectedItem = (bool?)value;
                        NativeControl.AutoScrollToSelectedItem = AutoScrollToSelectedItem ?? (bool)ACP.SelectingItemsControl.AutoScrollToSelectedItemProperty.GetDefaultValue(ACP.SelectingItemsControl.AutoScrollToSelectedItemProperty.OwnerType);
                    }
                    break;
                case nameof(IsTextSearchEnabled):
                    if (!Equals(IsTextSearchEnabled, value))
                    {
                        IsTextSearchEnabled = (bool?)value;
                        NativeControl.IsTextSearchEnabled = IsTextSearchEnabled ?? (bool)ACP.SelectingItemsControl.IsTextSearchEnabledProperty.GetDefaultValue(ACP.SelectingItemsControl.IsTextSearchEnabledProperty.OwnerType);
                    }
                    break;
                case nameof(SelectedIndex):
                    if (!Equals(SelectedIndex, value))
                    {
                        SelectedIndex = (int?)value;
                        NativeControl.SelectedIndex = SelectedIndex ?? (int)ACP.SelectingItemsControl.SelectedIndexProperty.GetDefaultValue(ACP.SelectingItemsControl.SelectedIndexProperty.OwnerType);
                    }
                    break;
                case nameof(SelectedItem):
                    if (!Equals(SelectedItem, value))
                    {
                        SelectedItem = (object)value;
                        NativeControl.SelectedItem = SelectedItem;
                    }
                    break;
                case nameof(SelectedValue):
                    if (!Equals(SelectedValue, value))
                    {
                        SelectedValue = (object)value;
                        NativeControl.SelectedValue = SelectedValue;
                    }
                    break;
                case nameof(SelectedValueBinding):
                    if (!Equals(SelectedValueBinding, value))
                    {
                        SelectedValueBinding = (global::Avalonia.Data.IBinding)value;
                        NativeControl.SelectedValueBinding = SelectedValueBinding;
                    }
                    break;
                case nameof(WrapSelection):
                    if (!Equals(WrapSelection, value))
                    {
                        WrapSelection = (bool?)value;
                        NativeControl.WrapSelection = WrapSelection ?? (bool)ACP.SelectingItemsControl.WrapSelectionProperty.GetDefaultValue(ACP.SelectingItemsControl.WrapSelectionProperty.OwnerType);
                    }
                    break;
                case nameof(OnSelectionChanged):
                    if (!Equals(OnSelectionChanged, value))
                    {
                        void NativeControlSelectionChanged(object sender, AC.SelectionChangedEventArgs e) => InvokeEventCallback(OnSelectionChanged, e);

                        OnSelectionChanged = (EventCallback<AC.SelectionChangedEventArgs>)value;
                        NativeControl.SelectionChanged -= NativeControlSelectionChanged;
                        NativeControl.SelectionChanged += NativeControlSelectionChanged;
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
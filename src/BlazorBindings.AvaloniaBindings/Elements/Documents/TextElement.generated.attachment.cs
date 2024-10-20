using ACD = Avalonia.Controls.Documents;
using BlazorBindings.AvaloniaBindings.Elements;

namespace BlazorBindings.AvaloniaBindings.Elements
{
    
    internal static class TextElementInitializer
    {
        [System.Runtime.CompilerServices.ModuleInitializer]
        internal static void RegisterAdditionalHandlers()
        {
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("TextElement.FontFamily",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(ACD.TextElement.FontFamilyProperty);
                    }
                    else
                    {
                        Avalonia.Controls.Documents.TextElement.SetFontFamily((Avalonia.Controls.Control)element, (global::Avalonia.Media.FontFamily)Convert.ChangeType(value, typeof(global::Avalonia.Media.FontFamily)));
                    }
                });
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("TextElement.FontFeatures",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(ACD.TextElement.FontFeaturesProperty);
                    }
                    else
                    {
                        Avalonia.Controls.Documents.TextElement.SetFontFeatures((Avalonia.Controls.Control)element, (global::Avalonia.Media.FontFeatureCollection)Convert.ChangeType(value, typeof(global::Avalonia.Media.FontFeatureCollection)));
                    }
                });
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("TextElement.FontSize",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(ACD.TextElement.FontSizeProperty);
                    }
                    else
                    {
                        Avalonia.Controls.Documents.TextElement.SetFontSize((Avalonia.Controls.Control)element, (double)Convert.ChangeType(value, typeof(double)));
                    }
                });
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("TextElement.FontStretch",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(ACD.TextElement.FontStretchProperty);
                    }
                    else
                    {
                        Avalonia.Controls.Documents.TextElement.SetFontStretch((Avalonia.Controls.Control)element, (global::Avalonia.Media.FontStretch)Convert.ChangeType(value, typeof(global::Avalonia.Media.FontStretch)));
                    }
                });
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("TextElement.FontStyle",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(ACD.TextElement.FontStyleProperty);
                    }
                    else
                    {
                        Avalonia.Controls.Documents.TextElement.SetFontStyle((Avalonia.Controls.Control)element, (global::Avalonia.Media.FontStyle)Convert.ChangeType(value, typeof(global::Avalonia.Media.FontStyle)));
                    }
                });
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("TextElement.FontWeight",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(ACD.TextElement.FontWeightProperty);
                    }
                    else
                    {
                        Avalonia.Controls.Documents.TextElement.SetFontWeight((Avalonia.Controls.Control)element, (global::Avalonia.Media.FontWeight)Convert.ChangeType(value, typeof(global::Avalonia.Media.FontWeight)));
                    }
                });
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("TextElement.Foreground",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(ACD.TextElement.ForegroundProperty);
                    }
                    else
                    {
                        Avalonia.Controls.Documents.TextElement.SetForeground((Avalonia.Controls.Control)element, (global::Avalonia.Media.IBrush)Convert.ChangeType(value, typeof(global::Avalonia.Media.IBrush)));
                    }
                });
        }
    }

    public static partial class TextElementExtensions
    {
        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.Documents.TextElement.FontFamily" /> property.
        /// </summary>
        public static Control TextElementFontFamily(this Control element, global::Avalonia.Media.FontFamily value)
        {
            element.AttachedProperties["TextElement.FontFamily"] = value;
        
            return element;
        }
        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.Documents.TextElement.FontFeatures" /> property.
        /// </summary>
        public static Control TextElementFontFeatures(this Control element, global::Avalonia.Media.FontFeatureCollection value)
        {
            element.AttachedProperties["TextElement.FontFeatures"] = value;
        
            return element;
        }
        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.Documents.TextElement.FontSize" /> property.
        /// </summary>
        public static Control TextElementFontSize(this Control element, double value)
        {
            element.AttachedProperties["TextElement.FontSize"] = value;
        
            return element;
        }
        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.Documents.TextElement.FontStretch" /> property.
        /// </summary>
        public static Control TextElementFontStretch(this Control element, global::Avalonia.Media.FontStretch value)
        {
            element.AttachedProperties["TextElement.FontStretch"] = value;
        
            return element;
        }
        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.Documents.TextElement.FontStyle" /> property.
        /// </summary>
        public static Control TextElementFontStyle(this Control element, global::Avalonia.Media.FontStyle value)
        {
            element.AttachedProperties["TextElement.FontStyle"] = value;
        
            return element;
        }
        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.Documents.TextElement.FontWeight" /> property.
        /// </summary>
        public static Control TextElementFontWeight(this Control element, global::Avalonia.Media.FontWeight value)
        {
            element.AttachedProperties["TextElement.FontWeight"] = value;
        
            return element;
        }
        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.Documents.TextElement.Foreground" /> property.
        /// </summary>
        public static Control TextElementForeground(this Control element, global::Avalonia.Media.IBrush value)
        {
            element.AttachedProperties["TextElement.Foreground"] = value;
        
            return element;
        }
    }

    public class TextElement_Attachment : NativeControlComponentBase, INonPhysicalChild, IContainerElementHandler
    {
        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.Documents.TextElement.FontFamily" /> property.
        /// </summary>
        [Parameter] public global::Avalonia.Media.FontFamily FontFamily { get; set; }

        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.Documents.TextElement.FontFeatures" /> property.
        /// </summary>
        [Parameter] public global::Avalonia.Media.FontFeatureCollection FontFeatures { get; set; }

        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.Documents.TextElement.FontSize" /> property.
        /// </summary>
        [Parameter] public double FontSize { get; set; }

        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.Documents.TextElement.FontStretch" /> property.
        /// </summary>
        [Parameter] public global::Avalonia.Media.FontStretch FontStretch { get; set; }

        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.Documents.TextElement.FontStyle" /> property.
        /// </summary>
        [Parameter] public global::Avalonia.Media.FontStyle FontStyle { get; set; }

        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.Documents.TextElement.FontWeight" /> property.
        /// </summary>
        [Parameter] public global::Avalonia.Media.FontWeight FontWeight { get; set; }

        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.Documents.TextElement.Foreground" /> property.
        /// </summary>
        [Parameter] public global::Avalonia.Media.IBrush Foreground { get; set; }

        private Avalonia.Controls.Control _parent;

        public object TargetElement => _parent;

        public override Task SetParametersAsync(ParameterView parameters)
        {
            foreach (var parameterValue in parameters)
            {
                var value = parameterValue.Value;
                switch (parameterValue.Name)
                {
                    case nameof(FontFamily):
                    if (!Equals(FontFamily, value))
                    {
                        FontFamily = (global::Avalonia.Media.FontFamily)value;
                        //NativeControl.FontFamilyProperty = FontFamily;
                    }
                    break;

                    case nameof(FontFeatures):
                    if (!Equals(FontFeatures, value))
                    {
                        FontFeatures = (global::Avalonia.Media.FontFeatureCollection)value;
                        //NativeControl.FontFeaturesProperty = FontFeatures;
                    }
                    break;

                    case nameof(FontSize):
                    if (!Equals(FontSize, value))
                    {
                        FontSize = (double)value;
                        //NativeControl.FontSizeProperty = FontSize;
                    }
                    break;

                    case nameof(FontStretch):
                    if (!Equals(FontStretch, value))
                    {
                        FontStretch = (global::Avalonia.Media.FontStretch)value;
                        //NativeControl.FontStretchProperty = FontStretch;
                    }
                    break;

                    case nameof(FontStyle):
                    if (!Equals(FontStyle, value))
                    {
                        FontStyle = (global::Avalonia.Media.FontStyle)value;
                        //NativeControl.FontStyleProperty = FontStyle;
                    }
                    break;

                    case nameof(FontWeight):
                    if (!Equals(FontWeight, value))
                    {
                        FontWeight = (global::Avalonia.Media.FontWeight)value;
                        //NativeControl.FontWeightProperty = FontWeight;
                    }
                    break;

                    case nameof(Foreground):
                    if (!Equals(Foreground, value))
                    {
                        Foreground = (global::Avalonia.Media.IBrush)value;
                        //NativeControl.ForegroundProperty = Foreground;
                    }
                    break;

                }
            }
        
            TryUpdateParent(_parent);
            return base.SetParametersAsync(ParameterView.Empty);
        }

        private void TryUpdateParent(object parentElement)
        {
            if (parentElement is not null)
            {
                if (FontFamily == Avalonia.Controls.Documents.TextElement.FontFamilyProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.Documents.TextElement.FontFamilyProperty);
                }
                else
                {
                    Avalonia.Controls.Documents.TextElement.SetFontFamily((Avalonia.Controls.Control)parentElement, FontFamily);
                }
                
                if (FontFeatures == Avalonia.Controls.Documents.TextElement.FontFeaturesProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.Documents.TextElement.FontFeaturesProperty);
                }
                else
                {
                    Avalonia.Controls.Documents.TextElement.SetFontFeatures((Avalonia.Controls.Control)parentElement, FontFeatures);
                }
                
                if (FontSize == Avalonia.Controls.Documents.TextElement.FontSizeProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.Documents.TextElement.FontSizeProperty);
                }
                else
                {
                    Avalonia.Controls.Documents.TextElement.SetFontSize((Avalonia.Controls.Control)parentElement, FontSize);
                }
                
                if (FontStretch == Avalonia.Controls.Documents.TextElement.FontStretchProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.Documents.TextElement.FontStretchProperty);
                }
                else
                {
                    Avalonia.Controls.Documents.TextElement.SetFontStretch((Avalonia.Controls.Control)parentElement, FontStretch);
                }
                
                if (FontStyle == Avalonia.Controls.Documents.TextElement.FontStyleProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.Documents.TextElement.FontStyleProperty);
                }
                else
                {
                    Avalonia.Controls.Documents.TextElement.SetFontStyle((Avalonia.Controls.Control)parentElement, FontStyle);
                }
                
                if (FontWeight == Avalonia.Controls.Documents.TextElement.FontWeightProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.Documents.TextElement.FontWeightProperty);
                }
                else
                {
                    Avalonia.Controls.Documents.TextElement.SetFontWeight((Avalonia.Controls.Control)parentElement, FontWeight);
                }
                
                if (Foreground == Avalonia.Controls.Documents.TextElement.ForegroundProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.Documents.TextElement.ForegroundProperty);
                }
                else
                {
                    Avalonia.Controls.Documents.TextElement.SetForeground((Avalonia.Controls.Control)parentElement, Foreground);
                }
                
            }
        }
    
        void INonPhysicalChild.SetParent(object parentElement)
        {
            var parentType = parentElement?.GetType();
            if (parentType is not null)
            {
                FontFamily = FontFamily != default ? FontFamily : Avalonia.Controls.Documents.TextElement.FontFamilyProperty.GetDefaultValue(parentType);
                FontFeatures = FontFeatures != default ? FontFeatures : Avalonia.Controls.Documents.TextElement.FontFeaturesProperty.GetDefaultValue(parentType);
                FontSize = FontSize != default ? FontSize : Avalonia.Controls.Documents.TextElement.FontSizeProperty.GetDefaultValue(parentType);
                FontStretch = FontStretch != default ? FontStretch : Avalonia.Controls.Documents.TextElement.FontStretchProperty.GetDefaultValue(parentType);
                FontStyle = FontStyle != default ? FontStyle : Avalonia.Controls.Documents.TextElement.FontStyleProperty.GetDefaultValue(parentType);
                FontWeight = FontWeight != default ? FontWeight : Avalonia.Controls.Documents.TextElement.FontWeightProperty.GetDefaultValue(parentType);
                Foreground = Foreground != default ? Foreground : Avalonia.Controls.Documents.TextElement.ForegroundProperty.GetDefaultValue(parentType);

                TryUpdateParent(parentElement);
            }

            _parent = (Avalonia.Controls.Control)parentElement;
        }
        
        
        public void RemoveFromParent(object parentElement)
        {
            var parentType = parentElement?.GetType();
            if (parentType is not null)
            {
                FontFamily = Avalonia.Controls.Documents.TextElement.FontFamilyProperty.GetDefaultValue(parentType);
                FontFeatures = Avalonia.Controls.Documents.TextElement.FontFeaturesProperty.GetDefaultValue(parentType);
                FontSize = Avalonia.Controls.Documents.TextElement.FontSizeProperty.GetDefaultValue(parentType);
                FontStretch = Avalonia.Controls.Documents.TextElement.FontStretchProperty.GetDefaultValue(parentType);
                FontStyle = Avalonia.Controls.Documents.TextElement.FontStyleProperty.GetDefaultValue(parentType);
                FontWeight = Avalonia.Controls.Documents.TextElement.FontWeightProperty.GetDefaultValue(parentType);
                Foreground = Avalonia.Controls.Documents.TextElement.ForegroundProperty.GetDefaultValue(parentType);

                TryUpdateParent(parentElement);
            }

            _parent = null;
        }

        public void AddChild(object child, int physicalSiblingIndex)
        {
        }

        public void RemoveChild(object child, int physicalSiblingIndex)
        {
        }

        protected override void RenderAdditionalElementContent(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder builder, ref int sequence)
        {
            base.RenderAdditionalElementContent(builder, ref sequence);
        }
    }
}



namespace BlazorBindings.AvaloniaBindings.Elements
{
    public class NativeMenu_Attachment : NativeControlComponentBase, INonPhysicalChild, IContainerElementHandler
    {
        [Parameter] public AC.NativeMenu Menu { get; set; }

        private Avalonia.AvaloniaObject _parent;

        public object TargetElement => _parent;

        public override Task SetParametersAsync(ParameterView parameters)
        {
            foreach (var parameterValue in parameters)
            {
                var value = parameterValue.Value;
                switch (parameterValue.Name)
                {
                    case nameof(Menu):
                    if (!Equals(Menu, value))
                    {
                        Menu = (AC.NativeMenu)value;
                        //NativeControl.MenuProperty = Menu;
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
                if (Menu == Avalonia.Controls.NativeMenu.MenuProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.AvaloniaObject)parentElement).ClearValue(Avalonia.Controls.NativeMenu.MenuProperty);
                }
                else
                {
                    Avalonia.Controls.NativeMenu.SetMenu((Avalonia.AvaloniaObject)parentElement, Menu);
                }
                
            }
        }
    
        void INonPhysicalChild.SetParent(object parentElement)
        {
            var parentType = parentElement?.GetType();
            if (parentType is not null)
            {
                Menu = Menu != default ? Menu : Avalonia.Controls.NativeMenu.MenuProperty.GetDefaultValue(parentType);
            }

            TryUpdateParent(parentElement);
            _parent = (Avalonia.AvaloniaObject)parentElement;
        }
        
        
        public void RemoveFromParent(object parentElement)
        {
            //_children.Clear();

            //Avalonia.Controls.NativeMenu.SetTip(_parent, null);

            _parent = null;
        }

        public void AddChild(object child, int physicalSiblingIndex)
        {
            var childView = child.Cast<AC.Control>();

            //_children.Add(childView);
        }

        public void RemoveChild(object child, int physicalSiblingIndex)
        {
            //_children.Remove((AC.Control)child);
        }

        protected override void RenderAdditionalElementContent(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder builder, ref int sequence)
        {
            base.RenderAdditionalElementContent(builder, ref sequence);
        }
    }
}
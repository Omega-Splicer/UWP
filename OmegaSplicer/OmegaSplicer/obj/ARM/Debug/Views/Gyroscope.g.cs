﻿#pragma checksum "C:\Users\dimitricisneros\Desktop\UW\OmegaSplicer\OmegaSplicer\Views\Gyroscope.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E5D53F02AE70AD339871481E94504806"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OmegaSplicer.Views
{
    partial class Gyroscope : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.ellipseX = (global::Windows.UI.Xaml.Shapes.Ellipse)(target);
                }
                break;
            case 2:
                {
                    this.ellipseY = (global::Windows.UI.Xaml.Shapes.Ellipse)(target);
                }
                break;
            case 3:
                {
                    this.ellipseZ = (global::Windows.UI.Xaml.Shapes.Ellipse)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}


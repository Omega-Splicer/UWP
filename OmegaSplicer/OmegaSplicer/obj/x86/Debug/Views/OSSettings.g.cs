﻿#pragma checksum "C:\Users\dimitricisneros\Desktop\UWP\OmegaSplicer\OmegaSplicer\Views\OSSettings.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E4AA6585B43CFF743A0CE95930303DD5"
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
    partial class OSSettings : 
        global::Windows.UI.Xaml.Controls.Page, 
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
                    this.SettingsContent = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2:
                {
                    this.ContentRoot = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3:
                {
                    this.ControlTitle = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                }
                break;
            case 4:
                {
                    this.ControlSwitch = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 5:
                {
                    this.UnitTitle = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                }
                break;
            case 6:
                {
                    this.UnitSwitch = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 7:
                {
                    this.UnitKMPH = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    #line 82 "..\..\..\Views\OSSettings.xaml"
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.UnitKMPH).Checked += this.UnitButton_Checked;
                    #line default
                }
                break;
            case 8:
                {
                    this.UnitMPS = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    #line 83 "..\..\..\Views\OSSettings.xaml"
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.UnitMPS).Checked += this.UnitButton_Checked;
                    #line default
                }
                break;
            case 9:
                {
                    this.UnitMPH = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    #line 84 "..\..\..\Views\OSSettings.xaml"
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.UnitMPH).Checked += this.UnitButton_Checked;
                    #line default
                }
                break;
            case 10:
                {
                    this.Pad = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    #line 71 "..\..\..\Views\OSSettings.xaml"
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.Pad).Checked += this.ControlButton_Checked;
                    #line default
                }
                break;
            case 11:
                {
                    this.Gyroscope = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    #line 72 "..\..\..\Views\OSSettings.xaml"
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.Gyroscope).Checked += this.ControlButton_Checked;
                    #line default
                }
                break;
            case 12:
                {
                    this.AcceptButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 13:
                {
                    this.SaveButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
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


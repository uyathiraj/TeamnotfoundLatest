﻿#pragma checksum "C:\Users\uyat\Documents\GitHub\TeamNotFound\teamnotfound_Windows_CS\teamnotfound\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5904E32A92DECB44198BA75A27137510"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace teamnotfound
{
    partial class MainPage : 
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
                    this.LayoutRoot = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2:
                {
                    this.VisualStateGroup = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 3:
                {
                    this.NarrowState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 4:
                {
                    this.WideState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 5:
                {
                    this.ContentGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 6:
                {
                    this.TitleGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 7:
                {
                    this.ContentPanel = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 8:
                {
                    this.ItemsGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 9:
                {
                    this.ListItems = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 10:
                {
                    global::Windows.UI.Xaml.Controls.CheckBox element10 = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 129 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)element10).Checked += this.CheckBoxComplete_Checked;
                    #line default
                }
                break;
            case 11:
                {
                    this.quickStartTaskQuery = (global::teamnotfound.QuickStartTask)(target);
                }
                break;
            case 12:
                {
                    this.ButtonRefresh = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 111 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ButtonRefresh).Click += this.ButtonRefresh_Click;
                    #line default
                }
                break;
            case 13:
                {
                    this.quickStartTask = (global::teamnotfound.QuickStartTask)(target);
                }
                break;
            case 14:
                {
                    this.TextInput = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 89 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.TextInput).KeyDown += this.TextInput_KeyDown;
                    #line default
                }
                break;
            case 15:
                {
                    this.ButtonSave = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 90 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ButtonSave).Click += this.ButtonSave_Click;
                    #line default
                }
                break;
            case 16:
                {
                    this.TitleTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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


﻿#pragma checksum "C:\Users\uyat\Documents\GitHub\TeamNotFound\teamnotfound_Windows_CS\teamnotfound\View\DashBoard.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E67A8AA4603D45091F6F6FCB13B52314"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeamNotFound.View
{
    partial class DashBoard : 
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
                    this.MySplitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 2:
                {
                    this.HamburgerButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 16 "..\..\..\View\DashBoard.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.HamburgerButton).Click += this.HamburgerButton_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.listView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 4:
                {
                    global::Windows.UI.Xaml.Controls.ListViewItem element4 = (global::Windows.UI.Xaml.Controls.ListViewItem)(target);
                    #line 18 "..\..\..\View\DashBoard.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListViewItem)element4).Tapped += this.Profile_Tapped;
                    #line default
                }
                break;
            case 5:
                {
                    global::Windows.UI.Xaml.Controls.ListViewItem element5 = (global::Windows.UI.Xaml.Controls.ListViewItem)(target);
                    #line 25 "..\..\..\View\DashBoard.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListViewItem)element5).Tapped += this.MyProject_Tapped;
                    #line default
                }
                break;
            case 6:
                {
                    global::Windows.UI.Xaml.Controls.ListViewItem element6 = (global::Windows.UI.Xaml.Controls.ListViewItem)(target);
                    #line 32 "..\..\..\View\DashBoard.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListViewItem)element6).Tapped += this.PostProject_Tapped;
                    #line default
                }
                break;
            case 7:
                {
                    this.ProfileImage = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 8:
                {
                    this.myFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
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


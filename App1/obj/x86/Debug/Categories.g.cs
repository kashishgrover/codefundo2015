﻿#pragma checksum "C:\Users\Kashish\Documents\Visual Studio 2015\Projects\App1\App1\Categories.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CF73BC88E493E0F70095E05472894E58"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App1
{
    partial class Categories : 
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
                    this.Electronics = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 11 "..\..\..\Categories.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Electronics).Click += this.Electronics_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.Cleaning = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 12 "..\..\..\Categories.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Cleaning).Click += this.Cleaning_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.Writing = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 13 "..\..\..\Categories.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Writing).Click += this.Writing_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.Daily = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 14 "..\..\..\Categories.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Daily).Click += this.Daily_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.Misc = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 15 "..\..\..\Categories.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Misc).Click += this.Misc_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.searchtb = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7:
                {
                    this.search = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 17 "..\..\..\Categories.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.search).Click += this.search_Click;
                    #line default
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

﻿#pragma checksum "C:\Users\Kashish\Documents\Visual Studio 2015\Projects\App1\App1\LoginPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DE45C77A2584268EF84CD7703C9F0765"
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
    partial class LoginPage : 
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
                    this.textBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 2:
                {
                    this.Username = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3:
                {
                    this.textBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4:
                {
                    this.Password = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.passwordBox = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 6:
                {
                    this.textBlock1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7:
                {
                    this.LoginButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 17 "..\..\..\LoginPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.LoginButton).Click += this.LoginButton_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.Username_Copy = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9:
                {
                    this.RegIDBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 10:
                {
                    this.Password_Copy = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11:
                {
                    this.RegPwdBox = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 12:
                {
                    this.RegButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 22 "..\..\..\LoginPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.RegButton).Click += this.RegButton_Click;
                    #line default
                }
                break;
            case 13:
                {
                    this.Username_Copy1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14:
                {
                    this.RegNameBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
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


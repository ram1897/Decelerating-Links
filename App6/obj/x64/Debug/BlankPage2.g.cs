﻿#pragma checksum "c:\users\ramanathan\documents\visual studio 2015\Projects\App6\App6\BlankPage2.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "ACADAE043DCB81EA8E89F12A5942D6D5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App6
{
    partial class BlankPage2 : 
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
                    this.comboBox1 = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 3:
                {
                    this.textBlock1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.radioButton2 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 24 "..\..\..\BlankPage2.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.radioButton2).Checked += this.geospeed;
                    #line default
                }
                break;
            case 5:
                {
                    this.radioButton = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 6:
                {
                    this.textBlock2 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7:
                {
                    this.combobox2 = (global::Windows.UI.Xaml.Controls.ComboBoxItem)(target);
                }
                break;
            case 8:
                {
                    this.comboBox3 = (global::Windows.UI.Xaml.Controls.ComboBoxItem)(target);
                }
                break;
            case 9:
                {
                    this.comboBox4 = (global::Windows.UI.Xaml.Controls.ComboBoxItem)(target);
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


﻿#pragma checksum "..\..\WindowsServerGUI.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E412E23412A81588B3C1CD9E5FC41B22C1861C42"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MessagingServer;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace MessagingServer {
    
    
    /// <summary>
    /// WindowsServerGUI
    /// </summary>
    public partial class WindowsServerGUI : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\WindowsServerGUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainGrid;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\WindowsServerGUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox OutPutBox;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\WindowsServerGUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CommandBox;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\WindowsServerGUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label PortLabel;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\WindowsServerGUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PortTextBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MessagingServer;component/windowsservergui.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WindowsServerGUI.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.MainGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.OutPutBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.CommandBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 12 "..\..\WindowsServerGUI.xaml"
            this.CommandBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.CommandBox_TextChanged);
            
            #line default
            #line hidden
            
            #line 12 "..\..\WindowsServerGUI.xaml"
            this.CommandBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.CommandBox_OnKeyDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.PortLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.PortTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 14 "..\..\WindowsServerGUI.xaml"
            this.PortTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.PortTextBox_TextChanged);
            
            #line default
            #line hidden
            
            #line 14 "..\..\WindowsServerGUI.xaml"
            this.PortTextBox.Initialized += new System.EventHandler(this.PortTextBox_Initialized);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


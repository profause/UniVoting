﻿#pragma checksum "..\..\..\Clients\ClientsLoginWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5EA0630A65C1600F192AFEFF5F421EAB6685D4E0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
using MaterialDesignThemes.MahApps;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace UniVoting.Admin.Clients {
    
    
    /// <summary>
    /// ClientsLoginWindow
    /// </summary>
    public partial class ClientsLoginWindow : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\Clients\ClientsLoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Pin;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Clients\ClientsLoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnGo;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Clients\ClientsLoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label VotingName;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Clients\ClientsLoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label VotingSubtitle;
        
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
            System.Uri resourceLocater = new System.Uri("/UniVoting.Admin;component/clients/clientsloginwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Clients\ClientsLoginWindow.xaml"
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
            this.Pin = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 2:
            this.BtnGo = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.VotingName = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.VotingSubtitle = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


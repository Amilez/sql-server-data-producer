﻿#pragma checksum "..\..\SqlConnectionStringBuilder.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "ED82189DCE747F6B7DC9213B96A2DBFE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ConnectionStringCreatorGUI;
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


namespace ConnectionStringCreatorGUI {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    internal partial class SqlConnectionStringBuilder : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 42 "..\..\SqlConnectionStringBuilder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SqlServerName;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\SqlConnectionStringBuilder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SqlDatabaseName;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\SqlConnectionStringBuilder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton SqlAuthTypeWindows;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\SqlConnectionStringBuilder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton SqlAuthTypeSql;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ConnectionStringCreatorGUI;component/sqlconnectionstringbuilder.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SqlConnectionStringBuilder.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.SqlServerName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.SqlDatabaseName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.SqlAuthTypeWindows = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 4:
            this.SqlAuthTypeSql = ((System.Windows.Controls.RadioButton)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


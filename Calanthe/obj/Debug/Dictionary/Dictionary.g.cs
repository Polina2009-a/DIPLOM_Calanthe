﻿#pragma checksum "..\..\..\Dictionary\Dictionary.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BE8A9DF8A6944F07A1F87FA76FAEDF9DC2A14E7DA4FC39553F214BA5F4B6B878"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Calanthe;
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


namespace Calanthe {
    
    
    /// <summary>
    /// Dictionary
    /// </summary>
    public partial class Dictionary : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\Dictionary\Dictionary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back_b;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Dictionary\Dictionary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbResearch;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Dictionary\Dictionary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Research_bt;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Dictionary\Dictionary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dbWords;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Dictionary\Dictionary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Edit_b;
        
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
            System.Uri resourceLocater = new System.Uri("/Calanthe;component/dictionary/dictionary.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Dictionary\Dictionary.xaml"
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
            this.Back_b = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\Dictionary\Dictionary.xaml"
            this.Back_b.Click += new System.Windows.RoutedEventHandler(this.Back_b_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tbResearch = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Research_bt = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.dbWords = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.Edit_b = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\Dictionary\Dictionary.xaml"
            this.Edit_b.Click += new System.Windows.RoutedEventHandler(this.Edit_b_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

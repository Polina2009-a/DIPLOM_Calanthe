﻿#pragma checksum "..\..\..\Autorization\Autorization.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1AE9D87204BD1B2198A78F26E5968C69804DA67DBFCDA9C876318CD92A699F8F"
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
    /// Autorization
    /// </summary>
    public partial class Autorization : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 43 "..\..\..\Autorization\Autorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Mail;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Autorization\Autorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NewPassword;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Autorization\Autorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Password;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Autorization\Autorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back_b;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\Autorization\Autorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button registration_b;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Autorization\Autorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Continue_b;
        
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
            System.Uri resourceLocater = new System.Uri("/Calanthe;component/autorization/autorization.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Autorization\Autorization.xaml"
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
            this.Mail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.NewPassword = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Password = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            
            #line 59 "..\..\..\Autorization\Autorization.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.Hyperlink_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Back_b = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\Autorization\Autorization.xaml"
            this.Back_b.Click += new System.Windows.RoutedEventHandler(this.Back_b_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.registration_b = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\Autorization\Autorization.xaml"
            this.registration_b.Click += new System.Windows.RoutedEventHandler(this.registration_b_Click_1);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Continue_b = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\Autorization\Autorization.xaml"
            this.Continue_b.Click += new System.Windows.RoutedEventHandler(this.Continue_b_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

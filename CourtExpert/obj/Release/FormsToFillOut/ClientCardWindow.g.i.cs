﻿#pragma checksum "..\..\..\FormsToFillOut\ClientCardWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A4AB8500A6A126F0AAFB1B549B8F5A3959F9E7B52958796F1570DF78CE6EC0FF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using CourtExpert.FormsToFillOut;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace CourtExpert.FormsToFillOut {
    
    
    /// <summary>
    /// ClientCardWindow
    /// </summary>
    public partial class ClientCardWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\FormsToFillOut\ClientCardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame ClientCardFrame;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\FormsToFillOut\ClientCardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonIndividualPerson;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\FormsToFillOut\ClientCardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonLegalEntity;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\FormsToFillOut\ClientCardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonNextPage;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\FormsToFillOut\ClientCardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonPreviousPage;
        
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
            System.Uri resourceLocater = new System.Uri("/CourtExpert;component/formstofillout/clientcardwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\FormsToFillOut\ClientCardWindow.xaml"
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
            this.ClientCardFrame = ((System.Windows.Controls.Frame)(target));
            return;
            case 2:
            this.ButtonIndividualPerson = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\FormsToFillOut\ClientCardWindow.xaml"
            this.ButtonIndividualPerson.Click += new System.Windows.RoutedEventHandler(this.ButtonIndividualPersonClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ButtonLegalEntity = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\FormsToFillOut\ClientCardWindow.xaml"
            this.ButtonLegalEntity.Click += new System.Windows.RoutedEventHandler(this.ButtonLegalEntityClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ButtonNextPage = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\FormsToFillOut\ClientCardWindow.xaml"
            this.ButtonNextPage.Click += new System.Windows.RoutedEventHandler(this.ButtonNextPageClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ButtonPreviousPage = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\FormsToFillOut\ClientCardWindow.xaml"
            this.ButtonPreviousPage.Click += new System.Windows.RoutedEventHandler(this.ButtonPreviousPageClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


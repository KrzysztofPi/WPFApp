﻿#pragma checksum "..\..\PageDel.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03D72BE33580FD12673CB1F1E7BF47E9514784F8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using ProjektZalWPF;
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


namespace ProjektZalWPF {
    
    
    /// <summary>
    /// PageDel
    /// </summary>
    public partial class PageDel : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\PageDel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cBoxJakiePrzepisy;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\PageDel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cBoxWhatLaws;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\PageDel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTrescArt;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\PageDel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSee;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\PageDel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDel;
        
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
            System.Uri resourceLocater = new System.Uri("/ProjektZalWPF;component/pagedel.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PageDel.xaml"
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
            this.cBoxJakiePrzepisy = ((System.Windows.Controls.ComboBox)(target));
            
            #line 17 "..\..\PageDel.xaml"
            this.cBoxJakiePrzepisy.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cBoxJakiePrzepisy_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cBoxWhatLaws = ((System.Windows.Controls.ComboBox)(target));
            
            #line 23 "..\..\PageDel.xaml"
            this.cBoxWhatLaws.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cBoxWhatLaws_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lblTrescArt = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.btnSee = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\PageDel.xaml"
            this.btnSee.Click += new System.Windows.RoutedEventHandler(this.btnSee_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnDel = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\PageDel.xaml"
            this.btnDel.Click += new System.Windows.RoutedEventHandler(this.btnDel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


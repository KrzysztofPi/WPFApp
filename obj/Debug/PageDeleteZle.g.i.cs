﻿#pragma checksum "..\..\PageDeleteZle.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E4CFBEC699CA7F87D0B06BBE3B0DBE0BFF2310F8"
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
    /// PageDelete
    /// </summary>
    public partial class PageDelete : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\PageDeleteZle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cBoxWhatLaws;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\PageDeleteZle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cBoxJakiArtykul;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\PageDeleteZle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTrescArt;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\PageDeleteZle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSee;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\PageDeleteZle.xaml"
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
            System.Uri resourceLocater = new System.Uri("/ProjektZalWPF;component/pagedeletezle.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PageDeleteZle.xaml"
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
            this.cBoxWhatLaws = ((System.Windows.Controls.ComboBox)(target));
            
            #line 17 "..\..\PageDeleteZle.xaml"
            this.cBoxWhatLaws.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cBoxWhatLaws_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cBoxJakiArtykul = ((System.Windows.Controls.ComboBox)(target));
            
            #line 23 "..\..\PageDeleteZle.xaml"
            this.cBoxJakiArtykul.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cBoxWhatLaws_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lblTrescArt = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.btnSee = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.btnDel = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\..\Pages\SaveCoffeePage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D05375E18522991A39D9FC099F4143FA3EEAD876"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using TheCoffeAdminPanel.Wpf.Pages;


namespace TheCoffeAdminPanel.Wpf.Pages {
    
    
    /// <summary>
    /// SaveCoffeePage
    /// </summary>
    public partial class SaveCoffeePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\..\Pages\SaveCoffeePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ImageBrush CoffeeImg;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Pages\SaveCoffeePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ImageBtn;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Pages\SaveCoffeePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock IdTxt;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Pages\SaveCoffeePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Name;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\Pages\SaveCoffeePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Description;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\Pages\SaveCoffeePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Price;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\Pages\SaveCoffeePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveBtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TheCoffeAdminPanel.Wpf;component/pages/savecoffeepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\SaveCoffeePage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.CoffeeImg = ((System.Windows.Media.ImageBrush)(target));
            return;
            case 2:
            this.ImageBtn = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\..\Pages\SaveCoffeePage.xaml"
            this.ImageBtn.Click += new System.Windows.RoutedEventHandler(this.ImageBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.IdTxt = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.Name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Description = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Price = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.SaveBtn = ((System.Windows.Controls.Button)(target));
            
            #line 83 "..\..\..\..\Pages\SaveCoffeePage.xaml"
            this.SaveBtn.Click += new System.Windows.RoutedEventHandler(this.SaveBtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 96 "..\..\..\..\Pages\SaveCoffeePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

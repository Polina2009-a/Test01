﻿#pragma checksum "..\..\Win1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EBBE8974972A6D3C95CF13D30F283ED1BA0F923E2A11AED4AF097FFB11FD9FF5"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// Win1
    /// </summary>
    public partial class Win1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\Win1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid res;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Win1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox id;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Win1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid data;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\Win1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Name;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\Win1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Password;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\Win1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Status;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\Win1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button save_b;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\Win1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button del_b;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\Win1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button add_b;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\Win1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid choise;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/win1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Win1.xaml"
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
            this.res = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.id = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            
            #line 21 "..\..\Win1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 23 "..\..\Win1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.data = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.Name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.Password = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.Status = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.save_b = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\Win1.xaml"
            this.save_b.Click += new System.Windows.RoutedEventHandler(this.save_b_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.del_b = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\Win1.xaml"
            this.del_b.Click += new System.Windows.RoutedEventHandler(this.del_b_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.add_b = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\Win1.xaml"
            this.add_b.Click += new System.Windows.RoutedEventHandler(this.add_b_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.choise = ((System.Windows.Controls.Grid)(target));
            return;
            case 13:
            
            #line 56 "..\..\Win1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_3);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 57 "..\..\Win1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 58 "..\..\Win1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_4);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


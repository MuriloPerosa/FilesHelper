﻿#pragma checksum "..\..\BackupWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B05172AB39EC76C0FBCFAE9F23A14408"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FilesHelper;
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
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace FilesHelper {
    
    
    /// <summary>
    /// BackupWindow
    /// </summary>
    public partial class BackupWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 24 "..\..\BackupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mn_Backup;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\BackupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mn_Salvar;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\BackupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mn_Sair;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\BackupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dg_items;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\BackupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ctx_add;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\BackupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Salvar;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\BackupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Cancelar;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\BackupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_add;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\BackupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Backup;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\BackupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tb_Product;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\BackupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tb_Version;
        
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
            System.Uri resourceLocater = new System.Uri("/FilesHelper;component/backupwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\BackupWindow.xaml"
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
            this.mn_Backup = ((System.Windows.Controls.MenuItem)(target));
            
            #line 24 "..\..\BackupWindow.xaml"
            this.mn_Backup.Click += new System.Windows.RoutedEventHandler(this.mn_Backup_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.mn_Salvar = ((System.Windows.Controls.MenuItem)(target));
            
            #line 25 "..\..\BackupWindow.xaml"
            this.mn_Salvar.Click += new System.Windows.RoutedEventHandler(this.mn_Salvar_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.mn_Sair = ((System.Windows.Controls.MenuItem)(target));
            
            #line 27 "..\..\BackupWindow.xaml"
            this.mn_Sair.Click += new System.Windows.RoutedEventHandler(this.mn_Sair_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.dg_items = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.ctx_add = ((System.Windows.Controls.MenuItem)(target));
            
            #line 39 "..\..\BackupWindow.xaml"
            this.ctx_add.Click += new System.Windows.RoutedEventHandler(this.ctx_add_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btn_Salvar = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\BackupWindow.xaml"
            this.btn_Salvar.Click += new System.Windows.RoutedEventHandler(this.mn_Salvar_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btn_Cancelar = ((System.Windows.Controls.Button)(target));
            
            #line 83 "..\..\BackupWindow.xaml"
            this.btn_Cancelar.Click += new System.Windows.RoutedEventHandler(this.mn_Sair_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btn_add = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\BackupWindow.xaml"
            this.btn_add.Click += new System.Windows.RoutedEventHandler(this.ctx_add_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btn_Backup = ((System.Windows.Controls.Button)(target));
            
            #line 85 "..\..\BackupWindow.xaml"
            this.btn_Backup.Click += new System.Windows.RoutedEventHandler(this.mn_Backup_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.tb_Product = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 13:
            this.tb_Version = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 6:
            
            #line 59 "..\..\BackupWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_Open_Click);
            
            #line default
            #line hidden
            break;
            case 7:
            
            #line 67 "..\..\BackupWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_Remover_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

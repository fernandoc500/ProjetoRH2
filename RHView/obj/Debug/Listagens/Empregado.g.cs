﻿#pragma checksum "..\..\..\Listagens\Empregado.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6C589A97AA68EC7F101EB33280094E2B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using RHView;
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


namespace RHView {
    
    
    /// <summary>
    /// ListagemEmpregado
    /// </summary>
    public partial class ListagemEmpregado : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\Listagens\Empregado.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem RelatorioTeste;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Listagens\Empregado.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGEmp;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\Listagens\Empregado.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxCargo;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\Listagens\Empregado.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnHistoricoCargo;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\Listagens\Empregado.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSalvar;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Listagens\Empregado.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNovo;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\Listagens\Empregado.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancelar;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\Listagens\Empregado.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRemover;
        
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
            System.Uri resourceLocater = new System.Uri("/RHView;component/listagens/empregado.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Listagens\Empregado.xaml"
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
            
            #line 8 "..\..\..\Listagens\Empregado.xaml"
            ((RHView.ListagemEmpregado)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.RelatorioTeste = ((System.Windows.Controls.MenuItem)(target));
            
            #line 20 "..\..\..\Listagens\Empregado.xaml"
            this.RelatorioTeste.Click += new System.Windows.RoutedEventHandler(this.RelatorioTeste_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DGEmp = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.ComboBoxCargo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.btnHistoricoCargo = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\..\Listagens\Empregado.xaml"
            this.btnHistoricoCargo.Click += new System.Windows.RoutedEventHandler(this.btnHistoricoCargo_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnSalvar = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\..\Listagens\Empregado.xaml"
            this.btnSalvar.Click += new System.Windows.RoutedEventHandler(this.btnSalvar_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnNovo = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\..\Listagens\Empregado.xaml"
            this.btnNovo.Click += new System.Windows.RoutedEventHandler(this.btnNovo_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnCancelar = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\..\Listagens\Empregado.xaml"
            this.btnCancelar.Click += new System.Windows.RoutedEventHandler(this.btnCancelar_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnRemover = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


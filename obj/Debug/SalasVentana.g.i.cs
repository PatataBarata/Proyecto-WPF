// Updated by XamlIntelliSenseFileGenerator 20/02/2021 23:21:10
#pragma checksum "..\..\SalasVentana.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "86ED645868FD78B4FCBDCE0B24329465B33A3D981D889B9140FC76ED293C8047"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Proyecto_WPF;
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


namespace Proyecto_WPF
{


    /// <summary>
    /// SalasVentana
    /// </summary>
    public partial class SalasVentana : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 10 "..\..\SalasVentana.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel CambiarSalasStackPanel;

#line default
#line hidden


#line 12 "..\..\SalasVentana.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NumeroSalaTexBox;

#line default
#line hidden


#line 14 "..\..\SalasVentana.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox asientosSalaTexBox;

#line default
#line hidden


#line 15 "..\..\SalasVentana.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button aleatorioButtonSalas;

#line default
#line hidden


#line 16 "..\..\SalasVentana.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock aleatorioButtonSalasTextBlock;

#line default
#line hidden


#line 18 "..\..\SalasVentana.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelarButton;

#line default
#line hidden


#line 22 "..\..\SalasVentana.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button añadirNuevaSalaButton;

#line default
#line hidden


#line 23 "..\..\SalasVentana.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button modificarSalaButton;

#line default
#line hidden


#line 25 "..\..\SalasVentana.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid gestionSalasLixtBox;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Proyecto WPF;component/salasventana.xaml", System.UriKind.Relative);

#line 1 "..\..\SalasVentana.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.CambiarSalasStackPanel = ((System.Windows.Controls.StackPanel)(target));
                    return;
                case 2:
                    this.NumeroSalaTexBox = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 3:
                    this.asientosSalaTexBox = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 4:
                    this.aleatorioButtonSalas = ((System.Windows.Controls.Button)(target));
                    return;
                case 5:
                    this.aleatorioButtonSalasTextBlock = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 6:
                    this.CancelarButton = ((System.Windows.Controls.Button)(target));

#line 18 "..\..\SalasVentana.xaml"
                    this.CancelarButton.Click += new System.Windows.RoutedEventHandler(this.CancelarButton_Click);

#line default
#line hidden
                    return;
                case 7:
                    this.añadirNuevaSalaButton = ((System.Windows.Controls.Button)(target));

#line 22 "..\..\SalasVentana.xaml"
                    this.añadirNuevaSalaButton.Click += new System.Windows.RoutedEventHandler(this.añadirNuevaSalaButton_Click);

#line default
#line hidden
                    return;
                case 8:
                    this.modificarSalaButton = ((System.Windows.Controls.Button)(target));

#line 23 "..\..\SalasVentana.xaml"
                    this.modificarSalaButton.Click += new System.Windows.RoutedEventHandler(this.modificarSalaButton_Click);

#line default
#line hidden
                    return;
                case 9:
                    this.gestionSalasLixtBox = ((System.Windows.Controls.DataGrid)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.TextBox disponibleSalaTexBox;
    }
}


﻿#pragma checksum "..\..\..\UserForm\EditFuelForm.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C5569000C6A1A7CBEE10C2EC24F22B4E2EE7F94D71EAB2FF755F1D125DC42CAF"
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
using TripNode.UserForm;


namespace TripNode.UserForm {
    
    
    /// <summary>
    /// EditFuelForm
    /// </summary>
    public partial class EditFuelForm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\UserForm\EditFuelForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBoxFuel;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\UserForm\EditFuelForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxPrice;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\UserForm\EditFuelForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBoxOctane;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\UserForm\EditFuelForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditFuelButton;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\UserForm\EditFuelForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteButton;
        
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
            System.Uri resourceLocater = new System.Uri("/TripNode;component/userform/editfuelform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserForm\EditFuelForm.xaml"
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
            this.comboBoxFuel = ((System.Windows.Controls.ComboBox)(target));
            
            #line 26 "..\..\..\UserForm\EditFuelForm.xaml"
            this.comboBoxFuel.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboBoxFuel_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.textBoxPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.comboBoxOctane = ((System.Windows.Controls.ComboBox)(target));
            
            #line 31 "..\..\..\UserForm\EditFuelForm.xaml"
            this.comboBoxOctane.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboBoxOctane_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.EditFuelButton = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\UserForm\EditFuelForm.xaml"
            this.EditFuelButton.Click += new System.Windows.RoutedEventHandler(this.EditFuelButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DeleteButton = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\UserForm\EditFuelForm.xaml"
            this.DeleteButton.Click += new System.Windows.RoutedEventHandler(this.DeleteButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


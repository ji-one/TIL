#pragma checksum "..\..\UnDoReDoEx.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "131AA3F8CB10D48AC24578B93CCDEF2AB1DBC0A50ED223946A34644C29298060"
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

using CopyPasteEx;
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


namespace CopyPasteEx {
    
    
    /// <summary>
    /// UnDoReDoEx
    /// </summary>
    public partial class UnDoReDoEx : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\UnDoReDoEx.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MyTextBox;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\UnDoReDoEx.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Chk_Undo;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\UnDoReDoEx.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Chk_Redo;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\UnDoReDoEx.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chk_IsUndoEnabled;
        
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
            System.Uri resourceLocater = new System.Uri("/CopyPasteEx;component/undoredoex.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UnDoReDoEx.xaml"
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
            this.MyTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\UnDoReDoEx.xaml"
            this.MyTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.MyTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 15 "..\..\UnDoReDoEx.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Undo_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 16 "..\..\UnDoReDoEx.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Redo_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Chk_Undo = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 5:
            this.Chk_Redo = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 6:
            this.chk_IsUndoEnabled = ((System.Windows.Controls.CheckBox)(target));
            
            #line 22 "..\..\UnDoReDoEx.xaml"
            this.chk_IsUndoEnabled.Click += new System.Windows.RoutedEventHandler(this.IsUndoEnabled_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;

namespace CaliburnTestProject
{
        public class BindableFocusBehavior : Behavior<Control>
        {
            public static readonly DependencyProperty HasFocusProperty =
                DependencyProperty.Register("HasFocus", typeof(bool), typeof(BindableFocusBehavior), new PropertyMetadata(default(bool), HasFocusUpdated));

            private static void HasFocusUpdated(DependencyObject d, DependencyPropertyChangedEventArgs e)
            {
                ((BindableFocusBehavior)d).SetFocus();
            }

            public bool HasFocus
            {
                get { return (bool)GetValue(HasFocusProperty); }
                set { SetValue(HasFocusProperty, value); }
            }

            private void SetFocus()
            {
                if (HasFocus)
                {
                    AssociatedObject.Focus();
                }
            }
        }
}

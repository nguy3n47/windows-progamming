using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Notepad
{
    public static class CustomCommands
    {
        public static readonly RoutedUICommand NewWindows = new RoutedUICommand
            (
                "NewWindows",
                "NewWindows",
                typeof(CustomCommands),
                new InputGestureCollection()
                {
                    new KeyGesture(Key.N, ModifierKeys.Shift | ModifierKeys.Control)
                }
            );

        public static readonly RoutedUICommand FindNext = new RoutedUICommand
            (
                "FindNext",
                "FindNext",
                typeof(CustomCommands),
                new InputGestureCollection()
                {
                    new KeyGesture(Key.F3)
                }
            );

        public static readonly RoutedUICommand GoTo = new RoutedUICommand
           (
               "GoTo",
               "Goto",
               typeof(CustomCommands),
               new InputGestureCollection()
                {
                    new KeyGesture(Key.G,ModifierKeys.Control)
                }
           );
        public static readonly RoutedUICommand TimeDate = new RoutedUICommand
           (
               "TimeDate",
               "TimeDate",
               typeof(CustomCommands),
               new InputGestureCollection()
                {
                    new KeyGesture(Key.F5)
                }
           );
        public static readonly RoutedUICommand SelectAll = new RoutedUICommand
           (
               "SelectAll",
               "SelectAll",
               typeof(CustomCommands),
               new InputGestureCollection()
                {
                    new KeyGesture(Key.A,ModifierKeys.Control)
                }
           );
        //Define more commands here, just like the one above
    }
}

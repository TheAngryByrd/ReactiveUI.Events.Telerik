using System;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Subjects;

using System.Windows.Interop;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using System.ComponentModel;
using System.Runtime.InteropServices.Automation;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media.Animation;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Microsoft.Phone.Shell;
using Microsoft.Devices;
using System.Windows.Navigation;
using Microsoft.Phone.UserData;
using Microsoft.Phone.BackgroundTransfer;
using Microsoft.Phone.BackgroundAudio;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Notification;
using Microsoft.Phone.Media;
using Microsoft.Phone.SecureElement;
using Microsoft.Phone.Maps.Controls;

namespace System.Windows.Interop
{
    public static class EventsMixin
    {
        public static ContentEvents Events(this Content This)
        {
            return new ContentEvents(This);
        }
        public static SilverlightHostEvents Events(this SilverlightHost This)
        {
            return new SilverlightHostEvents(This);
        }
    }

    public class ContentEvents
    {
        Content This;

        public ContentEvents(Content This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> ScaleFactorChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.ScaleFactorChanged += x, x => This.ScaleFactorChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Resized {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Resized += x, x => This.Resized -= x).Select(x => x.EventArgs); }
        }

    }
    public class SilverlightHostEvents
    {
        SilverlightHost This;

        public SilverlightHostEvents(SilverlightHost This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Interop.NavigationStateChangedEventArgs> NavigationStateChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Interop.NavigationStateChangedEventArgs>, System.Windows.Interop.NavigationStateChangedEventArgs>(x => This.NavigationStateChanged += x, x => This.NavigationStateChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace System.Windows
{
    public static class EventsMixin
    {
        public static ApplicationEvents Events(this Application This)
        {
            return new ApplicationEvents(This);
        }
        public static UIElementEvents Events(this UIElement This)
        {
            return new UIElementEvents(This);
        }
        public static FrameworkElementEvents Events(this FrameworkElement This)
        {
            return new FrameworkElementEvents(This);
        }
        public static VisualStateGroupEvents Events(this VisualStateGroup This)
        {
            return new VisualStateGroupEvents(This);
        }
    }

    public class ApplicationEvents
    {
        Application This;

        public ApplicationEvents(Application This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.StartupEventArgs> Startup {
            get { return Observable.FromEventPattern<System.Windows.StartupEventHandler, System.Windows.StartupEventArgs>(x => This.Startup += x, x => This.Startup -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Exit {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Exit += x, x => This.Exit -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.ApplicationUnhandledExceptionEventArgs> UnhandledException {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.ApplicationUnhandledExceptionEventArgs>, System.Windows.ApplicationUnhandledExceptionEventArgs>(x => This.UnhandledException += x, x => This.UnhandledException -= x).Select(x => x.EventArgs); }
        }

    }
    public class UIElementEvents
    {
        UIElement This;

        public UIElementEvents(UIElement This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Input.ManipulationStartedEventArgs> ManipulationStarted {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Input.ManipulationStartedEventArgs>, System.Windows.Input.ManipulationStartedEventArgs>(x => This.ManipulationStarted += x, x => This.ManipulationStarted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.ManipulationDeltaEventArgs> ManipulationDelta {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Input.ManipulationDeltaEventArgs>, System.Windows.Input.ManipulationDeltaEventArgs>(x => This.ManipulationDelta += x, x => This.ManipulationDelta -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.ManipulationCompletedEventArgs> ManipulationCompleted {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Input.ManipulationCompletedEventArgs>, System.Windows.Input.ManipulationCompletedEventArgs>(x => This.ManipulationCompleted += x, x => This.ManipulationCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.GestureEventArgs> Tap {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Input.GestureEventArgs>, System.Windows.Input.GestureEventArgs>(x => This.Tap += x, x => This.Tap -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.GestureEventArgs> DoubleTap {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Input.GestureEventArgs>, System.Windows.Input.GestureEventArgs>(x => This.DoubleTap += x, x => This.DoubleTap -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.GestureEventArgs> Hold {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Input.GestureEventArgs>, System.Windows.Input.GestureEventArgs>(x => This.Hold += x, x => This.Hold -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseEventArgs> MouseMove {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(x => This.MouseMove += x, x => This.MouseMove -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseEventArgs> MouseEnter {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(x => This.MouseEnter += x, x => This.MouseEnter -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseEventArgs> MouseLeave {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(x => This.MouseLeave += x, x => This.MouseLeave -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> MouseLeftButtonDown {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.MouseLeftButtonDown += x, x => This.MouseLeftButtonDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> MouseLeftButtonUp {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.MouseLeftButtonUp += x, x => This.MouseLeftButtonUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseWheelEventArgs> MouseWheel {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseWheelEventHandler, System.Windows.Input.MouseWheelEventArgs>(x => This.MouseWheel += x, x => This.MouseWheel -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.KeyEventArgs> KeyUp {
            get { return Observable.FromEventPattern<System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(x => This.KeyUp += x, x => This.KeyUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.KeyEventArgs> KeyDown {
            get { return Observable.FromEventPattern<System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(x => This.KeyDown += x, x => This.KeyDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> GotFocus {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.GotFocus += x, x => This.GotFocus -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> LostFocus {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.LostFocus += x, x => This.LostFocus -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseEventArgs> LostMouseCapture {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(x => This.LostMouseCapture += x, x => This.LostMouseCapture -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.TextCompositionEventArgs> TextInput {
            get { return Observable.FromEventPattern<System.Windows.Input.TextCompositionEventHandler, System.Windows.Input.TextCompositionEventArgs>(x => This.TextInput += x, x => This.TextInput -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.TextCompositionEventArgs> TextInputStart {
            get { return Observable.FromEventPattern<System.Windows.Input.TextCompositionEventHandler, System.Windows.Input.TextCompositionEventArgs>(x => This.TextInputStart += x, x => This.TextInputStart -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.TextCompositionEventArgs> TextInputUpdate {
            get { return Observable.FromEventPattern<System.Windows.Input.TextCompositionEventHandler, System.Windows.Input.TextCompositionEventArgs>(x => This.TextInputUpdate += x, x => This.TextInputUpdate -= x).Select(x => x.EventArgs); }
        }

    }
    public class FrameworkElementEvents
        : System.Windows.UIElementEvents
    {
        FrameworkElement This;

        public FrameworkElementEvents(FrameworkElement This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.SizeChangedEventArgs> SizeChanged {
            get { return Observable.FromEventPattern<System.Windows.SizeChangedEventHandler, System.Windows.SizeChangedEventArgs>(x => This.SizeChanged += x, x => This.SizeChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> LayoutUpdated {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.LayoutUpdated += x, x => This.LayoutUpdated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.ValidationErrorEventArgs> BindingValidationError {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Controls.ValidationErrorEventArgs>, System.Windows.Controls.ValidationErrorEventArgs>(x => This.BindingValidationError += x, x => This.BindingValidationError -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> Loaded {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.Loaded += x, x => This.Loaded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> Unloaded {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.Unloaded += x, x => This.Unloaded -= x).Select(x => x.EventArgs); }
        }

    }
    public class VisualStateGroupEvents
    {
        VisualStateGroup This;

        public VisualStateGroupEvents(VisualStateGroup This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.VisualStateChangedEventArgs> CurrentStateChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.VisualStateChangedEventArgs>, System.Windows.VisualStateChangedEventArgs>(x => This.CurrentStateChanged += x, x => This.CurrentStateChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.VisualStateChangedEventArgs> CurrentStateChanging {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.VisualStateChangedEventArgs>, System.Windows.VisualStateChangedEventArgs>(x => This.CurrentStateChanging += x, x => This.CurrentStateChanging -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace System.Windows.Controls
{
    public static class EventsMixin
    {
        public static ControlEvents Events(this Control This)
        {
            return new ControlEvents(This);
        }
        public static ComboBoxEvents Events(this ComboBox This)
        {
            return new ComboBoxEvents(This);
        }
        public static ImageEvents Events(this Image This)
        {
            return new ImageEvents(This);
        }
        public static ItemContainerGeneratorEvents Events(this ItemContainerGenerator This)
        {
            return new ItemContainerGeneratorEvents(This);
        }
        public static MediaElementEvents Events(this MediaElement This)
        {
            return new MediaElementEvents(This);
        }
        public static PasswordBoxEvents Events(this PasswordBox This)
        {
            return new PasswordBoxEvents(This);
        }
        public static RichTextBoxEvents Events(this RichTextBox This)
        {
            return new RichTextBoxEvents(This);
        }
        public static TextBoxEvents Events(this TextBox This)
        {
            return new TextBoxEvents(This);
        }
        public static ToolTipEvents Events(this ToolTip This)
        {
            return new ToolTipEvents(This);
        }
        public static VirtualizingStackPanelEvents Events(this VirtualizingStackPanel This)
        {
            return new VirtualizingStackPanelEvents(This);
        }
        public static MultiScaleImageEvents Events(this MultiScaleImage This)
        {
            return new MultiScaleImageEvents(This);
        }
        public static FrameEvents Events(this Frame This)
        {
            return new FrameEvents(This);
        }
    }

    public class ControlEvents
        : System.Windows.FrameworkElementEvents
    {
        Control This;

        public ControlEvents(Control This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsEnabledChanged {
            get { return Observable.FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(x => This.IsEnabledChanged += x, x => This.IsEnabledChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ComboBoxEvents
        : System.Windows.Controls.Primitives.SelectorEvents
    {
        ComboBox This;

        public ComboBoxEvents(ComboBox This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> DropDownClosed {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DropDownClosed += x, x => This.DropDownClosed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DropDownOpened {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DropDownOpened += x, x => This.DropDownOpened -= x).Select(x => x.EventArgs); }
        }

    }
    public class ImageEvents
        : System.Windows.FrameworkElementEvents
    {
        Image This;

        public ImageEvents(Image This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.ExceptionRoutedEventArgs> ImageFailed {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.ExceptionRoutedEventArgs>, System.Windows.ExceptionRoutedEventArgs>(x => This.ImageFailed += x, x => This.ImageFailed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> ImageOpened {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.RoutedEventArgs>, System.Windows.RoutedEventArgs>(x => This.ImageOpened += x, x => This.ImageOpened -= x).Select(x => x.EventArgs); }
        }

    }
    public class ItemContainerGeneratorEvents
    {
        ItemContainerGenerator This;

        public ItemContainerGeneratorEvents(ItemContainerGenerator This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Controls.Primitives.ItemsChangedEventArgs> ItemsChanged {
            get { return Observable.FromEventPattern<System.Windows.Controls.Primitives.ItemsChangedEventHandler, System.Windows.Controls.Primitives.ItemsChangedEventArgs>(x => This.ItemsChanged += x, x => This.ItemsChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class MediaElementEvents
        : System.Windows.FrameworkElementEvents
    {
        MediaElement This;

        public MediaElementEvents(MediaElement This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.ExceptionRoutedEventArgs> MediaFailed {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.ExceptionRoutedEventArgs>, System.Windows.ExceptionRoutedEventArgs>(x => This.MediaFailed += x, x => This.MediaFailed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Media.TimelineMarkerRoutedEventArgs> MarkerReached {
            get { return Observable.FromEventPattern<System.Windows.Media.TimelineMarkerRoutedEventHandler, System.Windows.Media.TimelineMarkerRoutedEventArgs>(x => This.MarkerReached += x, x => This.MarkerReached -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> MediaOpened {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.MediaOpened += x, x => This.MediaOpened -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> MediaEnded {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.MediaEnded += x, x => This.MediaEnded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> DownloadProgressChanged {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.DownloadProgressChanged += x, x => This.DownloadProgressChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> BufferingProgressChanged {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.BufferingProgressChanged += x, x => This.BufferingProgressChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> CurrentStateChanged {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.CurrentStateChanged += x, x => This.CurrentStateChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Media.LogReadyRoutedEventArgs> LogReady {
            get { return Observable.FromEventPattern<System.Windows.Media.LogReadyRoutedEventHandler, System.Windows.Media.LogReadyRoutedEventArgs>(x => This.LogReady += x, x => This.LogReady -= x).Select(x => x.EventArgs); }
        }

    }
    public class PasswordBoxEvents
        : System.Windows.Controls.ControlEvents
    {
        PasswordBox This;

        public PasswordBoxEvents(PasswordBox This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.RoutedEventArgs> PasswordChanged {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.PasswordChanged += x, x => This.PasswordChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class RichTextBoxEvents
        : System.Windows.Controls.ControlEvents
    {
        RichTextBox This;

        public RichTextBoxEvents(RichTextBox This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.RoutedEventArgs> SelectionChanged {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.SelectionChanged += x, x => This.SelectionChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.ContentChangedEventArgs> ContentChanged {
            get { return Observable.FromEventPattern<System.Windows.Controls.ContentChangedEventHandler, System.Windows.Controls.ContentChangedEventArgs>(x => This.ContentChanged += x, x => This.ContentChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class TextBoxEvents
        : System.Windows.Controls.ControlEvents
    {
        TextBox This;

        public TextBoxEvents(TextBox This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Controls.TextChangedEventArgs> TextChanged {
            get { return Observable.FromEventPattern<System.Windows.Controls.TextChangedEventHandler, System.Windows.Controls.TextChangedEventArgs>(x => This.TextChanged += x, x => This.TextChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> SelectionChanged {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.SelectionChanged += x, x => This.SelectionChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ToolTipEvents
        : System.Windows.Controls.ControlEvents
    {
        ToolTip This;

        public ToolTipEvents(ToolTip This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.RoutedEventArgs> Closed {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.Closed += x, x => This.Closed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> Opened {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.Opened += x, x => This.Opened -= x).Select(x => x.EventArgs); }
        }

    }
    public class VirtualizingStackPanelEvents
        : System.Windows.FrameworkElementEvents
    {
        VirtualizingStackPanel This;

        public VirtualizingStackPanelEvents(VirtualizingStackPanel This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Controls.CleanUpVirtualizedItemEventArgs> CleanUpVirtualizedItemEvent {
            get { return Observable.FromEventPattern<System.Windows.Controls.CleanUpVirtualizedItemEventHandler, System.Windows.Controls.CleanUpVirtualizedItemEventArgs>(x => This.CleanUpVirtualizedItemEvent += x, x => This.CleanUpVirtualizedItemEvent -= x).Select(x => x.EventArgs); }
        }

    }
    public class MultiScaleImageEvents
        : System.Windows.FrameworkElementEvents
    {
        MultiScaleImage This;

        public MultiScaleImageEvents(MultiScaleImage This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.ExceptionRoutedEventArgs> ImageOpenFailed {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.ExceptionRoutedEventArgs>, System.Windows.ExceptionRoutedEventArgs>(x => This.ImageOpenFailed += x, x => This.ImageOpenFailed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> MotionFinished {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.MotionFinished += x, x => This.MotionFinished -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> ImageOpenSucceeded {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.ImageOpenSucceeded += x, x => This.ImageOpenSucceeded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> ViewportChanged {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.ViewportChanged += x, x => This.ViewportChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> ImageFailed {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.ImageFailed += x, x => This.ImageFailed -= x).Select(x => x.EventArgs); }
        }

    }
    public class FrameEvents
        : System.Windows.Controls.ControlEvents
    {
        Frame This;

        public FrameEvents(Frame This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Navigation.NavigationEventArgs> Navigated {
            get { return Observable.FromEventPattern<System.Windows.Navigation.NavigatedEventHandler, System.Windows.Navigation.NavigationEventArgs>(x => This.Navigated += x, x => This.Navigated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Navigation.NavigatingCancelEventArgs> Navigating {
            get { return Observable.FromEventPattern<System.Windows.Navigation.NavigatingCancelEventHandler, System.Windows.Navigation.NavigatingCancelEventArgs>(x => This.Navigating += x, x => This.Navigating -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Navigation.NavigationFailedEventArgs> NavigationFailed {
            get { return Observable.FromEventPattern<System.Windows.Navigation.NavigationFailedEventHandler, System.Windows.Navigation.NavigationFailedEventArgs>(x => This.NavigationFailed += x, x => This.NavigationFailed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Navigation.NavigationEventArgs> NavigationStopped {
            get { return Observable.FromEventPattern<System.Windows.Navigation.NavigationStoppedEventHandler, System.Windows.Navigation.NavigationEventArgs>(x => This.NavigationStopped += x, x => This.NavigationStopped -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Navigation.FragmentNavigationEventArgs> FragmentNavigation {
            get { return Observable.FromEventPattern<System.Windows.Navigation.FragmentNavigationEventHandler, System.Windows.Navigation.FragmentNavigationEventArgs>(x => This.FragmentNavigation += x, x => This.FragmentNavigation -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace System.Windows.Threading
{
    public static class EventsMixin
    {
        public static DispatcherTimerEvents Events(this DispatcherTimer This)
        {
            return new DispatcherTimerEvents(This);
        }
    }

    public class DispatcherTimerEvents
    {
        DispatcherTimer This;

        public DispatcherTimerEvents(DispatcherTimer This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Tick {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Tick += x, x => This.Tick -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace System.ComponentModel
{
    public static class EventsMixin
    {
        public static ICollectionViewEvents Events(this ICollectionView This)
        {
            return new ICollectionViewEvents(This);
        }
    }

    public class ICollectionViewEvents
    {
        ICollectionView This;

        public ICollectionViewEvents(ICollectionView This)
        {
            this.This = This;
        }

        public IObservable<System.ComponentModel.CurrentChangingEventArgs> CurrentChanging {
            get { return Observable.FromEventPattern<System.ComponentModel.CurrentChangingEventHandler, System.ComponentModel.CurrentChangingEventArgs>(x => This.CurrentChanging += x, x => This.CurrentChanging -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> CurrentChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.CurrentChanged += x, x => This.CurrentChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace System.Runtime.InteropServices.Automation
{
    public static class EventsMixin
    {
        public static AutomationEventEvents Events(this AutomationEvent This)
        {
            return new AutomationEventEvents(This);
        }
    }

    public class AutomationEventEvents
    {
        AutomationEvent This;

        public AutomationEventEvents(AutomationEvent This)
        {
            this.This = This;
        }

        public IObservable<System.Runtime.InteropServices.Automation.AutomationEventArgs> EventRaised {
            get { return Observable.FromEventPattern<System.EventHandler<System.Runtime.InteropServices.Automation.AutomationEventArgs>, System.Runtime.InteropServices.Automation.AutomationEventArgs>(x => This.EventRaised += x, x => This.EventRaised -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace System.Windows.Controls.Primitives
{
    public static class EventsMixin
    {
        public static ButtonBaseEvents Events(this ButtonBase This)
        {
            return new ButtonBaseEvents(This);
        }
        public static ToggleButtonEvents Events(this ToggleButton This)
        {
            return new ToggleButtonEvents(This);
        }
        public static SelectorEvents Events(this Selector This)
        {
            return new SelectorEvents(This);
        }
        public static ViewportControlEvents Events(this ViewportControl This)
        {
            return new ViewportControlEvents(This);
        }
        public static PopupEvents Events(this Popup This)
        {
            return new PopupEvents(This);
        }
        public static RangeBaseEvents Events(this RangeBase This)
        {
            return new RangeBaseEvents(This);
        }
        public static ScrollBarEvents Events(this ScrollBar This)
        {
            return new ScrollBarEvents(This);
        }
        public static ThumbEvents Events(this Thumb This)
        {
            return new ThumbEvents(This);
        }
    }

    public class ButtonBaseEvents
        : System.Windows.Controls.ControlEvents
    {
        ButtonBase This;

        public ButtonBaseEvents(ButtonBase This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.RoutedEventArgs> Click {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.Click += x, x => This.Click -= x).Select(x => x.EventArgs); }
        }

    }
    public class ToggleButtonEvents
        : System.Windows.Controls.Primitives.ButtonBaseEvents
    {
        ToggleButton This;

        public ToggleButtonEvents(ToggleButton This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.RoutedEventArgs> Checked {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.Checked += x, x => This.Checked -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> Indeterminate {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.Indeterminate += x, x => This.Indeterminate -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> Unchecked {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.Unchecked += x, x => This.Unchecked -= x).Select(x => x.EventArgs); }
        }

    }
    public class SelectorEvents
        : System.Windows.Controls.ControlEvents
    {
        Selector This;

        public SelectorEvents(Selector This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Controls.SelectionChangedEventArgs> SelectionChanged {
            get { return Observable.FromEventPattern<System.Windows.Controls.SelectionChangedEventHandler, System.Windows.Controls.SelectionChangedEventArgs>(x => This.SelectionChanged += x, x => This.SelectionChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ViewportControlEvents
        : System.Windows.Controls.ControlEvents
    {
        ViewportControl This;

        public ViewportControlEvents(ViewportControl This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Controls.Primitives.ViewportChangedEventArgs> ViewportChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Controls.Primitives.ViewportChangedEventArgs>, System.Windows.Controls.Primitives.ViewportChangedEventArgs>(x => This.ViewportChanged += x, x => This.ViewportChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.Primitives.ManipulationStateChangedEventArgs> ManipulationStateChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Controls.Primitives.ManipulationStateChangedEventArgs>, System.Windows.Controls.Primitives.ManipulationStateChangedEventArgs>(x => This.ManipulationStateChanged += x, x => This.ManipulationStateChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class PopupEvents
        : System.Windows.FrameworkElementEvents
    {
        Popup This;

        public PopupEvents(Popup This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Opened {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Opened += x, x => This.Opened -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Closed {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Closed += x, x => This.Closed -= x).Select(x => x.EventArgs); }
        }

    }
    public class RangeBaseEvents
        : System.Windows.Controls.ControlEvents
    {
        RangeBase This;

        public RangeBaseEvents(RangeBase This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.RoutedPropertyChangedEventArgs<System.Double>> ValueChanged {
            get { return Observable.FromEventPattern<System.Windows.RoutedPropertyChangedEventHandler<System.Double>, System.Windows.RoutedPropertyChangedEventArgs<System.Double>>(x => This.ValueChanged += x, x => This.ValueChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ScrollBarEvents
        : System.Windows.Controls.Primitives.RangeBaseEvents
    {
        ScrollBar This;

        public ScrollBarEvents(ScrollBar This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Controls.Primitives.ScrollEventArgs> Scroll {
            get { return Observable.FromEventPattern<System.Windows.Controls.Primitives.ScrollEventHandler, System.Windows.Controls.Primitives.ScrollEventArgs>(x => This.Scroll += x, x => This.Scroll -= x).Select(x => x.EventArgs); }
        }

    }
    public class ThumbEvents
        : System.Windows.Controls.ControlEvents
    {
        Thumb This;

        public ThumbEvents(Thumb This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Controls.Primitives.DragStartedEventArgs> DragStarted {
            get { return Observable.FromEventPattern<System.Windows.Controls.Primitives.DragStartedEventHandler, System.Windows.Controls.Primitives.DragStartedEventArgs>(x => This.DragStarted += x, x => This.DragStarted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.Primitives.DragDeltaEventArgs> DragDelta {
            get { return Observable.FromEventPattern<System.Windows.Controls.Primitives.DragDeltaEventHandler, System.Windows.Controls.Primitives.DragDeltaEventArgs>(x => This.DragDelta += x, x => This.DragDelta -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.Primitives.DragCompletedEventArgs> DragCompleted {
            get { return Observable.FromEventPattern<System.Windows.Controls.Primitives.DragCompletedEventHandler, System.Windows.Controls.Primitives.DragCompletedEventArgs>(x => This.DragCompleted += x, x => This.DragCompleted -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace System.Windows.Data
{
    public static class EventsMixin
    {
        public static CollectionViewSourceEvents Events(this CollectionViewSource This)
        {
            return new CollectionViewSourceEvents(This);
        }
    }

    public class CollectionViewSourceEvents
    {
        CollectionViewSource This;

        public CollectionViewSourceEvents(CollectionViewSource This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Data.FilterEventArgs> Filter {
            get { return Observable.FromEventPattern<System.Windows.Data.FilterEventHandler, System.Windows.Data.FilterEventArgs>(x => This.Filter += x, x => This.Filter -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace System.Windows.Documents
{
    public static class EventsMixin
    {
        public static HyperlinkEvents Events(this Hyperlink This)
        {
            return new HyperlinkEvents(This);
        }
    }

    public class HyperlinkEvents
    {
        Hyperlink This;

        public HyperlinkEvents(Hyperlink This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.RoutedEventArgs> Click {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.Click += x, x => This.Click -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace System.Windows.Media.Animation
{
    public static class EventsMixin
    {
        public static TimelineEvents Events(this Timeline This)
        {
            return new TimelineEvents(This);
        }
    }

    public class TimelineEvents
    {
        Timeline This;

        public TimelineEvents(Timeline This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Completed {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Completed += x, x => This.Completed -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace System.Windows.Media
{
    public static class EventsMixin
    {
        public static ImageBrushEvents Events(this ImageBrush This)
        {
            return new ImageBrushEvents(This);
        }
        public static CaptureSourceEvents Events(this CaptureSource This)
        {
            return new CaptureSourceEvents(This);
        }
        public static DomainAcquirerEvents Events(this DomainAcquirer This)
        {
            return new DomainAcquirerEvents(This);
        }
        public static LicenseAcquirerEvents Events(this LicenseAcquirer This)
        {
            return new LicenseAcquirerEvents(This);
        }
    }

    public class ImageBrushEvents
    {
        ImageBrush This;

        public ImageBrushEvents(ImageBrush This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.ExceptionRoutedEventArgs> ImageFailed {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.ExceptionRoutedEventArgs>, System.Windows.ExceptionRoutedEventArgs>(x => This.ImageFailed += x, x => This.ImageFailed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> ImageOpened {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.RoutedEventArgs>, System.Windows.RoutedEventArgs>(x => This.ImageOpened += x, x => This.ImageOpened -= x).Select(x => x.EventArgs); }
        }

    }
    public class CaptureSourceEvents
    {
        CaptureSource This;

        public CaptureSourceEvents(CaptureSource This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.ExceptionRoutedEventArgs> CaptureFailed {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.ExceptionRoutedEventArgs>, System.Windows.ExceptionRoutedEventArgs>(x => This.CaptureFailed += x, x => This.CaptureFailed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Media.CaptureImageCompletedEventArgs> CaptureImageCompleted {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Media.CaptureImageCompletedEventArgs>, System.Windows.Media.CaptureImageCompletedEventArgs>(x => This.CaptureImageCompleted += x, x => This.CaptureImageCompleted -= x).Select(x => x.EventArgs); }
        }

    }
    public class DomainAcquirerEvents
    {
        DomainAcquirer This;

        public DomainAcquirerEvents(DomainAcquirer This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Media.JoinDomainCompletedEventArgs> JoinDomainCompleted {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Media.JoinDomainCompletedEventArgs>, System.Windows.Media.JoinDomainCompletedEventArgs>(x => This.JoinDomainCompleted += x, x => This.JoinDomainCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Media.LeaveDomainCompletedEventArgs> LeaveDomainCompleted {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Media.LeaveDomainCompletedEventArgs>, System.Windows.Media.LeaveDomainCompletedEventArgs>(x => This.LeaveDomainCompleted += x, x => This.LeaveDomainCompleted -= x).Select(x => x.EventArgs); }
        }

    }
    public class LicenseAcquirerEvents
    {
        LicenseAcquirer This;

        public LicenseAcquirerEvents(LicenseAcquirer This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Media.AcquireLicenseCompletedEventArgs> AcquireLicenseCompleted {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Media.AcquireLicenseCompletedEventArgs>, System.Windows.Media.AcquireLicenseCompletedEventArgs>(x => This.AcquireLicenseCompleted += x, x => This.AcquireLicenseCompleted -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace System.Windows.Media.Imaging
{
    public static class EventsMixin
    {
        public static BitmapImageEvents Events(this BitmapImage This)
        {
            return new BitmapImageEvents(This);
        }
    }

    public class BitmapImageEvents
    {
        BitmapImage This;

        public BitmapImageEvents(BitmapImage This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Media.Imaging.DownloadProgressEventArgs> DownloadProgress {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Media.Imaging.DownloadProgressEventArgs>, System.Windows.Media.Imaging.DownloadProgressEventArgs>(x => This.DownloadProgress += x, x => This.DownloadProgress -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.ExceptionRoutedEventArgs> ImageFailed {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.ExceptionRoutedEventArgs>, System.Windows.ExceptionRoutedEventArgs>(x => This.ImageFailed += x, x => This.ImageFailed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> ImageOpened {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.RoutedEventArgs>, System.Windows.RoutedEventArgs>(x => This.ImageOpened += x, x => This.ImageOpened -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Microsoft.Phone.Shell
{
    public static class EventsMixin
    {
        public static PhoneApplicationServiceEvents Events(this PhoneApplicationService This)
        {
            return new PhoneApplicationServiceEvents(This);
        }
        public static IApplicationBarEvents Events(this IApplicationBar This)
        {
            return new IApplicationBarEvents(This);
        }
        public static ApplicationBarEvents Events(this ApplicationBar This)
        {
            return new ApplicationBarEvents(This);
        }
        public static IApplicationBarMenuItemEvents Events(this IApplicationBarMenuItem This)
        {
            return new IApplicationBarMenuItemEvents(This);
        }
        public static ApplicationBarMenuItemEvents Events(this ApplicationBarMenuItem This)
        {
            return new ApplicationBarMenuItemEvents(This);
        }
        public static ApplicationBarIconButtonEvents Events(this ApplicationBarIconButton This)
        {
            return new ApplicationBarIconButtonEvents(This);
        }
    }

    public class PhoneApplicationServiceEvents
    {
        PhoneApplicationService This;

        public PhoneApplicationServiceEvents(PhoneApplicationService This)
        {
            this.This = This;
        }

        public IObservable<Microsoft.Phone.Shell.LaunchingEventArgs> Launching {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.Shell.LaunchingEventArgs>, Microsoft.Phone.Shell.LaunchingEventArgs>(x => This.Launching += x, x => This.Launching -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Microsoft.Phone.Shell.ActivatedEventArgs> Activated {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.Shell.ActivatedEventArgs>, Microsoft.Phone.Shell.ActivatedEventArgs>(x => This.Activated += x, x => This.Activated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Microsoft.Phone.Shell.DeactivatedEventArgs> Deactivated {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.Shell.DeactivatedEventArgs>, Microsoft.Phone.Shell.DeactivatedEventArgs>(x => This.Deactivated += x, x => This.Deactivated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Microsoft.Phone.Shell.RunningInBackgroundEventArgs> RunningInBackground {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.Shell.RunningInBackgroundEventArgs>, Microsoft.Phone.Shell.RunningInBackgroundEventArgs>(x => This.RunningInBackground += x, x => This.RunningInBackground -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Microsoft.Phone.Shell.ClosingEventArgs> Closing {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.Shell.ClosingEventArgs>, Microsoft.Phone.Shell.ClosingEventArgs>(x => This.Closing += x, x => This.Closing -= x).Select(x => x.EventArgs); }
        }

    }
    public class IApplicationBarEvents
    {
        IApplicationBar This;

        public IApplicationBarEvents(IApplicationBar This)
        {
            this.This = This;
        }

        public IObservable<Microsoft.Phone.Shell.ApplicationBarStateChangedEventArgs> StateChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.Shell.ApplicationBarStateChangedEventArgs>, Microsoft.Phone.Shell.ApplicationBarStateChangedEventArgs>(x => This.StateChanged += x, x => This.StateChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ApplicationBarEvents
    {
        ApplicationBar This;

        public ApplicationBarEvents(ApplicationBar This)
        {
            this.This = This;
        }

        public IObservable<Microsoft.Phone.Shell.ApplicationBarStateChangedEventArgs> StateChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.Shell.ApplicationBarStateChangedEventArgs>, Microsoft.Phone.Shell.ApplicationBarStateChangedEventArgs>(x => This.StateChanged += x, x => This.StateChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class IApplicationBarMenuItemEvents
    {
        IApplicationBarMenuItem This;

        public IApplicationBarMenuItemEvents(IApplicationBarMenuItem This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Click {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Click += x, x => This.Click -= x).Select(x => x.EventArgs); }
        }

    }
    public class ApplicationBarMenuItemEvents
    {
        ApplicationBarMenuItem This;

        public ApplicationBarMenuItemEvents(ApplicationBarMenuItem This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Click {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Click += x, x => This.Click -= x).Select(x => x.EventArgs); }
        }

    }
    public class ApplicationBarIconButtonEvents
    {
        ApplicationBarIconButton This;

        public ApplicationBarIconButtonEvents(ApplicationBarIconButton This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Click {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Click += x, x => This.Click -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Microsoft.Devices
{
    public static class EventsMixin
    {
        public static CameraEvents Events(this Camera This)
        {
            return new CameraEvents(This);
        }
        public static PhotoCameraEvents Events(this PhotoCamera This)
        {
            return new PhotoCameraEvents(This);
        }
    }

    public class CameraEvents
    {
        Camera This;

        public CameraEvents(Camera This)
        {
            this.This = This;
        }

        public IObservable<Microsoft.Devices.CameraOperationCompletedEventArgs> Initialized {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Devices.CameraOperationCompletedEventArgs>, Microsoft.Devices.CameraOperationCompletedEventArgs>(x => This.Initialized += x, x => This.Initialized -= x).Select(x => x.EventArgs); }
        }

    }
    public class PhotoCameraEvents
        : Microsoft.Devices.CameraEvents
    {
        PhotoCamera This;

        public PhotoCameraEvents(PhotoCamera This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Microsoft.Devices.CameraOperationCompletedEventArgs> AutoFocusCompleted {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Devices.CameraOperationCompletedEventArgs>, Microsoft.Devices.CameraOperationCompletedEventArgs>(x => This.AutoFocusCompleted += x, x => This.AutoFocusCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> CaptureStarted {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.CaptureStarted += x, x => This.CaptureStarted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Microsoft.Devices.ContentReadyEventArgs> CaptureThumbnailAvailable {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Devices.ContentReadyEventArgs>, Microsoft.Devices.ContentReadyEventArgs>(x => This.CaptureThumbnailAvailable += x, x => This.CaptureThumbnailAvailable -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Microsoft.Devices.ContentReadyEventArgs> CaptureImageAvailable {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Devices.ContentReadyEventArgs>, Microsoft.Devices.ContentReadyEventArgs>(x => This.CaptureImageAvailable += x, x => This.CaptureImageAvailable -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Microsoft.Devices.CameraOperationCompletedEventArgs> CaptureCompleted {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Devices.CameraOperationCompletedEventArgs>, Microsoft.Devices.CameraOperationCompletedEventArgs>(x => This.CaptureCompleted += x, x => This.CaptureCompleted -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace System.Windows.Navigation
{
    public static class EventsMixin
    {
        public static NavigationServiceEvents Events(this NavigationService This)
        {
            return new NavigationServiceEvents(This);
        }
    }

    public class NavigationServiceEvents
    {
        NavigationService This;

        public NavigationServiceEvents(NavigationService This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Navigation.NavigationFailedEventArgs> NavigationFailed {
            get { return Observable.FromEventPattern<System.Windows.Navigation.NavigationFailedEventHandler, System.Windows.Navigation.NavigationFailedEventArgs>(x => This.NavigationFailed += x, x => This.NavigationFailed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Navigation.NavigatingCancelEventArgs> Navigating {
            get { return Observable.FromEventPattern<System.Windows.Navigation.NavigatingCancelEventHandler, System.Windows.Navigation.NavigatingCancelEventArgs>(x => This.Navigating += x, x => This.Navigating -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Navigation.NavigationEventArgs> Navigated {
            get { return Observable.FromEventPattern<System.Windows.Navigation.NavigatedEventHandler, System.Windows.Navigation.NavigationEventArgs>(x => This.Navigated += x, x => This.Navigated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Navigation.NavigationEventArgs> NavigationStopped {
            get { return Observable.FromEventPattern<System.Windows.Navigation.NavigationStoppedEventHandler, System.Windows.Navigation.NavigationEventArgs>(x => This.NavigationStopped += x, x => This.NavigationStopped -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Navigation.FragmentNavigationEventArgs> FragmentNavigation {
            get { return Observable.FromEventPattern<System.Windows.Navigation.FragmentNavigationEventHandler, System.Windows.Navigation.FragmentNavigationEventArgs>(x => This.FragmentNavigation += x, x => This.FragmentNavigation -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Navigation.JournalEntryRemovedEventArgs> JournalEntryRemoved {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Navigation.JournalEntryRemovedEventArgs>, System.Windows.Navigation.JournalEntryRemovedEventArgs>(x => This.JournalEntryRemoved += x, x => This.JournalEntryRemoved -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Microsoft.Phone.UserData
{
    public static class EventsMixin
    {
        public static AppointmentsEvents Events(this Appointments This)
        {
            return new AppointmentsEvents(This);
        }
        public static ContactsEvents Events(this Contacts This)
        {
            return new ContactsEvents(This);
        }
    }

    public class AppointmentsEvents
    {
        Appointments This;

        public AppointmentsEvents(Appointments This)
        {
            this.This = This;
        }

        public IObservable<Microsoft.Phone.UserData.AppointmentsSearchEventArgs> SearchCompleted {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.UserData.AppointmentsSearchEventArgs>, Microsoft.Phone.UserData.AppointmentsSearchEventArgs>(x => This.SearchCompleted += x, x => This.SearchCompleted -= x).Select(x => x.EventArgs); }
        }

    }
    public class ContactsEvents
    {
        Contacts This;

        public ContactsEvents(Contacts This)
        {
            this.This = This;
        }

        public IObservable<Microsoft.Phone.UserData.ContactsSearchEventArgs> SearchCompleted {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.UserData.ContactsSearchEventArgs>, Microsoft.Phone.UserData.ContactsSearchEventArgs>(x => This.SearchCompleted += x, x => This.SearchCompleted -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Microsoft.Phone.BackgroundTransfer
{
    public static class EventsMixin
    {
        public static BackgroundTransferRequestEvents Events(this BackgroundTransferRequest This)
        {
            return new BackgroundTransferRequestEvents(This);
        }
    }

    public class BackgroundTransferRequestEvents
    {
        BackgroundTransferRequest This;

        public BackgroundTransferRequestEvents(BackgroundTransferRequest This)
        {
            this.This = This;
        }

        public IObservable<Microsoft.Phone.BackgroundTransfer.BackgroundTransferEventArgs> TransferStatusChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.BackgroundTransfer.BackgroundTransferEventArgs>, Microsoft.Phone.BackgroundTransfer.BackgroundTransferEventArgs>(x => This.TransferStatusChanged += x, x => This.TransferStatusChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Microsoft.Phone.BackgroundTransfer.BackgroundTransferEventArgs> TransferProgressChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.BackgroundTransfer.BackgroundTransferEventArgs>, Microsoft.Phone.BackgroundTransfer.BackgroundTransferEventArgs>(x => This.TransferProgressChanged += x, x => This.TransferProgressChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Microsoft.Phone.BackgroundAudio
{
    public static class EventsMixin
    {
        public static BackgroundAudioPlayerEvents Events(this BackgroundAudioPlayer This)
        {
            return new BackgroundAudioPlayerEvents(This);
        }
    }

    public class BackgroundAudioPlayerEvents
    {
        BackgroundAudioPlayer This;

        public BackgroundAudioPlayerEvents(BackgroundAudioPlayer This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> PlayStateChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.PlayStateChanged += x, x => This.PlayStateChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Microsoft.Phone.Controls
{
    public static class EventsMixin
    {
        public static PhoneApplicationFrameEvents Events(this PhoneApplicationFrame This)
        {
            return new PhoneApplicationFrameEvents(This);
        }
        public static PhoneApplicationPageEvents Events(this PhoneApplicationPage This)
        {
            return new PhoneApplicationPageEvents(This);
        }
        public static LongListSelectorEvents Events(this LongListSelector This)
        {
            return new LongListSelectorEvents(This);
        }
        public static WebBrowserEvents Events(this WebBrowser This)
        {
            return new WebBrowserEvents(This);
        }
        public static PanoramaEvents Events(this Panorama This)
        {
            return new PanoramaEvents(This);
        }
        public static PivotEvents Events(this Pivot This)
        {
            return new PivotEvents(This);
        }
    }

    public class PhoneApplicationFrameEvents
        : System.Windows.Controls.FrameEvents
    {
        PhoneApplicationFrame This;

        public PhoneApplicationFrameEvents(PhoneApplicationFrame This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Microsoft.Phone.Controls.OrientationChangedEventArgs> OrientationChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.Controls.OrientationChangedEventArgs>, Microsoft.Phone.Controls.OrientationChangedEventArgs>(x => This.OrientationChanged += x, x => This.OrientationChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Microsoft.Phone.Controls.ObscuredEventArgs> Obscured {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.Controls.ObscuredEventArgs>, Microsoft.Phone.Controls.ObscuredEventArgs>(x => This.Obscured += x, x => This.Obscured -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Unobscured {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Unobscured += x, x => This.Unobscured -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.ComponentModel.CancelEventArgs> BackKeyPress {
            get { return Observable.FromEventPattern<System.EventHandler<System.ComponentModel.CancelEventArgs>, System.ComponentModel.CancelEventArgs>(x => This.BackKeyPress += x, x => This.BackKeyPress -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Navigation.JournalEntryRemovedEventArgs> JournalEntryRemoved {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Navigation.JournalEntryRemovedEventArgs>, System.Windows.Navigation.JournalEntryRemovedEventArgs>(x => This.JournalEntryRemoved += x, x => This.JournalEntryRemoved -= x).Select(x => x.EventArgs); }
        }

    }
    public class PhoneApplicationPageEvents
        : System.Windows.Controls.ControlEvents
    {
        PhoneApplicationPage This;

        public PhoneApplicationPageEvents(PhoneApplicationPage This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Microsoft.Phone.Controls.OrientationChangedEventArgs> BeginLayoutChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.Controls.OrientationChangedEventArgs>, Microsoft.Phone.Controls.OrientationChangedEventArgs>(x => This.BeginLayoutChanged += x, x => This.BeginLayoutChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Microsoft.Phone.Controls.OrientationChangedEventArgs> OrientationChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.Controls.OrientationChangedEventArgs>, Microsoft.Phone.Controls.OrientationChangedEventArgs>(x => This.OrientationChanged += x, x => This.OrientationChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.ComponentModel.CancelEventArgs> BackKeyPress {
            get { return Observable.FromEventPattern<System.EventHandler<System.ComponentModel.CancelEventArgs>, System.ComponentModel.CancelEventArgs>(x => This.BackKeyPress += x, x => This.BackKeyPress -= x).Select(x => x.EventArgs); }
        }

    }
    public class LongListSelectorEvents
        : System.Windows.Controls.ControlEvents
    {
        LongListSelector This;

        public LongListSelectorEvents(LongListSelector This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Controls.SelectionChangedEventArgs> SelectionChanged {
            get { return Observable.FromEventPattern<System.Windows.Controls.SelectionChangedEventHandler, System.Windows.Controls.SelectionChangedEventArgs>(x => This.SelectionChanged += x, x => This.SelectionChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Microsoft.Phone.Controls.ItemRealizationEventArgs> ItemRealized {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.Controls.ItemRealizationEventArgs>, Microsoft.Phone.Controls.ItemRealizationEventArgs>(x => This.ItemRealized += x, x => This.ItemRealized -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Microsoft.Phone.Controls.ItemRealizationEventArgs> ItemUnrealized {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.Controls.ItemRealizationEventArgs>, Microsoft.Phone.Controls.ItemRealizationEventArgs>(x => This.ItemUnrealized += x, x => This.ItemUnrealized -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> JumpListOpening {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.JumpListOpening += x, x => This.JumpListOpening -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> JumpListClosed {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.JumpListClosed += x, x => This.JumpListClosed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> ManipulationStateChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.ManipulationStateChanged += x, x => This.ManipulationStateChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.ComponentModel.PropertyChangedEventArgs> PropertyChanged {
            get { return Observable.FromEventPattern<System.ComponentModel.PropertyChangedEventHandler, System.ComponentModel.PropertyChangedEventArgs>(x => This.PropertyChanged += x, x => This.PropertyChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class WebBrowserEvents
        : System.Windows.Controls.ControlEvents
    {
        WebBrowser This;

        public WebBrowserEvents(WebBrowser This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Microsoft.Phone.Controls.NavigatingEventArgs> Navigating {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.Controls.NavigatingEventArgs>, Microsoft.Phone.Controls.NavigatingEventArgs>(x => This.Navigating += x, x => This.Navigating -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Navigation.NavigationEventArgs> Navigated {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Navigation.NavigationEventArgs>, System.Windows.Navigation.NavigationEventArgs>(x => This.Navigated += x, x => This.Navigated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Navigation.NavigationEventArgs> LoadCompleted {
            get { return Observable.FromEventPattern<System.Windows.Navigation.LoadCompletedEventHandler, System.Windows.Navigation.NavigationEventArgs>(x => This.LoadCompleted += x, x => This.LoadCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Navigation.NavigationFailedEventArgs> NavigationFailed {
            get { return Observable.FromEventPattern<System.Windows.Navigation.NavigationFailedEventHandler, System.Windows.Navigation.NavigationFailedEventArgs>(x => This.NavigationFailed += x, x => This.NavigationFailed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Microsoft.Phone.Controls.NotifyEventArgs> ScriptNotify {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.Controls.NotifyEventArgs>, Microsoft.Phone.Controls.NotifyEventArgs>(x => This.ScriptNotify += x, x => This.ScriptNotify -= x).Select(x => x.EventArgs); }
        }

    }
    public class PanoramaEvents
        : System.Windows.Controls.ControlEvents
    {
        Panorama This;

        public PanoramaEvents(Panorama This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Controls.SelectionChangedEventArgs> SelectionChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>, System.Windows.Controls.SelectionChangedEventArgs>(x => This.SelectionChanged += x, x => This.SelectionChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class PivotEvents
        : System.Windows.Controls.ControlEvents
    {
        Pivot This;

        public PivotEvents(Pivot This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Microsoft.Phone.Controls.PivotItemEventArgs> LoadingPivotItem {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.Controls.PivotItemEventArgs>, Microsoft.Phone.Controls.PivotItemEventArgs>(x => This.LoadingPivotItem += x, x => This.LoadingPivotItem -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Microsoft.Phone.Controls.PivotItemEventArgs> LoadedPivotItem {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.Controls.PivotItemEventArgs>, Microsoft.Phone.Controls.PivotItemEventArgs>(x => This.LoadedPivotItem += x, x => This.LoadedPivotItem -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Microsoft.Phone.Controls.PivotItemEventArgs> UnloadingPivotItem {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.Controls.PivotItemEventArgs>, Microsoft.Phone.Controls.PivotItemEventArgs>(x => This.UnloadingPivotItem += x, x => This.UnloadingPivotItem -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Microsoft.Phone.Controls.PivotItemEventArgs> UnloadedPivotItem {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.Controls.PivotItemEventArgs>, Microsoft.Phone.Controls.PivotItemEventArgs>(x => This.UnloadedPivotItem += x, x => This.UnloadedPivotItem -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.SelectionChangedEventArgs> SelectionChanged {
            get { return Observable.FromEventPattern<System.Windows.Controls.SelectionChangedEventHandler, System.Windows.Controls.SelectionChangedEventArgs>(x => This.SelectionChanged += x, x => This.SelectionChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Microsoft.Phone.Notification
{
    public static class EventsMixin
    {
        public static HttpNotificationChannelEvents Events(this HttpNotificationChannel This)
        {
            return new HttpNotificationChannelEvents(This);
        }
    }

    public class HttpNotificationChannelEvents
    {
        HttpNotificationChannel This;

        public HttpNotificationChannelEvents(HttpNotificationChannel This)
        {
            this.This = This;
        }

        public IObservable<Microsoft.Phone.Notification.NotificationChannelErrorEventArgs> ErrorOccurred {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.Notification.NotificationChannelErrorEventArgs>, Microsoft.Phone.Notification.NotificationChannelErrorEventArgs>(x => This.ErrorOccurred += x, x => This.ErrorOccurred -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Microsoft.Phone.Notification.NotificationChannelUriEventArgs> ChannelUriUpdated {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.Notification.NotificationChannelUriEventArgs>, Microsoft.Phone.Notification.NotificationChannelUriEventArgs>(x => This.ChannelUriUpdated += x, x => This.ChannelUriUpdated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Microsoft.Phone.Notification.NotificationChannelConnectionEventArgs> ConnectionStatusChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.Notification.NotificationChannelConnectionEventArgs>, Microsoft.Phone.Notification.NotificationChannelConnectionEventArgs>(x => This.ConnectionStatusChanged += x, x => This.ConnectionStatusChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Microsoft.Phone.Notification.HttpNotificationEventArgs> HttpNotificationReceived {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.Notification.HttpNotificationEventArgs>, Microsoft.Phone.Notification.HttpNotificationEventArgs>(x => This.HttpNotificationReceived += x, x => This.HttpNotificationReceived -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Microsoft.Phone.Notification.NotificationEventArgs> ShellToastNotificationReceived {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.Notification.NotificationEventArgs>, Microsoft.Phone.Notification.NotificationEventArgs>(x => This.ShellToastNotificationReceived += x, x => This.ShellToastNotificationReceived -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Microsoft.Phone.Media
{
    public static class EventsMixin
    {
        public static MediaStreamerEvents Events(this MediaStreamer This)
        {
            return new MediaStreamerEvents(This);
        }
    }

    public class MediaStreamerEvents
    {
        MediaStreamer This;

        public MediaStreamerEvents(MediaStreamer This)
        {
            this.This = This;
        }

        public IObservable<Microsoft.Phone.Media.MediaStreamerFailedEventArgs> MediaFailed {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.Media.MediaStreamerFailedEventArgs>, Microsoft.Phone.Media.MediaStreamerFailedEventArgs>(x => This.MediaFailed += x, x => This.MediaFailed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Microsoft.Phone.Media.MediaStreamerEndedEventArgs> MediaEnded {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.Media.MediaStreamerEndedEventArgs>, Microsoft.Phone.Media.MediaStreamerEndedEventArgs>(x => This.MediaEnded += x, x => This.MediaEnded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Microsoft.Phone.Media.MediaStreamerOpenedEventArgs> MediaOpened {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.Media.MediaStreamerOpenedEventArgs>, Microsoft.Phone.Media.MediaStreamerOpenedEventArgs>(x => This.MediaOpened += x, x => This.MediaOpened -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Microsoft.Phone.SecureElement
{
    public static class EventsMixin
    {
        public static SecureElementReaderEvents Events(this SecureElementReader This)
        {
            return new SecureElementReaderEvents(This);
        }
    }

    public class SecureElementReaderEvents
    {
        SecureElementReader This;

        public SecureElementReaderEvents(SecureElementReader This)
        {
            this.This = This;
        }

        public IObservable<Microsoft.Phone.SecureElement.RegisterSecureElementItemEventArgs> RegisterSecureElementItemCompleted {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.SecureElement.RegisterSecureElementItemEventArgs>, Microsoft.Phone.SecureElement.RegisterSecureElementItemEventArgs>(x => This.RegisterSecureElementItemCompleted += x, x => This.RegisterSecureElementItemCompleted -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Microsoft.Phone.Maps.Controls
{
    public static class EventsMixin
    {
        public static MapEvents Events(this Map This)
        {
            return new MapEvents(This);
        }
    }

    public class MapEvents
        : System.Windows.Controls.ControlEvents
    {
        Map This;

        public MapEvents(Map This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Microsoft.Phone.Maps.Controls.MapCenterChangedEventArgs> CenterChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.Maps.Controls.MapCenterChangedEventArgs>, Microsoft.Phone.Maps.Controls.MapCenterChangedEventArgs>(x => This.CenterChanged += x, x => This.CenterChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Microsoft.Phone.Maps.Controls.MapTransformCenterChangedEventArgs> TransformCenterChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.Maps.Controls.MapTransformCenterChangedEventArgs>, Microsoft.Phone.Maps.Controls.MapTransformCenterChangedEventArgs>(x => This.TransformCenterChanged += x, x => This.TransformCenterChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Microsoft.Phone.Maps.Controls.MapZoomLevelChangedEventArgs> ZoomLevelChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.Maps.Controls.MapZoomLevelChangedEventArgs>, Microsoft.Phone.Maps.Controls.MapZoomLevelChangedEventArgs>(x => This.ZoomLevelChanged += x, x => This.ZoomLevelChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Microsoft.Phone.Maps.Controls.MapHeadingChangedEventArgs> HeadingChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.Maps.Controls.MapHeadingChangedEventArgs>, Microsoft.Phone.Maps.Controls.MapHeadingChangedEventArgs>(x => This.HeadingChanged += x, x => This.HeadingChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Microsoft.Phone.Maps.Controls.MapPitchChangedEventArgs> PitchChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.Maps.Controls.MapPitchChangedEventArgs>, Microsoft.Phone.Maps.Controls.MapPitchChangedEventArgs>(x => This.PitchChanged += x, x => This.PitchChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Microsoft.Phone.Maps.Controls.MapCartographicModeChangedEventArgs> CartographicModeChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.Maps.Controls.MapCartographicModeChangedEventArgs>, Microsoft.Phone.Maps.Controls.MapCartographicModeChangedEventArgs>(x => This.CartographicModeChanged += x, x => This.CartographicModeChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Microsoft.Phone.Maps.Controls.MapColorModeChangedEventArgs> ColorModeChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.Maps.Controls.MapColorModeChangedEventArgs>, Microsoft.Phone.Maps.Controls.MapColorModeChangedEventArgs>(x => This.ColorModeChanged += x, x => This.ColorModeChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Microsoft.Phone.Maps.Controls.MapLandmarksEnabledChangedEventArgs> LandmarksEnabledChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.Maps.Controls.MapLandmarksEnabledChangedEventArgs>, Microsoft.Phone.Maps.Controls.MapLandmarksEnabledChangedEventArgs>(x => This.LandmarksEnabledChanged += x, x => This.LandmarksEnabledChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Microsoft.Phone.Maps.Controls.MapPedestrianFeaturesEnabledChangedEventArgs> PedestrianFeaturesEnabledChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.Maps.Controls.MapPedestrianFeaturesEnabledChangedEventArgs>, Microsoft.Phone.Maps.Controls.MapPedestrianFeaturesEnabledChangedEventArgs>(x => This.PedestrianFeaturesEnabledChanged += x, x => This.PedestrianFeaturesEnabledChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Microsoft.Phone.Maps.Controls.MapViewChangingEventArgs> ViewChanging {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.Maps.Controls.MapViewChangingEventArgs>, Microsoft.Phone.Maps.Controls.MapViewChangingEventArgs>(x => This.ViewChanging += x, x => This.ViewChanging -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Microsoft.Phone.Maps.Controls.MapViewChangedEventArgs> ViewChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.Maps.Controls.MapViewChangedEventArgs>, Microsoft.Phone.Maps.Controls.MapViewChangedEventArgs>(x => This.ViewChanged += x, x => This.ViewChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Microsoft.Phone.Maps.Controls.MapResolveCompletedEventArgs> ResolveCompleted {
            get { return Observable.FromEventPattern<System.EventHandler<Microsoft.Phone.Maps.Controls.MapResolveCompletedEventArgs>, Microsoft.Phone.Maps.Controls.MapResolveCompletedEventArgs>(x => This.ResolveCompleted += x, x => This.ResolveCompleted -= x).Select(x => x.EventArgs); }
        }

    }
}



using System;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Subjects;

using Telerik.Windows.Controls.AnalyticsTest;
using Telerik.Windows.Controls.Primitives;
using Telerik.Windows.Controls;
using Telerik.Windows.Controls.TransitionControl;

namespace Telerik.Windows.Controls.AnalyticsTest
{
    public static class EventsMixin
    {
        public static TestTraceMonitorEvents Events(this TestTraceMonitor This)
        {
            return new TestTraceMonitorEvents(This);
        }
    }

    public class TestTraceMonitorEvents

    {
        TestTraceMonitor This;

        public TestTraceMonitorEvents(TestTraceMonitor This)

        {
            this.This = This;
        }

        public IObservable<System.EventArgs> TrackFeature {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.TrackFeature += x, x => This.TrackFeature -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Telerik.Windows.Controls.Primitives
{
    public static class EventsMixin
    {
        public static AutocompleteBehaviorEvents Events(this AutocompleteBehavior This)
        {
            return new AutocompleteBehaviorEvents(This);
        }
        public static ITextSourceEvents Events(this ITextSource This)
        {
            return new ITextSourceEvents(This);
        }
        public static ISelectorEvents Events(this ISelector This)
        {
            return new ISelectorEvents(This);
        }
        public static ItemsControlSelectorEvents Events(this ItemsControlSelector This)
        {
            return new ItemsControlSelectorEvents(This);
        }
    }

    public class AutocompleteBehaviorEvents

    {
        AutocompleteBehavior This;

        public AutocompleteBehaviorEvents(AutocompleteBehavior This)

        {
            this.This = This;
        }

        public IObservable<System.EventArgs> MatchingItemChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.MatchingItemChanged += x, x => This.MatchingItemChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> CurrentTextChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.CurrentTextChanged += x, x => This.CurrentTextChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ITextSourceEvents

    {
        ITextSource This;

        public ITextSourceEvents(ITextSource This)

        {
            this.This = This;
        }

        public IObservable<System.ComponentModel.CancelEventArgs> PreviewTextChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.ComponentModel.CancelEventArgs>, System.ComponentModel.CancelEventArgs>(x => This.PreviewTextChanged += x, x => This.PreviewTextChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.ComponentModel.CancelEventArgs> PreviewTextChangedByUserInteraction {
            get { return Observable.FromEventPattern<System.EventHandler<System.ComponentModel.CancelEventArgs>, System.ComponentModel.CancelEventArgs>(x => This.PreviewTextChangedByUserInteraction += x, x => This.PreviewTextChangedByUserInteraction -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> TextChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.TextChanged += x, x => This.TextChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Telerik.Windows.Controls.Primitives.TextChangedByUserInteractionEventArgs> TextChangedByUserInteraction {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.Controls.Primitives.TextChangedByUserInteractionEventArgs>, Telerik.Windows.Controls.Primitives.TextChangedByUserInteractionEventArgs>(x => This.TextChangedByUserInteraction += x, x => This.TextChangedByUserInteraction -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> SelectionChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.SelectionChanged += x, x => This.SelectionChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ISelectorEvents

    {
        ISelector This;

        public ISelectorEvents(ISelector This)

        {
            this.This = This;
        }

        public IObservable<System.Windows.Controls.SelectionChangedEventArgs> SelectionChanged {
            get { return Observable.FromEventPattern<System.Windows.Controls.SelectionChangedEventHandler, System.Windows.Controls.SelectionChangedEventArgs>(x => This.SelectionChanged += x, x => This.SelectionChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ItemsControlSelectorEvents

    {
        ItemsControlSelector This;

        public ItemsControlSelectorEvents(ItemsControlSelector This)

        {
            this.This = This;
        }

        public IObservable<System.Windows.Controls.SelectionChangedEventArgs> SelectionChanged {
            get { return Observable.FromEventPattern<System.Windows.Controls.SelectionChangedEventHandler, System.Windows.Controls.SelectionChangedEventArgs>(x => This.SelectionChanged += x, x => This.SelectionChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Telerik.Windows.Controls
{
    public static class EventsMixin
    {
        public static RadButtonEvents Events(this RadButton This)
        {
            return new RadButtonEvents(This);
        }
        public static RadDropDownButtonEvents Events(this RadDropDownButton This)
        {
            return new RadDropDownButtonEvents(This);
        }
        public static RadRadioButtonEvents Events(this RadRadioButton This)
        {
            return new RadRadioButtonEvents(This);
        }
        public static RadSplitButtonEvents Events(this RadSplitButton This)
        {
            return new RadSplitButtonEvents(This);
        }
        public static RadToggleButtonEvents Events(this RadToggleButton This)
        {
            return new RadToggleButtonEvents(This);
        }
        public static RadTileListEvents Events(this RadTileList This)
        {
            return new RadTileListEvents(This);
        }
        public static INotifyLayoutChangeEvents Events(this INotifyLayoutChange This)
        {
            return new INotifyLayoutChangeEvents(This);
        }
        public static RadExpanderEvents Events(this RadExpander This)
        {
            return new RadExpanderEvents(This);
        }
        public static RadFluidContentControlEvents Events(this RadFluidContentControl This)
        {
            return new RadFluidContentControlEvents(This);
        }
        public static RadRangeBaseEvents Events(this RadRangeBase This)
        {
            return new RadRangeBaseEvents(This);
        }
        public static DoubleRangeBaseEvents Events(this DoubleRangeBase This)
        {
            return new DoubleRangeBaseEvents(This);
        }
        public static RadSliderEvents Events(this RadSlider This)
        {
            return new RadSliderEvents(This);
        }
        public static DelegateCommandEvents Events(this DelegateCommand This)
        {
            return new DelegateCommandEvents(This);
        }
        public static RadTransitionControlEvents Events(this RadTransitionControl This)
        {
            return new RadTransitionControlEvents(This);
        }
    }

    public class RadButtonEvents

    {
        RadButton This;

        public RadButtonEvents(RadButton This)

        {
            this.This = This;
        }

        public IObservable<Telerik.Windows.RadRoutedEventArgs> Activate {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.RadRoutedEventArgs>, Telerik.Windows.RadRoutedEventArgs>(x => This.Activate += x, x => This.Activate -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Telerik.Windows.RadRoutedEventArgs> Hover {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.RadRoutedEventArgs>, Telerik.Windows.RadRoutedEventArgs>(x => This.Hover += x, x => This.Hover -= x).Select(x => x.EventArgs); }
        }

    }
    public class RadDropDownButtonEvents

    {
        RadDropDownButton This;

        public RadDropDownButtonEvents(RadDropDownButton This)

        {
            this.This = This;
        }

        public IObservable<System.Windows.RoutedEventArgs> DropDownClosed {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.DropDownClosed += x, x => This.DropDownClosed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> DropDownOpened {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.DropDownOpened += x, x => This.DropDownOpened -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> DropDownOpening {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.DropDownOpening += x, x => This.DropDownOpening -= x).Select(x => x.EventArgs); }
        }

    }
    public class RadRadioButtonEvents

    {
        RadRadioButton This;

        public RadRadioButtonEvents(RadRadioButton This)

        {
            this.This = This;
        }

        public IObservable<Telerik.Windows.RadRoutedEventArgs> Activate {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.RadRoutedEventArgs>, Telerik.Windows.RadRoutedEventArgs>(x => This.Activate += x, x => This.Activate -= x).Select(x => x.EventArgs); }
        }

    }
    public class RadSplitButtonEvents

    {
        RadSplitButton This;

        public RadSplitButtonEvents(RadSplitButton This)

        {
            this.This = This;
        }

        public IObservable<System.Windows.RoutedEventArgs> Click {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.Click += x, x => This.Click -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> Checked {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.Checked += x, x => This.Checked -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> Unchecked {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.Unchecked += x, x => This.Unchecked -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Telerik.Windows.RadRoutedEventArgs> Activate {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.RadRoutedEventArgs>, Telerik.Windows.RadRoutedEventArgs>(x => This.Activate += x, x => This.Activate -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> DropDownClosed {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.DropDownClosed += x, x => This.DropDownClosed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> DropDownOpened {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.DropDownOpened += x, x => This.DropDownOpened -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> DropDownOpening {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.DropDownOpening += x, x => This.DropDownOpening -= x).Select(x => x.EventArgs); }
        }

    }
    public class RadToggleButtonEvents

    {
        RadToggleButton This;

        public RadToggleButtonEvents(RadToggleButton This)

        {
            this.This = This;
        }

        public IObservable<Telerik.Windows.RadRoutedEventArgs> Activate {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.RadRoutedEventArgs>, Telerik.Windows.RadRoutedEventArgs>(x => This.Activate += x, x => This.Activate -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> PreviewClick {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.PreviewClick += x, x => This.PreviewClick -= x).Select(x => x.EventArgs); }
        }

    }
    public class RadTileListEvents

    {
        RadTileList This;

        public RadTileListEvents(RadTileList This)

        {
            this.This = This;
        }

        public IObservable<Telerik.Windows.Controls.AutoGeneratingTileEventArgs> AutoGeneratingTile {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.Controls.AutoGeneratingTileEventArgs>, Telerik.Windows.Controls.AutoGeneratingTileEventArgs>(x => This.AutoGeneratingTile += x, x => This.AutoGeneratingTile -= x).Select(x => x.EventArgs); }
        }

    }
    public class INotifyLayoutChangeEvents

    {
        INotifyLayoutChange This;

        public INotifyLayoutChangeEvents(INotifyLayoutChange This)

        {
            this.This = This;
        }

        public IObservable<System.EventArgs> LayoutChangeStarted {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.LayoutChangeStarted += x, x => This.LayoutChangeStarted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> LayoutChangeEnded {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.LayoutChangeEnded += x, x => This.LayoutChangeEnded -= x).Select(x => x.EventArgs); }
        }

    }
    public class RadExpanderEvents

    {
        RadExpander This;

        public RadExpanderEvents(RadExpander This)

        {
            this.This = This;
        }

        public IObservable<Telerik.Windows.RadRoutedEventArgs> Collapsed {
            get { return Observable.FromEventPattern<Telerik.Windows.RadRoutedEventHandler, Telerik.Windows.RadRoutedEventArgs>(x => This.Collapsed += x, x => This.Collapsed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Telerik.Windows.RadRoutedEventArgs> Expanded {
            get { return Observable.FromEventPattern<Telerik.Windows.RadRoutedEventHandler, Telerik.Windows.RadRoutedEventArgs>(x => This.Expanded += x, x => This.Expanded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Telerik.Windows.RadRoutedEventArgs> PreviewCollapsed {
            get { return Observable.FromEventPattern<Telerik.Windows.RadRoutedEventHandler, Telerik.Windows.RadRoutedEventArgs>(x => This.PreviewCollapsed += x, x => This.PreviewCollapsed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Telerik.Windows.RadRoutedEventArgs> PreviewExpanded {
            get { return Observable.FromEventPattern<Telerik.Windows.RadRoutedEventHandler, Telerik.Windows.RadRoutedEventArgs>(x => This.PreviewExpanded += x, x => This.PreviewExpanded -= x).Select(x => x.EventArgs); }
        }

    }
    public class RadFluidContentControlEvents

    {
        RadFluidContentControl This;

        public RadFluidContentControlEvents(RadFluidContentControl This)

        {
            this.This = This;
        }

        public IObservable<Telerik.Windows.Controls.FluidContentControlStateChangedEventArgs> StateChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.Controls.FluidContentControlStateChangedEventArgs>, Telerik.Windows.Controls.FluidContentControlStateChangedEventArgs>(x => This.StateChanged += x, x => This.StateChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class RadRangeBaseEvents

    {
        RadRangeBase This;

        public RadRangeBaseEvents(RadRangeBase This)

        {
            this.This = This;
        }

        public IObservable<Telerik.Windows.Controls.RadRangeBaseValueChangedEventArgs> ValueChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.Controls.RadRangeBaseValueChangedEventArgs>, Telerik.Windows.Controls.RadRangeBaseValueChangedEventArgs>(x => This.ValueChanged += x, x => This.ValueChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class DoubleRangeBaseEvents

    {
        DoubleRangeBase This;

        public DoubleRangeBaseEvents(DoubleRangeBase This)

        {
            this.This = This;
        }

        public IObservable<System.Windows.RoutedPropertyChangedEventArgs<System.Double>> SelectionStartChanged {
            get { return Observable.FromEventPattern<System.Windows.RoutedPropertyChangedEventHandler<System.Double>, System.Windows.RoutedPropertyChangedEventArgs<System.Double>>(x => This.SelectionStartChanged += x, x => This.SelectionStartChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedPropertyChangedEventArgs<System.Double>> SelectionEndChanged {
            get { return Observable.FromEventPattern<System.Windows.RoutedPropertyChangedEventHandler<System.Double>, System.Windows.RoutedPropertyChangedEventArgs<System.Double>>(x => This.SelectionEndChanged += x, x => This.SelectionEndChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedPropertyChangedEventArgs<System.Double>> MinimumRangeSpanChanged {
            get { return Observable.FromEventPattern<System.Windows.RoutedPropertyChangedEventHandler<System.Double>, System.Windows.RoutedPropertyChangedEventArgs<System.Double>>(x => This.MinimumRangeSpanChanged += x, x => This.MinimumRangeSpanChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedPropertyChangedEventArgs<System.Double>> MaximumRangeSpanChanged {
            get { return Observable.FromEventPattern<System.Windows.RoutedPropertyChangedEventHandler<System.Double>, System.Windows.RoutedPropertyChangedEventArgs<System.Double>>(x => This.MaximumRangeSpanChanged += x, x => This.MaximumRangeSpanChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Telerik.Windows.RadRoutedEventArgs> SelectionChanged {
            get { return Observable.FromEventPattern<Telerik.Windows.RadRoutedEventHandler, Telerik.Windows.RadRoutedEventArgs>(x => This.SelectionChanged += x, x => This.SelectionChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class RadSliderEvents

    {
        RadSlider This;

        public RadSliderEvents(RadSlider This)

        {
            this.This = This;
        }

        public IObservable<Telerik.Windows.Controls.RadDragStartedEventArgs> DragStarted {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.Controls.RadDragStartedEventArgs>, Telerik.Windows.Controls.RadDragStartedEventArgs>(x => This.DragStarted += x, x => This.DragStarted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Telerik.Windows.Controls.RadDragDeltaEventArgs> DragDelta {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.Controls.RadDragDeltaEventArgs>, Telerik.Windows.Controls.RadDragDeltaEventArgs>(x => This.DragDelta += x, x => This.DragDelta -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Telerik.Windows.Controls.RadDragCompletedEventArgs> DragCompleted {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.Controls.RadDragCompletedEventArgs>, Telerik.Windows.Controls.RadDragCompletedEventArgs>(x => This.DragCompleted += x, x => This.DragCompleted -= x).Select(x => x.EventArgs); }
        }

    }
    public class DelegateCommandEvents

    {
        DelegateCommand This;

        public DelegateCommandEvents(DelegateCommand This)

        {
            this.This = This;
        }

        public IObservable<System.EventArgs> CanExecuteChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.CanExecuteChanged += x, x => This.CanExecuteChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class RadTransitionControlEvents

    {
        RadTransitionControl This;

        public RadTransitionControlEvents(RadTransitionControl This)

        {
            this.This = This;
        }

        public IObservable<Telerik.Windows.Controls.TransitionControl.TransitionStatusChangedEventArgs> TransitionStatusChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.Controls.TransitionControl.TransitionStatusChangedEventArgs>, Telerik.Windows.Controls.TransitionControl.TransitionStatusChangedEventArgs>(x => This.TransitionStatusChanged += x, x => This.TransitionStatusChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Telerik.Windows.Controls.TransitionControl.TriggeringTransitionEventArgs> TriggeringTransition {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.Controls.TransitionControl.TriggeringTransitionEventArgs>, Telerik.Windows.Controls.TransitionControl.TriggeringTransitionEventArgs>(x => This.TriggeringTransition += x, x => This.TriggeringTransition -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Telerik.Windows.Controls.TransitionControl
{
    public static class EventsMixin
    {
        public static TransitionPresenterEvents Events(this TransitionPresenter This)
        {
            return new TransitionPresenterEvents(This);
        }
    }

    public class TransitionPresenterEvents

    {
        TransitionPresenter This;

        public TransitionPresenterEvents(TransitionPresenter This)

        {
            this.This = This;
        }

        public IObservable<Telerik.Windows.Controls.TransitionControl.TransitionStatusChangedEventArgs> TransitionStatusChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.Controls.TransitionControl.TransitionStatusChangedEventArgs>, Telerik.Windows.Controls.TransitionControl.TransitionStatusChangedEventArgs>(x => This.TransitionStatusChanged += x, x => This.TransitionStatusChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Telerik.Windows.Controls.TransitionControl.TriggeringTransitionEventArgs> TriggeringTransition {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.Controls.TransitionControl.TriggeringTransitionEventArgs>, Telerik.Windows.Controls.TransitionControl.TriggeringTransitionEventArgs>(x => This.TriggeringTransition += x, x => This.TriggeringTransition -= x).Select(x => x.EventArgs); }
        }

    }
}



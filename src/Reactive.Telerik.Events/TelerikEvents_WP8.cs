using System;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Subjects;

using Telerik.Windows.Controls;
using Telerik.Windows.Controls.SlideView;
using Telerik.Windows.Controls.Primitives;
using Telerik.Windows.Data;

namespace Telerik.Windows.Controls
{
    public static class EventsMixin
    {
        public static RadAnimationEvents Events(this RadAnimation This)
        {
            return new RadAnimationEvents(This);
        }
        public static AppointmentSourceEvents Events(this AppointmentSource This)
        {
            return new AppointmentSourceEvents(This);
        }
        public static DisposableObjectEvents Events(this DisposableObject This)
        {
            return new DisposableObjectEvents(This);
        }
        public static ApplicationBarButtonEvents Events(this ApplicationBarButton This)
        {
            return new ApplicationBarButtonEvents(This);
        }
        public static ApplicationBarInfoEvents Events(this ApplicationBarInfo This)
        {
            return new ApplicationBarInfoEvents(This);
        }
        public static RadSelectorEvents Events(this RadSelector This)
        {
            return new RadSelectorEvents(This);
        }
        public static RadContextMenuItemEvents Events(this RadContextMenuItem This)
        {
            return new RadContextMenuItemEvents(This);
        }
        public static RadContextMenuEvents Events(this RadContextMenu This)
        {
            return new RadContextMenuEvents(This);
        }
        public static RadVirtualizingDataControlEvents Events(this RadVirtualizingDataControl This)
        {
            return new RadVirtualizingDataControlEvents(This);
        }
        public static RadDataBoundListBoxEvents Events(this RadDataBoundListBox This)
        {
            return new RadDataBoundListBoxEvents(This);
        }
        public static RadDiagnosticsEvents Events(this RadDiagnostics This)
        {
            return new RadDiagnosticsEvents(This);
        }
        public static RadExpanderControlEvents Events(this RadExpanderControl This)
        {
            return new RadExpanderControlEvents(This);
        }
        public static RadImageButtonEvents Events(this RadImageButton This)
        {
            return new RadImageButtonEvents(This);
        }
        public static RadMultiResolutionImageEvents Events(this RadMultiResolutionImage This)
        {
            return new RadMultiResolutionImageEvents(This);
        }
        public static IPageProviderEvents Events(this IPageProvider This)
        {
            return new IPageProviderEvents(This);
        }
        public static RadPasswordBoxEvents Events(this RadPasswordBox This)
        {
            return new RadPasswordBoxEvents(This);
        }
        public static RadSlideViewEvents Events(this RadSlideView This)
        {
            return new RadSlideViewEvents(This);
        }
        public static RadTextBoxEvents Events(this RadTextBox This)
        {
            return new RadTextBoxEvents(This);
        }
        public static RadLoopingListEvents Events(this RadLoopingList This)
        {
            return new RadLoopingListEvents(This);
        }
        public static LoopingListDataSourceEvents Events(this LoopingListDataSource This)
        {
            return new LoopingListDataSourceEvents(This);
        }
        public static RadPhoneApplicationFrameEvents Events(this RadPhoneApplicationFrame This)
        {
            return new RadPhoneApplicationFrameEvents(This);
        }
        public static RadPickerBoxEvents Events(this RadPickerBox This)
        {
            return new RadPickerBoxEvents(This);
        }
        public static RadToggleSwitchEvents Events(this RadToggleSwitch This)
        {
            return new RadToggleSwitchEvents(This);
        }
        public static RadTransitionControlEvents Events(this RadTransitionControl This)
        {
            return new RadTransitionControlEvents(This);
        }
        public static RadWindowEvents Events(this RadWindow This)
        {
            return new RadWindowEvents(This);
        }
    }

    public class RadAnimationEvents

    {
        RadAnimation This;

        public RadAnimationEvents(RadAnimation This)

        {
            this.This = This;
        }

        public IObservable<Telerik.Windows.Controls.AnimationEndedEventArgs> Ended {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.Controls.AnimationEndedEventArgs>, Telerik.Windows.Controls.AnimationEndedEventArgs>(x => This.Ended += x, x => This.Ended -= x).Select(x => x.EventArgs); }
        }

    }
    public class AppointmentSourceEvents

    {
        AppointmentSource This;

        public AppointmentSourceEvents(AppointmentSource This)

        {
            this.This = This;
        }

        public IObservable<System.EventArgs> DataLoaded {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DataLoaded += x, x => This.DataLoaded -= x).Select(x => x.EventArgs); }
        }

    }
    public class DisposableObjectEvents

    {
        DisposableObject This;

        public DisposableObjectEvents(DisposableObject This)

        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Disposing {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Disposing += x, x => This.Disposing -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Disposed {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Disposed += x, x => This.Disposed -= x).Select(x => x.EventArgs); }
        }

    }
    public class ApplicationBarButtonEvents

    {
        ApplicationBarButton This;

        public ApplicationBarButtonEvents(ApplicationBarButton This)

        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Click {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Click += x, x => This.Click -= x).Select(x => x.EventArgs); }
        }

    }
    public class ApplicationBarInfoEvents

    {
        ApplicationBarInfo This;

        public ApplicationBarInfoEvents(ApplicationBarInfo This)

        {
            this.This = This;
        }

        public IObservable<Telerik.Windows.Controls.ApplicationBarButtonClickEventArgs> ButtonClick {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.Controls.ApplicationBarButtonClickEventArgs>, Telerik.Windows.Controls.ApplicationBarButtonClickEventArgs>(x => This.ButtonClick += x, x => This.ButtonClick -= x).Select(x => x.EventArgs); }
        }

    }
    public class RadSelectorEvents

    {
        RadSelector This;

        public RadSelectorEvents(RadSelector This)

        {
            this.This = This;
        }

        public IObservable<Telerik.Windows.Controls.Primitives.SelectorItemClickEventArgs> ItemClick {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.Controls.Primitives.SelectorItemClickEventArgs>, Telerik.Windows.Controls.Primitives.SelectorItemClickEventArgs>(x => This.ItemClick += x, x => This.ItemClick -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.SelectionChangedEventArgs> SelectionChanged {
            get { return Observable.FromEventPattern<System.Windows.Controls.SelectionChangedEventHandler, System.Windows.Controls.SelectionChangedEventArgs>(x => This.SelectionChanged += x, x => This.SelectionChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class RadContextMenuItemEvents

    {
        RadContextMenuItem This;

        public RadContextMenuItemEvents(RadContextMenuItem This)

        {
            this.This = This;
        }

        public IObservable<Telerik.Windows.Controls.ContextMenuItemSelectedEventArgs> Tapped {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.Controls.ContextMenuItemSelectedEventArgs>, Telerik.Windows.Controls.ContextMenuItemSelectedEventArgs>(x => This.Tapped += x, x => This.Tapped -= x).Select(x => x.EventArgs); }
        }

    }
    public class RadContextMenuEvents

    {
        RadContextMenu This;

        public RadContextMenuEvents(RadContextMenu This)

        {
            this.This = This;
        }

        public IObservable<Telerik.Windows.Controls.ContextMenuItemSelectedEventArgs> ItemTapped {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.Controls.ContextMenuItemSelectedEventArgs>, Telerik.Windows.Controls.ContextMenuItemSelectedEventArgs>(x => This.ItemTapped += x, x => This.ItemTapped -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Telerik.Windows.Controls.ContextMenuOpeningEventArgs> Opening {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.Controls.ContextMenuOpeningEventArgs>, Telerik.Windows.Controls.ContextMenuOpeningEventArgs>(x => This.Opening += x, x => This.Opening -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Opened {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Opened += x, x => This.Opened -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.ComponentModel.CancelEventArgs> Closing {
            get { return Observable.FromEventPattern<System.EventHandler<System.ComponentModel.CancelEventArgs>, System.ComponentModel.CancelEventArgs>(x => This.Closing += x, x => This.Closing -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Closed {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Closed += x, x => This.Closed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Telerik.Windows.Controls.OpenFailedEventArgs> OpenFailed {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.Controls.OpenFailedEventArgs>, Telerik.Windows.Controls.OpenFailedEventArgs>(x => This.OpenFailed += x, x => This.OpenFailed -= x).Select(x => x.EventArgs); }
        }

    }
    public class RadVirtualizingDataControlEvents

    {
        RadVirtualizingDataControl This;

        public RadVirtualizingDataControlEvents(RadVirtualizingDataControl This)

        {
            this.This = This;
        }

        public IObservable<Telerik.Windows.Controls.ItemStateChangedEventArgs> ItemStateChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.Controls.ItemStateChangedEventArgs>, Telerik.Windows.Controls.ItemStateChangedEventArgs>(x => This.ItemStateChanged += x, x => This.ItemStateChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Telerik.Windows.Controls.ScrollStateChangedEventArgs> ScrollStateChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.Controls.ScrollStateChangedEventArgs>, Telerik.Windows.Controls.ScrollStateChangedEventArgs>(x => This.ScrollStateChanged += x, x => This.ScrollStateChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Telerik.Windows.Controls.ItemAnimationEndedEventArgs> ItemAnimationEnded {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.Controls.ItemAnimationEndedEventArgs>, Telerik.Windows.Controls.ItemAnimationEndedEventArgs>(x => This.ItemAnimationEnded += x, x => This.ItemAnimationEnded -= x).Select(x => x.EventArgs); }
        }

    }
    public class RadDataBoundListBoxEvents

    {
        RadDataBoundListBox This;

        public RadDataBoundListBoxEvents(RadDataBoundListBox This)

        {
            this.This = This;
        }

        public IObservable<System.EventArgs> ItemReorderUpButtonTap {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.ItemReorderUpButtonTap += x, x => This.ItemReorderUpButtonTap -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> ItemReorderDownButtonTap {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.ItemReorderDownButtonTap += x, x => This.ItemReorderDownButtonTap -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Telerik.Windows.Controls.ItemReorderStateChangedEventArgs> ItemReorderStateChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.Controls.ItemReorderStateChangedEventArgs>, Telerik.Windows.Controls.ItemReorderStateChangedEventArgs>(x => This.ItemReorderStateChanged += x, x => This.ItemReorderStateChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Telerik.Windows.Controls.IsCheckModeActiveChangedEventArgs> IsCheckModeActiveChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.Controls.IsCheckModeActiveChangedEventArgs>, Telerik.Windows.Controls.IsCheckModeActiveChangedEventArgs>(x => This.IsCheckModeActiveChanged += x, x => This.IsCheckModeActiveChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Telerik.Windows.Controls.IsCheckModeActiveChangingEventArgs> IsCheckModeActiveChanging {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.Controls.IsCheckModeActiveChangingEventArgs>, Telerik.Windows.Controls.IsCheckModeActiveChangingEventArgs>(x => This.IsCheckModeActiveChanging += x, x => This.IsCheckModeActiveChanging -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Telerik.Windows.Controls.ItemCheckedStateChangingEventArgs> ItemCheckedStateChanging {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.Controls.ItemCheckedStateChangingEventArgs>, Telerik.Windows.Controls.ItemCheckedStateChangingEventArgs>(x => This.ItemCheckedStateChanging += x, x => This.ItemCheckedStateChanging -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Telerik.Windows.Controls.ItemCheckedStateChangedEventArgs> ItemCheckedStateChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.Controls.ItemCheckedStateChangedEventArgs>, Telerik.Windows.Controls.ItemCheckedStateChangedEventArgs>(x => This.ItemCheckedStateChanged += x, x => This.ItemCheckedStateChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DataRequested {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.DataRequested += x, x => This.DataRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> RefreshRequested {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.RefreshRequested += x, x => This.RefreshRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Telerik.Windows.Controls.ListBoxItemTapEventArgs> ItemTap {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.Controls.ListBoxItemTapEventArgs>, Telerik.Windows.Controls.ListBoxItemTapEventArgs>(x => This.ItemTap += x, x => This.ItemTap -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.SelectionChangedEventArgs> SelectionChanged {
            get { return Observable.FromEventPattern<System.Windows.Controls.SelectionChangedEventHandler, System.Windows.Controls.SelectionChangedEventArgs>(x => This.SelectionChanged += x, x => This.SelectionChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Telerik.Windows.Controls.SelectionChangingEventArgs> SelectionChanging {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.Controls.SelectionChangingEventArgs>, Telerik.Windows.Controls.SelectionChangingEventArgs>(x => This.SelectionChanging += x, x => This.SelectionChanging -= x).Select(x => x.EventArgs); }
        }

    }
    public class RadDiagnosticsEvents

    {
        RadDiagnostics This;

        public RadDiagnosticsEvents(RadDiagnostics This)

        {
            this.This = This;
        }

        public IObservable<Telerik.Windows.Controls.ExceptionOccurredEventArgs> ExceptionOccurred {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.Controls.ExceptionOccurredEventArgs>, Telerik.Windows.Controls.ExceptionOccurredEventArgs>(x => This.ExceptionOccurred += x, x => This.ExceptionOccurred -= x).Select(x => x.EventArgs); }
        }

    }
    public class RadExpanderControlEvents

    {
        RadExpanderControl This;

        public RadExpanderControlEvents(RadExpanderControl This)

        {
            this.This = This;
        }

        public IObservable<Telerik.Windows.Controls.ExpandedStateChangingEventArgs> ExpandedStateChanging {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.Controls.ExpandedStateChangingEventArgs>, Telerik.Windows.Controls.ExpandedStateChangingEventArgs>(x => This.ExpandedStateChanging += x, x => This.ExpandedStateChanging -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Telerik.Windows.Controls.ExpandedStateChangedEventArgs> ExpandedStateChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.Controls.ExpandedStateChangedEventArgs>, Telerik.Windows.Controls.ExpandedStateChangedEventArgs>(x => This.ExpandedStateChanged += x, x => This.ExpandedStateChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class RadImageButtonEvents

    {
        RadImageButton This;

        public RadImageButtonEvents(RadImageButton This)

        {
            this.This = This;
        }

        public IObservable<Telerik.Windows.Controls.CheckedChangedEventArgs> CheckedChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.Controls.CheckedChangedEventArgs>, Telerik.Windows.Controls.CheckedChangedEventArgs>(x => This.CheckedChanged += x, x => This.CheckedChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> Checked {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.RoutedEventArgs>, System.Windows.RoutedEventArgs>(x => This.Checked += x, x => This.Checked -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> Unchecked {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.RoutedEventArgs>, System.Windows.RoutedEventArgs>(x => This.Unchecked += x, x => This.Unchecked -= x).Select(x => x.EventArgs); }
        }

    }
    public class RadMultiResolutionImageEvents

    {
        RadMultiResolutionImage This;

        public RadMultiResolutionImageEvents(RadMultiResolutionImage This)

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
    public class IPageProviderEvents

    {
        IPageProvider This;

        public IPageProviderEvents(IPageProvider This)

        {
            this.This = This;
        }

        public IObservable<System.EventArgs> CurrentIndexChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.CurrentIndexChanged += x, x => This.CurrentIndexChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class RadPasswordBoxEvents

    {
        RadPasswordBox This;

        public RadPasswordBoxEvents(RadPasswordBox This)

        {
            this.This = This;
        }

        public IObservable<System.EventArgs> ActionButtonTap {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.ActionButtonTap += x, x => This.ActionButtonTap -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> ClearButtonTap {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.ClearButtonTap += x, x => This.ClearButtonTap -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> PeekButtonTap {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.PeekButtonTap += x, x => This.PeekButtonTap -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> PasswordChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.PasswordChanged += x, x => This.PasswordChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class RadSlideViewEvents

    {
        RadSlideView This;

        public RadSlideViewEvents(RadSlideView This)

        {
            this.This = This;
        }

        public IObservable<System.Windows.Controls.SelectionChangedEventArgs> SelectionChanged {
            get { return Observable.FromEventPattern<System.Windows.Controls.SelectionChangedEventHandler, System.Windows.Controls.SelectionChangedEventArgs>(x => This.SelectionChanged += x, x => This.SelectionChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> SlideAnimationStarted {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.SlideAnimationStarted += x, x => This.SlideAnimationStarted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> SlideAnimationCompleted {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.SlideAnimationCompleted += x, x => This.SlideAnimationCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> RefreshRequested {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.RefreshRequested += x, x => This.RefreshRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Telerik.Windows.Controls.SlideViewStateChangedArgs> SlideViewStateChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.Controls.SlideViewStateChangedArgs>, Telerik.Windows.Controls.SlideViewStateChangedArgs>(x => This.SlideViewStateChanged += x, x => This.SlideViewStateChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class RadTextBoxEvents

    {
        RadTextBox This;

        public RadTextBoxEvents(RadTextBox This)

        {
            this.This = This;
        }

        public IObservable<System.EventArgs> ActionButtonTap {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.ActionButtonTap += x, x => This.ActionButtonTap -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> ClearButtonTap {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.ClearButtonTap += x, x => This.ClearButtonTap -= x).Select(x => x.EventArgs); }
        }

    }
    public class RadLoopingListEvents

    {
        RadLoopingList This;

        public RadLoopingListEvents(RadLoopingList This)

        {
            this.This = This;
        }

        public IObservable<System.EventArgs> SelectedIndexChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.SelectedIndexChanged += x, x => This.SelectedIndexChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Telerik.Windows.Controls.LoopingList.LoopingListScrollEventArgs> ScrollCompleted {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.Controls.LoopingList.LoopingListScrollEventArgs>, Telerik.Windows.Controls.LoopingList.LoopingListScrollEventArgs>(x => This.ScrollCompleted += x, x => This.ScrollCompleted -= x).Select(x => x.EventArgs); }
        }

    }
    public class LoopingListDataSourceEvents

    {
        LoopingListDataSource This;

        public LoopingListDataSourceEvents(LoopingListDataSource This)

        {
            this.This = This;
        }

        public IObservable<Telerik.Windows.Controls.LoopingListDataItemEventArgs> ItemNeeded {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.Controls.LoopingListDataItemEventArgs>, Telerik.Windows.Controls.LoopingListDataItemEventArgs>(x => This.ItemNeeded += x, x => This.ItemNeeded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Telerik.Windows.Controls.LoopingListDataItemEventArgs> ItemUpdated {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.Controls.LoopingListDataItemEventArgs>, Telerik.Windows.Controls.LoopingListDataItemEventArgs>(x => This.ItemUpdated += x, x => This.ItemUpdated -= x).Select(x => x.EventArgs); }
        }

    }
    public class RadPhoneApplicationFrameEvents

    {
        RadPhoneApplicationFrame This;

        public RadPhoneApplicationFrameEvents(RadPhoneApplicationFrame This)

        {
            this.This = This;
        }

        public IObservable<System.EventArgs> PageTransitionCompleted {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.PageTransitionCompleted += x, x => This.PageTransitionCompleted -= x).Select(x => x.EventArgs); }
        }

    }
    public class RadPickerBoxEvents

    {
        RadPickerBox This;

        public RadPickerBoxEvents(RadPickerBox This)

        {
            this.This = This;
        }

        public IObservable<System.EventArgs> ActionButtonTap {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.ActionButtonTap += x, x => This.ActionButtonTap -= x).Select(x => x.EventArgs); }
        }

    }
    public class RadToggleSwitchEvents

    {
        RadToggleSwitch This;

        public RadToggleSwitchEvents(RadToggleSwitch This)

        {
            this.This = This;
        }

        public IObservable<Telerik.Windows.Controls.CheckedChangedEventArgs> CheckedChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.Controls.CheckedChangedEventArgs>, Telerik.Windows.Controls.CheckedChangedEventArgs>(x => This.CheckedChanged += x, x => This.CheckedChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> Checked {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.RoutedEventArgs>, System.Windows.RoutedEventArgs>(x => This.Checked += x, x => This.Checked -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> Unchecked {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.RoutedEventArgs>, System.Windows.RoutedEventArgs>(x => This.Unchecked += x, x => This.Unchecked -= x).Select(x => x.EventArgs); }
        }

    }
    public class RadTransitionControlEvents

    {
        RadTransitionControl This;

        public RadTransitionControlEvents(RadTransitionControl This)

        {
            this.This = This;
        }

        public IObservable<System.EventArgs> OldContentTransitionEnded {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.OldContentTransitionEnded += x, x => This.OldContentTransitionEnded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> NewContentTransitionEnded {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.NewContentTransitionEnded += x, x => This.NewContentTransitionEnded -= x).Select(x => x.EventArgs); }
        }

    }
    public class RadWindowEvents

    {
        RadWindow This;

        public RadWindowEvents(RadWindow This)

        {
            this.This = This;
        }

        public IObservable<Telerik.Windows.Controls.ApplicationBarButtonClickEventArgs> ApplicationBarButtonClick {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.Controls.ApplicationBarButtonClickEventArgs>, Telerik.Windows.Controls.ApplicationBarButtonClickEventArgs>(x => This.ApplicationBarButtonClick += x, x => This.ApplicationBarButtonClick -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> WindowOpened {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.WindowOpened += x, x => This.WindowOpened -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.ComponentModel.CancelEventArgs> WindowOpening {
            get { return Observable.FromEventPattern<System.EventHandler<System.ComponentModel.CancelEventArgs>, System.ComponentModel.CancelEventArgs>(x => This.WindowOpening += x, x => This.WindowOpening -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Telerik.Windows.Controls.WindowClosedEventArgs> WindowClosed {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.Controls.WindowClosedEventArgs>, Telerik.Windows.Controls.WindowClosedEventArgs>(x => This.WindowClosed += x, x => This.WindowClosed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.ComponentModel.CancelEventArgs> WindowClosing {
            get { return Observable.FromEventPattern<System.EventHandler<System.ComponentModel.CancelEventArgs>, System.ComponentModel.CancelEventArgs>(x => This.WindowClosing += x, x => This.WindowClosing -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Telerik.Windows.Controls.WindowOpenFailedEventArgs> OpenFailed {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.Controls.WindowOpenFailedEventArgs>, Telerik.Windows.Controls.WindowOpenFailedEventArgs>(x => This.OpenFailed += x, x => This.OpenFailed -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Telerik.Windows.Controls.SlideView
{
    public static class EventsMixin
    {
        public static PanAndZoomImageEvents Events(this PanAndZoomImage This)
        {
            return new PanAndZoomImageEvents(This);
        }
    }

    public class PanAndZoomImageEvents

    {
        PanAndZoomImage This;

        public PanAndZoomImageEvents(PanAndZoomImage This)

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
}
namespace Telerik.Windows.Controls.Primitives
{
    public static class EventsMixin
    {
        public static PickerControlBaseEvents Events(this PickerControlBase This)
        {
            return new PickerControlBaseEvents(This);
        }
    }

    public class PickerControlBaseEvents

    {
        PickerControlBase This;

        public PickerControlBaseEvents(PickerControlBase This)

        {
            this.This = This;
        }

        public IObservable<Telerik.Windows.Controls.ApplicationBarButtonClickEventArgs> ApplicationBarButtonClick {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.Controls.ApplicationBarButtonClickEventArgs>, Telerik.Windows.Controls.ApplicationBarButtonClickEventArgs>(x => This.ApplicationBarButtonClick += x, x => This.ApplicationBarButtonClick -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> PopupOpened {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.PopupOpened += x, x => This.PopupOpened -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.ComponentModel.CancelEventArgs> PopupOpening {
            get { return Observable.FromEventPattern<System.EventHandler<System.ComponentModel.CancelEventArgs>, System.ComponentModel.CancelEventArgs>(x => This.PopupOpening += x, x => This.PopupOpening -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> PopupClosed {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.PopupClosed += x, x => This.PopupClosed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.ComponentModel.CancelEventArgs> PopupClosing {
            get { return Observable.FromEventPattern<System.EventHandler<System.ComponentModel.CancelEventArgs>, System.ComponentModel.CancelEventArgs>(x => This.PopupClosing += x, x => This.PopupClosing -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Telerik.Windows.Data
{
    public static class EventsMixin
    {
        public static VirtualizingDataCollectionEvents Events(this VirtualizingDataCollection This)
        {
            return new VirtualizingDataCollectionEvents(This);
        }
    }

    public class VirtualizingDataCollectionEvents

    {
        VirtualizingDataCollection This;

        public VirtualizingDataCollectionEvents(VirtualizingDataCollection This)

        {
            this.This = This;
        }

        public IObservable<System.Collections.Specialized.NotifyCollectionChangedEventArgs> CollectionChanged {
            get { return Observable.FromEventPattern<System.Collections.Specialized.NotifyCollectionChangedEventHandler, System.Collections.Specialized.NotifyCollectionChangedEventArgs>(x => This.CollectionChanged += x, x => This.CollectionChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Telerik.Windows.Data.VirtualizingDataCollectionItemsLoadingEventArgs> ItemsLoading {
            get { return Observable.FromEventPattern<System.EventHandler<Telerik.Windows.Data.VirtualizingDataCollectionItemsLoadingEventArgs>, Telerik.Windows.Data.VirtualizingDataCollectionItemsLoadingEventArgs>(x => This.ItemsLoading += x, x => This.ItemsLoading -= x).Select(x => x.EventArgs); }
        }

    }
}



using System;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Subjects;

using Windows.Foundation.Collections;
using Windows.Foundation.Diagnostics;
using Windows.Graphics.Display;
using Windows.Graphics.Printing.OptionDetails;
using Windows.Graphics.Printing;
using Windows.Media.Devices;
using Windows.Media.Effects;
using Windows.Media.PlayTo;
using Windows.Media;
using Windows.Media.Capture;
using Windows.Media.Protection;
using Windows.Media.Core;
using Windows.Media.ContentRestrictions;
using Windows.Networking.NetworkOperators;
using Windows.Networking.Proximity;
using Windows.Networking.Sockets;
using Windows.Networking.Vpn;
using Windows.Networking.PushNotifications;
using Windows.Security.Credentials;
using Windows.Storage.Pickers.Provider;
using Windows.Storage.Provider;
using Windows.Storage;
using Windows.Storage.Search;
using Windows.Storage.AccessCache;
using Windows.Storage.BulkAccess;
using Windows.UI.ApplicationSettings;
using Windows.UI.ViewManagement;
using Windows.UI.Input;
using Windows.UI.StartScreen;
using Windows.UI.Core;
using Windows.UI.WebUI;
using Windows.UI.Notifications;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Printing;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Media.Imaging;
using Windows.ApplicationModel.Background;
using Windows.ApplicationModel.Contacts.Provider;
using Windows.ApplicationModel.DataTransfer;
using Windows.ApplicationModel.Search;
using Windows.ApplicationModel.Search.Core;
using Windows.ApplicationModel.Activation;
using Windows.ApplicationModel.Calls;
using Windows.ApplicationModel.Core;
using Windows.ApplicationModel.Resources.Core;
using Windows.Devices.Sms;
using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Devices.Enumeration;
using Windows.Devices.Enumeration.Pnp;
using Windows.Devices.Geolocation.Geofencing;
using Windows.Devices.Geolocation;
using Windows.Devices.HumanInterfaceDevice;
using Windows.Devices.Input;
using Windows.Devices.PointOfService;
using Windows.Devices.Printers.Extensions;
using Windows.Devices.Sensors;
using Windows.Devices.SmartCards;
using Windows.Devices.Usb;
using Windows.Devices.WiFiDirect;

namespace Windows.Foundation.Collections
{
    public static class EventsMixin
    {
        public static PropertySetEvents Events(this PropertySet This)
        {
            return new PropertySetEvents(This);
        }
    }

    public class PropertySetEvents

    {
        PropertySet This;

        public PropertySetEvents(PropertySet This)

        {
            this.This = This;
        }

        public IObservable<Windows.Foundation.Collections.IMapChangedEventArgs<string>> MapChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.Collections.MapChangedEventHandler<string,object>, Windows.Foundation.Collections.IMapChangedEventArgs<string>>(x => This.MapChanged += x, x => This.MapChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Foundation.Diagnostics
{
    public static class EventsMixin
    {
        public static ILoggingChannelEvents Events(this ILoggingChannel This)
        {
            return new ILoggingChannelEvents(This);
        }
        public static LoggingChannelEvents Events(this LoggingChannel This)
        {
            return new LoggingChannelEvents(This);
        }
        public static IFileLoggingSessionEvents Events(this IFileLoggingSession This)
        {
            return new IFileLoggingSessionEvents(This);
        }
        public static FileLoggingSessionEvents Events(this FileLoggingSession This)
        {
            return new FileLoggingSessionEvents(This);
        }
    }

    public class ILoggingChannelEvents

    {
        ILoggingChannel This;

        public ILoggingChannelEvents(ILoggingChannel This)

        {
            this.This = This;
        }

        public IObservable<object> LoggingEnabled {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Foundation.Diagnostics.ILoggingChannel,object>, object>(x => This.LoggingEnabled += x, x => This.LoggingEnabled -= x).Select(x => x.EventArgs); }
        }

    }
    public class LoggingChannelEvents

    {
        LoggingChannel This;

        public LoggingChannelEvents(LoggingChannel This)

        {
            this.This = This;
        }

        public IObservable<object> LoggingEnabled {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Foundation.Diagnostics.ILoggingChannel,object>, object>(x => This.LoggingEnabled += x, x => This.LoggingEnabled -= x).Select(x => x.EventArgs); }
        }

    }
    public class IFileLoggingSessionEvents

    {
        IFileLoggingSession This;

        public IFileLoggingSessionEvents(IFileLoggingSession This)

        {
            this.This = This;
        }

        public IObservable<Windows.Foundation.Diagnostics.LogFileGeneratedEventArgs> LogFileGenerated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Foundation.Diagnostics.IFileLoggingSession,Windows.Foundation.Diagnostics.LogFileGeneratedEventArgs>, Windows.Foundation.Diagnostics.LogFileGeneratedEventArgs>(x => This.LogFileGenerated += x, x => This.LogFileGenerated -= x).Select(x => x.EventArgs); }
        }

    }
    public class FileLoggingSessionEvents

    {
        FileLoggingSession This;

        public FileLoggingSessionEvents(FileLoggingSession This)

        {
            this.This = This;
        }

        public IObservable<Windows.Foundation.Diagnostics.LogFileGeneratedEventArgs> LogFileGenerated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Foundation.Diagnostics.IFileLoggingSession,Windows.Foundation.Diagnostics.LogFileGeneratedEventArgs>, Windows.Foundation.Diagnostics.LogFileGeneratedEventArgs>(x => This.LogFileGenerated += x, x => This.LogFileGenerated -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Graphics.Display
{
    public static class EventsMixin
    {
        public static DisplayInformationEvents Events(this DisplayInformation This)
        {
            return new DisplayInformationEvents(This);
        }
    }

    public class DisplayInformationEvents

    {
        DisplayInformation This;

        public DisplayInformationEvents(DisplayInformation This)

        {
            this.This = This;
        }

        public IObservable<object> ColorProfileChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Graphics.Display.DisplayInformation,object>, object>(x => This.ColorProfileChanged += x, x => This.ColorProfileChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> DpiChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Graphics.Display.DisplayInformation,object>, object>(x => This.DpiChanged += x, x => This.DpiChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> OrientationChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Graphics.Display.DisplayInformation,object>, object>(x => This.OrientationChanged += x, x => This.OrientationChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> StereoEnabledChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Graphics.Display.DisplayInformation,object>, object>(x => This.StereoEnabledChanged += x, x => This.StereoEnabledChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Graphics.Printing.OptionDetails
{
    public static class EventsMixin
    {
        public static PrintTaskOptionDetailsEvents Events(this PrintTaskOptionDetails This)
        {
            return new PrintTaskOptionDetailsEvents(This);
        }
    }

    public class PrintTaskOptionDetailsEvents

    {
        PrintTaskOptionDetails This;

        public PrintTaskOptionDetailsEvents(PrintTaskOptionDetails This)

        {
            this.This = This;
        }

        public IObservable<object> BeginValidation {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Graphics.Printing.OptionDetails.PrintTaskOptionDetails,object>, object>(x => This.BeginValidation += x, x => This.BeginValidation -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Graphics.Printing.OptionDetails.PrintTaskOptionChangedEventArgs> OptionChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Graphics.Printing.OptionDetails.PrintTaskOptionDetails,Windows.Graphics.Printing.OptionDetails.PrintTaskOptionChangedEventArgs>, Windows.Graphics.Printing.OptionDetails.PrintTaskOptionChangedEventArgs>(x => This.OptionChanged += x, x => This.OptionChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Graphics.Printing
{
    public static class EventsMixin
    {
        public static PrintTaskEvents Events(this PrintTask This)
        {
            return new PrintTaskEvents(This);
        }
        public static PrintManagerEvents Events(this PrintManager This)
        {
            return new PrintManagerEvents(This);
        }
    }

    public class PrintTaskEvents

    {
        PrintTask This;

        public PrintTaskEvents(PrintTask This)

        {
            this.This = This;
        }

        public IObservable<Windows.Graphics.Printing.PrintTaskCompletedEventArgs> Completed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Graphics.Printing.PrintTask,Windows.Graphics.Printing.PrintTaskCompletedEventArgs>, Windows.Graphics.Printing.PrintTaskCompletedEventArgs>(x => This.Completed += x, x => This.Completed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> Previewing {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Graphics.Printing.PrintTask,object>, object>(x => This.Previewing += x, x => This.Previewing -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Graphics.Printing.PrintTaskProgressingEventArgs> Progressing {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Graphics.Printing.PrintTask,Windows.Graphics.Printing.PrintTaskProgressingEventArgs>, Windows.Graphics.Printing.PrintTaskProgressingEventArgs>(x => This.Progressing += x, x => This.Progressing -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> Submitting {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Graphics.Printing.PrintTask,object>, object>(x => This.Submitting += x, x => This.Submitting -= x).Select(x => x.EventArgs); }
        }

    }
    public class PrintManagerEvents

    {
        PrintManager This;

        public PrintManagerEvents(PrintManager This)

        {
            this.This = This;
        }

        public IObservable<Windows.Graphics.Printing.PrintTaskRequestedEventArgs> PrintTaskRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Graphics.Printing.PrintManager,Windows.Graphics.Printing.PrintTaskRequestedEventArgs>, Windows.Graphics.Printing.PrintTaskRequestedEventArgs>(x => This.PrintTaskRequested += x, x => This.PrintTaskRequested -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Media.Devices
{
    public static class EventsMixin
    {
        public static CallControlEvents Events(this CallControl This)
        {
            return new CallControlEvents(This);
        }
    }

    public class CallControlEvents

    {
        CallControl This;

        public CallControlEvents(CallControl This)

        {
            this.This = This;
        }

        public IObservable<Windows.Media.Devices.DialRequestedEventArgs> DialRequested {
            get { return Observable.FromEventPattern<Windows.Media.Devices.DialRequestedEventHandler, Windows.Media.Devices.DialRequestedEventArgs>(x => This.DialRequested += x, x => This.DialRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Devices.KeypadPressedEventArgs> KeypadPressed {
            get { return Observable.FromEventPattern<Windows.Media.Devices.KeypadPressedEventHandler, Windows.Media.Devices.KeypadPressedEventArgs>(x => This.KeypadPressed += x, x => This.KeypadPressed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Devices.RedialRequestedEventArgs> RedialRequested {
            get { return Observable.FromEventPattern<Windows.Media.Devices.RedialRequestedEventHandler, Windows.Media.Devices.RedialRequestedEventArgs>(x => This.RedialRequested += x, x => This.RedialRequested -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Media.Effects
{
    public static class EventsMixin
    {
        public static AudioRenderEffectsManagerEvents Events(this AudioRenderEffectsManager This)
        {
            return new AudioRenderEffectsManagerEvents(This);
        }
        public static AudioCaptureEffectsManagerEvents Events(this AudioCaptureEffectsManager This)
        {
            return new AudioCaptureEffectsManagerEvents(This);
        }
    }

    public class AudioRenderEffectsManagerEvents

    {
        AudioRenderEffectsManager This;

        public AudioRenderEffectsManagerEvents(AudioRenderEffectsManager This)

        {
            this.This = This;
        }

        public IObservable<object> AudioRenderEffectsChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Effects.AudioRenderEffectsManager,object>, object>(x => This.AudioRenderEffectsChanged += x, x => This.AudioRenderEffectsChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class AudioCaptureEffectsManagerEvents

    {
        AudioCaptureEffectsManager This;

        public AudioCaptureEffectsManagerEvents(AudioCaptureEffectsManager This)

        {
            this.This = This;
        }

        public IObservable<object> AudioCaptureEffectsChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Effects.AudioCaptureEffectsManager,object>, object>(x => This.AudioCaptureEffectsChanged += x, x => This.AudioCaptureEffectsChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Media.PlayTo
{
    public static class EventsMixin
    {
        public static PlayToReceiverEvents Events(this PlayToReceiver This)
        {
            return new PlayToReceiverEvents(This);
        }
        public static PlayToConnectionEvents Events(this PlayToConnection This)
        {
            return new PlayToConnectionEvents(This);
        }
        public static PlayToManagerEvents Events(this PlayToManager This)
        {
            return new PlayToManagerEvents(This);
        }
    }

    public class PlayToReceiverEvents

    {
        PlayToReceiver This;

        public PlayToReceiverEvents(PlayToReceiver This)

        {
            this.This = This;
        }

        public IObservable<Windows.Media.PlayTo.CurrentTimeChangeRequestedEventArgs> CurrentTimeChangeRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.PlayTo.PlayToReceiver,Windows.Media.PlayTo.CurrentTimeChangeRequestedEventArgs>, Windows.Media.PlayTo.CurrentTimeChangeRequestedEventArgs>(x => This.CurrentTimeChangeRequested += x, x => This.CurrentTimeChangeRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.PlayTo.MuteChangeRequestedEventArgs> MuteChangeRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.PlayTo.PlayToReceiver,Windows.Media.PlayTo.MuteChangeRequestedEventArgs>, Windows.Media.PlayTo.MuteChangeRequestedEventArgs>(x => This.MuteChangeRequested += x, x => This.MuteChangeRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> PauseRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.PlayTo.PlayToReceiver,object>, object>(x => This.PauseRequested += x, x => This.PauseRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> PlayRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.PlayTo.PlayToReceiver,object>, object>(x => This.PlayRequested += x, x => This.PlayRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.PlayTo.PlaybackRateChangeRequestedEventArgs> PlaybackRateChangeRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.PlayTo.PlayToReceiver,Windows.Media.PlayTo.PlaybackRateChangeRequestedEventArgs>, Windows.Media.PlayTo.PlaybackRateChangeRequestedEventArgs>(x => This.PlaybackRateChangeRequested += x, x => This.PlaybackRateChangeRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.PlayTo.SourceChangeRequestedEventArgs> SourceChangeRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.PlayTo.PlayToReceiver,Windows.Media.PlayTo.SourceChangeRequestedEventArgs>, Windows.Media.PlayTo.SourceChangeRequestedEventArgs>(x => This.SourceChangeRequested += x, x => This.SourceChangeRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> StopRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.PlayTo.PlayToReceiver,object>, object>(x => This.StopRequested += x, x => This.StopRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> TimeUpdateRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.PlayTo.PlayToReceiver,object>, object>(x => This.TimeUpdateRequested += x, x => This.TimeUpdateRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.PlayTo.VolumeChangeRequestedEventArgs> VolumeChangeRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.PlayTo.PlayToReceiver,Windows.Media.PlayTo.VolumeChangeRequestedEventArgs>, Windows.Media.PlayTo.VolumeChangeRequestedEventArgs>(x => This.VolumeChangeRequested += x, x => This.VolumeChangeRequested -= x).Select(x => x.EventArgs); }
        }

    }
    public class PlayToConnectionEvents

    {
        PlayToConnection This;

        public PlayToConnectionEvents(PlayToConnection This)

        {
            this.This = This;
        }

        public IObservable<Windows.Media.PlayTo.PlayToConnectionErrorEventArgs> Error {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.PlayTo.PlayToConnection,Windows.Media.PlayTo.PlayToConnectionErrorEventArgs>, Windows.Media.PlayTo.PlayToConnectionErrorEventArgs>(x => This.Error += x, x => This.Error -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.PlayTo.PlayToConnectionStateChangedEventArgs> StateChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.PlayTo.PlayToConnection,Windows.Media.PlayTo.PlayToConnectionStateChangedEventArgs>, Windows.Media.PlayTo.PlayToConnectionStateChangedEventArgs>(x => This.StateChanged += x, x => This.StateChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.PlayTo.PlayToConnectionTransferredEventArgs> Transferred {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.PlayTo.PlayToConnection,Windows.Media.PlayTo.PlayToConnectionTransferredEventArgs>, Windows.Media.PlayTo.PlayToConnectionTransferredEventArgs>(x => This.Transferred += x, x => This.Transferred -= x).Select(x => x.EventArgs); }
        }

    }
    public class PlayToManagerEvents

    {
        PlayToManager This;

        public PlayToManagerEvents(PlayToManager This)

        {
            this.This = This;
        }

        public IObservable<Windows.Media.PlayTo.PlayToSourceRequestedEventArgs> SourceRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.PlayTo.PlayToManager,Windows.Media.PlayTo.PlayToSourceRequestedEventArgs>, Windows.Media.PlayTo.PlayToSourceRequestedEventArgs>(x => This.SourceRequested += x, x => This.SourceRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.PlayTo.PlayToSourceSelectedEventArgs> SourceSelected {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.PlayTo.PlayToManager,Windows.Media.PlayTo.PlayToSourceSelectedEventArgs>, Windows.Media.PlayTo.PlayToSourceSelectedEventArgs>(x => This.SourceSelected += x, x => This.SourceSelected -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Media
{
    public static class EventsMixin
    {
        public static SystemMediaTransportControlsEvents Events(this SystemMediaTransportControls This)
        {
            return new SystemMediaTransportControlsEvents(This);
        }
    }

    public class SystemMediaTransportControlsEvents

    {
        SystemMediaTransportControls This;

        public SystemMediaTransportControlsEvents(SystemMediaTransportControls This)

        {
            this.This = This;
        }

        public IObservable<Windows.Media.SystemMediaTransportControlsButtonPressedEventArgs> ButtonPressed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.SystemMediaTransportControls,Windows.Media.SystemMediaTransportControlsButtonPressedEventArgs>, Windows.Media.SystemMediaTransportControlsButtonPressedEventArgs>(x => This.ButtonPressed += x, x => This.ButtonPressed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.SystemMediaTransportControlsPropertyChangedEventArgs> PropertyChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.SystemMediaTransportControls,Windows.Media.SystemMediaTransportControlsPropertyChangedEventArgs>, Windows.Media.SystemMediaTransportControlsPropertyChangedEventArgs>(x => This.PropertyChanged += x, x => This.PropertyChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Media.Capture
{
    public static class EventsMixin
    {
        public static MediaCaptureEvents Events(this MediaCapture This)
        {
            return new MediaCaptureEvents(This);
        }
        public static LowLagPhotoSequenceCaptureEvents Events(this LowLagPhotoSequenceCapture This)
        {
            return new LowLagPhotoSequenceCaptureEvents(This);
        }
    }

    public class MediaCaptureEvents

    {
        MediaCapture This;

        public MediaCaptureEvents(MediaCapture This)

        {
            this.This = This;
        }

        public IObservable<Windows.Media.Capture.MediaCaptureFailedEventArgs> Failed {
            get { return Observable.FromEventPattern<Windows.Media.Capture.MediaCaptureFailedEventHandler, Windows.Media.Capture.MediaCaptureFailedEventArgs>(x => This.Failed += x, x => This.Failed -= x).Select(x => x.EventArgs); }
        }

    }
    public class LowLagPhotoSequenceCaptureEvents

    {
        LowLagPhotoSequenceCapture This;

        public LowLagPhotoSequenceCaptureEvents(LowLagPhotoSequenceCapture This)

        {
            this.This = This;
        }

        public IObservable<Windows.Media.Capture.PhotoCapturedEventArgs> PhotoCaptured {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Capture.LowLagPhotoSequenceCapture,Windows.Media.Capture.PhotoCapturedEventArgs>, Windows.Media.Capture.PhotoCapturedEventArgs>(x => This.PhotoCaptured += x, x => This.PhotoCaptured -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Media.Protection
{
    public static class EventsMixin
    {
        public static MediaProtectionManagerEvents Events(this MediaProtectionManager This)
        {
            return new MediaProtectionManagerEvents(This);
        }
    }

    public class MediaProtectionManagerEvents

    {
        MediaProtectionManager This;

        public MediaProtectionManagerEvents(MediaProtectionManager This)

        {
            this.This = This;
        }

        public IObservable<Windows.Media.Protection.ComponentLoadFailedEventArgs> ComponentLoadFailed {
            get { return Observable.FromEventPattern<Windows.Media.Protection.ComponentLoadFailedEventHandler, Windows.Media.Protection.ComponentLoadFailedEventArgs>(x => This.ComponentLoadFailed += x, x => This.ComponentLoadFailed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Protection.ServiceRequestedEventArgs> ServiceRequested {
            get { return Observable.FromEventPattern<Windows.Media.Protection.ServiceRequestedEventHandler, Windows.Media.Protection.ServiceRequestedEventArgs>(x => This.ServiceRequested += x, x => This.ServiceRequested -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Media.Core
{
    public static class EventsMixin
    {
        public static MediaStreamSourceEvents Events(this MediaStreamSource This)
        {
            return new MediaStreamSourceEvents(This);
        }
        public static MediaStreamSampleEvents Events(this MediaStreamSample This)
        {
            return new MediaStreamSampleEvents(This);
        }
    }

    public class MediaStreamSourceEvents

    {
        MediaStreamSource This;

        public MediaStreamSourceEvents(MediaStreamSource This)

        {
            this.This = This;
        }

        public IObservable<Windows.Media.Core.MediaStreamSourceClosedEventArgs> Closed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Core.MediaStreamSource,Windows.Media.Core.MediaStreamSourceClosedEventArgs>, Windows.Media.Core.MediaStreamSourceClosedEventArgs>(x => This.Closed += x, x => This.Closed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> Paused {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Core.MediaStreamSource,object>, object>(x => This.Paused += x, x => This.Paused -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Core.MediaStreamSourceSampleRequestedEventArgs> SampleRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Core.MediaStreamSource,Windows.Media.Core.MediaStreamSourceSampleRequestedEventArgs>, Windows.Media.Core.MediaStreamSourceSampleRequestedEventArgs>(x => This.SampleRequested += x, x => This.SampleRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Core.MediaStreamSourceStartingEventArgs> Starting {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Core.MediaStreamSource,Windows.Media.Core.MediaStreamSourceStartingEventArgs>, Windows.Media.Core.MediaStreamSourceStartingEventArgs>(x => This.Starting += x, x => This.Starting -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Core.MediaStreamSourceSwitchStreamsRequestedEventArgs> SwitchStreamsRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Core.MediaStreamSource,Windows.Media.Core.MediaStreamSourceSwitchStreamsRequestedEventArgs>, Windows.Media.Core.MediaStreamSourceSwitchStreamsRequestedEventArgs>(x => This.SwitchStreamsRequested += x, x => This.SwitchStreamsRequested -= x).Select(x => x.EventArgs); }
        }

    }
    public class MediaStreamSampleEvents

    {
        MediaStreamSample This;

        public MediaStreamSampleEvents(MediaStreamSample This)

        {
            this.This = This;
        }

        public IObservable<object> Processed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Core.MediaStreamSample,object>, object>(x => This.Processed += x, x => This.Processed -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Media.ContentRestrictions
{
    public static class EventsMixin
    {
        public static RatedContentRestrictionsEvents Events(this RatedContentRestrictions This)
        {
            return new RatedContentRestrictionsEvents(This);
        }
    }

    public class RatedContentRestrictionsEvents

    {
        RatedContentRestrictions This;

        public RatedContentRestrictionsEvents(RatedContentRestrictions This)

        {
            this.This = This;
        }

        public IObservable<object> RestrictionsChanged {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.RestrictionsChanged += x, x => This.RestrictionsChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Networking.NetworkOperators
{
    public static class EventsMixin
    {
        public static MobileBroadbandAccountWatcherEvents Events(this MobileBroadbandAccountWatcher This)
        {
            return new MobileBroadbandAccountWatcherEvents(This);
        }
    }

    public class MobileBroadbandAccountWatcherEvents

    {
        MobileBroadbandAccountWatcher This;

        public MobileBroadbandAccountWatcherEvents(MobileBroadbandAccountWatcher This)

        {
            this.This = This;
        }

        public IObservable<Windows.Networking.NetworkOperators.MobileBroadbandAccountEventArgs> AccountAdded {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Networking.NetworkOperators.MobileBroadbandAccountWatcher,Windows.Networking.NetworkOperators.MobileBroadbandAccountEventArgs>, Windows.Networking.NetworkOperators.MobileBroadbandAccountEventArgs>(x => This.AccountAdded += x, x => This.AccountAdded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Networking.NetworkOperators.MobileBroadbandAccountEventArgs> AccountRemoved {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Networking.NetworkOperators.MobileBroadbandAccountWatcher,Windows.Networking.NetworkOperators.MobileBroadbandAccountEventArgs>, Windows.Networking.NetworkOperators.MobileBroadbandAccountEventArgs>(x => This.AccountRemoved += x, x => This.AccountRemoved -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Networking.NetworkOperators.MobileBroadbandAccountUpdatedEventArgs> AccountUpdated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Networking.NetworkOperators.MobileBroadbandAccountWatcher,Windows.Networking.NetworkOperators.MobileBroadbandAccountUpdatedEventArgs>, Windows.Networking.NetworkOperators.MobileBroadbandAccountUpdatedEventArgs>(x => This.AccountUpdated += x, x => This.AccountUpdated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> EnumerationCompleted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Networking.NetworkOperators.MobileBroadbandAccountWatcher,object>, object>(x => This.EnumerationCompleted += x, x => This.EnumerationCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> Stopped {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Networking.NetworkOperators.MobileBroadbandAccountWatcher,object>, object>(x => This.Stopped += x, x => This.Stopped -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Networking.Proximity
{
    public static class EventsMixin
    {
        public static PeerWatcherEvents Events(this PeerWatcher This)
        {
            return new PeerWatcherEvents(This);
        }
    }

    public class PeerWatcherEvents

    {
        PeerWatcher This;

        public PeerWatcherEvents(PeerWatcher This)

        {
            this.This = This;
        }

        public IObservable<Windows.Networking.Proximity.PeerInformation> Added {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Networking.Proximity.PeerWatcher,Windows.Networking.Proximity.PeerInformation>, Windows.Networking.Proximity.PeerInformation>(x => This.Added += x, x => This.Added -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> EnumerationCompleted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Networking.Proximity.PeerWatcher,object>, object>(x => This.EnumerationCompleted += x, x => This.EnumerationCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Networking.Proximity.PeerInformation> Removed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Networking.Proximity.PeerWatcher,Windows.Networking.Proximity.PeerInformation>, Windows.Networking.Proximity.PeerInformation>(x => This.Removed += x, x => This.Removed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> Stopped {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Networking.Proximity.PeerWatcher,object>, object>(x => This.Stopped += x, x => This.Stopped -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Networking.Proximity.PeerInformation> Updated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Networking.Proximity.PeerWatcher,Windows.Networking.Proximity.PeerInformation>, Windows.Networking.Proximity.PeerInformation>(x => This.Updated += x, x => This.Updated -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Networking.Sockets
{
    public static class EventsMixin
    {
        public static DatagramSocketEvents Events(this DatagramSocket This)
        {
            return new DatagramSocketEvents(This);
        }
        public static StreamSocketListenerEvents Events(this StreamSocketListener This)
        {
            return new StreamSocketListenerEvents(This);
        }
        public static IWebSocketEvents Events(this IWebSocket This)
        {
            return new IWebSocketEvents(This);
        }
        public static MessageWebSocketEvents Events(this MessageWebSocket This)
        {
            return new MessageWebSocketEvents(This);
        }
        public static StreamWebSocketEvents Events(this StreamWebSocket This)
        {
            return new StreamWebSocketEvents(This);
        }
    }

    public class DatagramSocketEvents

    {
        DatagramSocket This;

        public DatagramSocketEvents(DatagramSocket This)

        {
            this.This = This;
        }

        public IObservable<Windows.Networking.Sockets.DatagramSocketMessageReceivedEventArgs> MessageReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Networking.Sockets.DatagramSocket,Windows.Networking.Sockets.DatagramSocketMessageReceivedEventArgs>, Windows.Networking.Sockets.DatagramSocketMessageReceivedEventArgs>(x => This.MessageReceived += x, x => This.MessageReceived -= x).Select(x => x.EventArgs); }
        }

    }
    public class StreamSocketListenerEvents

    {
        StreamSocketListener This;

        public StreamSocketListenerEvents(StreamSocketListener This)

        {
            this.This = This;
        }

        public IObservable<Windows.Networking.Sockets.StreamSocketListenerConnectionReceivedEventArgs> ConnectionReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Networking.Sockets.StreamSocketListener,Windows.Networking.Sockets.StreamSocketListenerConnectionReceivedEventArgs>, Windows.Networking.Sockets.StreamSocketListenerConnectionReceivedEventArgs>(x => This.ConnectionReceived += x, x => This.ConnectionReceived -= x).Select(x => x.EventArgs); }
        }

    }
    public class IWebSocketEvents

    {
        IWebSocket This;

        public IWebSocketEvents(IWebSocket This)

        {
            this.This = This;
        }

        public IObservable<Windows.Networking.Sockets.WebSocketClosedEventArgs> Closed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Networking.Sockets.IWebSocket,Windows.Networking.Sockets.WebSocketClosedEventArgs>, Windows.Networking.Sockets.WebSocketClosedEventArgs>(x => This.Closed += x, x => This.Closed -= x).Select(x => x.EventArgs); }
        }

    }
    public class MessageWebSocketEvents

    {
        MessageWebSocket This;

        public MessageWebSocketEvents(MessageWebSocket This)

        {
            this.This = This;
        }

        public IObservable<Windows.Networking.Sockets.MessageWebSocketMessageReceivedEventArgs> MessageReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Networking.Sockets.MessageWebSocket,Windows.Networking.Sockets.MessageWebSocketMessageReceivedEventArgs>, Windows.Networking.Sockets.MessageWebSocketMessageReceivedEventArgs>(x => This.MessageReceived += x, x => This.MessageReceived -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Networking.Sockets.WebSocketClosedEventArgs> Closed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Networking.Sockets.IWebSocket,Windows.Networking.Sockets.WebSocketClosedEventArgs>, Windows.Networking.Sockets.WebSocketClosedEventArgs>(x => This.Closed += x, x => This.Closed -= x).Select(x => x.EventArgs); }
        }

    }
    public class StreamWebSocketEvents

    {
        StreamWebSocket This;

        public StreamWebSocketEvents(StreamWebSocket This)

        {
            this.This = This;
        }

        public IObservable<Windows.Networking.Sockets.WebSocketClosedEventArgs> Closed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Networking.Sockets.IWebSocket,Windows.Networking.Sockets.WebSocketClosedEventArgs>, Windows.Networking.Sockets.WebSocketClosedEventArgs>(x => This.Closed += x, x => This.Closed -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Networking.Vpn
{
    public static class EventsMixin
    {
        public static VpnChannelEvents Events(this VpnChannel This)
        {
            return new VpnChannelEvents(This);
        }
    }

    public class VpnChannelEvents

    {
        VpnChannel This;

        public VpnChannelEvents(VpnChannel This)

        {
            this.This = This;
        }

        public IObservable<Windows.Networking.Vpn.VpnChannelActivityEventArgs> ActivityChange {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Networking.Vpn.VpnChannel,Windows.Networking.Vpn.VpnChannelActivityEventArgs>, Windows.Networking.Vpn.VpnChannelActivityEventArgs>(x => This.ActivityChange += x, x => This.ActivityChange -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Networking.PushNotifications
{
    public static class EventsMixin
    {
        public static PushNotificationChannelEvents Events(this PushNotificationChannel This)
        {
            return new PushNotificationChannelEvents(This);
        }
    }

    public class PushNotificationChannelEvents

    {
        PushNotificationChannel This;

        public PushNotificationChannelEvents(PushNotificationChannel This)

        {
            this.This = This;
        }

        public IObservable<Windows.Networking.PushNotifications.PushNotificationReceivedEventArgs> PushNotificationReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Networking.PushNotifications.PushNotificationChannel,Windows.Networking.PushNotifications.PushNotificationReceivedEventArgs>, Windows.Networking.PushNotifications.PushNotificationReceivedEventArgs>(x => This.PushNotificationReceived += x, x => This.PushNotificationReceived -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Security.Credentials
{
    public static class EventsMixin
    {
        public static PasswordCredentialPropertyStoreEvents Events(this PasswordCredentialPropertyStore This)
        {
            return new PasswordCredentialPropertyStoreEvents(This);
        }
    }

    public class PasswordCredentialPropertyStoreEvents

    {
        PasswordCredentialPropertyStore This;

        public PasswordCredentialPropertyStoreEvents(PasswordCredentialPropertyStore This)

        {
            this.This = This;
        }

        public IObservable<Windows.Foundation.Collections.IMapChangedEventArgs<string>> MapChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.Collections.MapChangedEventHandler<string,object>, Windows.Foundation.Collections.IMapChangedEventArgs<string>>(x => This.MapChanged += x, x => This.MapChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Storage.Pickers.Provider
{
    public static class EventsMixin
    {
        public static FileOpenPickerUIEvents Events(this FileOpenPickerUI This)
        {
            return new FileOpenPickerUIEvents(This);
        }
        public static FileSavePickerUIEvents Events(this FileSavePickerUI This)
        {
            return new FileSavePickerUIEvents(This);
        }
    }

    public class FileOpenPickerUIEvents

    {
        FileOpenPickerUI This;

        public FileOpenPickerUIEvents(FileOpenPickerUI This)

        {
            this.This = This;
        }

        public IObservable<Windows.Storage.Pickers.Provider.PickerClosingEventArgs> Closing {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.Pickers.Provider.FileOpenPickerUI,Windows.Storage.Pickers.Provider.PickerClosingEventArgs>, Windows.Storage.Pickers.Provider.PickerClosingEventArgs>(x => This.Closing += x, x => This.Closing -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Storage.Pickers.Provider.FileRemovedEventArgs> FileRemoved {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.Pickers.Provider.FileOpenPickerUI,Windows.Storage.Pickers.Provider.FileRemovedEventArgs>, Windows.Storage.Pickers.Provider.FileRemovedEventArgs>(x => This.FileRemoved += x, x => This.FileRemoved -= x).Select(x => x.EventArgs); }
        }

    }
    public class FileSavePickerUIEvents

    {
        FileSavePickerUI This;

        public FileSavePickerUIEvents(FileSavePickerUI This)

        {
            this.This = This;
        }

        public IObservable<object> FileNameChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.Pickers.Provider.FileSavePickerUI,object>, object>(x => This.FileNameChanged += x, x => This.FileNameChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Storage.Pickers.Provider.TargetFileRequestedEventArgs> TargetFileRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.Pickers.Provider.FileSavePickerUI,Windows.Storage.Pickers.Provider.TargetFileRequestedEventArgs>, Windows.Storage.Pickers.Provider.TargetFileRequestedEventArgs>(x => This.TargetFileRequested += x, x => This.TargetFileRequested -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Storage.Provider
{
    public static class EventsMixin
    {
        public static CachedFileUpdaterUIEvents Events(this CachedFileUpdaterUI This)
        {
            return new CachedFileUpdaterUIEvents(This);
        }
    }

    public class CachedFileUpdaterUIEvents

    {
        CachedFileUpdaterUI This;

        public CachedFileUpdaterUIEvents(CachedFileUpdaterUI This)

        {
            this.This = This;
        }

        public IObservable<Windows.Storage.Provider.FileUpdateRequestedEventArgs> FileUpdateRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.Provider.CachedFileUpdaterUI,Windows.Storage.Provider.FileUpdateRequestedEventArgs>, Windows.Storage.Provider.FileUpdateRequestedEventArgs>(x => This.FileUpdateRequested += x, x => This.FileUpdateRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> UIRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.Provider.CachedFileUpdaterUI,object>, object>(x => This.UIRequested += x, x => This.UIRequested -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Storage
{
    public static class EventsMixin
    {
        public static StorageLibraryEvents Events(this StorageLibrary This)
        {
            return new StorageLibraryEvents(This);
        }
        public static ApplicationDataEvents Events(this ApplicationData This)
        {
            return new ApplicationDataEvents(This);
        }
        public static ApplicationDataContainerSettingsEvents Events(this ApplicationDataContainerSettings This)
        {
            return new ApplicationDataContainerSettingsEvents(This);
        }
        public static ApplicationDataCompositeValueEvents Events(this ApplicationDataCompositeValue This)
        {
            return new ApplicationDataCompositeValueEvents(This);
        }
    }

    public class StorageLibraryEvents

    {
        StorageLibrary This;

        public StorageLibraryEvents(StorageLibrary This)

        {
            this.This = This;
        }

        public IObservable<object> DefinitionChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.StorageLibrary,object>, object>(x => This.DefinitionChanged += x, x => This.DefinitionChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ApplicationDataEvents

    {
        ApplicationData This;

        public ApplicationDataEvents(ApplicationData This)

        {
            this.This = This;
        }

        public IObservable<object> DataChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.ApplicationData,object>, object>(x => This.DataChanged += x, x => This.DataChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ApplicationDataContainerSettingsEvents

    {
        ApplicationDataContainerSettings This;

        public ApplicationDataContainerSettingsEvents(ApplicationDataContainerSettings This)

        {
            this.This = This;
        }

        public IObservable<Windows.Foundation.Collections.IMapChangedEventArgs<string>> MapChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.Collections.MapChangedEventHandler<string,object>, Windows.Foundation.Collections.IMapChangedEventArgs<string>>(x => This.MapChanged += x, x => This.MapChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ApplicationDataCompositeValueEvents

    {
        ApplicationDataCompositeValue This;

        public ApplicationDataCompositeValueEvents(ApplicationDataCompositeValue This)

        {
            this.This = This;
        }

        public IObservable<Windows.Foundation.Collections.IMapChangedEventArgs<string>> MapChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.Collections.MapChangedEventHandler<string,object>, Windows.Foundation.Collections.IMapChangedEventArgs<string>>(x => This.MapChanged += x, x => This.MapChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Storage.Search
{
    public static class EventsMixin
    {
        public static IStorageQueryResultBaseEvents Events(this IStorageQueryResultBase This)
        {
            return new IStorageQueryResultBaseEvents(This);
        }
        public static StorageFileQueryResultEvents Events(this StorageFileQueryResult This)
        {
            return new StorageFileQueryResultEvents(This);
        }
        public static StorageFolderQueryResultEvents Events(this StorageFolderQueryResult This)
        {
            return new StorageFolderQueryResultEvents(This);
        }
        public static StorageItemQueryResultEvents Events(this StorageItemQueryResult This)
        {
            return new StorageItemQueryResultEvents(This);
        }
    }

    public class IStorageQueryResultBaseEvents

    {
        IStorageQueryResultBase This;

        public IStorageQueryResultBaseEvents(IStorageQueryResultBase This)

        {
            this.This = This;
        }

        public IObservable<object> ContentsChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.Search.IStorageQueryResultBase,object>, object>(x => This.ContentsChanged += x, x => This.ContentsChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> OptionsChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.Search.IStorageQueryResultBase,object>, object>(x => This.OptionsChanged += x, x => This.OptionsChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class StorageFileQueryResultEvents

    {
        StorageFileQueryResult This;

        public StorageFileQueryResultEvents(StorageFileQueryResult This)

        {
            this.This = This;
        }

        public IObservable<object> ContentsChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.Search.IStorageQueryResultBase,object>, object>(x => This.ContentsChanged += x, x => This.ContentsChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> OptionsChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.Search.IStorageQueryResultBase,object>, object>(x => This.OptionsChanged += x, x => This.OptionsChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class StorageFolderQueryResultEvents

    {
        StorageFolderQueryResult This;

        public StorageFolderQueryResultEvents(StorageFolderQueryResult This)

        {
            this.This = This;
        }

        public IObservable<object> ContentsChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.Search.IStorageQueryResultBase,object>, object>(x => This.ContentsChanged += x, x => This.ContentsChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> OptionsChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.Search.IStorageQueryResultBase,object>, object>(x => This.OptionsChanged += x, x => This.OptionsChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class StorageItemQueryResultEvents

    {
        StorageItemQueryResult This;

        public StorageItemQueryResultEvents(StorageItemQueryResult This)

        {
            this.This = This;
        }

        public IObservable<object> ContentsChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.Search.IStorageQueryResultBase,object>, object>(x => This.ContentsChanged += x, x => This.ContentsChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> OptionsChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.Search.IStorageQueryResultBase,object>, object>(x => This.OptionsChanged += x, x => This.OptionsChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Storage.AccessCache
{
    public static class EventsMixin
    {
        public static StorageItemMostRecentlyUsedListEvents Events(this StorageItemMostRecentlyUsedList This)
        {
            return new StorageItemMostRecentlyUsedListEvents(This);
        }
    }

    public class StorageItemMostRecentlyUsedListEvents

    {
        StorageItemMostRecentlyUsedList This;

        public StorageItemMostRecentlyUsedListEvents(StorageItemMostRecentlyUsedList This)

        {
            this.This = This;
        }

        public IObservable<Windows.Storage.AccessCache.ItemRemovedEventArgs> ItemRemoved {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.AccessCache.StorageItemMostRecentlyUsedList,Windows.Storage.AccessCache.ItemRemovedEventArgs>, Windows.Storage.AccessCache.ItemRemovedEventArgs>(x => This.ItemRemoved += x, x => This.ItemRemoved -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Storage.BulkAccess
{
    public static class EventsMixin
    {
        public static IStorageItemInformationEvents Events(this IStorageItemInformation This)
        {
            return new IStorageItemInformationEvents(This);
        }
        public static FileInformationEvents Events(this FileInformation This)
        {
            return new FileInformationEvents(This);
        }
        public static FolderInformationEvents Events(this FolderInformation This)
        {
            return new FolderInformationEvents(This);
        }
    }

    public class IStorageItemInformationEvents

    {
        IStorageItemInformation This;

        public IStorageItemInformationEvents(IStorageItemInformation This)

        {
            this.This = This;
        }

        public IObservable<object> PropertiesUpdated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.BulkAccess.IStorageItemInformation,object>, object>(x => This.PropertiesUpdated += x, x => This.PropertiesUpdated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> ThumbnailUpdated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.BulkAccess.IStorageItemInformation,object>, object>(x => This.ThumbnailUpdated += x, x => This.ThumbnailUpdated -= x).Select(x => x.EventArgs); }
        }

    }
    public class FileInformationEvents

    {
        FileInformation This;

        public FileInformationEvents(FileInformation This)

        {
            this.This = This;
        }

        public IObservable<object> PropertiesUpdated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.BulkAccess.IStorageItemInformation,object>, object>(x => This.PropertiesUpdated += x, x => This.PropertiesUpdated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> ThumbnailUpdated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.BulkAccess.IStorageItemInformation,object>, object>(x => This.ThumbnailUpdated += x, x => This.ThumbnailUpdated -= x).Select(x => x.EventArgs); }
        }

    }
    public class FolderInformationEvents

    {
        FolderInformation This;

        public FolderInformationEvents(FolderInformation This)

        {
            this.This = This;
        }

        public IObservable<object> PropertiesUpdated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.BulkAccess.IStorageItemInformation,object>, object>(x => This.PropertiesUpdated += x, x => This.PropertiesUpdated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> ThumbnailUpdated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.BulkAccess.IStorageItemInformation,object>, object>(x => This.ThumbnailUpdated += x, x => This.ThumbnailUpdated -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.UI.ApplicationSettings
{
    public static class EventsMixin
    {
        public static SettingsPaneEvents Events(this SettingsPane This)
        {
            return new SettingsPaneEvents(This);
        }
        public static AccountsSettingsPaneEvents Events(this AccountsSettingsPane This)
        {
            return new AccountsSettingsPaneEvents(This);
        }
    }

    public class SettingsPaneEvents

    {
        SettingsPane This;

        public SettingsPaneEvents(SettingsPane This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.ApplicationSettings.SettingsPaneCommandsRequestedEventArgs> CommandsRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.ApplicationSettings.SettingsPane,Windows.UI.ApplicationSettings.SettingsPaneCommandsRequestedEventArgs>, Windows.UI.ApplicationSettings.SettingsPaneCommandsRequestedEventArgs>(x => This.CommandsRequested += x, x => This.CommandsRequested -= x).Select(x => x.EventArgs); }
        }

    }
    public class AccountsSettingsPaneEvents

    {
        AccountsSettingsPane This;

        public AccountsSettingsPaneEvents(AccountsSettingsPane This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.ApplicationSettings.AccountsSettingsPaneCommandsRequestedEventArgs> AccountCommandsRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.ApplicationSettings.AccountsSettingsPane,Windows.UI.ApplicationSettings.AccountsSettingsPaneCommandsRequestedEventArgs>, Windows.UI.ApplicationSettings.AccountsSettingsPaneCommandsRequestedEventArgs>(x => This.AccountCommandsRequested += x, x => This.AccountCommandsRequested -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.UI.ViewManagement
{
    public static class EventsMixin
    {
        public static ApplicationViewEvents Events(this ApplicationView This)
        {
            return new ApplicationViewEvents(This);
        }
        public static InputPaneEvents Events(this InputPane This)
        {
            return new InputPaneEvents(This);
        }
        public static AccessibilitySettingsEvents Events(this AccessibilitySettings This)
        {
            return new AccessibilitySettingsEvents(This);
        }
    }

    public class ApplicationViewEvents

    {
        ApplicationView This;

        public ApplicationViewEvents(ApplicationView This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.ViewManagement.ApplicationViewConsolidatedEventArgs> Consolidated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.ViewManagement.ApplicationView,Windows.UI.ViewManagement.ApplicationViewConsolidatedEventArgs>, Windows.UI.ViewManagement.ApplicationViewConsolidatedEventArgs>(x => This.Consolidated += x, x => This.Consolidated -= x).Select(x => x.EventArgs); }
        }

    }
    public class InputPaneEvents

    {
        InputPane This;

        public InputPaneEvents(InputPane This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.ViewManagement.InputPaneVisibilityEventArgs> Hiding {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.ViewManagement.InputPane,Windows.UI.ViewManagement.InputPaneVisibilityEventArgs>, Windows.UI.ViewManagement.InputPaneVisibilityEventArgs>(x => This.Hiding += x, x => This.Hiding -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.ViewManagement.InputPaneVisibilityEventArgs> Showing {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.ViewManagement.InputPane,Windows.UI.ViewManagement.InputPaneVisibilityEventArgs>, Windows.UI.ViewManagement.InputPaneVisibilityEventArgs>(x => This.Showing += x, x => This.Showing -= x).Select(x => x.EventArgs); }
        }

    }
    public class AccessibilitySettingsEvents

    {
        AccessibilitySettings This;

        public AccessibilitySettingsEvents(AccessibilitySettings This)

        {
            this.This = This;
        }

        public IObservable<object> HighContrastChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.ViewManagement.AccessibilitySettings,object>, object>(x => This.HighContrastChanged += x, x => This.HighContrastChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.UI.Input
{
    public static class EventsMixin
    {
        public static EdgeGestureEvents Events(this EdgeGesture This)
        {
            return new EdgeGestureEvents(This);
        }
        public static GestureRecognizerEvents Events(this GestureRecognizer This)
        {
            return new GestureRecognizerEvents(This);
        }
    }

    public class EdgeGestureEvents

    {
        EdgeGesture This;

        public EdgeGestureEvents(EdgeGesture This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Input.EdgeGestureEventArgs> Canceled {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.EdgeGesture,Windows.UI.Input.EdgeGestureEventArgs>, Windows.UI.Input.EdgeGestureEventArgs>(x => This.Canceled += x, x => This.Canceled -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.EdgeGestureEventArgs> Completed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.EdgeGesture,Windows.UI.Input.EdgeGestureEventArgs>, Windows.UI.Input.EdgeGestureEventArgs>(x => This.Completed += x, x => This.Completed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.EdgeGestureEventArgs> Starting {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.EdgeGesture,Windows.UI.Input.EdgeGestureEventArgs>, Windows.UI.Input.EdgeGestureEventArgs>(x => This.Starting += x, x => This.Starting -= x).Select(x => x.EventArgs); }
        }

    }
    public class GestureRecognizerEvents

    {
        GestureRecognizer This;

        public GestureRecognizerEvents(GestureRecognizer This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Input.CrossSlidingEventArgs> CrossSliding {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.GestureRecognizer,Windows.UI.Input.CrossSlidingEventArgs>, Windows.UI.Input.CrossSlidingEventArgs>(x => This.CrossSliding += x, x => This.CrossSliding -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.DraggingEventArgs> Dragging {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.GestureRecognizer,Windows.UI.Input.DraggingEventArgs>, Windows.UI.Input.DraggingEventArgs>(x => This.Dragging += x, x => This.Dragging -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.HoldingEventArgs> Holding {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.GestureRecognizer,Windows.UI.Input.HoldingEventArgs>, Windows.UI.Input.HoldingEventArgs>(x => This.Holding += x, x => This.Holding -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.ManipulationCompletedEventArgs> ManipulationCompleted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.GestureRecognizer,Windows.UI.Input.ManipulationCompletedEventArgs>, Windows.UI.Input.ManipulationCompletedEventArgs>(x => This.ManipulationCompleted += x, x => This.ManipulationCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.ManipulationInertiaStartingEventArgs> ManipulationInertiaStarting {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.GestureRecognizer,Windows.UI.Input.ManipulationInertiaStartingEventArgs>, Windows.UI.Input.ManipulationInertiaStartingEventArgs>(x => This.ManipulationInertiaStarting += x, x => This.ManipulationInertiaStarting -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.ManipulationStartedEventArgs> ManipulationStarted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.GestureRecognizer,Windows.UI.Input.ManipulationStartedEventArgs>, Windows.UI.Input.ManipulationStartedEventArgs>(x => This.ManipulationStarted += x, x => This.ManipulationStarted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.ManipulationUpdatedEventArgs> ManipulationUpdated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.GestureRecognizer,Windows.UI.Input.ManipulationUpdatedEventArgs>, Windows.UI.Input.ManipulationUpdatedEventArgs>(x => This.ManipulationUpdated += x, x => This.ManipulationUpdated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.RightTappedEventArgs> RightTapped {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.GestureRecognizer,Windows.UI.Input.RightTappedEventArgs>, Windows.UI.Input.RightTappedEventArgs>(x => This.RightTapped += x, x => This.RightTapped -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.TappedEventArgs> Tapped {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.GestureRecognizer,Windows.UI.Input.TappedEventArgs>, Windows.UI.Input.TappedEventArgs>(x => This.Tapped += x, x => This.Tapped -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.UI.StartScreen
{
    public static class EventsMixin
    {
        public static SecondaryTileEvents Events(this SecondaryTile This)
        {
            return new SecondaryTileEvents(This);
        }
    }

    public class SecondaryTileEvents

    {
        SecondaryTile This;

        public SecondaryTileEvents(SecondaryTile This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.StartScreen.VisualElementsRequestedEventArgs> VisualElementsRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.StartScreen.SecondaryTile,Windows.UI.StartScreen.VisualElementsRequestedEventArgs>, Windows.UI.StartScreen.VisualElementsRequestedEventArgs>(x => This.VisualElementsRequested += x, x => This.VisualElementsRequested -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.UI.Core
{
    public static class EventsMixin
    {
        public static ICoreWindowEvents Events(this ICoreWindow This)
        {
            return new ICoreWindowEvents(This);
        }
        public static CoreDispatcherEvents Events(this CoreDispatcher This)
        {
            return new CoreDispatcherEvents(This);
        }
        public static CoreWindowEvents Events(this CoreWindow This)
        {
            return new CoreWindowEvents(This);
        }
        public static ICoreAcceleratorKeysEvents Events(this ICoreAcceleratorKeys This)
        {
            return new ICoreAcceleratorKeysEvents(This);
        }
        public static CoreAcceleratorKeysEvents Events(this CoreAcceleratorKeys This)
        {
            return new CoreAcceleratorKeysEvents(This);
        }
        public static ICoreInputSourceBaseEvents Events(this ICoreInputSourceBase This)
        {
            return new ICoreInputSourceBaseEvents(This);
        }
        public static ICorePointerInputSourceEvents Events(this ICorePointerInputSource This)
        {
            return new ICorePointerInputSourceEvents(This);
        }
        public static CoreIndependentInputSourceEvents Events(this CoreIndependentInputSource This)
        {
            return new CoreIndependentInputSourceEvents(This);
        }
        public static CoreComponentInputSourceEvents Events(this CoreComponentInputSource This)
        {
            return new CoreComponentInputSourceEvents(This);
        }
        public static CoreWindowDialogEvents Events(this CoreWindowDialog This)
        {
            return new CoreWindowDialogEvents(This);
        }
        public static CoreWindowFlyoutEvents Events(this CoreWindowFlyout This)
        {
            return new CoreWindowFlyoutEvents(This);
        }
    }

    public class ICoreWindowEvents

    {
        ICoreWindow This;

        public ICoreWindowEvents(ICoreWindow This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Core.WindowActivatedEventArgs> Activated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.WindowActivatedEventArgs>, Windows.UI.Core.WindowActivatedEventArgs>(x => This.Activated += x, x => This.Activated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.AutomationProviderRequestedEventArgs> AutomationProviderRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.AutomationProviderRequestedEventArgs>, Windows.UI.Core.AutomationProviderRequestedEventArgs>(x => This.AutomationProviderRequested += x, x => This.AutomationProviderRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.CharacterReceivedEventArgs> CharacterReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.CharacterReceivedEventArgs>, Windows.UI.Core.CharacterReceivedEventArgs>(x => This.CharacterReceived += x, x => This.CharacterReceived -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.CoreWindowEventArgs> Closed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.CoreWindowEventArgs>, Windows.UI.Core.CoreWindowEventArgs>(x => This.Closed += x, x => This.Closed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.InputEnabledEventArgs> InputEnabled {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.InputEnabledEventArgs>, Windows.UI.Core.InputEnabledEventArgs>(x => This.InputEnabled += x, x => This.InputEnabled -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.KeyEventArgs> KeyDown {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.KeyEventArgs>, Windows.UI.Core.KeyEventArgs>(x => This.KeyDown += x, x => This.KeyDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.KeyEventArgs> KeyUp {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.KeyEventArgs>, Windows.UI.Core.KeyEventArgs>(x => This.KeyUp += x, x => This.KeyUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerCaptureLost {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerCaptureLost += x, x => This.PointerCaptureLost -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerEntered {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerEntered += x, x => This.PointerEntered -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerExited {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerExited += x, x => This.PointerExited -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerMoved {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerMoved += x, x => This.PointerMoved -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerPressed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerPressed += x, x => This.PointerPressed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerReleased {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerReleased += x, x => This.PointerReleased -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerWheelChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerWheelChanged += x, x => This.PointerWheelChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.WindowSizeChangedEventArgs> SizeChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.WindowSizeChangedEventArgs>, Windows.UI.Core.WindowSizeChangedEventArgs>(x => This.SizeChanged += x, x => This.SizeChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.TouchHitTestingEventArgs> TouchHitTesting {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.TouchHitTestingEventArgs>, Windows.UI.Core.TouchHitTestingEventArgs>(x => This.TouchHitTesting += x, x => This.TouchHitTesting -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.VisibilityChangedEventArgs> VisibilityChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.VisibilityChangedEventArgs>, Windows.UI.Core.VisibilityChangedEventArgs>(x => This.VisibilityChanged += x, x => This.VisibilityChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class CoreDispatcherEvents

    {
        CoreDispatcher This;

        public CoreDispatcherEvents(CoreDispatcher This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Core.AcceleratorKeyEventArgs> AcceleratorKeyActivated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreDispatcher,Windows.UI.Core.AcceleratorKeyEventArgs>, Windows.UI.Core.AcceleratorKeyEventArgs>(x => This.AcceleratorKeyActivated += x, x => This.AcceleratorKeyActivated -= x).Select(x => x.EventArgs); }
        }

    }
    public class CoreWindowEvents

    {
        CoreWindow This;

        public CoreWindowEvents(CoreWindow This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Core.WindowActivatedEventArgs> Activated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.WindowActivatedEventArgs>, Windows.UI.Core.WindowActivatedEventArgs>(x => This.Activated += x, x => This.Activated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.AutomationProviderRequestedEventArgs> AutomationProviderRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.AutomationProviderRequestedEventArgs>, Windows.UI.Core.AutomationProviderRequestedEventArgs>(x => This.AutomationProviderRequested += x, x => This.AutomationProviderRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.CharacterReceivedEventArgs> CharacterReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.CharacterReceivedEventArgs>, Windows.UI.Core.CharacterReceivedEventArgs>(x => This.CharacterReceived += x, x => This.CharacterReceived -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.CoreWindowEventArgs> Closed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.CoreWindowEventArgs>, Windows.UI.Core.CoreWindowEventArgs>(x => This.Closed += x, x => This.Closed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.InputEnabledEventArgs> InputEnabled {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.InputEnabledEventArgs>, Windows.UI.Core.InputEnabledEventArgs>(x => This.InputEnabled += x, x => This.InputEnabled -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.KeyEventArgs> KeyDown {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.KeyEventArgs>, Windows.UI.Core.KeyEventArgs>(x => This.KeyDown += x, x => This.KeyDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.KeyEventArgs> KeyUp {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.KeyEventArgs>, Windows.UI.Core.KeyEventArgs>(x => This.KeyUp += x, x => This.KeyUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerCaptureLost {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerCaptureLost += x, x => This.PointerCaptureLost -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerEntered {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerEntered += x, x => This.PointerEntered -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerExited {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerExited += x, x => This.PointerExited -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerMoved {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerMoved += x, x => This.PointerMoved -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerPressed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerPressed += x, x => This.PointerPressed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerReleased {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerReleased += x, x => This.PointerReleased -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerWheelChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerWheelChanged += x, x => This.PointerWheelChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.WindowSizeChangedEventArgs> SizeChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.WindowSizeChangedEventArgs>, Windows.UI.Core.WindowSizeChangedEventArgs>(x => This.SizeChanged += x, x => This.SizeChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.TouchHitTestingEventArgs> TouchHitTesting {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.TouchHitTestingEventArgs>, Windows.UI.Core.TouchHitTestingEventArgs>(x => This.TouchHitTesting += x, x => This.TouchHitTesting -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.VisibilityChangedEventArgs> VisibilityChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.VisibilityChangedEventArgs>, Windows.UI.Core.VisibilityChangedEventArgs>(x => This.VisibilityChanged += x, x => This.VisibilityChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ICoreAcceleratorKeysEvents

    {
        ICoreAcceleratorKeys This;

        public ICoreAcceleratorKeysEvents(ICoreAcceleratorKeys This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Core.AcceleratorKeyEventArgs> AcceleratorKeyActivated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreDispatcher,Windows.UI.Core.AcceleratorKeyEventArgs>, Windows.UI.Core.AcceleratorKeyEventArgs>(x => This.AcceleratorKeyActivated += x, x => This.AcceleratorKeyActivated -= x).Select(x => x.EventArgs); }
        }

    }
    public class CoreAcceleratorKeysEvents

    {
        CoreAcceleratorKeys This;

        public CoreAcceleratorKeysEvents(CoreAcceleratorKeys This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Core.AcceleratorKeyEventArgs> AcceleratorKeyActivated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreDispatcher,Windows.UI.Core.AcceleratorKeyEventArgs>, Windows.UI.Core.AcceleratorKeyEventArgs>(x => This.AcceleratorKeyActivated += x, x => This.AcceleratorKeyActivated -= x).Select(x => x.EventArgs); }
        }

    }
    public class ICoreInputSourceBaseEvents

    {
        ICoreInputSourceBase This;

        public ICoreInputSourceBaseEvents(ICoreInputSourceBase This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Core.InputEnabledEventArgs> InputEnabled {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.InputEnabledEventArgs>, Windows.UI.Core.InputEnabledEventArgs>(x => This.InputEnabled += x, x => This.InputEnabled -= x).Select(x => x.EventArgs); }
        }

    }
    public class ICorePointerInputSourceEvents

    {
        ICorePointerInputSource This;

        public ICorePointerInputSourceEvents(ICorePointerInputSource This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerCaptureLost {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerCaptureLost += x, x => This.PointerCaptureLost -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerEntered {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerEntered += x, x => This.PointerEntered -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerExited {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerExited += x, x => This.PointerExited -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerMoved {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerMoved += x, x => This.PointerMoved -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerPressed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerPressed += x, x => This.PointerPressed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerReleased {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerReleased += x, x => This.PointerReleased -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerWheelChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerWheelChanged += x, x => This.PointerWheelChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class CoreIndependentInputSourceEvents

    {
        CoreIndependentInputSource This;

        public CoreIndependentInputSourceEvents(CoreIndependentInputSource This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Core.InputEnabledEventArgs> InputEnabled {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.InputEnabledEventArgs>, Windows.UI.Core.InputEnabledEventArgs>(x => This.InputEnabled += x, x => This.InputEnabled -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerCaptureLost {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerCaptureLost += x, x => This.PointerCaptureLost -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerEntered {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerEntered += x, x => This.PointerEntered -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerExited {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerExited += x, x => This.PointerExited -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerMoved {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerMoved += x, x => This.PointerMoved -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerPressed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerPressed += x, x => This.PointerPressed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerReleased {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerReleased += x, x => This.PointerReleased -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerWheelChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerWheelChanged += x, x => This.PointerWheelChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class CoreComponentInputSourceEvents

    {
        CoreComponentInputSource This;

        public CoreComponentInputSourceEvents(CoreComponentInputSource This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Core.InputEnabledEventArgs> InputEnabled {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.InputEnabledEventArgs>, Windows.UI.Core.InputEnabledEventArgs>(x => This.InputEnabled += x, x => This.InputEnabled -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerCaptureLost {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerCaptureLost += x, x => This.PointerCaptureLost -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerEntered {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerEntered += x, x => This.PointerEntered -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerExited {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerExited += x, x => This.PointerExited -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerMoved {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerMoved += x, x => This.PointerMoved -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerPressed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerPressed += x, x => This.PointerPressed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerReleased {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerReleased += x, x => This.PointerReleased -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerWheelChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerWheelChanged += x, x => This.PointerWheelChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.CharacterReceivedEventArgs> CharacterReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.CharacterReceivedEventArgs>, Windows.UI.Core.CharacterReceivedEventArgs>(x => This.CharacterReceived += x, x => This.CharacterReceived -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.KeyEventArgs> KeyDown {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.KeyEventArgs>, Windows.UI.Core.KeyEventArgs>(x => This.KeyDown += x, x => This.KeyDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.KeyEventArgs> KeyUp {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.KeyEventArgs>, Windows.UI.Core.KeyEventArgs>(x => This.KeyUp += x, x => This.KeyUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.CoreWindowEventArgs> GotFocus {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.CoreWindowEventArgs>, Windows.UI.Core.CoreWindowEventArgs>(x => This.GotFocus += x, x => This.GotFocus -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.CoreWindowEventArgs> LostFocus {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.CoreWindowEventArgs>, Windows.UI.Core.CoreWindowEventArgs>(x => This.LostFocus += x, x => This.LostFocus -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.TouchHitTestingEventArgs> TouchHitTesting {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.TouchHitTestingEventArgs>, Windows.UI.Core.TouchHitTestingEventArgs>(x => This.TouchHitTesting += x, x => This.TouchHitTesting -= x).Select(x => x.EventArgs); }
        }

    }
    public class CoreWindowDialogEvents

    {
        CoreWindowDialog This;

        public CoreWindowDialogEvents(CoreWindowDialog This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Core.CoreWindowPopupShowingEventArgs> Showing {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.CoreWindowPopupShowingEventArgs>, Windows.UI.Core.CoreWindowPopupShowingEventArgs>(x => This.Showing += x, x => This.Showing -= x).Select(x => x.EventArgs); }
        }

    }
    public class CoreWindowFlyoutEvents

    {
        CoreWindowFlyout This;

        public CoreWindowFlyoutEvents(CoreWindowFlyout This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Core.CoreWindowPopupShowingEventArgs> Showing {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.CoreWindowPopupShowingEventArgs>, Windows.UI.Core.CoreWindowPopupShowingEventArgs>(x => This.Showing += x, x => This.Showing -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.UI.WebUI
{
    public static class EventsMixin
    {
        public static WebUIBackgroundTaskInstanceRuntimeClassEvents Events(this WebUIBackgroundTaskInstanceRuntimeClass This)
        {
            return new WebUIBackgroundTaskInstanceRuntimeClassEvents(This);
        }
    }

    public class WebUIBackgroundTaskInstanceRuntimeClassEvents

    {
        WebUIBackgroundTaskInstanceRuntimeClass This;

        public WebUIBackgroundTaskInstanceRuntimeClassEvents(WebUIBackgroundTaskInstanceRuntimeClass This)

        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.Background.BackgroundTaskCancellationReason> Canceled {
            get { return Observable.FromEventPattern<Windows.ApplicationModel.Background.BackgroundTaskCanceledEventHandler, Windows.ApplicationModel.Background.BackgroundTaskCancellationReason>(x => This.Canceled += x, x => This.Canceled -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.UI.Notifications
{
    public static class EventsMixin
    {
        public static ToastNotificationEvents Events(this ToastNotification This)
        {
            return new ToastNotificationEvents(This);
        }
    }

    public class ToastNotificationEvents

    {
        ToastNotification This;

        public ToastNotificationEvents(ToastNotification This)

        {
            this.This = This;
        }

        public IObservable<object> Activated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Notifications.ToastNotification,object>, object>(x => This.Activated += x, x => This.Activated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Notifications.ToastDismissedEventArgs> Dismissed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Notifications.ToastNotification,Windows.UI.Notifications.ToastDismissedEventArgs>, Windows.UI.Notifications.ToastDismissedEventArgs>(x => This.Dismissed += x, x => This.Dismissed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Notifications.ToastFailedEventArgs> Failed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Notifications.ToastNotification,Windows.UI.Notifications.ToastFailedEventArgs>, Windows.UI.Notifications.ToastFailedEventArgs>(x => This.Failed += x, x => This.Failed -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.UI.Xaml.Controls
{
    public static class EventsMixin
    {
        public static GroupStyleEvents Events(this GroupStyle This)
        {
            return new GroupStyleEvents(This);
        }
        public static ItemCollectionEvents Events(this ItemCollection This)
        {
            return new ItemCollectionEvents(This);
        }
        public static ItemContainerGeneratorEvents Events(this ItemContainerGenerator This)
        {
            return new ItemContainerGeneratorEvents(This);
        }
        public static ImageEvents Events(this Image This)
        {
            return new ImageEvents(This);
        }
        public static ItemsPresenterEvents Events(this ItemsPresenter This)
        {
            return new ItemsPresenterEvents(This);
        }
        public static MediaElementEvents Events(this MediaElement This)
        {
            return new MediaElementEvents(This);
        }
        public static RichTextBlockEvents Events(this RichTextBlock This)
        {
            return new RichTextBlockEvents(This);
        }
        public static StackPanelEvents Events(this StackPanel This)
        {
            return new StackPanelEvents(This);
        }
        public static TextBlockEvents Events(this TextBlock This)
        {
            return new TextBlockEvents(This);
        }
        public static VirtualizingStackPanelEvents Events(this VirtualizingStackPanel This)
        {
            return new VirtualizingStackPanelEvents(This);
        }
        public static SwapChainPanelEvents Events(this SwapChainPanel This)
        {
            return new SwapChainPanelEvents(This);
        }
        public static WebViewEvents Events(this WebView This)
        {
            return new WebViewEvents(This);
        }
        public static ControlEvents Events(this Control This)
        {
            return new ControlEvents(This);
        }
        public static DatePickerEvents Events(this DatePicker This)
        {
            return new DatePickerEvents(This);
        }
        public static SemanticZoomEvents Events(this SemanticZoom This)
        {
            return new SemanticZoomEvents(This);
        }
        public static PasswordBoxEvents Events(this PasswordBox This)
        {
            return new PasswordBoxEvents(This);
        }
        public static RichEditBoxEvents Events(this RichEditBox This)
        {
            return new RichEditBoxEvents(This);
        }
        public static ScrollViewerEvents Events(this ScrollViewer This)
        {
            return new ScrollViewerEvents(This);
        }
        public static SettingsFlyoutEvents Events(this SettingsFlyout This)
        {
            return new SettingsFlyoutEvents(This);
        }
        public static TextBoxEvents Events(this TextBox This)
        {
            return new TextBoxEvents(This);
        }
        public static ToggleSwitchEvents Events(this ToggleSwitch This)
        {
            return new ToggleSwitchEvents(This);
        }
        public static ToolTipEvents Events(this ToolTip This)
        {
            return new ToolTipEvents(This);
        }
        public static ComboBoxEvents Events(this ComboBox This)
        {
            return new ComboBoxEvents(This);
        }
        public static ListViewBaseEvents Events(this ListViewBase This)
        {
            return new ListViewBaseEvents(This);
        }
        public static AppBarEvents Events(this AppBar This)
        {
            return new AppBarEvents(This);
        }
        public static FrameEvents Events(this Frame This)
        {
            return new FrameEvents(This);
        }
        public static HubEvents Events(this Hub This)
        {
            return new HubEvents(This);
        }
        public static MenuFlyoutItemEvents Events(this MenuFlyoutItem This)
        {
            return new MenuFlyoutItemEvents(This);
        }
        public static SearchBoxEvents Events(this SearchBox This)
        {
            return new SearchBoxEvents(This);
        }
        public static TimePickerEvents Events(this TimePicker This)
        {
            return new TimePickerEvents(This);
        }
    }

    public class GroupStyleEvents

    {
        GroupStyle This;

        public GroupStyleEvents(GroupStyle This)

        {
            this.This = This;
        }

        public IObservable<global::System.ComponentModel.PropertyChangedEventArgs> PropertyChanged {
            get { return Observable.FromEventPattern<global::System.ComponentModel.PropertyChangedEventHandler, global::System.ComponentModel.PropertyChangedEventArgs>(x => This.PropertyChanged += x, x => This.PropertyChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ItemCollectionEvents

    {
        ItemCollection This;

        public ItemCollectionEvents(ItemCollection This)

        {
            this.This = This;
        }

        public IObservable<Windows.Foundation.Collections.IVectorChangedEventArgs> VectorChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.Collections.VectorChangedEventHandler<object>, Windows.Foundation.Collections.IVectorChangedEventArgs>(x => This.VectorChanged += x, x => This.VectorChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ItemContainerGeneratorEvents

    {
        ItemContainerGenerator This;

        public ItemContainerGeneratorEvents(ItemContainerGenerator This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.Primitives.ItemsChangedEventArgs> ItemsChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.Primitives.ItemsChangedEventHandler, Windows.UI.Xaml.Controls.Primitives.ItemsChangedEventArgs>(x => This.ItemsChanged += x, x => This.ItemsChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ImageEvents

    {
        Image This;

        public ImageEvents(Image This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.ExceptionRoutedEventArgs> ImageFailed {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.ExceptionRoutedEventHandler, Windows.UI.Xaml.ExceptionRoutedEventArgs>(x => This.ImageFailed += x, x => This.ImageFailed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> ImageOpened {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.ImageOpened += x, x => This.ImageOpened -= x).Select(x => x.EventArgs); }
        }

    }
    public class ItemsPresenterEvents

    {
        ItemsPresenter This;

        public ItemsPresenterEvents(ItemsPresenter This)

        {
            this.This = This;
        }

        public IObservable<object> HorizontalSnapPointsChanged {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.HorizontalSnapPointsChanged += x, x => This.HorizontalSnapPointsChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> VerticalSnapPointsChanged {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.VerticalSnapPointsChanged += x, x => This.VerticalSnapPointsChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class MediaElementEvents

    {
        MediaElement This;

        public MediaElementEvents(MediaElement This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> BufferingProgressChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.BufferingProgressChanged += x, x => This.BufferingProgressChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> CurrentStateChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.CurrentStateChanged += x, x => This.CurrentStateChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> DownloadProgressChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.DownloadProgressChanged += x, x => This.DownloadProgressChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Media.TimelineMarkerRoutedEventArgs> MarkerReached {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Media.TimelineMarkerRoutedEventHandler, Windows.UI.Xaml.Media.TimelineMarkerRoutedEventArgs>(x => This.MarkerReached += x, x => This.MarkerReached -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> MediaEnded {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.MediaEnded += x, x => This.MediaEnded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.ExceptionRoutedEventArgs> MediaFailed {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.ExceptionRoutedEventHandler, Windows.UI.Xaml.ExceptionRoutedEventArgs>(x => This.MediaFailed += x, x => This.MediaFailed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> MediaOpened {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.MediaOpened += x, x => This.MediaOpened -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Media.RateChangedRoutedEventArgs> RateChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Media.RateChangedRoutedEventHandler, Windows.UI.Xaml.Media.RateChangedRoutedEventArgs>(x => This.RateChanged += x, x => This.RateChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> SeekCompleted {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.SeekCompleted += x, x => This.SeekCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> VolumeChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.VolumeChanged += x, x => This.VolumeChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class RichTextBlockEvents

    {
        RichTextBlock This;

        public RichTextBlockEvents(RichTextBlock This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.ContextMenuEventArgs> ContextMenuOpening {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.ContextMenuOpeningEventHandler, Windows.UI.Xaml.Controls.ContextMenuEventArgs>(x => This.ContextMenuOpening += x, x => This.ContextMenuOpening -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> SelectionChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.SelectionChanged += x, x => This.SelectionChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class StackPanelEvents

    {
        StackPanel This;

        public StackPanelEvents(StackPanel This)

        {
            this.This = This;
        }

        public IObservable<object> HorizontalSnapPointsChanged {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.HorizontalSnapPointsChanged += x, x => This.HorizontalSnapPointsChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> VerticalSnapPointsChanged {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.VerticalSnapPointsChanged += x, x => This.VerticalSnapPointsChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class TextBlockEvents

    {
        TextBlock This;

        public TextBlockEvents(TextBlock This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.ContextMenuEventArgs> ContextMenuOpening {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.ContextMenuOpeningEventHandler, Windows.UI.Xaml.Controls.ContextMenuEventArgs>(x => This.ContextMenuOpening += x, x => This.ContextMenuOpening -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> SelectionChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.SelectionChanged += x, x => This.SelectionChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class VirtualizingStackPanelEvents

    {
        VirtualizingStackPanel This;

        public VirtualizingStackPanelEvents(VirtualizingStackPanel This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.CleanUpVirtualizedItemEventArgs> CleanUpVirtualizedItemEvent {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.CleanUpVirtualizedItemEventHandler, Windows.UI.Xaml.Controls.CleanUpVirtualizedItemEventArgs>(x => This.CleanUpVirtualizedItemEvent += x, x => This.CleanUpVirtualizedItemEvent -= x).Select(x => x.EventArgs); }
        }

    }
    public class SwapChainPanelEvents

    {
        SwapChainPanel This;

        public SwapChainPanelEvents(SwapChainPanel This)

        {
            this.This = This;
        }

        public IObservable<object> CompositionScaleChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.SwapChainPanel,object>, object>(x => This.CompositionScaleChanged += x, x => This.CompositionScaleChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class WebViewEvents

    {
        WebView This;

        public WebViewEvents(WebView This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Navigation.NavigationEventArgs> LoadCompleted {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Navigation.LoadCompletedEventHandler, Windows.UI.Xaml.Navigation.NavigationEventArgs>(x => This.LoadCompleted += x, x => This.LoadCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.WebViewNavigationFailedEventArgs> NavigationFailed {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.WebViewNavigationFailedEventHandler, Windows.UI.Xaml.Controls.WebViewNavigationFailedEventArgs>(x => This.NavigationFailed += x, x => This.NavigationFailed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.NotifyEventArgs> ScriptNotify {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.NotifyEventHandler, Windows.UI.Xaml.Controls.NotifyEventArgs>(x => This.ScriptNotify += x, x => This.ScriptNotify -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.WebViewContentLoadingEventArgs> ContentLoading {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.WebView,Windows.UI.Xaml.Controls.WebViewContentLoadingEventArgs>, Windows.UI.Xaml.Controls.WebViewContentLoadingEventArgs>(x => This.ContentLoading += x, x => This.ContentLoading -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.WebViewDOMContentLoadedEventArgs> DOMContentLoaded {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.WebView,Windows.UI.Xaml.Controls.WebViewDOMContentLoadedEventArgs>, Windows.UI.Xaml.Controls.WebViewDOMContentLoadedEventArgs>(x => This.DOMContentLoaded += x, x => This.DOMContentLoaded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.WebViewContentLoadingEventArgs> FrameContentLoading {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.WebView,Windows.UI.Xaml.Controls.WebViewContentLoadingEventArgs>, Windows.UI.Xaml.Controls.WebViewContentLoadingEventArgs>(x => This.FrameContentLoading += x, x => This.FrameContentLoading -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.WebViewDOMContentLoadedEventArgs> FrameDOMContentLoaded {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.WebView,Windows.UI.Xaml.Controls.WebViewDOMContentLoadedEventArgs>, Windows.UI.Xaml.Controls.WebViewDOMContentLoadedEventArgs>(x => This.FrameDOMContentLoaded += x, x => This.FrameDOMContentLoaded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.WebViewNavigationCompletedEventArgs> FrameNavigationCompleted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.WebView,Windows.UI.Xaml.Controls.WebViewNavigationCompletedEventArgs>, Windows.UI.Xaml.Controls.WebViewNavigationCompletedEventArgs>(x => This.FrameNavigationCompleted += x, x => This.FrameNavigationCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.WebViewNavigationStartingEventArgs> FrameNavigationStarting {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.WebView,Windows.UI.Xaml.Controls.WebViewNavigationStartingEventArgs>, Windows.UI.Xaml.Controls.WebViewNavigationStartingEventArgs>(x => This.FrameNavigationStarting += x, x => This.FrameNavigationStarting -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.WebViewLongRunningScriptDetectedEventArgs> LongRunningScriptDetected {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.WebView,Windows.UI.Xaml.Controls.WebViewLongRunningScriptDetectedEventArgs>, Windows.UI.Xaml.Controls.WebViewLongRunningScriptDetectedEventArgs>(x => This.LongRunningScriptDetected += x, x => This.LongRunningScriptDetected -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.WebViewNavigationCompletedEventArgs> NavigationCompleted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.WebView,Windows.UI.Xaml.Controls.WebViewNavigationCompletedEventArgs>, Windows.UI.Xaml.Controls.WebViewNavigationCompletedEventArgs>(x => This.NavigationCompleted += x, x => This.NavigationCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.WebViewNavigationStartingEventArgs> NavigationStarting {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.WebView,Windows.UI.Xaml.Controls.WebViewNavigationStartingEventArgs>, Windows.UI.Xaml.Controls.WebViewNavigationStartingEventArgs>(x => This.NavigationStarting += x, x => This.NavigationStarting -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> UnsafeContentWarningDisplaying {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.WebView,object>, object>(x => This.UnsafeContentWarningDisplaying += x, x => This.UnsafeContentWarningDisplaying -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.WebViewUnviewableContentIdentifiedEventArgs> UnviewableContentIdentified {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.WebView,Windows.UI.Xaml.Controls.WebViewUnviewableContentIdentifiedEventArgs>, Windows.UI.Xaml.Controls.WebViewUnviewableContentIdentifiedEventArgs>(x => This.UnviewableContentIdentified += x, x => This.UnviewableContentIdentified -= x).Select(x => x.EventArgs); }
        }

    }
    public class ControlEvents

    {
        Control This;

        public ControlEvents(Control This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.DependencyPropertyChangedEventArgs> IsEnabledChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.DependencyPropertyChangedEventHandler, Windows.UI.Xaml.DependencyPropertyChangedEventArgs>(x => This.IsEnabledChanged += x, x => This.IsEnabledChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class DatePickerEvents

    {
        DatePicker This;

        public DatePickerEvents(DatePicker This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.DatePickerValueChangedEventArgs> DateChanged {
            get { return Observable.FromEventPattern<EventHandler<Windows.UI.Xaml.Controls.DatePickerValueChangedEventArgs>, Windows.UI.Xaml.Controls.DatePickerValueChangedEventArgs>(x => This.DateChanged += x, x => This.DateChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class SemanticZoomEvents

    {
        SemanticZoom This;

        public SemanticZoomEvents(SemanticZoom This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.SemanticZoomViewChangedEventArgs> ViewChangeCompleted {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.SemanticZoomViewChangedEventHandler, Windows.UI.Xaml.Controls.SemanticZoomViewChangedEventArgs>(x => This.ViewChangeCompleted += x, x => This.ViewChangeCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.SemanticZoomViewChangedEventArgs> ViewChangeStarted {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.SemanticZoomViewChangedEventHandler, Windows.UI.Xaml.Controls.SemanticZoomViewChangedEventArgs>(x => This.ViewChangeStarted += x, x => This.ViewChangeStarted -= x).Select(x => x.EventArgs); }
        }

    }
    public class PasswordBoxEvents

    {
        PasswordBox This;

        public PasswordBoxEvents(PasswordBox This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.ContextMenuEventArgs> ContextMenuOpening {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.ContextMenuOpeningEventHandler, Windows.UI.Xaml.Controls.ContextMenuEventArgs>(x => This.ContextMenuOpening += x, x => This.ContextMenuOpening -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> PasswordChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.PasswordChanged += x, x => This.PasswordChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.TextControlPasteEventArgs> Paste {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.TextControlPasteEventHandler, Windows.UI.Xaml.Controls.TextControlPasteEventArgs>(x => This.Paste += x, x => This.Paste -= x).Select(x => x.EventArgs); }
        }

    }
    public class RichEditBoxEvents

    {
        RichEditBox This;

        public RichEditBoxEvents(RichEditBox This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.ContextMenuEventArgs> ContextMenuOpening {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.ContextMenuOpeningEventHandler, Windows.UI.Xaml.Controls.ContextMenuEventArgs>(x => This.ContextMenuOpening += x, x => This.ContextMenuOpening -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> SelectionChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.SelectionChanged += x, x => This.SelectionChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> TextChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.TextChanged += x, x => This.TextChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.TextControlPasteEventArgs> Paste {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.TextControlPasteEventHandler, Windows.UI.Xaml.Controls.TextControlPasteEventArgs>(x => This.Paste += x, x => This.Paste -= x).Select(x => x.EventArgs); }
        }

    }
    public class ScrollViewerEvents

    {
        ScrollViewer This;

        public ScrollViewerEvents(ScrollViewer This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.ScrollViewerViewChangedEventArgs> ViewChanged {
            get { return Observable.FromEventPattern<EventHandler<Windows.UI.Xaml.Controls.ScrollViewerViewChangedEventArgs>, Windows.UI.Xaml.Controls.ScrollViewerViewChangedEventArgs>(x => This.ViewChanged += x, x => This.ViewChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.ScrollViewerViewChangingEventArgs> ViewChanging {
            get { return Observable.FromEventPattern<EventHandler<Windows.UI.Xaml.Controls.ScrollViewerViewChangingEventArgs>, Windows.UI.Xaml.Controls.ScrollViewerViewChangingEventArgs>(x => This.ViewChanging += x, x => This.ViewChanging -= x).Select(x => x.EventArgs); }
        }

    }
    public class SettingsFlyoutEvents

    {
        SettingsFlyout This;

        public SettingsFlyoutEvents(SettingsFlyout This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.BackClickEventArgs> BackClick {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.BackClickEventHandler, Windows.UI.Xaml.Controls.BackClickEventArgs>(x => This.BackClick += x, x => This.BackClick -= x).Select(x => x.EventArgs); }
        }

    }
    public class TextBoxEvents

    {
        TextBox This;

        public TextBoxEvents(TextBox This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.ContextMenuEventArgs> ContextMenuOpening {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.ContextMenuOpeningEventHandler, Windows.UI.Xaml.Controls.ContextMenuEventArgs>(x => This.ContextMenuOpening += x, x => This.ContextMenuOpening -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> SelectionChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.SelectionChanged += x, x => This.SelectionChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.TextChangedEventArgs> TextChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.TextChangedEventHandler, Windows.UI.Xaml.Controls.TextChangedEventArgs>(x => This.TextChanged += x, x => This.TextChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.TextControlPasteEventArgs> Paste {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.TextControlPasteEventHandler, Windows.UI.Xaml.Controls.TextControlPasteEventArgs>(x => This.Paste += x, x => This.Paste -= x).Select(x => x.EventArgs); }
        }

    }
    public class ToggleSwitchEvents

    {
        ToggleSwitch This;

        public ToggleSwitchEvents(ToggleSwitch This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> Toggled {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.Toggled += x, x => This.Toggled -= x).Select(x => x.EventArgs); }
        }

    }
    public class ToolTipEvents

    {
        ToolTip This;

        public ToolTipEvents(ToolTip This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> Closed {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.Closed += x, x => This.Closed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> Opened {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.Opened += x, x => This.Opened -= x).Select(x => x.EventArgs); }
        }

    }
    public class ComboBoxEvents

    {
        ComboBox This;

        public ComboBoxEvents(ComboBox This)

        {
            this.This = This;
        }

        public IObservable<object> DropDownClosed {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.DropDownClosed += x, x => This.DropDownClosed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> DropDownOpened {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.DropDownOpened += x, x => This.DropDownOpened -= x).Select(x => x.EventArgs); }
        }

    }
    public class ListViewBaseEvents

    {
        ListViewBase This;

        public ListViewBaseEvents(ListViewBase This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.DragItemsStartingEventArgs> DragItemsStarting {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.DragItemsStartingEventHandler, Windows.UI.Xaml.Controls.DragItemsStartingEventArgs>(x => This.DragItemsStarting += x, x => This.DragItemsStarting -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.ItemClickEventArgs> ItemClick {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.ItemClickEventHandler, Windows.UI.Xaml.Controls.ItemClickEventArgs>(x => This.ItemClick += x, x => This.ItemClick -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs> ContainerContentChanging {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.ListViewBase,Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs>, Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs>(x => This.ContainerContentChanging += x, x => This.ContainerContentChanging -= x).Select(x => x.EventArgs); }
        }

    }
    public class AppBarEvents

    {
        AppBar This;

        public AppBarEvents(AppBar This)

        {
            this.This = This;
        }

        public IObservable<object> Closed {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.Closed += x, x => This.Closed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> Opened {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.Opened += x, x => This.Opened -= x).Select(x => x.EventArgs); }
        }

    }
    public class FrameEvents

    {
        Frame This;

        public FrameEvents(Frame This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Navigation.NavigationEventArgs> Navigated {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Navigation.NavigatedEventHandler, Windows.UI.Xaml.Navigation.NavigationEventArgs>(x => This.Navigated += x, x => This.Navigated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Navigation.NavigatingCancelEventArgs> Navigating {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Navigation.NavigatingCancelEventHandler, Windows.UI.Xaml.Navigation.NavigatingCancelEventArgs>(x => This.Navigating += x, x => This.Navigating -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Navigation.NavigationFailedEventArgs> NavigationFailed {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Navigation.NavigationFailedEventHandler, Windows.UI.Xaml.Navigation.NavigationFailedEventArgs>(x => This.NavigationFailed += x, x => This.NavigationFailed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Navigation.NavigationEventArgs> NavigationStopped {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Navigation.NavigationStoppedEventHandler, Windows.UI.Xaml.Navigation.NavigationEventArgs>(x => This.NavigationStopped += x, x => This.NavigationStopped -= x).Select(x => x.EventArgs); }
        }

    }
    public class HubEvents

    {
        Hub This;

        public HubEvents(Hub This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.HubSectionHeaderClickEventArgs> SectionHeaderClick {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.HubSectionHeaderClickEventHandler, Windows.UI.Xaml.Controls.HubSectionHeaderClickEventArgs>(x => This.SectionHeaderClick += x, x => This.SectionHeaderClick -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.SectionsInViewChangedEventArgs> SectionsInViewChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.SectionsInViewChangedEventHandler, Windows.UI.Xaml.Controls.SectionsInViewChangedEventArgs>(x => This.SectionsInViewChanged += x, x => This.SectionsInViewChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class MenuFlyoutItemEvents

    {
        MenuFlyoutItem This;

        public MenuFlyoutItemEvents(MenuFlyoutItem This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> Click {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.Click += x, x => This.Click -= x).Select(x => x.EventArgs); }
        }

    }
    public class SearchBoxEvents

    {
        SearchBox This;

        public SearchBoxEvents(SearchBox This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> PrepareForFocusOnKeyboardInput {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.SearchBox,Windows.UI.Xaml.RoutedEventArgs>, Windows.UI.Xaml.RoutedEventArgs>(x => This.PrepareForFocusOnKeyboardInput += x, x => This.PrepareForFocusOnKeyboardInput -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.SearchBoxQueryChangedEventArgs> QueryChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.SearchBox,Windows.UI.Xaml.Controls.SearchBoxQueryChangedEventArgs>, Windows.UI.Xaml.Controls.SearchBoxQueryChangedEventArgs>(x => This.QueryChanged += x, x => This.QueryChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.SearchBoxQuerySubmittedEventArgs> QuerySubmitted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.SearchBox,Windows.UI.Xaml.Controls.SearchBoxQuerySubmittedEventArgs>, Windows.UI.Xaml.Controls.SearchBoxQuerySubmittedEventArgs>(x => This.QuerySubmitted += x, x => This.QuerySubmitted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.SearchBoxResultSuggestionChosenEventArgs> ResultSuggestionChosen {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.SearchBox,Windows.UI.Xaml.Controls.SearchBoxResultSuggestionChosenEventArgs>, Windows.UI.Xaml.Controls.SearchBoxResultSuggestionChosenEventArgs>(x => This.ResultSuggestionChosen += x, x => This.ResultSuggestionChosen -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.SearchBoxSuggestionsRequestedEventArgs> SuggestionsRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.SearchBox,Windows.UI.Xaml.Controls.SearchBoxSuggestionsRequestedEventArgs>, Windows.UI.Xaml.Controls.SearchBoxSuggestionsRequestedEventArgs>(x => This.SuggestionsRequested += x, x => This.SuggestionsRequested -= x).Select(x => x.EventArgs); }
        }

    }
    public class TimePickerEvents

    {
        TimePicker This;

        public TimePickerEvents(TimePicker This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.TimePickerValueChangedEventArgs> TimeChanged {
            get { return Observable.FromEventPattern<EventHandler<Windows.UI.Xaml.Controls.TimePickerValueChangedEventArgs>, Windows.UI.Xaml.Controls.TimePickerValueChangedEventArgs>(x => This.TimeChanged += x, x => This.TimeChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.UI.Xaml.Controls.Primitives
{
    public static class EventsMixin
    {
        public static IScrollSnapPointsInfoEvents Events(this IScrollSnapPointsInfo This)
        {
            return new IScrollSnapPointsInfoEvents(This);
        }
        public static FlyoutBaseEvents Events(this FlyoutBase This)
        {
            return new FlyoutBaseEvents(This);
        }
        public static CarouselPanelEvents Events(this CarouselPanel This)
        {
            return new CarouselPanelEvents(This);
        }
        public static OrientedVirtualizingPanelEvents Events(this OrientedVirtualizingPanel This)
        {
            return new OrientedVirtualizingPanelEvents(This);
        }
        public static PopupEvents Events(this Popup This)
        {
            return new PopupEvents(This);
        }
        public static ButtonBaseEvents Events(this ButtonBase This)
        {
            return new ButtonBaseEvents(This);
        }
        public static RangeBaseEvents Events(this RangeBase This)
        {
            return new RangeBaseEvents(This);
        }
        public static ScrollBarEvents Events(this ScrollBar This)
        {
            return new ScrollBarEvents(This);
        }
        public static SelectorEvents Events(this Selector This)
        {
            return new SelectorEvents(This);
        }
        public static ThumbEvents Events(this Thumb This)
        {
            return new ThumbEvents(This);
        }
        public static ToggleButtonEvents Events(this ToggleButton This)
        {
            return new ToggleButtonEvents(This);
        }
    }

    public class IScrollSnapPointsInfoEvents

    {
        IScrollSnapPointsInfo This;

        public IScrollSnapPointsInfoEvents(IScrollSnapPointsInfo This)

        {
            this.This = This;
        }

        public IObservable<object> HorizontalSnapPointsChanged {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.HorizontalSnapPointsChanged += x, x => This.HorizontalSnapPointsChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> VerticalSnapPointsChanged {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.VerticalSnapPointsChanged += x, x => This.VerticalSnapPointsChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class FlyoutBaseEvents

    {
        FlyoutBase This;

        public FlyoutBaseEvents(FlyoutBase This)

        {
            this.This = This;
        }

        public IObservable<object> Closed {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.Closed += x, x => This.Closed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> Opened {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.Opened += x, x => This.Opened -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> Opening {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.Opening += x, x => This.Opening -= x).Select(x => x.EventArgs); }
        }

    }
    public class CarouselPanelEvents

    {
        CarouselPanel This;

        public CarouselPanelEvents(CarouselPanel This)

        {
            this.This = This;
        }

        public IObservable<object> HorizontalSnapPointsChanged {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.HorizontalSnapPointsChanged += x, x => This.HorizontalSnapPointsChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> VerticalSnapPointsChanged {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.VerticalSnapPointsChanged += x, x => This.VerticalSnapPointsChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class OrientedVirtualizingPanelEvents

    {
        OrientedVirtualizingPanel This;

        public OrientedVirtualizingPanelEvents(OrientedVirtualizingPanel This)

        {
            this.This = This;
        }

        public IObservable<object> HorizontalSnapPointsChanged {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.HorizontalSnapPointsChanged += x, x => This.HorizontalSnapPointsChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> VerticalSnapPointsChanged {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.VerticalSnapPointsChanged += x, x => This.VerticalSnapPointsChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class PopupEvents

    {
        Popup This;

        public PopupEvents(Popup This)

        {
            this.This = This;
        }

        public IObservable<object> Closed {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.Closed += x, x => This.Closed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> Opened {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.Opened += x, x => This.Opened -= x).Select(x => x.EventArgs); }
        }

    }
    public class ButtonBaseEvents

    {
        ButtonBase This;

        public ButtonBaseEvents(ButtonBase This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> Click {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.Click += x, x => This.Click -= x).Select(x => x.EventArgs); }
        }

    }
    public class RangeBaseEvents

    {
        RangeBase This;

        public RangeBaseEvents(RangeBase This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.Primitives.RangeBaseValueChangedEventArgs> ValueChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.Primitives.RangeBaseValueChangedEventHandler, Windows.UI.Xaml.Controls.Primitives.RangeBaseValueChangedEventArgs>(x => This.ValueChanged += x, x => This.ValueChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ScrollBarEvents

    {
        ScrollBar This;

        public ScrollBarEvents(ScrollBar This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.Primitives.ScrollEventArgs> Scroll {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.Primitives.ScrollEventHandler, Windows.UI.Xaml.Controls.Primitives.ScrollEventArgs>(x => This.Scroll += x, x => This.Scroll -= x).Select(x => x.EventArgs); }
        }

    }
    public class SelectorEvents

    {
        Selector This;

        public SelectorEvents(Selector This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.SelectionChangedEventArgs> SelectionChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.SelectionChangedEventHandler, Windows.UI.Xaml.Controls.SelectionChangedEventArgs>(x => This.SelectionChanged += x, x => This.SelectionChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ThumbEvents

    {
        Thumb This;

        public ThumbEvents(Thumb This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.Primitives.DragCompletedEventArgs> DragCompleted {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.Primitives.DragCompletedEventHandler, Windows.UI.Xaml.Controls.Primitives.DragCompletedEventArgs>(x => This.DragCompleted += x, x => This.DragCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.Primitives.DragDeltaEventArgs> DragDelta {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.Primitives.DragDeltaEventHandler, Windows.UI.Xaml.Controls.Primitives.DragDeltaEventArgs>(x => This.DragDelta += x, x => This.DragDelta -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.Primitives.DragStartedEventArgs> DragStarted {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.Primitives.DragStartedEventHandler, Windows.UI.Xaml.Controls.Primitives.DragStartedEventArgs>(x => This.DragStarted += x, x => This.DragStarted -= x).Select(x => x.EventArgs); }
        }

    }
    public class ToggleButtonEvents

    {
        ToggleButton This;

        public ToggleButtonEvents(ToggleButton This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> Checked {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.Checked += x, x => This.Checked -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> Indeterminate {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.Indeterminate += x, x => This.Indeterminate -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> Unchecked {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.Unchecked += x, x => This.Unchecked -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.UI.Xaml.Printing
{
    public static class EventsMixin
    {
        public static PrintDocumentEvents Events(this PrintDocument This)
        {
            return new PrintDocumentEvents(This);
        }
    }

    public class PrintDocumentEvents

    {
        PrintDocument This;

        public PrintDocumentEvents(PrintDocument This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Printing.AddPagesEventArgs> AddPages {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Printing.AddPagesEventHandler, Windows.UI.Xaml.Printing.AddPagesEventArgs>(x => This.AddPages += x, x => This.AddPages -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Printing.GetPreviewPageEventArgs> GetPreviewPage {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Printing.GetPreviewPageEventHandler, Windows.UI.Xaml.Printing.GetPreviewPageEventArgs>(x => This.GetPreviewPage += x, x => This.GetPreviewPage -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Printing.PaginateEventArgs> Paginate {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Printing.PaginateEventHandler, Windows.UI.Xaml.Printing.PaginateEventArgs>(x => This.Paginate += x, x => This.Paginate -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.UI.Xaml.Documents
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

        public IObservable<Windows.UI.Xaml.Documents.HyperlinkClickEventArgs> Click {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Documents.Hyperlink,Windows.UI.Xaml.Documents.HyperlinkClickEventArgs>, Windows.UI.Xaml.Documents.HyperlinkClickEventArgs>(x => This.Click += x, x => This.Click -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.UI.Xaml
{
    public static class EventsMixin
    {
        public static DebugSettingsEvents Events(this DebugSettings This)
        {
            return new DebugSettingsEvents(This);
        }
        public static DependencyObjectCollectionEvents Events(this DependencyObjectCollection This)
        {
            return new DependencyObjectCollectionEvents(This);
        }
        public static DispatcherTimerEvents Events(this DispatcherTimer This)
        {
            return new DispatcherTimerEvents(This);
        }
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
        public static WindowEvents Events(this Window This)
        {
            return new WindowEvents(This);
        }
    }

    public class DebugSettingsEvents

    {
        DebugSettings This;

        public DebugSettingsEvents(DebugSettings This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.BindingFailedEventArgs> BindingFailed {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.BindingFailedEventHandler, Windows.UI.Xaml.BindingFailedEventArgs>(x => This.BindingFailed += x, x => This.BindingFailed -= x).Select(x => x.EventArgs); }
        }

    }
    public class DependencyObjectCollectionEvents

    {
        DependencyObjectCollection This;

        public DependencyObjectCollectionEvents(DependencyObjectCollection This)

        {
            this.This = This;
        }

        public IObservable<Windows.Foundation.Collections.IVectorChangedEventArgs> VectorChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.Collections.VectorChangedEventHandler<Windows.UI.Xaml.DependencyObject>, Windows.Foundation.Collections.IVectorChangedEventArgs>(x => This.VectorChanged += x, x => This.VectorChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class DispatcherTimerEvents

    {
        DispatcherTimer This;

        public DispatcherTimerEvents(DispatcherTimer This)

        {
            this.This = This;
        }

        public IObservable<object> Tick {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.Tick += x, x => This.Tick -= x).Select(x => x.EventArgs); }
        }

    }
    public class ApplicationEvents

    {
        Application This;

        public ApplicationEvents(Application This)

        {
            this.This = This;
        }

        public IObservable<object> Resuming {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.Resuming += x, x => This.Resuming -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.SuspendingEventArgs> Suspending {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.SuspendingEventHandler, Windows.ApplicationModel.SuspendingEventArgs>(x => This.Suspending += x, x => This.Suspending -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.UnhandledExceptionEventArgs> UnhandledException {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.UnhandledExceptionEventHandler, Windows.UI.Xaml.UnhandledExceptionEventArgs>(x => This.UnhandledException += x, x => This.UnhandledException -= x).Select(x => x.EventArgs); }
        }

    }
    public class UIElementEvents

    {
        UIElement This;

        public UIElementEvents(UIElement This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Input.DoubleTappedRoutedEventArgs> DoubleTapped {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Input.DoubleTappedEventHandler, Windows.UI.Xaml.Input.DoubleTappedRoutedEventArgs>(x => This.DoubleTapped += x, x => This.DoubleTapped -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.DragEventArgs> DragEnter {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.DragEventHandler, Windows.UI.Xaml.DragEventArgs>(x => This.DragEnter += x, x => This.DragEnter -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.DragEventArgs> DragLeave {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.DragEventHandler, Windows.UI.Xaml.DragEventArgs>(x => This.DragLeave += x, x => This.DragLeave -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.DragEventArgs> DragOver {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.DragEventHandler, Windows.UI.Xaml.DragEventArgs>(x => This.DragOver += x, x => This.DragOver -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.DragEventArgs> Drop {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.DragEventHandler, Windows.UI.Xaml.DragEventArgs>(x => This.Drop += x, x => This.Drop -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> GotFocus {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.GotFocus += x, x => This.GotFocus -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Input.HoldingRoutedEventArgs> Holding {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Input.HoldingEventHandler, Windows.UI.Xaml.Input.HoldingRoutedEventArgs>(x => This.Holding += x, x => This.Holding -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Input.KeyRoutedEventArgs> KeyDown {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Input.KeyEventHandler, Windows.UI.Xaml.Input.KeyRoutedEventArgs>(x => This.KeyDown += x, x => This.KeyDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Input.KeyRoutedEventArgs> KeyUp {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Input.KeyEventHandler, Windows.UI.Xaml.Input.KeyRoutedEventArgs>(x => This.KeyUp += x, x => This.KeyUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> LostFocus {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.LostFocus += x, x => This.LostFocus -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Input.ManipulationCompletedRoutedEventArgs> ManipulationCompleted {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Input.ManipulationCompletedEventHandler, Windows.UI.Xaml.Input.ManipulationCompletedRoutedEventArgs>(x => This.ManipulationCompleted += x, x => This.ManipulationCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Input.ManipulationDeltaRoutedEventArgs> ManipulationDelta {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Input.ManipulationDeltaEventHandler, Windows.UI.Xaml.Input.ManipulationDeltaRoutedEventArgs>(x => This.ManipulationDelta += x, x => This.ManipulationDelta -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Input.ManipulationInertiaStartingRoutedEventArgs> ManipulationInertiaStarting {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Input.ManipulationInertiaStartingEventHandler, Windows.UI.Xaml.Input.ManipulationInertiaStartingRoutedEventArgs>(x => This.ManipulationInertiaStarting += x, x => This.ManipulationInertiaStarting -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Input.ManipulationStartedRoutedEventArgs> ManipulationStarted {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Input.ManipulationStartedEventHandler, Windows.UI.Xaml.Input.ManipulationStartedRoutedEventArgs>(x => This.ManipulationStarted += x, x => This.ManipulationStarted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Input.ManipulationStartingRoutedEventArgs> ManipulationStarting {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Input.ManipulationStartingEventHandler, Windows.UI.Xaml.Input.ManipulationStartingRoutedEventArgs>(x => This.ManipulationStarting += x, x => This.ManipulationStarting -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Input.PointerRoutedEventArgs> PointerCanceled {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Input.PointerEventHandler, Windows.UI.Xaml.Input.PointerRoutedEventArgs>(x => This.PointerCanceled += x, x => This.PointerCanceled -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Input.PointerRoutedEventArgs> PointerCaptureLost {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Input.PointerEventHandler, Windows.UI.Xaml.Input.PointerRoutedEventArgs>(x => This.PointerCaptureLost += x, x => This.PointerCaptureLost -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Input.PointerRoutedEventArgs> PointerEntered {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Input.PointerEventHandler, Windows.UI.Xaml.Input.PointerRoutedEventArgs>(x => This.PointerEntered += x, x => This.PointerEntered -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Input.PointerRoutedEventArgs> PointerExited {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Input.PointerEventHandler, Windows.UI.Xaml.Input.PointerRoutedEventArgs>(x => This.PointerExited += x, x => This.PointerExited -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Input.PointerRoutedEventArgs> PointerMoved {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Input.PointerEventHandler, Windows.UI.Xaml.Input.PointerRoutedEventArgs>(x => This.PointerMoved += x, x => This.PointerMoved -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Input.PointerRoutedEventArgs> PointerPressed {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Input.PointerEventHandler, Windows.UI.Xaml.Input.PointerRoutedEventArgs>(x => This.PointerPressed += x, x => This.PointerPressed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Input.PointerRoutedEventArgs> PointerReleased {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Input.PointerEventHandler, Windows.UI.Xaml.Input.PointerRoutedEventArgs>(x => This.PointerReleased += x, x => This.PointerReleased -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Input.PointerRoutedEventArgs> PointerWheelChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Input.PointerEventHandler, Windows.UI.Xaml.Input.PointerRoutedEventArgs>(x => This.PointerWheelChanged += x, x => This.PointerWheelChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Input.RightTappedRoutedEventArgs> RightTapped {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Input.RightTappedEventHandler, Windows.UI.Xaml.Input.RightTappedRoutedEventArgs>(x => This.RightTapped += x, x => This.RightTapped -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Input.TappedRoutedEventArgs> Tapped {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Input.TappedEventHandler, Windows.UI.Xaml.Input.TappedRoutedEventArgs>(x => This.Tapped += x, x => This.Tapped -= x).Select(x => x.EventArgs); }
        }

    }
    public class FrameworkElementEvents

    {
        FrameworkElement This;

        public FrameworkElementEvents(FrameworkElement This)

        {
            this.This = This;
        }

        public IObservable<object> LayoutUpdated {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.LayoutUpdated += x, x => This.LayoutUpdated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> Loaded {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.Loaded += x, x => This.Loaded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.SizeChangedEventArgs> SizeChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.SizeChangedEventHandler, Windows.UI.Xaml.SizeChangedEventArgs>(x => This.SizeChanged += x, x => This.SizeChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> Unloaded {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.Unloaded += x, x => This.Unloaded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.DataContextChangedEventArgs> DataContextChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.FrameworkElement,Windows.UI.Xaml.DataContextChangedEventArgs>, Windows.UI.Xaml.DataContextChangedEventArgs>(x => This.DataContextChanged += x, x => This.DataContextChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class VisualStateGroupEvents

    {
        VisualStateGroup This;

        public VisualStateGroupEvents(VisualStateGroup This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.VisualStateChangedEventArgs> CurrentStateChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.VisualStateChangedEventHandler, Windows.UI.Xaml.VisualStateChangedEventArgs>(x => This.CurrentStateChanged += x, x => This.CurrentStateChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.VisualStateChangedEventArgs> CurrentStateChanging {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.VisualStateChangedEventHandler, Windows.UI.Xaml.VisualStateChangedEventArgs>(x => This.CurrentStateChanging += x, x => This.CurrentStateChanging -= x).Select(x => x.EventArgs); }
        }

    }
    public class WindowEvents

    {
        Window This;

        public WindowEvents(Window This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Core.WindowActivatedEventArgs> Activated {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.WindowActivatedEventHandler, Windows.UI.Core.WindowActivatedEventArgs>(x => This.Activated += x, x => This.Activated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.CoreWindowEventArgs> Closed {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.WindowClosedEventHandler, Windows.UI.Core.CoreWindowEventArgs>(x => This.Closed += x, x => This.Closed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.WindowSizeChangedEventArgs> SizeChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.WindowSizeChangedEventHandler, Windows.UI.Core.WindowSizeChangedEventArgs>(x => This.SizeChanged += x, x => This.SizeChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.VisibilityChangedEventArgs> VisibilityChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.WindowVisibilityChangedEventHandler, Windows.UI.Core.VisibilityChangedEventArgs>(x => This.VisibilityChanged += x, x => This.VisibilityChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.UI.Xaml.Media
{
    public static class EventsMixin
    {
        public static ImageBrushEvents Events(this ImageBrush This)
        {
            return new ImageBrushEvents(This);
        }
    }

    public class ImageBrushEvents

    {
        ImageBrush This;

        public ImageBrushEvents(ImageBrush This)

        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.ExceptionRoutedEventArgs> ImageFailed {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.ExceptionRoutedEventHandler, Windows.UI.Xaml.ExceptionRoutedEventArgs>(x => This.ImageFailed += x, x => This.ImageFailed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> ImageOpened {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.ImageOpened += x, x => This.ImageOpened -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.UI.Xaml.Media.Animation
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

        public IObservable<object> Completed {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.Completed += x, x => This.Completed -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.UI.Xaml.Media.Imaging
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

        public IObservable<Windows.UI.Xaml.Media.Imaging.DownloadProgressEventArgs> DownloadProgress {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Media.Imaging.DownloadProgressEventHandler, Windows.UI.Xaml.Media.Imaging.DownloadProgressEventArgs>(x => This.DownloadProgress += x, x => This.DownloadProgress -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.ExceptionRoutedEventArgs> ImageFailed {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.ExceptionRoutedEventHandler, Windows.UI.Xaml.ExceptionRoutedEventArgs>(x => This.ImageFailed += x, x => This.ImageFailed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> ImageOpened {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.ImageOpened += x, x => This.ImageOpened -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.ApplicationModel.Background
{
    public static class EventsMixin
    {
        public static IBackgroundTaskInstanceEvents Events(this IBackgroundTaskInstance This)
        {
            return new IBackgroundTaskInstanceEvents(This);
        }
        public static BackgroundTaskRegistrationEvents Events(this BackgroundTaskRegistration This)
        {
            return new BackgroundTaskRegistrationEvents(This);
        }
        public static IBackgroundTaskRegistrationEvents Events(this IBackgroundTaskRegistration This)
        {
            return new IBackgroundTaskRegistrationEvents(This);
        }
    }

    public class IBackgroundTaskInstanceEvents

    {
        IBackgroundTaskInstance This;

        public IBackgroundTaskInstanceEvents(IBackgroundTaskInstance This)

        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.Background.BackgroundTaskCancellationReason> Canceled {
            get { return Observable.FromEventPattern<Windows.ApplicationModel.Background.BackgroundTaskCanceledEventHandler, Windows.ApplicationModel.Background.BackgroundTaskCancellationReason>(x => This.Canceled += x, x => This.Canceled -= x).Select(x => x.EventArgs); }
        }

    }
    public class BackgroundTaskRegistrationEvents

    {
        BackgroundTaskRegistration This;

        public BackgroundTaskRegistrationEvents(BackgroundTaskRegistration This)

        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.Background.BackgroundTaskCompletedEventArgs> Completed {
            get { return Observable.FromEventPattern<Windows.ApplicationModel.Background.BackgroundTaskCompletedEventHandler, Windows.ApplicationModel.Background.BackgroundTaskCompletedEventArgs>(x => This.Completed += x, x => This.Completed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Background.BackgroundTaskProgressEventArgs> Progress {
            get { return Observable.FromEventPattern<Windows.ApplicationModel.Background.BackgroundTaskProgressEventHandler, Windows.ApplicationModel.Background.BackgroundTaskProgressEventArgs>(x => This.Progress += x, x => This.Progress -= x).Select(x => x.EventArgs); }
        }

    }
    public class IBackgroundTaskRegistrationEvents

    {
        IBackgroundTaskRegistration This;

        public IBackgroundTaskRegistrationEvents(IBackgroundTaskRegistration This)

        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.Background.BackgroundTaskCompletedEventArgs> Completed {
            get { return Observable.FromEventPattern<Windows.ApplicationModel.Background.BackgroundTaskCompletedEventHandler, Windows.ApplicationModel.Background.BackgroundTaskCompletedEventArgs>(x => This.Completed += x, x => This.Completed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Background.BackgroundTaskProgressEventArgs> Progress {
            get { return Observable.FromEventPattern<Windows.ApplicationModel.Background.BackgroundTaskProgressEventHandler, Windows.ApplicationModel.Background.BackgroundTaskProgressEventArgs>(x => This.Progress += x, x => This.Progress -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.ApplicationModel.Contacts.Provider
{
    public static class EventsMixin
    {
        public static ContactPickerUIEvents Events(this ContactPickerUI This)
        {
            return new ContactPickerUIEvents(This);
        }
    }

    public class ContactPickerUIEvents

    {
        ContactPickerUI This;

        public ContactPickerUIEvents(ContactPickerUI This)

        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.Contacts.Provider.ContactRemovedEventArgs> ContactRemoved {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Contacts.Provider.ContactPickerUI,Windows.ApplicationModel.Contacts.Provider.ContactRemovedEventArgs>, Windows.ApplicationModel.Contacts.Provider.ContactRemovedEventArgs>(x => This.ContactRemoved += x, x => This.ContactRemoved -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.ApplicationModel.DataTransfer
{
    public static class EventsMixin
    {
        public static DataPackageEvents Events(this DataPackage This)
        {
            return new DataPackageEvents(This);
        }
        public static DataTransferManagerEvents Events(this DataTransferManager This)
        {
            return new DataTransferManagerEvents(This);
        }
    }

    public class DataPackageEvents

    {
        DataPackage This;

        public DataPackageEvents(DataPackage This)

        {
            this.This = This;
        }

        public IObservable<object> Destroyed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.DataTransfer.DataPackage,object>, object>(x => This.Destroyed += x, x => This.Destroyed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.DataTransfer.OperationCompletedEventArgs> OperationCompleted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.DataTransfer.DataPackage,Windows.ApplicationModel.DataTransfer.OperationCompletedEventArgs>, Windows.ApplicationModel.DataTransfer.OperationCompletedEventArgs>(x => This.OperationCompleted += x, x => This.OperationCompleted -= x).Select(x => x.EventArgs); }
        }

    }
    public class DataTransferManagerEvents

    {
        DataTransferManager This;

        public DataTransferManagerEvents(DataTransferManager This)

        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.DataTransfer.DataRequestedEventArgs> DataRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.DataTransfer.DataTransferManager,Windows.ApplicationModel.DataTransfer.DataRequestedEventArgs>, Windows.ApplicationModel.DataTransfer.DataRequestedEventArgs>(x => This.DataRequested += x, x => This.DataRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.DataTransfer.TargetApplicationChosenEventArgs> TargetApplicationChosen {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.DataTransfer.DataTransferManager,Windows.ApplicationModel.DataTransfer.TargetApplicationChosenEventArgs>, Windows.ApplicationModel.DataTransfer.TargetApplicationChosenEventArgs>(x => This.TargetApplicationChosen += x, x => This.TargetApplicationChosen -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.ApplicationModel.Search
{
    public static class EventsMixin
    {
        public static SearchPaneEvents Events(this SearchPane This)
        {
            return new SearchPaneEvents(This);
        }
    }

    public class SearchPaneEvents

    {
        SearchPane This;

        public SearchPaneEvents(SearchPane This)

        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.Search.SearchPaneQueryChangedEventArgs> QueryChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Search.SearchPane,Windows.ApplicationModel.Search.SearchPaneQueryChangedEventArgs>, Windows.ApplicationModel.Search.SearchPaneQueryChangedEventArgs>(x => This.QueryChanged += x, x => This.QueryChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Search.SearchPaneQuerySubmittedEventArgs> QuerySubmitted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Search.SearchPane,Windows.ApplicationModel.Search.SearchPaneQuerySubmittedEventArgs>, Windows.ApplicationModel.Search.SearchPaneQuerySubmittedEventArgs>(x => This.QuerySubmitted += x, x => This.QuerySubmitted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Search.SearchPaneResultSuggestionChosenEventArgs> ResultSuggestionChosen {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Search.SearchPane,Windows.ApplicationModel.Search.SearchPaneResultSuggestionChosenEventArgs>, Windows.ApplicationModel.Search.SearchPaneResultSuggestionChosenEventArgs>(x => This.ResultSuggestionChosen += x, x => This.ResultSuggestionChosen -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Search.SearchPaneSuggestionsRequestedEventArgs> SuggestionsRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Search.SearchPane,Windows.ApplicationModel.Search.SearchPaneSuggestionsRequestedEventArgs>, Windows.ApplicationModel.Search.SearchPaneSuggestionsRequestedEventArgs>(x => This.SuggestionsRequested += x, x => This.SuggestionsRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Search.SearchPaneVisibilityChangedEventArgs> VisibilityChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Search.SearchPane,Windows.ApplicationModel.Search.SearchPaneVisibilityChangedEventArgs>, Windows.ApplicationModel.Search.SearchPaneVisibilityChangedEventArgs>(x => This.VisibilityChanged += x, x => This.VisibilityChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.ApplicationModel.Search.Core
{
    public static class EventsMixin
    {
        public static SearchSuggestionManagerEvents Events(this SearchSuggestionManager This)
        {
            return new SearchSuggestionManagerEvents(This);
        }
    }

    public class SearchSuggestionManagerEvents

    {
        SearchSuggestionManager This;

        public SearchSuggestionManagerEvents(SearchSuggestionManager This)

        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.Search.Core.RequestingFocusOnKeyboardInputEventArgs> RequestingFocusOnKeyboardInput {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Search.Core.SearchSuggestionManager,Windows.ApplicationModel.Search.Core.RequestingFocusOnKeyboardInputEventArgs>, Windows.ApplicationModel.Search.Core.RequestingFocusOnKeyboardInputEventArgs>(x => This.RequestingFocusOnKeyboardInput += x, x => This.RequestingFocusOnKeyboardInput -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Search.Core.SearchSuggestionsRequestedEventArgs> SuggestionsRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Search.Core.SearchSuggestionManager,Windows.ApplicationModel.Search.Core.SearchSuggestionsRequestedEventArgs>, Windows.ApplicationModel.Search.Core.SearchSuggestionsRequestedEventArgs>(x => This.SuggestionsRequested += x, x => This.SuggestionsRequested -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.ApplicationModel.Activation
{
    public static class EventsMixin
    {
        public static SplashScreenEvents Events(this SplashScreen This)
        {
            return new SplashScreenEvents(This);
        }
    }

    public class SplashScreenEvents

    {
        SplashScreen This;

        public SplashScreenEvents(SplashScreen This)

        {
            this.This = This;
        }

        public IObservable<object> Dismissed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Activation.SplashScreen,object>, object>(x => This.Dismissed += x, x => This.Dismissed -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.ApplicationModel.Calls
{
    public static class EventsMixin
    {
        public static LockScreenCallUIEvents Events(this LockScreenCallUI This)
        {
            return new LockScreenCallUIEvents(This);
        }
    }

    public class LockScreenCallUIEvents

    {
        LockScreenCallUI This;

        public LockScreenCallUIEvents(LockScreenCallUI This)

        {
            this.This = This;
        }

        public IObservable<object> Closed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Calls.LockScreenCallUI,object>, object>(x => This.Closed += x, x => This.Closed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Calls.LockScreenCallEndRequestedEventArgs> EndRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Calls.LockScreenCallUI,Windows.ApplicationModel.Calls.LockScreenCallEndRequestedEventArgs>, Windows.ApplicationModel.Calls.LockScreenCallEndRequestedEventArgs>(x => This.EndRequested += x, x => This.EndRequested -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.ApplicationModel.Core
{
    public static class EventsMixin
    {
        public static CoreApplicationViewEvents Events(this CoreApplicationView This)
        {
            return new CoreApplicationViewEvents(This);
        }
        public static ICoreApplicationUnhandledErrorEvents Events(this ICoreApplicationUnhandledError This)
        {
            return new ICoreApplicationUnhandledErrorEvents(This);
        }
    }

    public class CoreApplicationViewEvents

    {
        CoreApplicationView This;

        public CoreApplicationViewEvents(CoreApplicationView This)

        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.Activation.IActivatedEventArgs> Activated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Core.CoreApplicationView,Windows.ApplicationModel.Activation.IActivatedEventArgs>, Windows.ApplicationModel.Activation.IActivatedEventArgs>(x => This.Activated += x, x => This.Activated -= x).Select(x => x.EventArgs); }
        }

    }
    public class ICoreApplicationUnhandledErrorEvents

    {
        ICoreApplicationUnhandledError This;

        public ICoreApplicationUnhandledErrorEvents(ICoreApplicationUnhandledError This)

        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.Core.UnhandledErrorDetectedEventArgs> UnhandledErrorDetected {
            get { return Observable.FromEventPattern<EventHandler<Windows.ApplicationModel.Core.UnhandledErrorDetectedEventArgs>, Windows.ApplicationModel.Core.UnhandledErrorDetectedEventArgs>(x => This.UnhandledErrorDetected += x, x => This.UnhandledErrorDetected -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.ApplicationModel.Resources.Core
{
    public static class EventsMixin
    {
        public static ResourceQualifierObservableMapEvents Events(this ResourceQualifierObservableMap This)
        {
            return new ResourceQualifierObservableMapEvents(This);
        }
    }

    public class ResourceQualifierObservableMapEvents

    {
        ResourceQualifierObservableMap This;

        public ResourceQualifierObservableMapEvents(ResourceQualifierObservableMap This)

        {
            this.This = This;
        }

        public IObservable<Windows.Foundation.Collections.IMapChangedEventArgs<string>> MapChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.Collections.MapChangedEventHandler<string,string>, Windows.Foundation.Collections.IMapChangedEventArgs<string>>(x => This.MapChanged += x, x => This.MapChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Devices.Sms
{
    public static class EventsMixin
    {
        public static SmsDeviceEvents Events(this SmsDevice This)
        {
            return new SmsDeviceEvents(This);
        }
        public static ISmsDeviceEvents Events(this ISmsDevice This)
        {
            return new ISmsDeviceEvents(This);
        }
    }

    public class SmsDeviceEvents

    {
        SmsDevice This;

        public SmsDeviceEvents(SmsDevice This)

        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Sms.SmsMessageReceivedEventArgs> SmsMessageReceived {
            get { return Observable.FromEventPattern<Windows.Devices.Sms.SmsMessageReceivedEventHandler, Windows.Devices.Sms.SmsMessageReceivedEventArgs>(x => This.SmsMessageReceived += x, x => This.SmsMessageReceived -= x).Select(x => x.EventArgs); }
        }

    }
    public class ISmsDeviceEvents

    {
        ISmsDevice This;

        public ISmsDeviceEvents(ISmsDevice This)

        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Sms.SmsMessageReceivedEventArgs> SmsMessageReceived {
            get { return Observable.FromEventPattern<Windows.Devices.Sms.SmsMessageReceivedEventHandler, Windows.Devices.Sms.SmsMessageReceivedEventArgs>(x => This.SmsMessageReceived += x, x => This.SmsMessageReceived -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
    public static class EventsMixin
    {
        public static GattCharacteristicEvents Events(this GattCharacteristic This)
        {
            return new GattCharacteristicEvents(This);
        }
    }

    public class GattCharacteristicEvents

    {
        GattCharacteristic This;

        public GattCharacteristicEvents(GattCharacteristic This)

        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Bluetooth.GenericAttributeProfile.GattValueChangedEventArgs> ValueChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Bluetooth.GenericAttributeProfile.GattCharacteristic,Windows.Devices.Bluetooth.GenericAttributeProfile.GattValueChangedEventArgs>, Windows.Devices.Bluetooth.GenericAttributeProfile.GattValueChangedEventArgs>(x => This.ValueChanged += x, x => This.ValueChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Devices.Enumeration
{
    public static class EventsMixin
    {
        public static DeviceWatcherEvents Events(this DeviceWatcher This)
        {
            return new DeviceWatcherEvents(This);
        }
        public static DeviceAccessInformationEvents Events(this DeviceAccessInformation This)
        {
            return new DeviceAccessInformationEvents(This);
        }
    }

    public class DeviceWatcherEvents

    {
        DeviceWatcher This;

        public DeviceWatcherEvents(DeviceWatcher This)

        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Enumeration.DeviceInformation> Added {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Enumeration.DeviceWatcher,Windows.Devices.Enumeration.DeviceInformation>, Windows.Devices.Enumeration.DeviceInformation>(x => This.Added += x, x => This.Added -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> EnumerationCompleted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Enumeration.DeviceWatcher,object>, object>(x => This.EnumerationCompleted += x, x => This.EnumerationCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.Enumeration.DeviceInformationUpdate> Removed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Enumeration.DeviceWatcher,Windows.Devices.Enumeration.DeviceInformationUpdate>, Windows.Devices.Enumeration.DeviceInformationUpdate>(x => This.Removed += x, x => This.Removed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> Stopped {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Enumeration.DeviceWatcher,object>, object>(x => This.Stopped += x, x => This.Stopped -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.Enumeration.DeviceInformationUpdate> Updated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Enumeration.DeviceWatcher,Windows.Devices.Enumeration.DeviceInformationUpdate>, Windows.Devices.Enumeration.DeviceInformationUpdate>(x => This.Updated += x, x => This.Updated -= x).Select(x => x.EventArgs); }
        }

    }
    public class DeviceAccessInformationEvents

    {
        DeviceAccessInformation This;

        public DeviceAccessInformationEvents(DeviceAccessInformation This)

        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Enumeration.DeviceAccessChangedEventArgs> AccessChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Enumeration.DeviceAccessInformation,Windows.Devices.Enumeration.DeviceAccessChangedEventArgs>, Windows.Devices.Enumeration.DeviceAccessChangedEventArgs>(x => This.AccessChanged += x, x => This.AccessChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Devices.Enumeration.Pnp
{
    public static class EventsMixin
    {
        public static PnpObjectWatcherEvents Events(this PnpObjectWatcher This)
        {
            return new PnpObjectWatcherEvents(This);
        }
    }

    public class PnpObjectWatcherEvents

    {
        PnpObjectWatcher This;

        public PnpObjectWatcherEvents(PnpObjectWatcher This)

        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Enumeration.Pnp.PnpObject> Added {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Enumeration.Pnp.PnpObjectWatcher,Windows.Devices.Enumeration.Pnp.PnpObject>, Windows.Devices.Enumeration.Pnp.PnpObject>(x => This.Added += x, x => This.Added -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> EnumerationCompleted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Enumeration.Pnp.PnpObjectWatcher,object>, object>(x => This.EnumerationCompleted += x, x => This.EnumerationCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.Enumeration.Pnp.PnpObjectUpdate> Removed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Enumeration.Pnp.PnpObjectWatcher,Windows.Devices.Enumeration.Pnp.PnpObjectUpdate>, Windows.Devices.Enumeration.Pnp.PnpObjectUpdate>(x => This.Removed += x, x => This.Removed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> Stopped {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Enumeration.Pnp.PnpObjectWatcher,object>, object>(x => This.Stopped += x, x => This.Stopped -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.Enumeration.Pnp.PnpObjectUpdate> Updated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Enumeration.Pnp.PnpObjectWatcher,Windows.Devices.Enumeration.Pnp.PnpObjectUpdate>, Windows.Devices.Enumeration.Pnp.PnpObjectUpdate>(x => This.Updated += x, x => This.Updated -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Devices.Geolocation.Geofencing
{
    public static class EventsMixin
    {
        public static GeofenceMonitorEvents Events(this GeofenceMonitor This)
        {
            return new GeofenceMonitorEvents(This);
        }
    }

    public class GeofenceMonitorEvents

    {
        GeofenceMonitor This;

        public GeofenceMonitorEvents(GeofenceMonitor This)

        {
            this.This = This;
        }

        public IObservable<object> GeofenceStateChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Geolocation.Geofencing.GeofenceMonitor,object>, object>(x => This.GeofenceStateChanged += x, x => This.GeofenceStateChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> StatusChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Geolocation.Geofencing.GeofenceMonitor,object>, object>(x => This.StatusChanged += x, x => This.StatusChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Devices.Geolocation
{
    public static class EventsMixin
    {
        public static GeolocatorEvents Events(this Geolocator This)
        {
            return new GeolocatorEvents(This);
        }
    }

    public class GeolocatorEvents

    {
        Geolocator This;

        public GeolocatorEvents(Geolocator This)

        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Geolocation.PositionChangedEventArgs> PositionChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Geolocation.Geolocator,Windows.Devices.Geolocation.PositionChangedEventArgs>, Windows.Devices.Geolocation.PositionChangedEventArgs>(x => This.PositionChanged += x, x => This.PositionChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.Geolocation.StatusChangedEventArgs> StatusChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Geolocation.Geolocator,Windows.Devices.Geolocation.StatusChangedEventArgs>, Windows.Devices.Geolocation.StatusChangedEventArgs>(x => This.StatusChanged += x, x => This.StatusChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Devices.HumanInterfaceDevice
{
    public static class EventsMixin
    {
        public static HidDeviceEvents Events(this HidDevice This)
        {
            return new HidDeviceEvents(This);
        }
    }

    public class HidDeviceEvents

    {
        HidDevice This;

        public HidDeviceEvents(HidDevice This)

        {
            this.This = This;
        }

        public IObservable<Windows.Devices.HumanInterfaceDevice.HidInputReportReceivedEventArgs> InputReportReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.HumanInterfaceDevice.HidDevice,Windows.Devices.HumanInterfaceDevice.HidInputReportReceivedEventArgs>, Windows.Devices.HumanInterfaceDevice.HidInputReportReceivedEventArgs>(x => This.InputReportReceived += x, x => This.InputReportReceived -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Devices.Input
{
    public static class EventsMixin
    {
        public static MouseDeviceEvents Events(this MouseDevice This)
        {
            return new MouseDeviceEvents(This);
        }
    }

    public class MouseDeviceEvents

    {
        MouseDevice This;

        public MouseDeviceEvents(MouseDevice This)

        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Input.MouseEventArgs> MouseMoved {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Input.MouseDevice,Windows.Devices.Input.MouseEventArgs>, Windows.Devices.Input.MouseEventArgs>(x => This.MouseMoved += x, x => This.MouseMoved -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Devices.PointOfService
{
    public static class EventsMixin
    {
        public static BarcodeScannerEvents Events(this BarcodeScanner This)
        {
            return new BarcodeScannerEvents(This);
        }
        public static ClaimedBarcodeScannerEvents Events(this ClaimedBarcodeScanner This)
        {
            return new ClaimedBarcodeScannerEvents(This);
        }
        public static ClaimedMagneticStripeReaderEvents Events(this ClaimedMagneticStripeReader This)
        {
            return new ClaimedMagneticStripeReaderEvents(This);
        }
        public static MagneticStripeReaderEvents Events(this MagneticStripeReader This)
        {
            return new MagneticStripeReaderEvents(This);
        }
    }

    public class BarcodeScannerEvents

    {
        BarcodeScanner This;

        public BarcodeScannerEvents(BarcodeScanner This)

        {
            this.This = This;
        }

        public IObservable<Windows.Devices.PointOfService.BarcodeScannerStatusUpdatedEventArgs> StatusUpdated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.PointOfService.BarcodeScanner,Windows.Devices.PointOfService.BarcodeScannerStatusUpdatedEventArgs>, Windows.Devices.PointOfService.BarcodeScannerStatusUpdatedEventArgs>(x => This.StatusUpdated += x, x => This.StatusUpdated -= x).Select(x => x.EventArgs); }
        }

    }
    public class ClaimedBarcodeScannerEvents

    {
        ClaimedBarcodeScanner This;

        public ClaimedBarcodeScannerEvents(ClaimedBarcodeScanner This)

        {
            this.This = This;
        }

        public IObservable<Windows.Devices.PointOfService.BarcodeScannerDataReceivedEventArgs> DataReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.PointOfService.ClaimedBarcodeScanner,Windows.Devices.PointOfService.BarcodeScannerDataReceivedEventArgs>, Windows.Devices.PointOfService.BarcodeScannerDataReceivedEventArgs>(x => This.DataReceived += x, x => This.DataReceived -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.PointOfService.BarcodeScannerErrorOccurredEventArgs> ErrorOccurred {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.PointOfService.ClaimedBarcodeScanner,Windows.Devices.PointOfService.BarcodeScannerErrorOccurredEventArgs>, Windows.Devices.PointOfService.BarcodeScannerErrorOccurredEventArgs>(x => This.ErrorOccurred += x, x => This.ErrorOccurred -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.PointOfService.BarcodeScannerImagePreviewReceivedEventArgs> ImagePreviewReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.PointOfService.ClaimedBarcodeScanner,Windows.Devices.PointOfService.BarcodeScannerImagePreviewReceivedEventArgs>, Windows.Devices.PointOfService.BarcodeScannerImagePreviewReceivedEventArgs>(x => This.ImagePreviewReceived += x, x => This.ImagePreviewReceived -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.PointOfService.ClaimedBarcodeScanner> ReleaseDeviceRequested {
            get { return Observable.FromEventPattern<EventHandler<Windows.Devices.PointOfService.ClaimedBarcodeScanner>, Windows.Devices.PointOfService.ClaimedBarcodeScanner>(x => This.ReleaseDeviceRequested += x, x => This.ReleaseDeviceRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.PointOfService.ClaimedBarcodeScanner> TriggerPressed {
            get { return Observable.FromEventPattern<EventHandler<Windows.Devices.PointOfService.ClaimedBarcodeScanner>, Windows.Devices.PointOfService.ClaimedBarcodeScanner>(x => This.TriggerPressed += x, x => This.TriggerPressed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.PointOfService.ClaimedBarcodeScanner> TriggerReleased {
            get { return Observable.FromEventPattern<EventHandler<Windows.Devices.PointOfService.ClaimedBarcodeScanner>, Windows.Devices.PointOfService.ClaimedBarcodeScanner>(x => This.TriggerReleased += x, x => This.TriggerReleased -= x).Select(x => x.EventArgs); }
        }

    }
    public class ClaimedMagneticStripeReaderEvents

    {
        ClaimedMagneticStripeReader This;

        public ClaimedMagneticStripeReaderEvents(ClaimedMagneticStripeReader This)

        {
            this.This = This;
        }

        public IObservable<Windows.Devices.PointOfService.MagneticStripeReaderAamvaCardDataReceivedEventArgs> AamvaCardDataReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.PointOfService.ClaimedMagneticStripeReader,Windows.Devices.PointOfService.MagneticStripeReaderAamvaCardDataReceivedEventArgs>, Windows.Devices.PointOfService.MagneticStripeReaderAamvaCardDataReceivedEventArgs>(x => This.AamvaCardDataReceived += x, x => This.AamvaCardDataReceived -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.PointOfService.MagneticStripeReaderBankCardDataReceivedEventArgs> BankCardDataReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.PointOfService.ClaimedMagneticStripeReader,Windows.Devices.PointOfService.MagneticStripeReaderBankCardDataReceivedEventArgs>, Windows.Devices.PointOfService.MagneticStripeReaderBankCardDataReceivedEventArgs>(x => This.BankCardDataReceived += x, x => This.BankCardDataReceived -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.PointOfService.MagneticStripeReaderErrorOccurredEventArgs> ErrorOccurred {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.PointOfService.ClaimedMagneticStripeReader,Windows.Devices.PointOfService.MagneticStripeReaderErrorOccurredEventArgs>, Windows.Devices.PointOfService.MagneticStripeReaderErrorOccurredEventArgs>(x => This.ErrorOccurred += x, x => This.ErrorOccurred -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.PointOfService.ClaimedMagneticStripeReader> ReleaseDeviceRequested {
            get { return Observable.FromEventPattern<EventHandler<Windows.Devices.PointOfService.ClaimedMagneticStripeReader>, Windows.Devices.PointOfService.ClaimedMagneticStripeReader>(x => This.ReleaseDeviceRequested += x, x => This.ReleaseDeviceRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.PointOfService.MagneticStripeReaderVendorSpecificCardDataReceivedEventArgs> VendorSpecificDataReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.PointOfService.ClaimedMagneticStripeReader,Windows.Devices.PointOfService.MagneticStripeReaderVendorSpecificCardDataReceivedEventArgs>, Windows.Devices.PointOfService.MagneticStripeReaderVendorSpecificCardDataReceivedEventArgs>(x => This.VendorSpecificDataReceived += x, x => This.VendorSpecificDataReceived -= x).Select(x => x.EventArgs); }
        }

    }
    public class MagneticStripeReaderEvents

    {
        MagneticStripeReader This;

        public MagneticStripeReaderEvents(MagneticStripeReader This)

        {
            this.This = This;
        }

        public IObservable<Windows.Devices.PointOfService.MagneticStripeReaderStatusUpdatedEventArgs> StatusUpdated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.PointOfService.MagneticStripeReader,Windows.Devices.PointOfService.MagneticStripeReaderStatusUpdatedEventArgs>, Windows.Devices.PointOfService.MagneticStripeReaderStatusUpdatedEventArgs>(x => This.StatusUpdated += x, x => This.StatusUpdated -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Devices.Printers.Extensions
{
    public static class EventsMixin
    {
        public static PrintTaskConfigurationEvents Events(this PrintTaskConfiguration This)
        {
            return new PrintTaskConfigurationEvents(This);
        }
    }

    public class PrintTaskConfigurationEvents

    {
        PrintTaskConfiguration This;

        public PrintTaskConfigurationEvents(PrintTaskConfiguration This)

        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Printers.Extensions.PrintTaskConfigurationSaveRequestedEventArgs> SaveRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Printers.Extensions.PrintTaskConfiguration,Windows.Devices.Printers.Extensions.PrintTaskConfigurationSaveRequestedEventArgs>, Windows.Devices.Printers.Extensions.PrintTaskConfigurationSaveRequestedEventArgs>(x => This.SaveRequested += x, x => This.SaveRequested -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Devices.Sensors
{
    public static class EventsMixin
    {
        public static AccelerometerEvents Events(this Accelerometer This)
        {
            return new AccelerometerEvents(This);
        }
        public static InclinometerEvents Events(this Inclinometer This)
        {
            return new InclinometerEvents(This);
        }
        public static GyrometerEvents Events(this Gyrometer This)
        {
            return new GyrometerEvents(This);
        }
        public static CompassEvents Events(this Compass This)
        {
            return new CompassEvents(This);
        }
        public static LightSensorEvents Events(this LightSensor This)
        {
            return new LightSensorEvents(This);
        }
        public static OrientationSensorEvents Events(this OrientationSensor This)
        {
            return new OrientationSensorEvents(This);
        }
        public static SimpleOrientationSensorEvents Events(this SimpleOrientationSensor This)
        {
            return new SimpleOrientationSensorEvents(This);
        }
    }

    public class AccelerometerEvents

    {
        Accelerometer This;

        public AccelerometerEvents(Accelerometer This)

        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Sensors.AccelerometerReadingChangedEventArgs> ReadingChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Sensors.Accelerometer,Windows.Devices.Sensors.AccelerometerReadingChangedEventArgs>, Windows.Devices.Sensors.AccelerometerReadingChangedEventArgs>(x => This.ReadingChanged += x, x => This.ReadingChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.Sensors.AccelerometerShakenEventArgs> Shaken {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Sensors.Accelerometer,Windows.Devices.Sensors.AccelerometerShakenEventArgs>, Windows.Devices.Sensors.AccelerometerShakenEventArgs>(x => This.Shaken += x, x => This.Shaken -= x).Select(x => x.EventArgs); }
        }

    }
    public class InclinometerEvents

    {
        Inclinometer This;

        public InclinometerEvents(Inclinometer This)

        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Sensors.InclinometerReadingChangedEventArgs> ReadingChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Sensors.Inclinometer,Windows.Devices.Sensors.InclinometerReadingChangedEventArgs>, Windows.Devices.Sensors.InclinometerReadingChangedEventArgs>(x => This.ReadingChanged += x, x => This.ReadingChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class GyrometerEvents

    {
        Gyrometer This;

        public GyrometerEvents(Gyrometer This)

        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Sensors.GyrometerReadingChangedEventArgs> ReadingChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Sensors.Gyrometer,Windows.Devices.Sensors.GyrometerReadingChangedEventArgs>, Windows.Devices.Sensors.GyrometerReadingChangedEventArgs>(x => This.ReadingChanged += x, x => This.ReadingChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class CompassEvents

    {
        Compass This;

        public CompassEvents(Compass This)

        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Sensors.CompassReadingChangedEventArgs> ReadingChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Sensors.Compass,Windows.Devices.Sensors.CompassReadingChangedEventArgs>, Windows.Devices.Sensors.CompassReadingChangedEventArgs>(x => This.ReadingChanged += x, x => This.ReadingChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class LightSensorEvents

    {
        LightSensor This;

        public LightSensorEvents(LightSensor This)

        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Sensors.LightSensorReadingChangedEventArgs> ReadingChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Sensors.LightSensor,Windows.Devices.Sensors.LightSensorReadingChangedEventArgs>, Windows.Devices.Sensors.LightSensorReadingChangedEventArgs>(x => This.ReadingChanged += x, x => This.ReadingChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class OrientationSensorEvents

    {
        OrientationSensor This;

        public OrientationSensorEvents(OrientationSensor This)

        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Sensors.OrientationSensorReadingChangedEventArgs> ReadingChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Sensors.OrientationSensor,Windows.Devices.Sensors.OrientationSensorReadingChangedEventArgs>, Windows.Devices.Sensors.OrientationSensorReadingChangedEventArgs>(x => This.ReadingChanged += x, x => This.ReadingChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class SimpleOrientationSensorEvents

    {
        SimpleOrientationSensor This;

        public SimpleOrientationSensorEvents(SimpleOrientationSensor This)

        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Sensors.SimpleOrientationSensorOrientationChangedEventArgs> OrientationChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Sensors.SimpleOrientationSensor,Windows.Devices.Sensors.SimpleOrientationSensorOrientationChangedEventArgs>, Windows.Devices.Sensors.SimpleOrientationSensorOrientationChangedEventArgs>(x => This.OrientationChanged += x, x => This.OrientationChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Devices.SmartCards
{
    public static class EventsMixin
    {
        public static SmartCardReaderEvents Events(this SmartCardReader This)
        {
            return new SmartCardReaderEvents(This);
        }
    }

    public class SmartCardReaderEvents

    {
        SmartCardReader This;

        public SmartCardReaderEvents(SmartCardReader This)

        {
            this.This = This;
        }

        public IObservable<Windows.Devices.SmartCards.CardAddedEventArgs> CardAdded {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.SmartCards.SmartCardReader,Windows.Devices.SmartCards.CardAddedEventArgs>, Windows.Devices.SmartCards.CardAddedEventArgs>(x => This.CardAdded += x, x => This.CardAdded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.SmartCards.CardRemovedEventArgs> CardRemoved {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.SmartCards.SmartCardReader,Windows.Devices.SmartCards.CardRemovedEventArgs>, Windows.Devices.SmartCards.CardRemovedEventArgs>(x => This.CardRemoved += x, x => This.CardRemoved -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Devices.Usb
{
    public static class EventsMixin
    {
        public static UsbInterruptInPipeEvents Events(this UsbInterruptInPipe This)
        {
            return new UsbInterruptInPipeEvents(This);
        }
    }

    public class UsbInterruptInPipeEvents

    {
        UsbInterruptInPipe This;

        public UsbInterruptInPipeEvents(UsbInterruptInPipe This)

        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Usb.UsbInterruptInEventArgs> DataReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Usb.UsbInterruptInPipe,Windows.Devices.Usb.UsbInterruptInEventArgs>, Windows.Devices.Usb.UsbInterruptInEventArgs>(x => This.DataReceived += x, x => This.DataReceived -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Devices.WiFiDirect
{
    public static class EventsMixin
    {
        public static WiFiDirectDeviceEvents Events(this WiFiDirectDevice This)
        {
            return new WiFiDirectDeviceEvents(This);
        }
    }

    public class WiFiDirectDeviceEvents

    {
        WiFiDirectDevice This;

        public WiFiDirectDeviceEvents(WiFiDirectDevice This)

        {
            this.This = This;
        }

        public IObservable<object> ConnectionStatusChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.WiFiDirect.WiFiDirectDevice,object>, object>(x => This.ConnectionStatusChanged += x, x => This.ConnectionStatusChanged -= x).Select(x => x.EventArgs); }
        }

    }
}



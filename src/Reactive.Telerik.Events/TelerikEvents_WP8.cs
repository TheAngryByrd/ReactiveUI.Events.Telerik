using System;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Subjects;

using Telerik.Windows.Controls;

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
}



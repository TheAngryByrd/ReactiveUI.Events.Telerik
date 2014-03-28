using System;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Subjects;

using System;
using System.Runtime.InteropServices;
using System.Reflection;
using System;

namespace System
{
    public static class EventsMixin
    {
        public static _AppDomainEvents Events(this _AppDomain This)
        {
            return new _AppDomainEvents(This);
        }
        public static AppDomainEvents Events(this AppDomain This)
        {
            return new AppDomainEvents(This);
        }
    }

    public class _AppDomainEvents
    {
        _AppDomain This;

        public _AppDomainEvents(_AppDomain This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> DomainUnload {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DomainUnload += x, x => This.DomainUnload -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.AssemblyLoadEventArgs> AssemblyLoad {
            get { return Observable.FromEventPattern<System.AssemblyLoadEventHandler, System.AssemblyLoadEventArgs>(x => This.AssemblyLoad += x, x => This.AssemblyLoad -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> ProcessExit {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.ProcessExit += x, x => This.ProcessExit -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.ResolveEventArgs> TypeResolve {
            get { return Observable.FromEventPattern<System.ResolveEventHandler, System.ResolveEventArgs>(x => This.TypeResolve += x, x => This.TypeResolve -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.ResolveEventArgs> ResourceResolve {
            get { return Observable.FromEventPattern<System.ResolveEventHandler, System.ResolveEventArgs>(x => This.ResourceResolve += x, x => This.ResourceResolve -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.ResolveEventArgs> AssemblyResolve {
            get { return Observable.FromEventPattern<System.ResolveEventHandler, System.ResolveEventArgs>(x => This.AssemblyResolve += x, x => This.AssemblyResolve -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.UnhandledExceptionEventArgs> UnhandledException {
            get { return Observable.FromEventPattern<System.UnhandledExceptionEventHandler, System.UnhandledExceptionEventArgs>(x => This.UnhandledException += x, x => This.UnhandledException -= x).Select(x => x.EventArgs); }
        }

    }
    public class AppDomainEvents
    {
        AppDomain This;

        public AppDomainEvents(AppDomain This)
        {
            this.This = This;
        }

        public IObservable<System.AssemblyLoadEventArgs> AssemblyLoad {
            get { return Observable.FromEventPattern<System.AssemblyLoadEventHandler, System.AssemblyLoadEventArgs>(x => This.AssemblyLoad += x, x => This.AssemblyLoad -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.ResolveEventArgs> TypeResolve {
            get { return Observable.FromEventPattern<System.ResolveEventHandler, System.ResolveEventArgs>(x => This.TypeResolve += x, x => This.TypeResolve -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.ResolveEventArgs> ResourceResolve {
            get { return Observable.FromEventPattern<System.ResolveEventHandler, System.ResolveEventArgs>(x => This.ResourceResolve += x, x => This.ResourceResolve -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.ResolveEventArgs> AssemblyResolve {
            get { return Observable.FromEventPattern<System.ResolveEventHandler, System.ResolveEventArgs>(x => This.AssemblyResolve += x, x => This.AssemblyResolve -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.ResolveEventArgs> ReflectionOnlyAssemblyResolve {
            get { return Observable.FromEventPattern<System.ResolveEventHandler, System.ResolveEventArgs>(x => This.ReflectionOnlyAssemblyResolve += x, x => This.ReflectionOnlyAssemblyResolve -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> ProcessExit {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.ProcessExit += x, x => This.ProcessExit -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DomainUnload {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DomainUnload += x, x => This.DomainUnload -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.UnhandledExceptionEventArgs> UnhandledException {
            get { return Observable.FromEventPattern<System.UnhandledExceptionEventHandler, System.UnhandledExceptionEventArgs>(x => This.UnhandledException += x, x => This.UnhandledException -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs> FirstChanceException {
            get { return Observable.FromEventPattern<System.EventHandler<System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs>, System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs>(x => This.FirstChanceException += x, x => This.FirstChanceException -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace System.Runtime.InteropServices
{
    public static class EventsMixin
    {
        public static _AssemblyEvents Events(this _Assembly This)
        {
            return new _AssemblyEvents(This);
        }
    }

    public class _AssemblyEvents
    {
        _Assembly This;

        public _AssemblyEvents(_Assembly This)
        {
            this.This = This;
        }

        public IObservable<System.ResolveEventArgs> ModuleResolve {
            get { return Observable.FromEventPattern<System.Reflection.ModuleResolveEventHandler, System.ResolveEventArgs>(x => This.ModuleResolve += x, x => This.ModuleResolve -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace System.Reflection
{
    public static class EventsMixin
    {
        public static AssemblyEvents Events(this Assembly This)
        {
            return new AssemblyEvents(This);
        }
    }

    public class AssemblyEvents
    {
        Assembly This;

        public AssemblyEvents(Assembly This)
        {
            this.This = This;
        }

        public IObservable<System.ResolveEventArgs> ModuleResolve {
            get { return Observable.FromEventPattern<System.Reflection.ModuleResolveEventHandler, System.ResolveEventArgs>(x => This.ModuleResolve += x, x => This.ModuleResolve -= x).Select(x => x.EventArgs); }
        }

    }
}

namespace System.Rx
{
    public abstract partial class DelegateRx : Delegate
    {
        protected readonly Subject<Tuple<System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext>> _GetObjectData = new Subject<Tuple<System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext>>();
        public IObservable<Tuple<System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext>> GetObjectDataObs { get { return _GetObjectData; } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
            _GetObjectData.OnNext(Tuple.Create(info, context));
        }

    }
    public abstract partial class MulticastDelegateRx : MulticastDelegate
    {
        protected readonly Subject<Tuple<System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext>> _GetObjectData = new Subject<Tuple<System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext>>();
        public IObservable<Tuple<System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext>> GetObjectDataObs { get { return _GetObjectData; } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
            _GetObjectData.OnNext(Tuple.Create(info, context));
        }

    }
}


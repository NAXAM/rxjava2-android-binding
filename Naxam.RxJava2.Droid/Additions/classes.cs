namespace IO.Reactivex.Internal.Operators.Observable
{
    partial class ObservableDematerialize
    {
        partial class DematerializeObserver
        {
            public unsafe void OnNext(Java.Lang.Object t)
            {
                OnNext((Reactivex.Notification)t);
            }
        }
    }
}

namespace IO.Reactivex.Subscribers
{
    partial class TestSubscriber
    {
        public override Java.Lang.Object AssertNotSubscribed()
        {
            return TestAssertNotSubscribed();
        }
        public override Java.Lang.Object AssertSubscribed()
        {
            return TestAssertSubscribed();
        }
    }
}


namespace IO.Reactivex.Observers
{
    partial class TestObserver
    {
        public override Java.Lang.Object AssertNotSubscribed()
        {
            return TestAssertNotSubscribed();
        }
        public override Java.Lang.Object AssertSubscribed()
        {
            return TestAssertSubscribed();
        }
    }
}

namespace IO.Reactivex.Internal.Operators.Observable
{
    partial class BlockingObservableLatest
    {
        partial class BlockingObservableLatestIterator
        {
            public override void OnNext(Java.Lang.Object args)
            {
                OnNext((Reactivex.Notification)args);
            }
        }
    }

    partial class BlockingObservableNext
    {
        partial class NextObserver
        {
            public override void OnNext(Java.Lang.Object args)
            {
                OnNext((Reactivex.Notification)args);
            }
        }
    }
}

namespace IO.Reactivex.Internal.Operators.Flowable
{
    partial class BlockingFlowableLatest
    {
        partial class LatestSubscriberIterator
        {
            public override void OnNext(Java.Lang.Object args)
            {
                OnNext((Reactivex.Notification)args);
            }
        }
    }
    partial class BlockingFlowableNext
    {
        partial class NextSubscriber
        {
            public override void OnNext(Java.Lang.Object args)
            {
                OnNext((Reactivex.Notification)args);
            }
        }
    }
}

namespace IO.Reactivex.Internal.Functions
{
    partial class Functions
    {
        partial class ToMultimapKeyValueSelector
        {
            public unsafe void Accept(Java.Lang.Object p0, Java.Lang.Object p1)
            {
                Accept((Java.Lang.Object)p0, (Java.Lang.Object)p1);
            }

        }
        partial class ToMapKeyValueSelector
        {
            public unsafe void Accept(Java.Lang.Object p0, Java.Lang.Object p1)
            {
                Accept((Java.Lang.Object)p0, (Java.Lang.Object)p1);
            }

        }
        partial class ToMapKeySelector
        {
            public unsafe void Accept(Java.Lang.Object p0, Java.Lang.Object p1)
            {
                Accept((Java.Lang.Object)p0, (Java.Lang.Object)p1);
            }
        }
        partial class Array2Func
        {
            public unsafe Java.Lang.Object Apply(Java.Lang.Object a)
            {
                return Apply(a.ToArray<Java.Lang.Object>());
            }
        }
        partial class Array3Func
        {
            public unsafe Java.Lang.Object Apply(Java.Lang.Object a)
            {
                return Apply(a.ToArray<Java.Lang.Object>());
            }
        }
        partial class Array4Func
        {
            public unsafe Java.Lang.Object Apply(Java.Lang.Object a)
            {
                return Apply(a.ToArray<Java.Lang.Object>());
            }
        }
        partial class Array5Func
        {
            public unsafe Java.Lang.Object Apply(Java.Lang.Object a)
            {
                return Apply(a.ToArray<Java.Lang.Object>());
            }
        }
        partial class Array6Func
        {
            public unsafe Java.Lang.Object Apply(Java.Lang.Object a)
            {
                return Apply(a.ToArray<Java.Lang.Object>());
            }
        }
        partial class Array7Func
        {
            public unsafe Java.Lang.Object Apply(Java.Lang.Object a)
            {
                return Apply(a.ToArray<Java.Lang.Object>());
            }
        }
        partial class Array8Func
        {
            public unsafe Java.Lang.Object Apply(Java.Lang.Object a)
            {
                return Apply(a.ToArray<Java.Lang.Object>());
            }
        }
        partial class Array9Func
        {
            public unsafe Java.Lang.Object Apply(Java.Lang.Object a)
            {
                return Apply(a.ToArray<Java.Lang.Object>());
            }
        }

        partial class ArrayListCapacityCallable
        {
            public Java.Lang.Object Call()
            {
                return (Java.Lang.Object)CallForData();
            }
        }

        partial class HashSetCallable
        {
            public Java.Lang.Object Call()
            {
                return (Java.Lang.Object)CallForData();
            }
        }

        partial class TimestampFunction
        {

            public Java.Lang.Object Apply(Java.Lang.Object Object)
            {
                return (Java.Lang.Object)ApplyMapper(Object);

            }
        }
    }

    namespace IO.Reactivex.Schedulers
    {
        partial class Schedulers
        {
            partial class ComputationTask
            {
                public Java.Lang.Object Call()
                {
                    return (Java.Lang.Object)CallForData();
                }
            }
            partial class IOTask
            {
                public Java.Lang.Object Call()
                {
                    return (Java.Lang.Object)CallForData();
                }
            }
            partial class NewThreadTask
            {
                public Java.Lang.Object Call()
                {
                    return (Java.Lang.Object)CallForData();
                }
            }
            partial class SingleTask
            {
                public Java.Lang.Object Call()
                {
                    return (Java.Lang.Object)CallForData();
                }
            }
        }

    }

    namespace IO.Reactivex.Internal.Operators.Observable
    {
        partial class ObservableInternalHelper
        {
            partial class BufferedReplayCallable
            {
                public Java.Lang.Object Call()
                {
                    return (Java.Lang.Object)CallForData();
                }
            }
            partial class BufferedTimedReplayCallable
            {
                public Java.Lang.Object Call()
                {
                    return (Java.Lang.Object)CallForData();
                }
            }
            partial class ReplayCallable
            {
                public Java.Lang.Object Call()
                {
                    return (Java.Lang.Object)CallForData();
                }
            }
            partial class TimedReplayCallable
            {
                public Java.Lang.Object Call()
                {
                    return (Java.Lang.Object)CallForData();
                }
            }
        }
    }

    namespace IO.Reactivex.Internal.Util
    {
        partial class ArrayListSupplier
        {
            public Java.Lang.Object Call()
            {
                return (Java.Lang.Object)CallForData();
            }
        }
        partial class HashMapSupplier
        {
            public Java.Lang.Object Call()
            {
                return (Java.Lang.Object)CallForData();
            }
        }
    }

    namespace IO.Reactivex.Internal.Operators.Flowable
    {
        partial class FlowableInternalHelper
        {
            partial class BufferedReplayCallable
            {
                public Java.Lang.Object Call()
                {
                    return (Java.Lang.Object)CallForData();
                }
            }
            partial class BufferedTimedReplayCallable
            {
                public Java.Lang.Object Call()
                {
                    return (Java.Lang.Object)CallForData();
                }
            }
            partial class ReplayCallable
            {
                public Java.Lang.Object Call()
                {
                    return (Java.Lang.Object)CallForData();
                }
            }
            partial class TimedCallable
            {
                public Java.Lang.Object Call()
                {
                    return (Java.Lang.Object)CallForData();
                }
            }

            partial class BufferedTimedReplay
            {
                public Java.Lang.Object Call()
                {
                    return (Java.Lang.Object)CallForData();
                }
            }

            partial class TimedReplay
            {
                public Java.Lang.Object Call()
                {
                    return (Java.Lang.Object)CallForData();
                }
            }
            //
            partial class ItemDelayFunction
            {
                public Java.Lang.Object Apply(Java.Lang.Object Object)
                {
                    return (Java.Lang.Object)ApplyMapper(Object);

                }


            }

            partial class FlatMapWithCombinerOuter
            {
                public Java.Lang.Object Apply(Java.Lang.Object Object)
                {
                    return (Java.Lang.Object)ApplyMapper(Object);

                }


            }
            partial class FlatMapIntoIterable
            {
                public Java.Lang.Object Apply(Java.Lang.Object Object)
                {
                    return (Java.Lang.Object)ApplyMapper(Object);

                }


            }
        }

        partial class FlowableReplay
        {
            partial class ReplayBufferTask
            {
                public Java.Lang.Object Call()
                {
                    return (Java.Lang.Object)CallForData();
                }
            }
            partial class ScheduledReplayBufferTask
            {
                public Java.Lang.Object Call()
                {
                    return (Java.Lang.Object)CallForData();
                }
            }
        }
    }

    namespace IO.Reactivex.Internal.Operators.Single
    {
        partial class SingleInternalHelper
        {
            partial class NoSuchElementCallable
            {
                public Java.Lang.Object Call()
                {
                    return (Java.Lang.Object)CallForData();
                }
            }
        }
    }
    namespace IO.Reactivex.Internal.Schedulers
    {
        partial class ScheduledDirectTask
        {
            public Java.Lang.Object Call()
            {
                return (Java.Lang.Object)CallForData();
            }
        }
    }
    namespace IO.Reactivex.Internal.Operators.Single
    {
        partial class SingleInternalHelper
        {
            partial class ToFlowableIterator
            {
                public Java.Lang.Object Next()
                {
                    return (Java.Lang.Object)NextItem();
                }

            }


        }

    }
    namespace IO.Reactivex.Internal.Operators.Observable
    {

        partial class ObservableInternalHelper
        {
            partial class ObservableMapper
            {
                public Java.Lang.Object Apply(Java.Lang.Object Object)
                {
                    return (Java.Lang.Object)ApplyMapper(Object);

                }

            }

            partial class ItemDelayFunction
            {
                public Java.Lang.Object Apply(Java.Lang.Object Object)
                {
                    return (Java.Lang.Object)ApplyMapper(Object);

                }


            }

            partial class FlatMapWithCombinerOuter
            {

                public Java.Lang.Object Apply(Java.Lang.Object Object)
                {
                    return (Java.Lang.Object)ApplyMapper(Object);

                }
            }

            partial class FlatMapIntoIterable
            {

                public Java.Lang.Object Apply(Java.Lang.Object Object)
                {
                    return (Java.Lang.Object)ApplyMapper(Object);

                }
            }

        }

    }


}

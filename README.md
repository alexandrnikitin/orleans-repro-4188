# orleans-repro-
Repro code for 

To reproduce:

```
cd \samples\GoogleHashcode2018
>BuildAndRun.ps1
```

Observe Client console app output.

The following exception appears:

```
System.AggregateException: One or more errors occurred. (Named type "DMCTS.Grains.NodeView`1<Rides.MakeRideAction>" is invalid: Type string "Rides.MakeRideAction" cannot be resolved.) ---> System.TypeAccessException: Named type "DMCTS.Grains.NodeView`1<Rides.MakeRideAction>" is invalid: Type string "Rides.MakeRideAction" cannot be resolved.
   at Orleans.Serialization.BinaryTokenStreamReaderExtensinons.ReadSpecifiedTypeHeader(IBinaryTokenStreamReader this, SerializationManager serializationManager)
   at Orleans.Serialization.SerializationManager.DeserializeInner(Type expected, IDeserializationContext context)
   at Orleans.Serialization.BuiltInTypes.DeserializeOrleansResponse(Type expected, IDeserializationContext context)
   at Orleans.Serialization.SerializationManager.DeserializeInner(Type expected, IDeserializationContext context)
   at Orleans.Serialization.SerializationManager.Deserialize(Type t, IBinaryTokenStreamReader stream)
   at Orleans.Runtime.Message.GetDeserializedBody(SerializationManager serializationManager)
   at Orleans.Runtime.GrainReferenceRuntime.ResponseCallback(Message message, TaskCompletionSource`1 context)
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at Orleans.OrleansTaskExtentions.<<ToTypedTask>g__ConvertAsync4_0>d`1.MoveNext()
   --- End of inner exception stack trace ---
   at System.Threading.Tasks.Task`1.GetResultCore(Boolean waitCompletionNotification)
   at Rides.Client.Program.<DoClientWork>d__3.MoveNext() in C:\projects\my\DistributedMonteCarloTreeSearch.NET\samples\GoogleHashcode2018\Rides.Client\Program.cs:line 81
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at Rides.Client.Program.<RunMainAsync>d__1.MoveNext() in C:\projects\my\DistributedMonteCarloTreeSearch.NET\samples\GoogleHashcode2018\Rides.Client\Program.cs:line 26
---> (Inner Exception #0) System.TypeAccessException: Named type "DMCTS.Grains.NodeView`1<Rides.MakeRideAction>" is invalid: Type string "Rides.MakeRideAction" cannot be resolved.
   at Orleans.Serialization.BinaryTokenStreamReaderExtensinons.ReadSpecifiedTypeHeader(IBinaryTokenStreamReader this, SerializationManager serializationManager)
   at Orleans.Serialization.SerializationManager.DeserializeInner(Type expected, IDeserializationContext context)
   at Orleans.Serialization.BuiltInTypes.DeserializeOrleansResponse(Type expected, IDeserializationContext context)
   at Orleans.Serialization.SerializationManager.DeserializeInner(Type expected, IDeserializationContext context)
   at Orleans.Serialization.SerializationManager.Deserialize(Type t, IBinaryTokenStreamReader stream)
   at Orleans.Runtime.Message.GetDeserializedBody(SerializationManager serializationManager)
   at Orleans.Runtime.GrainReferenceRuntime.ResponseCallback(Message message, TaskCompletionSource`1 context)
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at Orleans.OrleansTaskExtentions.<<ToTypedTask>g__ConvertAsync4_0>d`1.MoveNext()<---

```

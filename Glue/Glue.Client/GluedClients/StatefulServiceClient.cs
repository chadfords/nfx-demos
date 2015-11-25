
/* Auto generated by Glue Client Compiler tool (gluec) 
on 25.11.2015 22:09:21 at PC by 1
Do not modify this file by hand if you plan to regenerate this file again by the tool as manual changes will be lost
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using NFX.Glue;
using NFX.Glue.Protocol;


namespace Glue.Contracts.Services.GluedClients
{
  ///<summary>
  /// Client for glued contract Glue.Contracts.Services.IStatefulService server.
  /// Each contract method has synchronous and asynchronous versions, the later denoted by 'Async_' prefix.
  /// May inject client-level inspectors here like so:
  ///   client.MsgInspectors.Register( new YOUR_CLIENT_INSPECTOR_TYPE());
  ///</summary>
  public class StatefulServiceClient : ClientEndPoint, @Glue.@Contracts.@Services.@IStatefulService
  {

  #region Static Members

     private static TypeSpec s_ts_CONTRACT;
     private static MethodSpec @s_ms_Init_0;
     private static MethodSpec @s_ms_Add_1;
     private static MethodSpec @s_ms_GetValue_2;
     private static MethodSpec @s_ms_Done_3;

     //static .ctor
     static StatefulServiceClient()
     {
         var t = typeof(@Glue.@Contracts.@Services.@IStatefulService);
         s_ts_CONTRACT = new TypeSpec(t);
         @s_ms_Init_0 = new MethodSpec(t.GetMethod("Init", new Type[]{  }));
         @s_ms_Add_1 = new MethodSpec(t.GetMethod("Add", new Type[]{ typeof(@System.@Int32) }));
         @s_ms_GetValue_2 = new MethodSpec(t.GetMethod("GetValue", new Type[]{  }));
         @s_ms_Done_3 = new MethodSpec(t.GetMethod("Done", new Type[]{  }));
     }
  #endregion

  #region .ctor
     public StatefulServiceClient(string node, Binding binding = null) : base(node, binding) { ctor(); }
     public StatefulServiceClient(Node node, Binding binding = null) : base(node, binding) { ctor(); }
     public StatefulServiceClient(IGlue glue, string node, Binding binding = null) : base(glue, node, binding) { ctor(); }
     public StatefulServiceClient(IGlue glue, Node node, Binding binding = null) : base(glue, node, binding) { ctor(); }

     //common instance .ctor body
     private void ctor()
     {

     }

  #endregion

     public override Type Contract
     {
       get { return typeof(@Glue.@Contracts.@Services.@IStatefulService); }
     }



  #region Contract Methods

         ///<summary>
         /// Synchronous invoker for  'Glue.Contracts.Services.IStatefulService.Init'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or RemoteExceptionData instance.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         /// RemoteException is thrown if the server generated exception during method execution.
         ///</summary>
         public void @Init()
         {
            var call = Async_Init();
            call.CheckVoidValue();
         }

         ///<summary>
         /// Asynchronous invoker for  'Glue.Contracts.Services.IStatefulService.Init'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or RemoteExceptionData instance.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg and result.
         ///</summary>
         public CallSlot Async_Init()
         {
            var request = new RequestAnyMsg(s_ts_CONTRACT, @s_ms_Init_0, false, RemoteInstance, new object[]{});
            return DispatchCall(request);
         }



         ///<summary>
         /// Synchronous invoker for  'Glue.Contracts.Services.IStatefulService.Add'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or RemoteExceptionData instance.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         /// RemoteException is thrown if the server generated exception during method execution.
         ///</summary>
         public void @Add(@System.@Int32  @value)
         {
            var call = Async_Add(@value);
            call.CheckVoidValue();
         }

         ///<summary>
         /// Asynchronous invoker for  'Glue.Contracts.Services.IStatefulService.Add'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or RemoteExceptionData instance.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg and result.
         ///</summary>
         public CallSlot Async_Add(@System.@Int32  @value)
         {
            var request = new RequestAnyMsg(s_ts_CONTRACT, @s_ms_Add_1, false, RemoteInstance, new object[]{@value});
            return DispatchCall(request);
         }



         ///<summary>
         /// Synchronous invoker for  'Glue.Contracts.Services.IStatefulService.GetValue'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning '@System.@Int32' or RemoteExceptionData instance.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         /// RemoteException is thrown if the server generated exception during method execution.
         ///</summary>
         public @System.@Int32 @GetValue()
         {
            var call = Async_GetValue();
            return call.GetValue<@System.@Int32>();
         }

         ///<summary>
         /// Asynchronous invoker for  'Glue.Contracts.Services.IStatefulService.GetValue'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or RemoteExceptionData instance.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg and result.
         ///</summary>
         public CallSlot Async_GetValue()
         {
            var request = new RequestAnyMsg(s_ts_CONTRACT, @s_ms_GetValue_2, false, RemoteInstance, new object[]{});
            return DispatchCall(request);
         }



         ///<summary>
         /// Synchronous invoker for  'Glue.Contracts.Services.IStatefulService.Done'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or RemoteExceptionData instance.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         /// RemoteException is thrown if the server generated exception during method execution.
         ///</summary>
         public void @Done()
         {
            var call = Async_Done();
            call.CheckVoidValue();
         }

         ///<summary>
         /// Asynchronous invoker for  'Glue.Contracts.Services.IStatefulService.Done'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or RemoteExceptionData instance.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg and result.
         ///</summary>
         public CallSlot Async_Done()
         {
            var request = new RequestAnyMsg(s_ts_CONTRACT, @s_ms_Done_3, false, RemoteInstance, new object[]{});
            return DispatchCall(request);
         }


  #endregion

  }//class
}//namespace

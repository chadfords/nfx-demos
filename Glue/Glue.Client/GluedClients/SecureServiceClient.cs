
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
  /// Client for glued contract Glue.Contracts.Services.ISecureService server.
  /// Each contract method has synchronous and asynchronous versions, the later denoted by 'Async_' prefix.
  /// May inject client-level inspectors here like so:
  ///   client.MsgInspectors.Register( new YOUR_CLIENT_INSPECTOR_TYPE());
  ///</summary>
  public class SecureServiceClient : ClientEndPoint, @Glue.@Contracts.@Services.@ISecureService
  {

  #region Static Members

     private static TypeSpec s_ts_CONTRACT;
     private static MethodSpec @s_ms_Echo_0;
     private static MethodSpec @s_ms_PresidentEcho_1;

     //static .ctor
     static SecureServiceClient()
     {
         var t = typeof(@Glue.@Contracts.@Services.@ISecureService);
         s_ts_CONTRACT = new TypeSpec(t);
         @s_ms_Echo_0 = new MethodSpec(t.GetMethod("Echo", new Type[]{ typeof(@System.@String) }));
         @s_ms_PresidentEcho_1 = new MethodSpec(t.GetMethod("PresidentEcho", new Type[]{ typeof(@System.@String) }));
     }
  #endregion

  #region .ctor
     public SecureServiceClient(string node, Binding binding = null) : base(node, binding) { ctor(); }
     public SecureServiceClient(Node node, Binding binding = null) : base(node, binding) { ctor(); }
     public SecureServiceClient(IGlue glue, string node, Binding binding = null) : base(glue, node, binding) { ctor(); }
     public SecureServiceClient(IGlue glue, Node node, Binding binding = null) : base(glue, node, binding) { ctor(); }

     //common instance .ctor body
     private void ctor()
     {

     }

  #endregion

     public override Type Contract
     {
       get { return typeof(@Glue.@Contracts.@Services.@ISecureService); }
     }



  #region Contract Methods

         ///<summary>
         /// Synchronous invoker for  'Glue.Contracts.Services.ISecureService.Echo'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning '@System.@String' or RemoteExceptionData instance.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         /// RemoteException is thrown if the server generated exception during method execution.
         ///</summary>
         public @System.@String @Echo(@System.@String  @message)
         {
            var call = Async_Echo(@message);
            return call.GetValue<@System.@String>();
         }

         ///<summary>
         /// Asynchronous invoker for  'Glue.Contracts.Services.ISecureService.Echo'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or RemoteExceptionData instance.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg and result.
         ///</summary>
         public CallSlot Async_Echo(@System.@String  @message)
         {
            var request = new RequestAnyMsg(s_ts_CONTRACT, @s_ms_Echo_0, false, RemoteInstance, new object[]{@message});
            return DispatchCall(request);
         }



         ///<summary>
         /// Synchronous invoker for  'Glue.Contracts.Services.ISecureService.PresidentEcho'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning '@System.@String' or RemoteExceptionData instance.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         /// RemoteException is thrown if the server generated exception during method execution.
         ///</summary>
         public @System.@String @PresidentEcho(@System.@String  @message)
         {
            var call = Async_PresidentEcho(@message);
            return call.GetValue<@System.@String>();
         }

         ///<summary>
         /// Asynchronous invoker for  'Glue.Contracts.Services.ISecureService.PresidentEcho'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or RemoteExceptionData instance.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg and result.
         ///</summary>
         public CallSlot Async_PresidentEcho(@System.@String  @message)
         {
            var request = new RequestAnyMsg(s_ts_CONTRACT, @s_ms_PresidentEcho_1, false, RemoteInstance, new object[]{@message});
            return DispatchCall(request);
         }


  #endregion

  }//class
}//namespace

 var callcontext = new CAdxCallContext();
     callcontext.codeLang = "ENG";
     callcontext.poolAlias = "BGRTEST";

     var proxy = new CAdxWebServiceXmlCCClient();
     proxy.Endpoint.EndpointBehaviors.Add(new CustomEndpoint());
     proxy.ClientCredentials.UserName.UserName = "USERNAME";
     proxy.ClientCredentials.UserName.Password = "PASSWORD";

     string inputXml = "<PARAM>" +
         "<GRP ID= \"GRP1\">" +
         "<FLD NAME = \"ITMREF\">" + "100001" + "</FLD>" +
         "</GRP>" +
         "</PARAM>";

     CAdxResultXml response;
     try
     {
         response = proxy.run(callcontext, "BGR_SIEPRO", inputXml);
     }
     catch (TimeoutException timeout)
     {
         Console.WriteLine(timeout.Message);
         // handle the timeout exception.
         proxy.Abort();
     }
     catch (CommunicationException commexception)
     {
         Console.WriteLine(commexception.Message);
         // handle the communication exception.
         proxy.Abort();
     }
     catch (Exception ex)
     {
         Console.WriteLine(ex.Message);
     }
     finally
     {
         proxy.Close();
     }
 }

 public class ClientMessageInspector : IClientMessageInspector
 {
     public void AfterReceiveReply(ref Message reply, object correlationState)
     {
         // Nothing Here
         Console.Write(reply.ToString());
     }

     public object BeforeSendRequest(ref Message request, IClientChannel channel)
     {
         HttpRequestMessageProperty httpRequestProperty = new HttpRequestMessageProperty();
         httpRequestProperty.Headers[HttpRequestHeader.Authorization] = "Basic " +
             Convert.ToBase64String(Encoding.ASCII.GetBytes("abiddle" + ":" +
                 "6t2A2b123@123"));
         request.Properties.Add(HttpRequestMessageProperty.Name, httpRequestProperty);
         return null;
     }
 }

 public class CustomEndpoint : IEndpointBehavior
 {
     public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
     {
         // Nothing here
     }

     public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
     {
         clientRuntime.ClientMessageInspectors.Add(new ClientMessageInspector());
     }

     public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
     {
         // Nothing here
     }

     public void Validate(ServiceEndpoint endpoint)
     {
         // Nothing here
     }
 }

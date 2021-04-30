namespace Adapter
{
    public class UserWebServiceClient
    {
        public string GetUserName(int userId)
        {
            return "UserName1";
        }

        //Additional methods.
        //..
        //..
        //..
    }

    public class UserServiceAdapter : IUserService
    {  
        private UserWebServiceClient _webservice;
        public UserServiceAdapter(UserWebServiceClient webservice)
        {
            _webservice = webservice;
        }
        public string GetUser(int userId)
        {
            return _webservice.GetUserName(userId);
        }
    }
}
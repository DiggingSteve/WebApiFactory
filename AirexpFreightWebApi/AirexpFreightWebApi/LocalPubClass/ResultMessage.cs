using Message = PublicClass.PublicClass.MessageInfo;

namespace AirexpFreightWebApi.LocalPubClass
{
    public class ResultMessageInfo : PublicClass.PublicClass.ResultMessageInfo
    {
        public static Message InsertDefaultWageError
        {
            get
            {
                return new Message { resultstatus = 1, resultmessage = "添加默认费用失败" };
            }
        }
         
    }
}
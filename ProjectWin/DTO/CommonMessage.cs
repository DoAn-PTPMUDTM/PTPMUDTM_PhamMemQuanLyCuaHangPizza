namespace DTO
{
    public class CommonMessage
    {
        public string message { get; set; }
        public object data { get; set; }
        public bool isSuccess => message.Equals(Constant.Success);

        public CommonMessage()
        {
            message = string.Empty;
            data = null;
        }

        private CommonMessage(string message, object data)
        {
            this.message = message;
            this.data = data;
        }


        public static CommonMessage Success(object data)
        {
            return new CommonMessage(Constant.Success, data);
        }

        public static CommonMessage Fail(object message)
        {
            return new CommonMessage(Constant.Fail, message);
        }
    }
}

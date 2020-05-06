namespace ZLoggerDemo.SinjulMSBH
{
    //? Due to the constraints of System.Text.JSON.JSONSerializer,
    //? only properties can be serialized.
    public class UserRegisteredLog
    {
        public object Id { get; internal set; }
        public object Name { get; internal set; }
    }
}

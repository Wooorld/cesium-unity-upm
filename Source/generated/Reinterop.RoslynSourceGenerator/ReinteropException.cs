#if UNITY_EDITOR_WIN
namespace Reinterop
{
    [Reinterop]
    internal class ReinteropException : System.Exception
    {
        public ReinteropException(string message) : base(message) {}

        internal static void ExposeToCPP()
        {
            ReinteropException e = new ReinteropException("message");
            string s = e.Message;
        }
    }
}
#endif
#if !UNITY_EDITOR && UNITY_ANDROID
namespace Reinterop
{
    [Reinterop]
    internal class ReinteropException : System.Exception
    {
        public ReinteropException(string message) : base(message) {}

        internal static void ExposeToCPP()
        {
            ReinteropException e = new ReinteropException("message");
            string s = e.Message;
        }
    }
}
#endif

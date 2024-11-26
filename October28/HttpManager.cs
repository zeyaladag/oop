namespace October28;
    public class HttpManager
    {
        public string Send(string url, string data)
        {
            Console.WriteLine($"send message to {url}");
            if (string.IsNullOrEmpty(url) || !url.StartsWith("https://"))
            {
                throw new InvalidUrlException(url);
            }
            return "Http OK(200)";
        }
    }

    /* we discovered how to create our own Exception in this file.
     * in order to InvalidUrlException be able to throw an Exception, it's enough to be inherited from Exception class.
     * this way, our own Exception can access some of the properties and methods.so we don't need to write pre-wrote methods again.
     * they are handled by the base type.
     * in cpp, multi inheritance is not supported. an object can only be inherited from one class.
     * but sometimes we can force it by using interface. */
    public class InvalidUrlException
        : Exception
    {
        /* base keyword points to an upper class.
         * in this example, base is Exception class.*/
        public InvalidUrlException(string url)
            : base($"invalid {url}")
        {

        }
    }
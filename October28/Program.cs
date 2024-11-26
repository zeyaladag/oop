internal class Program
    /* all exceptions are inherited from the Exception superclass.
     * this project is the beginning of inheritance concept.
     */
{
    private static void Main(string[] args)
    {
        try
        {
            double result = Div(10, 0);
            /* if there is an exception, the try block doesnt't execute rest of the code and immidately 
             * executes the catch method. we can catch different types of exceptions.
             */
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (NotFiniteNumberException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            // this catch block is default for handling all the possible errors not catched in previous catches.
            Console.WriteLine(ex.ToString());
        }
        finally {
            Console.WriteLine("you made it!");
            /* generally used for returning resources such as database or network connections, for handling memory
             * executes in every situation, if the error occurs or not
             */
        }
    }
  
    /* we can redisgn the Div class to prevent errors without using Exceptions, since they came with cost.
     */
    static Response Div(int x, int y)
    {
        if (y == 0)
        {
            return new Response
            {
                Value = 0,
                IsSuccess = false,
                ErrorMessage = "division error"
            };
        }
        return new Response
        {
            Value = x / y,
            IsSuccess = true,
            ErrorMessage = string.Empty
        };
    }
    /* we designed Response classes to return operational informations and results.
     * it is a good way to know if the operation is true or not.
     * also, we can handle errors and inform users if any error occurs. */
    static Response GetAccountInfo(int accountNumber)
    {
        return new Response
        {
            Value = new Account(),
            IsSuccess = true,
            ErrorMessage = string.Empty
        };
    }

    static Response SaveInvoice(double amount, int customerId)
    {
        // customerId undefinied
        // amount ivalid
        // amount is greater than customer limit

        return new Response
        {
            IsSuccess = false,
            Value = amount,
            ErrorMessage = "customer limit is insufficient."
        };
    }
}
class Response
{
    /* all objects are inherited from Object class. so, we can assign any object to the Value below.
     * but this is not a good practice, since we can assign wrong values that doesn't match with Value.
     * we can use generic types if we want to set constaints to Value. but it's next week's topic :3 */
   required public object Value { get; set; }
    public bool IsSuccess { get; set; }
    required public string ErrorMessage { get; set; }
}
class Account() {}  // symbolic
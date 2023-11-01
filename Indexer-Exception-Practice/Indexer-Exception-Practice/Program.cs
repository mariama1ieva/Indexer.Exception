using Indexer_Exception_Practice;
using Indexer_Exception_Practice.Controllers;
using Indexer_Exception_Practice.Exceptions;
using Indexer_Exception_Practice.Helpers.Constants;



////Library library = new Library();


////Book book = new Book();
////book.Id = 1;
////book.Name = "test1";

////library[0]=book;
////Console.WriteLine(library[0].Name);



//try
//{
//    int[] nums = new int[0];
//    nums[2] = 100;


//    int a = 6;
//    int b = 0;
//    int result = a / b;
//    Console.WriteLine(result);
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (NullReferenceException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (IndexOutOfRangeException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//finally
//{
//    Console.WriteLine("Salam");
//}


//static void Register(string username, string password)
//{
//    bool isSuccess=false;
//    try
//    {
//        if (username == "semed123")
//        {
//            Console.WriteLine(AccountMessages.RegisterSuccess);
//            isSuccess = true;
//        }
//        else
//        {
//            throw new RegisterFailedExceptions(AccountMessages.RegisterFailed);
//        }
//    }
//    catch(Exception ex)
//    {
//        Console.WriteLine(ex.Message);
//    }
//    finally
//     {
//        SendEmail(isSuccess);
//     }

//////}

//Register("semed123", "asdasd");
//static void SendEmail(bool isSuccess)
//{
//    if(isSuccess)
//    {
//        Console.WriteLine(AccountMessages.RegisterEmailSuccess);
//    }
//    else
//    {
//        Console.WriteLine(AccountMessages.RegisterEmailFailed);
//    }
//}


PersonController personController = new PersonController();

personController.GetById();





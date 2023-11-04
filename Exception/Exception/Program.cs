using Exception;
 

//Repository<Person> data=new Repository<Person>();
//data.Add(new Person { Age=22,Name="Meryem",Surname="Aliyeva",Id=1});
//data.Add(new Person { Age = 23, Name = "Haci", Surname = "Ahmedov", Id = 5 });
//data.Add(new Person { Age = 28, Name = "Tofiq", Surname = "Nasibli", Id = 11 });


//TASK1
//var datas = data.GetById(11);
//foreach (Person person in datas)
//{
//    Console.WriteLine($"{person.Name},{person.Surname},{person.Age}");
//}


//TASK2
//var datas = data.Delete(11);
//foreach(Person person in datas)
//{
//    Console.WriteLine($"{person.Name},{person.Surname},{person.Age}");
//}



//TASK3
try
{
    int a =int.Parse(Console.ReadLine());
    
    if (a>0)
    {

        int factorial = 1;
        for (int i = 1; i <= a; i++)
        {
            factorial *= i;
        }
    }
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}






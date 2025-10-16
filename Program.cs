/*using System;

class Book
{
    public string title;
    public string author;
    public int pages;

    public static void Main()
    {
        Book firstBook = new Book();
        firstBook.title = "Harry Potter";
        firstBook.author = "J.K Rowling";
        firstBook.pages = 432;

        Book secondBook = new Book();
        secondBook.title = "Lord of The Rings";
        secondBook.author = "J.J.R Tolkien";
        secondBook.pages = 604;
        
        Console.WriteLine($"Title: {firstBook.title}, Author: {firstBook.author}, Pages: {firstBook.pages}");
        Console.WriteLine($"Title: {secondBook.title}, Author: {secondBook.author}, Pages: {secondBook.pages}");
    }
}*/

using System;


//  ---------- TEST AV CONOSTRUCTOR, EJ KLAR, ORKADE INTE OCH VAR INTE EN DEL
// ------------ AV UPPGIFTEN!
class Student
{
    public string name;
    public int age;
    public string favoriteSubject;

    public Book(string title, int age, string favoriteSubject)
    {
        this.title = title;
        this.age = age;
        this.favoriteSubject = favoriteSubject;

    }
}

/*public static void Main()
{
    Student firstStudent = new Student();
    Student secondStudent = new Student();
    Student thirdtudent = new Student();


    firstStudent.name = "Hanna";
    firstStudent.age = 22;
    firstStudent.favoriteSubject = "Art";

    secondStudent.name = "William";
    secondStudent.age = 34;
    secondStudent.favoriteSubject = "Music";

    thirdtudent.name = "Noah";
    thirdtudent.age = 5;
    thirdtudent.favoriteSubject = "Games";

    Console.WriteLine($"Name: {firstStudent.name}, age: {firstStudent.age}, Favorite: {firstStudent.favoriteSubject}");
}
}*/
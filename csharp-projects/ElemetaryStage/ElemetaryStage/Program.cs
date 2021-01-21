//using ElemetaryStage.Models;
using System;

#region Task 3
/*
 * Создать класс Book. Создать классы Title, Author и Content, каждый из которых должен содержать
 * одно строковое поле и метод  void Show().
 * Реализуйте возможность добавления в книгу названия книги, имени автора и содержания.
 * Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и
 * содержание.
 */
#endregion



namespace ElemetaryStage
{
    public class Program
    {
        public class Book
        {
            public Title Title { get; set; } = new Title();

            public Author Author { get; set; } = new Author();

            public Content Content { get; set; } = new Content();


            public Book(string title, string author)
            {
                Title.c = title;
            }

            private 
        }


        public class Title
        {
            private string text;

            public string Text
            {
                get 
                {
                    if (String.IsNullOrWhiteSpace(text)) throw new NullReferenceException("Title text couldn be null or empty.");
                    
                    return text; 
                }
                set { text = value; }
            }


            public void Show()
            {
                
            }

            public override string ToString()
            {
                return Text;
            }
        }


        public class Author
        {
            private string content;

            public void Show()
            {
                throw new NotImplementedException();
            }
        }


        public class Content
        {
            private string content;

            public void Show()
            {
                throw new NotImplementedException();
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.ReadLine();
        }
    }
}

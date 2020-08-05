using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class Library
    {
        //В теле Library создайте приватное поле типа Book.
        //В Library создайте пользовательский конструктор, принимающий название книги и автора, и создающий некую книгу.
        //Также в Library создайте конструктор по умолчанию, инициализирующий поля класса.
        //В теле метода Main создайте два экземпляра класса Library - с использованием конструктора по умолчанию
        //и с использованием пользовательского конструктора. Выведите на экран данные по содержащимся в библиотеках книгам.

        private Book someBook;


        public Library(): this("NoName", "NoName")
        {

        }

        public Library(string bookName, string bookAuthor)
        {
            someBook = InitBook(bookName, bookAuthor);
        }

        private Book InitBook(string bookName, string bookAuthor) => new Book() { BookName = bookName, Author = bookAuthor };

        public override string ToString()
        {
            return $"{someBook.BookName} - {someBook.Author}";
        }
    }
}

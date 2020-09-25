using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class Book
    {
        //Создайте класс Book отдельным файлом.
        //В классе Book создайте закрытые поля author и bookName.
        //Создайте свойства для доступа к этим полям.Создайте класс Library отдельным файлом.

        private string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        private string bookName;

        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }



    }
}

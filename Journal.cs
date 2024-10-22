using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace hw
{
    public class Journal
    {
//         Задание 5
// Создайте класс «Журнал». Необходимо хранить в полях класса: 
// название журнала, год основания, описание журнала, контактный телефон, контактный e-mail.
// Реализуйте методы класса для ввода данных, вывода данных,
//  реализуйте доступ к отдельным полям через методы класса.


// Задание 1
// Ранее в одном из практических заданий вы создавали класс «Журнал». 
// Добавьте к уже созданному классу информацию о количестве сотрудников. 
// Выполните перегрузку + (для увеличения количества сотрудников на указанную 
// величину), - (для уменьшения количества сотрудников на указанную величину),
//  == (проверка на равенство количества сотрудников), < и > (проверка на меньше
//   или больше количества сотрудников), != и Equals. Используйте механизм свойств для полей класса.

public string Name { get; set; }
public int Year { get; set; }
public string Description { get; set; }
public string Phone { get; set; }
public string Email { get; set; }
public int Count { get; set; }


public Journal(){
    Name = "";
    Year = 0;
    Description = "";
    Phone = "";
    Email = "";
    Count = 0;
}

public Journal(string name, int year, string description, string phone, string email, int count){
    Name = name;
    Year = year;
    Description = description;
    Phone = phone;
    Email = email;
    Count = count;
}



public void Input(){
    WriteLine("введите название: ");
    string name = ReadLine();
    Name = name;
    

    WriteLine("введите год: ");
    string year = ReadLine();
    int y = int.Parse(year);
    Year = y;


    WriteLine("введите описание: ");
    string description = ReadLine();
    Description = description;
    


    WriteLine("введите контактный номер телефона: ");
    string phone = ReadLine();
    Phone = phone;



    WriteLine("введите контактную электронную почту: ");
    string email = ReadLine();
    Email = email;



     WriteLine("введите количество сотрудников: ");
    string count = ReadLine();
    int c = int.Parse(count);
    Count = c;

}


public void Print(){
    Write("название: " + Name + " " + "год: " + Year + " " + "описание: " + Description + " " + "телефон: " + Phone + " " + "почта: " + Email + " " + "количество сотрудников: " + Count + "\n");
}


public static Journal operator -(Journal obj1, Journal obj2){
    Journal result = new Journal{
        Count = obj1.Count - obj2.Count
    };

    return result;
}

public static Journal operator -(Journal obj, int number){

    Journal result = new Journal();
       

        if (number < obj.Count)
        {
            result.Count = obj.Count - number;
        }
        else
        {
            result.Count = 0; 
        }


    return result;
}


public static Journal operator +(Journal obj1, Journal obj2){
    Journal result = new Journal{
        Count = obj1.Count + obj2.Count
    };

return result;

}
    public static Journal operator +(Journal obj, int number){
        Journal result = new Journal();
        result.Count = obj.Count + number;
            return result;
    }


public static bool operator !=(Journal obj1, Journal obj2){

    if(obj1.Name != obj2.Name && obj1.Count != obj2.Count && obj1.Year != obj2.Year){
        return true;
    }
          else return false;
}



public static bool operator ==(Journal obj1, Journal obj2){

    if(obj1.Name == obj2.Name && obj1.Count == obj2.Count && obj1.Year == obj2.Year){
        return true;
    }
          else return false;
}


public static bool operator >(Journal obj1, Journal obj2){
    if(obj1.Count > obj2.Count){
        return true;
    }
    else return false;
}

public static bool operator <(Journal obj1, Journal obj2){
    if(obj1.Count < obj2.Count){
        return true;
    }
    else return false;
}

public override bool Equals(object obj)
    {
   
   
        if (obj == null)
        {
            return false;
        }

        Journal result = (Journal)obj;
        return Count == result.Count;
    }

    }
}
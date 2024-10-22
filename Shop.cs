using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using static System.Console;

namespace hw
{
    public class Shop
    {
//         Задание 6
// Создайте класс «Магазин». Необходимо хранить в полях класса:
//  название магазина, адрес, описание профиля магазина, контактный телефон, контактный e-mail.
// Реализуйте методы класса для ввода данных, вывода данных,
//  реализуйте доступ к отдельным полям через методы класса.

// Задание 2
// Ранее в одном из практических заданий вы создавали класс «Магазин».
//  Добавьте к уже созданному классу информацию о площади магазина. 
//  Выполните перегрузку + (для увеличения площади магазина на указанную величину),
//   — (для уменьшения площади магазина на указанную величину),
//    == (проверка на равенство площадей магазинов), < и > (проверка на меньше или больше площади магазина), 
/// <summary>
/// /  != и Equals. Используйте механизм свойств для полей класса.
/// </summary>


public string Name { get; set; }
public string Location { get; set; }
public string Description { get; set; }
public string Phone { get; set; }
public string Email { get; set; }
public double Area { get; set; }


public Shop(){
    Name = "";
    Location = "";
    Description = "";
    Phone = "";
    Email = "";
    Area = 0;
}


public Shop(string name, string location, string description, string phone, string email, double area){
    Name = name;
    Location = location;
    Description = description;
    Phone = phone;
    Email = email;
    Area = area;
}


public void Input(){
    WriteLine("введите название: ");
    string name = ReadLine();
    Name = name;


    WriteLine("введите адрес: ");
    string adress = ReadLine();
    Location = adress;


    WriteLine("введите описание: ");
    string description = ReadLine();
    Description = description;
    


    WriteLine("введите контактный номер телефона: ");
    string phone = ReadLine();
    Phone = phone;



    WriteLine("введите контактную электронную почту: ");
    string email = ReadLine();
    Email = email;



  WriteLine("введите метраж пространства: ");
    string area = ReadLine();
    double a = double.Parse(area);
    Area = a;
    

}


public void Print(){
    Write("название: " + Name + " " + "адрес: " + Location + " " + "описание: " + Description + " " + "телефон: " + Phone + " " + "почта: " + Email +  " " + "площадь: " + Area + "\n");
}



public static Shop operator +(Shop shop, double area){

    Shop result = new Shop();
    result.Area = shop.Area + area;
    return result;
}


public static Shop operator -(Shop shop, double area){

    Shop result = new Shop();
    if(shop.Area > area){
    result.Area = shop.Area - area;
    }
    return result;
}

public static bool operator ==(Shop shop, Shop shop1){
   if(shop.Area == shop1.Area){
    return true;
   }
   else return false;

}


public static bool operator !=(Shop shop, Shop shop1){
   if(shop.Area != shop1.Area){
    return true;
   }
   else return false;

}


public static bool operator >(Shop shop, Shop shop2){
    if(shop.Area > shop2.Area){
        return true;
    }
    else return false;
}

public static bool operator <(Shop shop, Shop shop2){
    if(shop.Area < shop2.Area){
        return true;
    }
    else return false;
}


public override bool Equals(object obj){
    Shop shop = obj as Shop;

      if (shop == null)
    {
        return false;
    }

     return Name == shop.Name && Location == shop.Location;
}



    }
}
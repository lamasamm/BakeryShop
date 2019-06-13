using myBakeryShop.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace myBakeryShop
{
    class DisplayItemVM
    {
        public ObservableCollection<Item> itemlist {  get; set;}

        public DisplayItemVM() {

            itemlist = new ObservableCollection<Item>()
            {

             new Item(){ItemName=" Cinamon bun" , Price = "7 SR" , Image= "buns.jpg" ,Calories = "170 kcal" , Discription =" A very Fluffy dough that is rolled with suger and cinammon and paked tto perfection"},
             new Item(){ItemName=" Pretzel" , Price = "7 SR" , Image= "pretz.jpg" , Calories = "100 kcal" , Discription =" A Saviory dough that is light and perfect as a quick breakfast"},
             new Item(){ItemName=" Lemon Cake" , Price = "15 SR" , Image= "cake.jpg",Calories = "200 kcal" , Discription =" is all whats your sweet tooth NEED!" },
             new Item(){ItemName=" Chocolate doughnut" , Price = "5 SR" , Image= "D2.jpg" ,Calories = "160 kcal" , Discription =" Classic chocolate doughnut that will never let you down!"},
             new Item(){ItemName=" no carb Lemon Cake" , Price = "15 SR" , Image= "cake2.jpg" , Calories = "70 kcal" , Discription =" all whats your sweet tooth need and its low carb, Hurry and order !!"},
             new Item(){ItemName=" BlueBerry Muffin" , Price = "5 SR" , Image= "muffen.jpg" , Calories = "170 kcal" , Discription =" made with the finest eastren berries"},
             new Item(){ItemName=" Butter croissant" , Price = "10 SR" , Image= "caro.jpg",Calories = "250 kcal" , Discription ="Classic french recipe croissant and made to suit everybody " }

             

            };
        }

       

    }
}

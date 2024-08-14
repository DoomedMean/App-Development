using App.Model;
using Microsoft.Maui.Controls;

namespace App.View;

public partial class DetailPage : ContentPage
{
    public DetailPage()
    {
        InitializeComponent();
    }

    List<Item> ItemList = new List<Item>
    {
        new Item{Id = 0, Name = "Ramen", Rating = 4.3f, Price = 250, Shop = "John" },
        new Item{Id = 1, Name = "Fried Rice", Rating = 3.8f, Price = 100, Shop = "Resyu" },
        new Item{Id = 2, Name = "Toy", Rating = 3.2f, Price = 350, Shop = "Tim" },
        new Item{Id = 3, Name = "Computer", Rating = 3.3f, Price = 15000, Shop = "Boigg" },
        new Item{Id = 4, Name = "Stationery", Rating = 1.3f, Price = 50-200, Shop = "Zynn" },
        new Item{Id = 5, Name = "Drink", Rating = 1.8f, Price = 100-200, Shop = "Lotvk" },
        new Item{Id = 6, Name = "Shoes", Rating = 2.1f, Price = 1000, Shop = "Poiiny" },
        new Item{Id = 7, Name = "Nintendo Switch", Rating = 3f, Price = 13000, Shop = "Weyya" },
    }
        ;

    private void Buy_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("ERROR", "NOT CONFIGURED YET", "OK");
    }
}
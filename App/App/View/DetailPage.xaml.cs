using App.Model;
using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace App.View;

[QueryProperty(nameof(ID), "Id")]
public partial class DetailPage : ContentPage
{
    public int ID {  get; set; } //retrieve from other page
    
    public ObservableCollection<Item> Items { get; set; }

    public DetailPage()
    {
        InitializeComponent();

        Items = new ObservableCollection<Item>
        {
            new Item{Id = 0, Name = "Ramen", Rating = 4.3f, Price = "250", Shop = "John", ImagePath="ramen.jpeg" },
            new Item{Id = 1, Name = "Fried Rice", Rating = 3.8f, Price = "100", Shop = "Resyu", ImagePath="fried_rice.jpeg"  },
            new Item{Id = 2, Name = "Toy", Rating = 3.2f, Price = "350", Shop = "Tim", ImagePath="toy.jpeg"  },
            new Item{Id = 3, Name = "Computer", Rating = 3.3f, Price = "15000", Shop = "Boigg", ImagePath="computer.jpg"  },
            new Item{Id = 4, Name = "Stationery", Rating = 1.3f, Price = "50-200", Shop = "Zynn", ImagePath="stationery.jpeg"  },
            new Item{Id = 5, Name = "Drink", Rating = 1.8f, Price = "100-200", Shop = "Lotvk", ImagePath="drink.jpeg"  },
            new Item{Id = 6, Name = "Shoes", Rating = 2.1f, Price = "1000", Shop = "Poiiny", ImagePath="shoes.webp"  },
            new Item{Id = 7, Name = "Nintendo Switch", Rating = 3f, Price = "13000", Shop = "Weyya", ImagePath="nintendo_switch.jpeg"  },
        };
    }

    private void Buy_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("ERROR", "NOT CONFIGURED YET", "OK");
    }

    protected override void OnAppearing() // This method will be triggered when the page appears

    {
        base.OnAppearing();

        var selectedItem = Items.FirstOrDefault(item => item.Id == ID);
        if (selectedItem != null)
        {
            BindingContext = selectedItem;
        }
    }
}
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using zadanie_19_01_2024_BETTER.Components;

namespace zadanie_19_01_2024_BETTER;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    
    }

    public void createStars(object sender, int amount)
    {

        if (sender is HorizontalStackLayout horizontal)
        {
            for (int i = 0; i < amount; i++)
            {
                Image img = new Image
                {
                    Source = "star.svg",
                    WidthRequest = 25,
                    HeightRequest = 25
                };
                horizontal.Children.Add(img);
            }
        }
    }

    private void first_Loaded(object sender, EventArgs e)
    {
        createStars(sender, 2);
    }

    private void second_Loaded(object sender, EventArgs e)
    {
        createStars(sender, 5);
    }

    private void third_Loaded(object sender, EventArgs e)
    {
        createStars(sender, 4);
    }

    private void fourth_Loaded(object sender, EventArgs e)
    {
        createStars(sender, 3);
    }
}




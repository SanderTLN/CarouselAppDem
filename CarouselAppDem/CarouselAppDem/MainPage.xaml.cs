using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselAppDem
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            var minecraftPage = new ContentPage
            {
                Content = new StackLayout
                {
                    BackgroundColor = Color.Wheat,
                    Children =
                    {
                        new Label
                        {
                            Text = "Minecraft",
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                            TextColor = Color.Green,
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                        {
                            WidthRequest = 300,
                            HeightRequest = 300,
                            Source = "minecraft.png",
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.CenterAndExpand
                        },
                        new Button
                        {
                            Text = "Тест",
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Button)),
                            BackgroundColor = Color.Gray,
                            TextColor = Color.Orange,
                            WidthRequest = 160,
                            HeightRequest = 60,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.EndAndExpand
                        }
                    }
                }
            };
            var gtavPage = new ContentPage
            {
                Content = new StackLayout
                {
                    BackgroundColor = Color.Wheat,
                    Children =
                    {
                        new Label
                        {
                            Text = "GTA V",
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                            TextColor = Color.Green,
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                        {
                            WidthRequest = 300,
                            HeightRequest = 300,
                            Source = "gtav.png",
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.CenterAndExpand
                        },
                        new Button
                        {
                            Text = "Тест",
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Button)),
                            BackgroundColor = Color.Gray,
                            TextColor = Color.Orange,
                            WidthRequest = 160,
                            HeightRequest = 60,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.EndAndExpand
                        }
                    }
                }
            };
            var farcryPage = new ContentPage
            {
                Content = new StackLayout
                {
                    BackgroundColor = Color.Wheat,
                    Children =
                    {
                        new Label
                        {
                            Text = "Far Cry 5",
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                            TextColor = Color.Green,
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                        {
                            WidthRequest = 300,
                            HeightRequest = 300,
                            Source = "farcry.png",
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.CenterAndExpand
                        },
                        new Button
                        {
                            Text = "Тест",
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Button)),
                            BackgroundColor = Color.Gray,
                            TextColor = Color.Orange,
                            WidthRequest = 160,
                            HeightRequest = 60,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.EndAndExpand
                        }
                    }
                }
            };
            var falloutPage = new ContentPage
            {
                Content = new StackLayout
                {
                    BackgroundColor = Color.Wheat,
                    Children =
                    {
                        new Label
                        {
                            Text = "Fallout 4",
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                            TextColor = Color.Green,
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                        {
                            WidthRequest = 300,
                            HeightRequest = 300,
                            Source = "fallout.png",
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.CenterAndExpand
                        },
                        new Button
                        {
                            Text = "Тест",
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Button)),
                            BackgroundColor = Color.Gray,
                            TextColor = Color.Orange,
                            WidthRequest = 160,
                            HeightRequest = 60,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.EndAndExpand
                        }
                    }
                }
            };
            var warcraftPage = new ContentPage
            {
                Content = new StackLayout
                {
                    BackgroundColor = Color.Wheat,
                    Children =
                    {
                        new Label
                        {
                            Text = "Warcraft 3",
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                            TextColor = Color.Green,
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                        {
                            WidthRequest = 300,
                            HeightRequest = 300,
                            Source = "warcraft.png",
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.CenterAndExpand
                        },
                        new Button
                        {
                            Text = "Тест",
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Button)),
                            BackgroundColor = Color.Gray,
                            TextColor = Color.Orange,
                            WidthRequest = 160,
                            HeightRequest = 60,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.EndAndExpand
                        }
                    }
                }
            };
            var halflifePage = new ContentPage
            {
                Content = new StackLayout
                {
                    BackgroundColor = Color.Wheat,
                    Children =
                    {
                        new Label
                        {
                            Text = "Half-Life 2",
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                            TextColor = Color.Green,
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                        {
                            WidthRequest = 300,
                            HeightRequest = 300,
                            Source = "halflife.png",
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.CenterAndExpand
                        },
                        new Button
                        {
                            Text = "Тест",
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Button)),
                            BackgroundColor = Color.Gray,
                            TextColor = Color.Orange,
                            WidthRequest = 160,
                            HeightRequest = 60,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.EndAndExpand
                        }
                    }
                }
            };
            Children.Add(minecraftPage);
            Children.Add(gtavPage);
            Children.Add(farcryPage);
            Children.Add(falloutPage);
            Children.Add(warcraftPage);
            Children.Add(halflifePage);
        }
    }
}
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
                        new Label
                        {
                            Text = "Minecraft  — это строительная игра жанра «песочница», вдохновлённая Infiniminer, Dwarf Fortress и Dungeon Keeper и созданная Маркусом Перссоном, основателем Mojang AB." +
                            " Игра позволяет игрокам создавать и разрушать различные блоки и использовать предметы в трёхмерном окружении." +
                            " Игрок может создавать фантастические строения и художественные работы в одиночку или с другими игроками на сервере в различных игровых режимах.",
                            FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
                            TextColor = Color.Green,
                            Margin = 10,
                            HorizontalTextAlignment = TextAlignment.Center,
                            HorizontalOptions = LayoutOptions.Center
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
                            Text = "Grand Theft Auto V",
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
                        new Label
                        {
                            Text = "Grand Theft Auto V (сокр. GTA V) — мультиплатформенная компьютерная игра в жанре action-adventure с открытым миром, разработанная компанией Rockstar North и изданная компанией Rockstar Games." +
                            " Изначально игра была выпущена для игровых консолей PlayStation 3 и Xbox 360 в 2013 году, в 2014 году переиздана для PlayStation 4 и Xbox One, а в 2015 году — для персональных компьютеров под управлением Windows." +
                            " Является пятнадцатой по счёту игрой серии Grand Theft Auto и следующей крупной игрой после Grand Theft Auto IV, выпущенной в 2008 году." +
                            " В России и СНГ издателем Grand Theft Auto V выступает компания 1С-СофтКлаб.",
                            FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
                            TextColor = Color.Green,
                            Margin = 10,
                            HorizontalTextAlignment = TextAlignment.Center,
                            HorizontalOptions = LayoutOptions.Center
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
                        new Label
                        {
                            Text = "Far Cry 5 — компьютерная игра в жанре шутера от первого лица и action-adventure, разработанная студией Ubisoft Montreal и изданная компанией Ubisoft." +
                            " Является пятой основной игрой из одноимённой серии игр." +
                            " Действие игры происходит в округе Хоуп, штат Монтана, и повествует о противостоянии помощника шерифа и культа судного дня под названием «Врата Эдема»." +
                            " Far Cry 5 была выпущена в 2018 году на платформах Windows, PlayStation 4 и Xbox One.",
                            FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
                            TextColor = Color.Green,
                            Margin = 10,
                            HorizontalTextAlignment = TextAlignment.Center,
                            HorizontalOptions = LayoutOptions.Center
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
                        new Label
                        {
                            Text = "Fallout 4 — компьютерная игра в жанре Action RPG, разработанная Bethesda Game Studios и изданная Bethesda Softworks." +
                            " Является частью серии Fallout." +
                            " Игра была выпущена 10 ноября 2015 года на Windows, PlayStation 4 и Xbox One." +
                            " Локализатор на территории России и СНГ — компания СофтКлаб.",
                            FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
                            TextColor = Color.Green,
                            Margin = 10,
                            HorizontalTextAlignment = TextAlignment.Center,
                            HorizontalOptions = LayoutOptions.Center
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
                        new Label
                        {
                            Text = "Warcraft III — компьютерная игра в жанре стратегии в реальном времени с элементами MMORPG." +
                            " Разработана компанией Blizzard Entertainment при поддержке Vivendi Universal и выпущена в июле 2002 года." +
                            " В Дальнейшем в 2003 году для игры было выпущено дополнение Warcraft III: the Frozen Throne." +
                            " Игра продолжает события предыдущей игры серии Warcraft II.",
                            FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
                            TextColor = Color.Green,
                            Margin = 10,
                            HorizontalTextAlignment = TextAlignment.Center,
                            HorizontalOptions = LayoutOptions.Center
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
                        new Label
                        {
                            Text = "Half-Life 2 — компьютерная игра, научно-фантастический шутер от первого лица, сиквел Half-Life, разработанный компанией Valve, издаваемый ими же и Sierra Entertainment." +
                            " Игра была выпущена в 2004 году, получила всеобщее признание и собрала множество наград и более 45 титулов «Игра года 2004»." +
                            " В 2012 году Half-life 2 была награждена на Spike VGA 10 (Spike Video Game Awards) как лучшая игра десятилетия.",
                            FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
                            TextColor = Color.Green,
                            Margin = 10,
                            HorizontalTextAlignment = TextAlignment.Center,
                            HorizontalOptions = LayoutOptions.Center
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselAppDem
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : CarouselPage
    {
        Button btn1, btn2, btn3, btn4, btn5, btn6;
        public MainPage()
        {
            btn1 = new Button();
            btn1.Text = "Тест по игре";
            btn1.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));
            btn1.BackgroundColor = Color.Gray;
            btn1.TextColor = Color.Orange;
            btn1.WidthRequest = 160;
            btn1.HeightRequest = 60;
            btn1.Margin = 5;
            btn1.Clicked += Btn1_Clicked;

            btn2 = new Button();
            btn2.Text = "Тест по игре";
            btn2.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));
            btn2.BackgroundColor = Color.Gray;
            btn2.TextColor = Color.Orange;
            btn2.WidthRequest = 160;
            btn2.HeightRequest = 60;
            btn2.Margin = 5;
            btn2.Clicked += Btn2_Clicked;

            btn3 = new Button();
            btn3.Text = "Тест по игре";
            btn3.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));
            btn3.BackgroundColor = Color.Gray;
            btn3.TextColor = Color.Orange;
            btn3.WidthRequest = 160;
            btn3.HeightRequest = 60;
            btn3.Margin = 5;
            btn3.Clicked += Btn3_Clicked;

            btn4 = new Button();
            btn4.Text = "Тест по игре";
            btn4.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));
            btn4.BackgroundColor = Color.Gray;
            btn4.TextColor = Color.Orange;
            btn4.WidthRequest = 160;
            btn4.HeightRequest = 60;
            btn4.Margin = 5;
            btn4.Clicked += Btn4_Clicked;

            btn5 = new Button();
            btn5.Text = "Тест по игре";
            btn5.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));
            btn5.BackgroundColor = Color.Gray;
            btn5.TextColor = Color.Orange;
            btn5.WidthRequest = 160;
            btn5.HeightRequest = 60;
            btn5.Margin = 5;
            btn5.Clicked += Btn5_Clicked;

            btn6 = new Button();
            btn6.Text = "Тест по игре";
            btn6.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));
            btn6.BackgroundColor = Color.Gray;
            btn6.TextColor = Color.Orange;
            btn6.WidthRequest = 160;
            btn6.HeightRequest = 60;
            btn6.Margin = 5;
            btn6.Clicked += Btn6_Clicked;

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
                        btn1
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
                        btn2
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
                        btn3
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
                        btn4
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
                        btn5
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
                        btn6
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

        private void Btn6_Clicked(object sender, EventArgs e)
        {
            Uri halflife = new Uri("https://vgtimes.ru/tests/36-test-naskolko-horosho-ty-znaesh-mir-half-life.html");
            Browser.OpenAsync(halflife);
        }

        private void Btn5_Clicked(object sender, EventArgs e)
        {
            Uri warcraft = new Uri("https://www.cybersport.ru/warcraft-iii/articles/naskolko-khorosho-vy-pomnite-originalnuyu-warcraft-iii-test-ot-cybersport-ru");
            Browser.OpenAsync(warcraft);
        }

        private void Btn4_Clicked(object sender, EventArgs e)
        {
            Uri fallout = new Uri("https://vgtimes.ru/tests/48-test-naskolko-horosho-ty-znaesh-igry-fallout.html");
            Browser.OpenAsync(fallout);
        }

        private void Btn3_Clicked(object sender, EventArgs e)
        {
            Uri farcry = new Uri("https://vgtimes.ru/tests/51-test-naskolko-horosho-ty-znaesh-seriyu-far-cry.html");
            Browser.OpenAsync(farcry);
        }

        private void Btn2_Clicked(object sender, EventArgs e)
        {
            Uri gta = new Uri("https://ustaliy.ru/test-kto-ty-iz-gta-5/");
            Browser.OpenAsync(gta);
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            Uri minecraft = new Uri("https://ustaliy.ru/snax_quiz/test-kak-horosho-ty-znaesh-minecraft/");
            Browser.OpenAsync(minecraft);
        }
    }
}

namespace Торты
{

    internal class Program
    {
        static List<punkt> forma = new List<punkt>();
        static List<punkt> glazur = new List<punkt>();
        static List<punkt> razmer = new List<punkt>();
        static List<punkt> vkus = new List<punkt>();
        static List<punkt> number = new List<punkt>();
        static List<punkt> decor = new List<punkt>();

        static int fullPrice = 0;
        static string fullZakaz = "";
        static void Main(string[] args)
        {

            punkt krug = new punkt();
            krug.name = "  Круг";
            krug.price = 100;
            forma.Add(krug);
            punkt kvadrat = new punkt();
            kvadrat.name = "  Квадрат";
            kvadrat.price = 150;
            forma.Add(kvadrat);
            punkt heart = new punkt();
            heart.name = "  Сердце";
            heart.price = 300;
            forma.Add(heart);
            punkt triangle = new punkt();
            triangle.name = "  Треугольник";
            triangle.price = 200;
            forma.Add(triangle);

            punkt chocolate = new punkt();
            chocolate.name = "  Шоколад";
            chocolate.price = 300;
            glazur.Add(chocolate);
            punkt cream = new punkt();
            cream.name = "  Крем";
            cream.price = 400;
            glazur.Add(cream);
            punkt beze = new punkt();
            beze.name = "  Бизе";
            beze.price = 500;
            glazur.Add(beze);
            punkt vanil = new punkt();
            vanil.name = "  Ваниль";
            vanil.price = 200;
            glazur.Add(vanil);

            punkt big = new punkt();
            big.name = "  Большой";
            big.price = 3000;
            razmer.Add(big);
            punkt normal = new punkt();
            normal.name = "  Средний";
            normal.price = 1500;
            razmer.Add(normal);
            punkt small = new punkt();
            small.name = "  Маленький";
            small.price = 800;
            razmer.Add(small);

            punkt choco = new punkt();
            choco.name = "  Шоколад";
            choco.price = 500;
            vkus.Add(choco);
            punkt strawberry = new punkt();
            strawberry.name = "  Клубника";
            strawberry.price = 700;
            vkus.Add(strawberry);
            punkt vanilla = new punkt();
            vanilla.name = "  Ваниль";
            vanilla.price = 500;
            vkus.Add(vanilla);
            punkt caramel = new punkt();
            caramel.name = "  Карамель";
            caramel.price = 800;
            vkus.Add(caramel);

            punkt onekorg = new punkt();
            onekorg.name = "  1 корж";
            onekorg.price = 300;
            number.Add(onekorg);
            punkt twokorg = new punkt();
            twokorg.name = "  2 коржа";
            twokorg.price = 600;
            number.Add(twokorg);
            punkt threekorg = new punkt();
            threekorg.name = "  3 коржа";
            threekorg.price = 900;
            number.Add(threekorg);
            punkt fourkorg = new punkt();
            fourkorg.name = "  4 коржа";
            fourkorg.price = 1200;
            number.Add(fourkorg);

            punkt slivki = new punkt();
            slivki.name = "  Взбитые сливки";
            slivki.price = 300;
            decor.Add(slivki);
            punkt yagoda = new punkt();
            yagoda.name = "  Ягоды";
            yagoda.price = 300;
            decor.Add(yagoda);
            punkt bezeshka = new punkt();
            bezeshka.name = "  Безе";
            bezeshka.price = 500;
            decor.Add(bezeshka);

            while (true)
            {
                Console.WriteLine("  Вас приветствует кондитерская Мирабель. Соберите свой заказ. ");
                Console.WriteLine("  Форма торта");
                Console.WriteLine("  Размер торта");
                Console.WriteLine("  Вкус коржей");
                Console.WriteLine("  Количество коржей");
                Console.WriteLine("  Глазурь");
                Console.WriteLine("  Декор");
                Console.WriteLine("  Конец заказа");
                Console.WriteLine("Заказ:" + fullZakaz);
                Console.WriteLine("Цена:" + fullPrice);
                Zakaz zakaz = new Zakaz(1, 7);
                int pos = zakaz.Show();


                if (pos == 1)
                {
                    Console.Clear();
                        foreach (var item in forma)
                        {
                            Console.WriteLine("  " + item.name + " - " + item.price);
                        }
                    Zakaz zakaz1 = new Zakaz(0, 3);
                    pos = zakaz1.Show();

                    fullPrice += forma[pos].price;
                    fullZakaz += forma[pos].name;
                }

                else if (pos == 5)
                {
                    Console.Clear();
                    foreach (var item in glazur)
                    {
                        Console.WriteLine("  " + item.name + " - " + item.price);
                    }
                    Zakaz zakaz2 = new Zakaz(0, 3);
                    pos = zakaz2.Show();

                    fullPrice += glazur[pos].price;
                    fullZakaz += glazur[pos].name;
                }

                else if (pos == 2)
                {
                    Console.Clear();
                    foreach (var item in razmer)
                    {
                        Console.WriteLine("  " + item.name + " - " + item.price);
                    }
                    Zakaz zakaz3 = new Zakaz(0, 2);
                    pos = zakaz3.Show();

                    fullPrice += razmer[pos].price;
                    fullZakaz += razmer[pos].name;
                }

                else if (pos == 3)
                {
                    Console.Clear();
                    foreach (var item in vkus)
                    {
                        Console.WriteLine("  " + item.name + " - " + item.price);
                    }
                    Zakaz zakaz4 = new Zakaz(0, 3);
                    pos = zakaz4.Show();

                    fullPrice += vkus[pos].price;
                    fullZakaz += vkus[pos].name;
                }

                else if (pos == 4)
                {
                    Console.Clear();
                    foreach (var item in number)
                    {
                        Console.WriteLine("  " + item.name + " - " + item.price);
                    }
                    Zakaz zakaz5 = new Zakaz(0, 3);
                    pos = zakaz5.Show();

                    fullPrice += number[pos].price;
                    fullZakaz += number[pos].name;
                }

                else if (pos == 6)
                {
                    Console.Clear();
                    foreach (var item in decor)
                    {
                        Console.WriteLine("  " + item.name + " - " + item.price);
                    }
                    Zakaz zakaz6 = new Zakaz(0, 2);
                    pos = zakaz6.Show();

                    fullPrice += decor[pos].price;
                    fullZakaz += decor[pos].name;
                }

                else if (pos == 7)
                {
                    Console.Clear();

                    string txt = "Ваш заказ:";
                    File.AppendAllText("C:\\Users\\User\\OneDrive\\Рабочий стол\\Тортики.txt.txt","\n" + txt + fullPrice.ToString() + fullZakaz.ToString());
                    Console.WriteLine("Конец заказа. Чтобы сделать еще один, нажмите Escape.");

                    fullPrice = 0;
                    fullZakaz = "";

                    ConsoleKeyInfo key;
                    key = Console.ReadKey();
                    while (key.Key != ConsoleKey.Escape)
                    {
                        key = Console.ReadKey();
                    }
                    
                }

                Console.Clear();


            }
        }
    }
}
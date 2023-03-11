using Task_1.Model;

Building[] buildings = new Building[5];
buildings[0] = new Building();
buildings[0].name = "Жилой дом";

buildings[1] = new Factory();
buildings[1].name = "Завод";
((Factory)buildings[1]).G = 1000;

buildings[2] = new Office();
buildings[2].name = "Офисное здание";
((Office)buildings[2]).N = 10;

buildings[3] = new Factory();
buildings[3].name = "Фабрика";
((Factory)buildings[3]).G = 2000;

buildings[4] = new Office();
buildings[4].name = "Бизнес-центр";
((Office)buildings[4]).N = 15;

foreach (Building building in buildings)
{
    building.GetInfo();
    Console.WriteLine();
}
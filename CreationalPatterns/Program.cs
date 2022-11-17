using CreationalPatterns;

UseFactoryMethod();



void UseFactoryMethod()
{
    /*
    * ПРИМЕНЯЕМОСТЬ:
    * 
    * Когда заранее неизвестны типы и зависимости объектов,
    * с которыми должен работать ваш код.
    * 
    * Когда вы хотите дать возможность пользователям расширять части вашего фреймворка или библиотеки.
    * 
    * Когда вы хотите экономить системные ресурсы,
    * повторно используя уже созданные объекты,
    * вместо создания новых.
    */
    TransportLogistics transportLogistics;

    var typeTransport = Console.ReadLine().ToLower();

    switch (typeTransport)
    {
        case "ship":
            transportLogistics = new ShipLogistics();
            break;
        case "car":
            transportLogistics = new ShipLogistics();
            break;
        default:
            Console.WriteLine("вы не выбрали тип транспорта. Доставим машиной.");
            transportLogistics = new ShipLogistics();
            break;
    }

    transportLogistics.PlanDelivery("Moscow", "Petersburg");
}
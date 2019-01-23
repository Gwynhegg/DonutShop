    using System;

    namespace DonutModel
    {
        class Program
        {
            static void Main(string[] args)
            {
            //Три вида пончиков - шоколадный(ChocoType), ванильный(VanilType), с глазурью(GlazeType)
            DonutCreation firstDonut = new DonutCreation(new VanilType());
            firstDonut.FinalizeIt();
            firstDonut = new DonutCreation(new ChocoType());
            firstDonut.FinalizeIt();
                Console.ReadKey();
            }
        }

        class DonutCreation
        {
            private Create finalDonut;
            public DonutCreation(donutType donut)
            {//В конструкторе экземпляру класса передаем тип в качестве аргумента и возвращаем пончик указанного типа
                finalDonut = donut.CreateDonut();
            }
            public void FinalizeIt()
            {//Выдаем сообщение вместе с пончиком типа выбранного экземпляра класса DonutCreation
                finalDonut.Give();
            }
        }

        abstract class donutType
        {
        //Абстрактный класс создания пончика
            public abstract Create CreateDonut();
        }

        class ChocoType : donutType
        { //Создание шоколадного пончика
            public override Create CreateDonut()
            {
                return new CreateChoco();
            }
        }

        class GlazeType : donutType
        { //Создание пончика с глазурью
            public override Create CreateDonut()
            {
                return new CreateGlaze();
            }
        }

        class VanilType : donutType
        { //Создание ванильного пончика
            public override Create CreateDonut()
            {
                return new CreateVanil();
            }
        }

        abstract class Create
        { //Абстрактный класс Create с методом Give
            public abstract void Give();
        }

        class CreateChoco : Create
        { //переопределяем метод и выдаем шоколадный пончик
            public override void Give()
            {
                Console.WriteLine("Create a chocolate One");
            }
        }

        class CreateGlaze : Create
        {//..выдаем пончик с глазурью
            public override void Give()
            {
                Console.WriteLine("Create a glaze One");
            }
        }

        class CreateVanil : Create
        {//..ванильный пончик
            public override void Give()
            {
                Console.WriteLine("Create a vanil One");
            }
        }
    }

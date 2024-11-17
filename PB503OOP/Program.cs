using PB503OOP.Model.AnimalTask;
using PB503OOP.Model.Vehicle2Task;

namespace PB503OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region BankTask
            /*
            1. Bir BankAccount sinifi yaradın.
               Bu sinifdə aşağıdakı xüsusiyyətlər olsun:
               - AccountNumber 
               - Balance 
               - Deposit(decimal amount) metodu (balansı artırır).
               - Withdraw(decimal amount) metodu (balansı azaldır).
               Withdraw metodu mənfi balansın yaranmasına icazə verməsin.

            */
            //BankAccount account = new BankAccount();
            //account.AccountNumber = "PB503";
            //account.Balance = 500;




            //int input;
            //do
            //{
            //    Console.WriteLine("Choose an operation: ");
            //    Console.WriteLine("1. Deposit");
            //    Console.WriteLine("2. Withdraw");
            //    Console.WriteLine("3. Balance");
            //    Console.WriteLine("0. Exit");

            //    input = int.Parse(Console.ReadLine());
            //    switch (input)
            //    {
            //        case 1:
            //            Console.WriteLine("Please enter deposit amount: ");
            //            decimal depositInput = decimal.Parse(Console.ReadLine());
            //            account.Deposit(depositInput);
            //            break;
            //        case 2:
            //            Console.WriteLine("Please enter withdraw amount: ");
            //            decimal withdrawInput = decimal.Parse(Console.ReadLine());
            //            account.Withdraw(withdrawInput);
            //            break;
            //        case 3:
            //            Console.WriteLine(account.Balance);
            //            break;
            //        case 0:
            //            Console.WriteLine("Cixish olundu!");
            //            break;
            //        default:
            //            Console.WriteLine("Duzgun proses daxil edin.");
            //            break;
            //    }

            //} while (input != 0);
            #endregion

            #region VehicleTask
            /*
             2. Vehicle adlı bir əsas sinif yaradın. Xüsusiyyətlər:
                - Brand (istehsalçı)
                - Model
                - Year
                - DisplayInfo() metodu (avtomobilin məlumatını göstərir).
                Car və Truck sinifləri yaradın, bunlar Vehicle sinifindən miras alınsın.
                - Car sinfinə əlavə NumberOfDoors xüsusiyyəti əlavə edin.
                - Truck sinfinə əlavə PayloadCapacity xüsusiyyəti əlavə edin.
             */

            //Car car = new Car("Bmw", "M3", 2022, 2);
            //car.DisplayInfo();

            //Truck truck = new Truck("Volvo", "FN", 2024, 2000);
            //truck.DisplayInfo();
            #endregion

            #region ZooTask
            /*
             Animal adlı abstrakt bir sinif yaradın. Bu sinifdə hər bir heyvan üçün ümumi olan Name, Age propertylerini və Eat() metodunu müəyyən edin.

             Müxtəlif heyvan növlərini təmsil edən siniflər (Leon, Elephant, Horse və s.) yaradın və bunları Heyvan sinfindən irs alaraq yaradın.
             
             Hər heyvan növünün özünə xas olan xüsusiyyətlərini və Eat() metodunu fərqli şəkildə həyata keçirin.
             
             Hər heyvanın Age məlumatlarını yalnız get və set metodları vasitəsilə əldə edilə bilən şəkildə kapsula edin.
             
             Age məlumatı üçün yalnız müsbət ədədlərin qəbul olunmasını təmin edən məntiq yazın.
             
             Heyvanlar üçün bir MakeSound() metodu yaradın. Bu metod fərqli heyvan növlərində fərqli səslər çıxarmalıdır. 
             
             Main metodunda müxtəlif heyvan siniflərindən obyektlər yaradın və onların Eat() və MakeSound() metodlarını çağıraraq nəticələrini yoxlayın.

             */

            Elephant elephant = new Elephant("Jhon", 220, 10);
            elephant.Eat();
            elephant.MakeSound();

            Horse horse = new Horse("Jhon", 10, 4);
            horse.Eat();
            horse.MakeSound();

            Leon leon = new Leon("Lion", 100, true);
            leon.Eat();
            leon.MakeSound();
            #endregion

            #region Vehicle2Task
            /*
             Vehicle adlı abstrakt sinif yaradın. Bu sinif hər bir nəqliyyat vasitəsi üçün ümumi olan Brand, Model, MaxSpeed propertyleri və Drive() metodunu özündə cəmləşdirməlidir.

              Bu sinifdən irsi alan Car, Motorcycle və Train adlı fərqli siniflər yaradın. Hər bir sinif özünəməxsus xüsusiyyətləri əlavə etməli və Drive() metodunu fərqli şəkildə həyata keçirməlidir.
              
              Car sinfi üçün FuelType, Motorcycle üçün RaceType, Train üçün CarriageCount kimi əlavə xüsusiyyətlər daxil edin.
              
              MaxSpeed və CarriageCount kimi sahələri qorumaq üçün get və set metodları ilə kapsula edin. MaxSpeed yalnız müsbət ədədləri qəbul etməli, CarriageCount isə minimum 1 olmalıdır.
              
              Brand və Model xüsusiyyətləri yalnız sinif daxilindən dəyişdirilə biləcək şəkildə yazılmalıdır (readonly kimi).
              
              Nəqliyyat vasitələrinin fərqli səslər çıxara bilməsi üçün ISound adlı bir interfeys yaradın. Bu interfeysdə MakeSound() adlı metod olsun.
              
              Car, Motorcycle, və Train sinifləri bu interfeysdən istifadə etməli və hər birində fərqli səs çıxarmalıdır (məsələn, Car üçün “Bip-bip!”, Train üçün “Tuf-tuf!”).
              
              Main metodunda müxtəlif nəqliyyat vasitələrindən obyektlər yaradın və onların Drive(), MakeSound() metodlarını çağırın.

             */

            SecondCar secondCar = new("Mercedes", "E class", 280, "Diesel");
            secondCar.MakeSound();
            secondCar.Drive();

            SecondTrain secondTrain = new("Siemens", "asd", 500, 5);
            secondTrain.MakeSound();
            secondTrain.Drive();

            SecondMotorcycle secondMotorcycle = new("Yamaha", "R1", 350, "Racing");
            secondMotorcycle.MakeSound();
            secondMotorcycle.Drive();


            #endregion
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _13iyun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Cars car1 = new Cars("Toyota","Camry",2018,100000,"Avtomat",40000,50000,5000,45000);
            showInfo(car1);
            BeginAgain:
            Console.Write("Avtomobili satmaq istədiyiniz qiyməti qeyd edin:");
            double offerPrice = Convert.ToDouble(Console.ReadLine());
            double price = car1.satisQiy - car1.maxEndirim;
            if (offerPrice <= price)
            {
                Console.WriteLine("Max. endirim qiymətindən aşağı bir qiymət təyin etməyə çalışdınız! Yenidən cəhd edin");            
                goto BeginAgain;
            }
            else if (offerPrice > price)
                Console.WriteLine("Qiymət uyğundur.");
            Console.WriteLine("Çıxış üçün Enter düyməsinə sıxın") ;
            Console.ReadLine();

        }
        static void showInfo(Cars car)
        {
            Console.WriteLine($"Avtomobil haqqında məlumat:\n\tMarka: {car.marka}\n\tModel: {car.model}\n\tİstehsal ili: {car.istehsal_ili}\n\t" +
                $"Yürüş: {car.Km}\n\tSürətlər qutusu: {car.suretQutusu}\n\tAlış qiyməti: {car.alisQiy}\n\tSatış qiyməti: {car.satisQiy}\n\tMaksimum endirim:" +
                $" {car.maxEndirim}\n\tQiymət: {car.showPrice()}");            
        }
        static double Price(Cars car)
        {
            return car.satisQiy - car.maxEndirim;
        }


    }
    

}

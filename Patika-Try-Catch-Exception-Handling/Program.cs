namespace Patika_Try_Catch_Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            try
            {
                Console.WriteLine("Bir sayı girinic");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girdiğiniz sayı: "+ sayi);
            }
            catch (Exception ex)
            {
                Console.WriteLine ("Hata:"+ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı.");

            }*/

            try
            {
                Console.WriteLine("Bir değer giriniz.");
                int a = int.Parse("320000000");
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz");
                Console.WriteLine(ex.Message);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil");
                Console.WriteLine(ex.Message);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Girilen değer çok büyük veya çok küçük");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı.");

            }




        }
    }
}

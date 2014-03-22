using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autochangepsw
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter;
            counter = 1;
            string username = "farukkisik" ; string usernamelog = " " ;            //sisteme giriş yapmak için bir kullanıcı adı ve şifre tanımlanır.
            string psw = "ozguryazilim"; string pswlog = " ";                      //bu metodu kullanacağınız programa bağlı olarak bu bilgiler dışarıdan(SQL,text dosyası...) da alınabilir.
            char[] pswbol = new char[psw.Length];
            Console.WriteLine("Hi Welcome to System. Please Log In.");
            B:Console.WriteLine("Enter your username: ");
            usernamelog = Console.ReadLine();
            if (usernamelog != username)
            {
                Console.WriteLine("Incorrect Username.Try again.");
                goto B;
            }
            Console.WriteLine("ATTENTION!After every 3 incorrect password attempt, your password will change itself.");
            A:Console.WriteLine("Enter your password: ");
            pswlog = Console.ReadLine();
            if (pswlog != psw)
            {
                 if (counter % 3==0)
                 {
                    int a=pswbol.Length-1;
                    pswbol = psw.ToCharArray();
                    for (int i = 0; i < pswbol.Length/2; i++)        //bu for döngüsünde şifremiz kendisini değiştiriyor.
                    {                                                //yeni şifre; eski şifremizin ters yazılmış hali.
                        char c = pswbol[i];                          //örneğin şifre= abcde ise yeni şifre=edcba olacaktır. 
                        pswbol[i] = pswbol[a];
                        pswbol[a] = c;
                        a--;
                    }
                    psw = new string(pswbol);
                    Console.WriteLine("You have reached 3 or a multiple of 3 incorrect attemps. Couse of that your password has changed itself.");
                    counter++;
                    goto A;
                 }
                 counter++;
                 Console.WriteLine("You have entered incorrect password. Attempting : " + counter + ". try.");
                goto A;
            }
            else
                Console.WriteLine("Congratulations! You have logged in successfully!");

        }
    }
}

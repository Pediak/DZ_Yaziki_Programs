//Пользователь вводит любой символ (переменная char). Необходимо проверить, является ли символ русской буквой и если да,
//то определить гласная она или согласная. Вывести сообщение на экран.
//Если введена не русская буква, то вывести сообщение "Error".



public class Proverka
{
    private char Bukva;
    
    public Proverka(char Bucva)
    {
        Bukva = Bucva; 
    }

    public string TypE()
    {
        string rez = "";
        Bukva = char.ToLower(Bukva);

        if ((Bukva == 'ё') || (Bukva >= 'а' && Bukva <='я'))
        {
            rez += "буква Русская";
            char ch = char.ToLower(Bukva);

            if (ch == 'а' || ch == 'е' || ch == 'ё' || ch == 'и' || ch == 'о' ||
                ch == 'у' || ch == 'ы' || ch == 'э' || ch == 'ю' || ch == 'я')
            {
                rez += " и гласная";
            }
            else
            {
                rez += " и согласная";
            }
        }
        else
        {
            return "Error";
        }
        return rez;
    }
}



class Prodramm
{
    static void Main(string[] args)
    {
        Console.Write("Введите букву: ");
        char ch = char.Parse(Console.ReadLine());

        Proverka ch1 = new Proverka(ch);
        Console.WriteLine(ch1.TypE());
    }
}
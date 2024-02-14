namespace Koleksiyonlar_soru_1;

    public class AsalSorgula
{
    public static bool AsalSorgulama (int number)
    {
        bool result = true;
        for (int i = 2; i < number - 1; i++)
        {
            if (number % i == 0)
            {
                result = false;
                i = number;
            }
        }
        return result;

    }

}




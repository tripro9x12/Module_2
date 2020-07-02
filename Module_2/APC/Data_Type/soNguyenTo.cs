namespace Data_Type
{
    public class soNguyenTo
    {
        public bool checkSoNguyenTo(int number)
        {
            if (number < 2)
            {
                return false;
            }
            else if (number == 2)
            {
                return true;
            }
            else
            {
                int dem = 0;
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        dem++;
                    }
                }
                if (dem == 2)
                {
                    return true;
                }
                else return false;
            }

        }
    }
}
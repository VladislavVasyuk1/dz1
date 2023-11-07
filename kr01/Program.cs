string[] array1 = new string[] {"вв", "уццу", "вмы", "44", "ывм", "вы", "3535"};
string[] array2 = new string[array1.Length];

void sorted(string[] array1, string[] array2)
{
    int x = 0;
    for(int i = 1; i < array1.Length; i++)
        {
            if (array1[i].Length <= 3)
                {
                    array2[x] = array1[i];
                    x++;
                }
        }
}









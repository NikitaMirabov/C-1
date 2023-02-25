int[]array = {11, 21, 31, 34, 35, 37, 23, 42, 38};

int n = array.Length;
int find = 23;
int index = 0;

while (index < n)
{

    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }

    //index= index+1;
    index++;
}



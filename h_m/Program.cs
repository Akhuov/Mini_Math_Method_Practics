using System.ComponentModel.DataAnnotations;

void arif_prog(int[] a)
{
    int e = a[1] - a[0];
    for (int i = 0; i < a.Length; i++)  
    {
        //Console.Write(a[i] + " ");
        if (i != a.Length - 1 && a[i + 1] - a[i] != e)
        {
            e = 0;
            break;
        }
    }
    Console.WriteLine("Answer:"+e);
}

void geo_prog(int[] a)
{
    int e = a[1] / a[0];
    for (int i = 0; i < a.Length; i++)
    {
        //console.write(a[i] + " ");
        if (i != a.Length - 1 && a[i + 1] / a[i] != e)
        {
            e = 0;
            break;
        }
    }
    Console.WriteLine("answer:" + e);
}

void Juft_tog(int[] a)//Juft_Tog tartibi tekshiruvchi dastur
{
    int index = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i]%2==0 && i == 0 || i % 2 == 0 && a[i] % 2 == 0)
            continue;
        else if (i % 2 == 1 && a[i] % 2 == 1)
        {
            continue;
        }
        else
        {
            index = i;
            break;
        }
    }

    Console.WriteLine("Answer:" + index);
}
//containe//
void Mus_Man(int[] a)//Musbat_Manfiy tartibi tekshiruvchi dastur
{
    int index = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] > 0 && i == 0 || i % 2 == 0 && a[i] > 0)
            continue;
        else if (i % 2 == 1 && a[i] < 0)
        {
            continue;
        }
        else
        {
            index = i;
            break;
        }
    }

    Console.WriteLine("Answer:" + index);
}

void Juft_index_min(int[] a)
{
    int min = a[0];
    for (int i = 2; i < a.Length; i+=2)
    {
        if (min > a[i])
        {
            a[i] = min;
        }   
    }
    Console.WriteLine(min);
}

void Tog_index_max(int[] a)
{
    int max = a[1];
    for (int i = 3; i < a.Length; i += 2)
    {
        if (max < a[i])
        {
            a[i] = max;
        }
    }
    Console.WriteLine(max);
}




int n = int.Parse(Console.ReadLine());
int[] a = new int[n];

for (int i = 0; i < n; i++)
{
    a[i] = int.Parse(Console.ReadLine());
}


//arif_prog(a);
//geo_prog(a);


//Juft_tog(a);
//Mus_Man(a);

//Juft_index_min(a);
Tog_index_max(a);
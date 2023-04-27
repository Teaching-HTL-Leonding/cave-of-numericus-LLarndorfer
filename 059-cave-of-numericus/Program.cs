// //* Cave of Numericus

// var rand = new Random(4711);
// double sum = 0;
// int times = 12345;
// int onetimeless = times - 1;
// int temp = 0;
// double averagedistance = 0;
// var distances = new int[times - 1];
// var zufaellige = new int[times];
// var avgdistance = new int[times - 1];
// for (int i = 0; i < times; i++)
// {
// zufaellige[i] = rand.Next(1, 1000000001);
// }


// for (int j = 1; j < zufaellige.Length; j++)
// {
// for (int i = 0; i < zufaellige.Length; i++)
// {
//     if(zufaellige[i] > zufaellige[j])
//     {
//         temp = zufaellige[i];
//         zufaellige[i] = zufaellige[j];  
//         zufaellige[j] = temp;
    
//     }
// }
// }

// for (int i = 0; i < onetimeless; i++)
// {
//     distances[i] = zufaellige[i] - zufaellige [i + 1];
//     if (distances[i] < 0)
//     {
//         distances[i] = distances[i] * (-1);
//     }
//     sum += distances[i];
// }
// averagedistance = sum / distances.Length;

// Console.WriteLine(averagedistance);


//* Cave of Numericus
double maxvalue = 0;
var rand = new Random();

long times = 100_000_000;
double onetimeless = times - 1;
int range = 1_000_001;

double averagedistance = 0;
double minvalue = range;

for (int i = 0; i < times; i++)
{
    var r = rand.Next(1, range);
    if (r > maxvalue)
    {
        maxvalue = r;
    }
    if (r < minvalue)
    {
        minvalue = r;
    }  
    
}                                            

averagedistance = (maxvalue - minvalue) / times;
System.Console.WriteLine(averagedistance);

// Task 1
// Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.

// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
// }

// -------------------------------------------------------------------------------------------

// Task 2
// 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

// for (int i = 1; i <= 20; i++)
// {
//     Console.WriteLine(i);
// }

// -------------------------------------------------------------------------------------------

// Task 3
// 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

// for (int i = 1; i <= 20; i++)
// {
//     if (i % 2 == 0)
//     {
//         Console.WriteLine(i);
//     }
// }

// -------------------------------------------------------------------------------------------

// Task 4
// 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.

// int total = 0;
// for (int i = 50; i < 150; i++)
// {
//     total += i;
// }
// Console.WriteLine("Total = " + total);

// -------------------------------------------------------------------------------------------

// Task 5
// 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.

int oddTotal = 0;
int evenTotal = 0;
for (int i = 0; i < 120; i++)
{
    if (i % 2 == 0)
    {
        evenTotal += i;
    }
    else
    {
        oddTotal += i;
    }
}
Console.WriteLine("Total of odd numbers: " + oddTotal);
Console.WriteLine("Total of even numbers: " + evenTotal);
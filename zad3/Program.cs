Console.WriteLine("Podaj wysokość choinki (min 2, max 10): ");
int maxh = 10;
char space = ' ';
char star = '*';
int startW = 1;

for (int height = int.Parse(Console.ReadLine()); height <= maxh;)
{
    startW++;
    height++;
    Console.WriteLine(star);
}

/*
        *
       ***
      *****
     *******
    *********
   ***********
  *************
 ***************
*****************
        *

*
***
*****
*******
*********
***********
*************
***************
*
*/
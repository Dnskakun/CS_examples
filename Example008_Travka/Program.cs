Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");

int x1 = 50, x2 = 50, x4 = 50, x6 = 50, x7 = 50;
//    xb = 1, yb = 30,
//    xc = 80, yc = 30;

int y = 20;
int count = 0;

while(count < 100)
{
    Console.SetCursorPosition(count, y);
    Console.WriteLine("+");
    count++;
}

count = 0;

while(count < 12)
{
    int  branch = new Random().Next(-1, 2); // [-1;2) -1 0 1
    if (branch == -1)
    {
        x1 = x1 + branch - count / 2;
        x2 = x2 + branch - count / 3;
        x4 = x4 + branch;
        x6 = x6 + branch + count / 3;
        x7 = x7 + branch + count / 2;
        y = y - 1;
    }

    if (branch == 0)
    {
        x1 = x1 + branch - count / 2;
        x2 = x2 + branch - count / 3;
        x4 = x4 + branch;
        x6 = x6 + branch + count / 3;
        x7 = x7 + branch + count / 2;
        y = y - 1;
    }

    if (branch == 1)
    {
        x1 = x1 + branch - count / 2;
        x2 = x2 + branch - count / 3;
        x4 = x4 + branch;
        x6 = x6 + branch + count / 3;
        x7 = x7 + branch + count / 2;
        y = y - 1;
    }

    Console.SetCursorPosition(x1, y);
    Console.WriteLine("Y");

    Console.SetCursorPosition(x2, y);
    Console.WriteLine("Y");
    
    Console.SetCursorPosition(x4, y);
    Console.WriteLine("Y");

    Console.SetCursorPosition(x6, y);
    Console.WriteLine("Y");

    Console.SetCursorPosition(x7, y);
    Console.WriteLine("Y");

    count++;

}
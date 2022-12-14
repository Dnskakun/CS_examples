int count = 0;
int time;
int distance = 10000;
int firstFriendSpeed = 1;
int secondFreindSpeed = 2;
int dogSpeed = 5;
int friend = 2;

while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance / (secondFreindSpeed + dogSpeed);
        friend = 1;
    }
    distance = distance - (firstFriendSpeed + secondFreindSpeed) * time;
    count++;
    Console.WriteLine(distance);
}

Console.Write("Собака пробежит ");
Console.Write(count);
Console.Write(" раз.");

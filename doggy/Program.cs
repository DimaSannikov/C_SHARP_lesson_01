int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int petSpeed = 5;
double distance = 10000;

double distanceBetweenFriends = distance;
int friendSpeed = 0;
int whichFriend = 2;
int count = 0;

while(distanceBetweenFriends > 3)
{
    if(whichFriend == 2)
    {
        friendSpeed = secondFriendSpeed;
        whichFriend = 1;
    }
    else
    {
        friendSpeed = firstFriendSpeed;
        whichFriend = 2;
    }
    double meetTime = distanceBetweenFriends / (petSpeed + friendSpeed);
    distanceBetweenFriends = meetTime * (firstFriendSpeed + secondFriendSpeed);
    count += 1;
}

Console.WriteLine(count);
using System.Globalization;
using FundamentalsOfCSharp;

class MainClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Welcome To C# Programming");

        DisplayFriendsName myFriends1 = new DisplayFriendsName();
        myFriends1.DisplayFriends();


        DisplayFriendsName myFriends2 = new DisplayFriendsName();
        myFriends2.DisplayFriendsNameUsingForeachLoop();


        DisplayFriendsName myFriends3 = new DisplayFriendsName();
        myFriends3.DisplayFriendsNameUsingForLoop();



        DisplayFriendsName myFriends4 = new DisplayFriendsName();
        myFriends4.DisplayFriendNameUserInput();





    }


}



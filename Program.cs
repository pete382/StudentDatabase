//git remote add origin https://github.com/pete382/StudentDatabase.git
//git branch -M main
//git push -u origin main

// Array to hold names
using System.ComponentModel.Design;
using System.Net.Security;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Channels;

string[] names = {
            "Justin", "Ethan", "Victoria", "Ethan", "Ben",
            "Kyra", "Jack", "Ramses", "Clare", "Ramsey",
            "Ali", "Pedro", "Mellisa"
        };


// Array to hold favorite foods
string[] favoriteFoods = {
            "Baja Blast", "Ethan", "Pho", "Hot Wings", "Crab legs",
            "Sushi", "Hot Wings", "Lasagna", "Cheesy Potatoes", "Dim Sum",
            "Indian", "Italian", "Pizza"
        };

// Array to hold hometowns
string[] hometowns = {
            "Westerville", "Ethan", "Blacksburg", "Bolivar", "Birmingham",
            "Hazel Park", "Trenton", "Wyoming", "Lake Orion", "Brooklyn",
            "Dearborn Heights", "Chicago", "Detroit"
        };

string Continue;


    int namesLength = names.Length;
    int ArrayPosition = 0;

    Console.WriteLine(namesLength);


    Console.WriteLine("Pick a student by number to learn more about them! \n");

    for (int i = 0; i < namesLength; i++)

    {
        string NameIndex = (i + 1).ToString();
        string NamesMenu = NameIndex + " " + (names[i]);
        Console.WriteLine(NamesMenu);

    }


    int Student = int.Parse(Console.ReadLine());

    if (Student > namesLength)

    {
        while (Student > namesLength) ;
        {

            Console.WriteLine("Please type a number from the list.");
            Student = int.Parse(Console.ReadLine());

        }

    }


    else
    {
        ArrayPosition = Student - 1;
        Console.WriteLine(ArrayPosition);
        Console.WriteLine(names[Student - 1]);
        Console.WriteLine("Would you like to learn about " + names[Student - 1] + "'s hometown or favorite food ? \n");
        Console.WriteLine("Type 'hometown or 'food' for favorite food ? \n");


    }

    string category = Console.ReadLine().ToLower().Trim();




    if (category == "food")
    {

        Console.WriteLine(favoriteFoods[ArrayPosition]);
    }
    else if (category == "hometown")
    {
        Console.WriteLine(hometowns[ArrayPosition]);

         }

    Console.WriteLine( "Do you want to continue ? Type 'y' for Yes and 'n' for no.") ;

   
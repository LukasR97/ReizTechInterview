//Program.cs cannot know about the item class, when user inputs an number the program has to print the item's name
using ReizInterview;

string userInput;
int userInputConvertedToInt;

CollectionOfItems collectionOfItems = new CollectionOfItems();

userInput = Console.ReadLine();


if (int.TryParse(userInput, out userInputConvertedToInt))
{
    var result = collectionOfItems.GetItemNameById(userInputConvertedToInt);
    if (result.IsSuccessful)
    {
        Console.WriteLine(result.ItemName);
    }
    else
    {
        Console.WriteLine(result.Error);
    }

}
else
{
    Console.WriteLine("TryParse failed to parse.");
}

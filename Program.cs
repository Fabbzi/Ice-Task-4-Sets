using EventAttendeeManager;

var eventManager = new EventManager();
bool running = true;

while (running)
{
    Console.WriteLine();
    Console.WriteLine("Event Attendee Manager");
    Console.WriteLine("1. Add Attendee");
    Console.WriteLine("2. Remove Attendee");
    Console.WriteLine("3. Display All Attendees");
    Console.WriteLine("4. Exit");
    Console.Write("Please enter your choice: ");
    
    string? choice = Console.ReadLine();
    Console.WriteLine();
    
    switch (choice)
    {
        case "1":
            Console.Write("Enter attendee name: ");
            string? nameToAdd = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(nameToAdd))
            {
                eventManager.AddAttendee(nameToAdd);
            }
            else
            {
                Console.WriteLine("Invalid name. Please try again.");
            }
            break;
            
        case "2":
            Console.Write("Enter attendee name to remove: ");
            string? nameToRemove = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(nameToRemove))
            {
                eventManager.RemoveAttendee(nameToRemove);
            }
            else
            {
                Console.WriteLine("Invalid name. Please try again.");
            }
            break;
            
        case "3":
            eventManager.DisplayAllAttendees();
            break;
            
        case "4":
            running = false;
            Console.WriteLine("Thank you for using Event Attendee Manager!");
            break;
            
        default:
            Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
            break;
    }
}

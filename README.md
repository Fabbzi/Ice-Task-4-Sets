Event Attendee Manager
Objective

The goal of this task is to build a simple console application to manage a list of attendees for an event. You will use a HashSet<string> to ensure that each attendee is only registered once.
Scenario

You are the developer for a small community event. The organizer needs a simple program to keep track of everyone who has registered. The key requirement is that the system must prevent duplicate registrations. A person should not be able to register more than once. Your job is to build the core logic for this system.
Core Requirements
1. Create an EventManager Class

This class will contain all the logic for managing attendees.

    It must have a private field to store the attendee names. You must use a HashSet<string> for this.

    It should have the following public methods:

        void AddAttendee(string name)

            This method adds a name to the HashSet.

            If the name is added successfully, it should print a confirmation message like: "{name}" has been registered successfully.

            If the name already exists, it should print a message like: "{name}" is already registered.

        void RemoveAttendee(string name)

            This method removes a name from the HashSet.

            If the name is found and removed, it should print: "{name}" has been removed.

            If the name is not found, it should print: "{name}" was not found in the registration list.

        void DisplayAllAttendees()

            This method should print all registered attendee names to the console.

            It should first print a header, like --- Registered Attendees ---.

            If there are no attendees, it should print No one is registered yet.

            List each attendee on a new line.

2. Create the Main Program Logic (Program.cs)

Your Main method will be the user interface for the console application. It should allow the user to interact with your EventManager.

    Create an instance of your EventManager class.

    Create a loop that continuously displays a menu of options to the user.

    The menu should look something like this:

    Event Attendee Manager
    1. Add Attendee
    2. Remove Attendee
    3. Display All Attendees
    4. Exit
    Please enter your choice:

    Based on the user's choice, call the appropriate method from your EventManager instance.

    The program should continue to run until the user selects "Exit".

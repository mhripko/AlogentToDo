Program Requirements:

Create a Windows Forms application that allows basic To-Do List functionality.  User can add/edit/delete to-do list entries.  
An entry consists of a title, a description and a due datetime.  
The Windows Forms application will talk to a WCF or Web API service layer, which will read and save an XML file representing our data store of To Do Tasks.  

Implementation

Windows Forms Application.

Highlights:

1. Tradition code behind on forms moved into Model-View-Presenter pattern.  No business logic in code behind forms.
2. All business logic separated and moved to business logic folder.
3. All Loading and Saving of To Do List XML handled automatically at app start and app close time.
4. UI separated into Views: ie. ToDoListView, ToolbarView.
5. Command pattern implemented for all Icons/Buttons/Help invocation.
6. Program calls MainFormPresenter which uses services of Display, Settings, SystemInformmation, and a ToDoListManager to coordinate action.
7. I did not localize strings, nor did I move them all into the resources file since that is something ReSharper can do in 10 seconds (and I don't have it on my home machine).
8. I did not implement anything fancy or specifically not called for (like printing, or marking them done) since those can be easily added but I figured it was style and structure over features you didn't ask about.
9. I first read "will talk to a WCF or Web API service layer" and assumed that meant - it would be integrated with, so initially i didn't create that layer, however I did mock up/create a simple Web API layer I will send over separately if you want.  The web api has it's own form for testing the to do web api, but since I didn't think it was initially required, it didn't connect the two.  I can do that if you expect the client Winforms to also include the entire web api backend.

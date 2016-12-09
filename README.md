# WinForm_BurgerJoint

  College program, Design a user interface that uses principles of human computer interaction.
  
# Conceptual thoughts during design

  A. Users should feel comfortable with the program, and easily accomplish their tasks.
  B. Mistakes are limited, and errors will provide rapid feedback as well as a fixable solution to them.
  C. Memory load should be minimal for the users, and the system should feel responsive to their needs.
  D. Visuals should always be optimally visibly, and rarely hidden from view.
  E. User interaction should be intuitive, and require little or no training for core tasks.
  F. Do not overload visuals, and functionality with too much information or things to consider
  G. Users take many forms:
     Age, Size, Culture, Education, Disabilities - Hearing/Sight/Physical/Etc...
     Try to capture as many of their needs as you can, without sacrifices core user experience
  
  Our team chose an ordering system to demonstrate an everyday use case.
  Initially it was just: Start, Order burger, Fries, Drink, and Receipt.
  The MVVC solution was adding more complexity than I felt necessary, total rewrite for Win Forms design.
  
  I never liked "static" screens on a computer, so I implemented a simple animated text effect.
  This gives a more appealing interface and shows the system is ready for you.  "Movement = Excitement, Inviting Interaction"
  
  The simple design of the pages rests within principles from Web Design.
    The Top simply informs us of the system were in, and also acts as a clickable/touch point to return "home".
    The home feature should have been made more obvious, but wasn't fixed before our presentation date.
    One solution was adding a "Back" button just before the title, and then a "Summary" after this title for core jump points.
    
    The next section down tells the user where in the menu system they are, a simple location point for referencing.
    All the menu's are based on a 4 square pattern inside a grid layout, this reduces any jarring effects from changing things.
    The user can quickly see the options available, and they are fairly large for ease of use.  "Touch Screen use"
    
    The Combo menu required additional logic, as the user technically isn't ordering just a burger, fry, and a drink individually.
    A combo is an entire meal, and it might include upgraded menu items.  This required extra logic and time to work correctly.
    The Items adjust their prices, based on if they are part of a combo price or not.
    
    Each menu should populate it's menu prices appropriately.
    This allows the user to know how much our items cost, before reaching the summary/receipt area of the program.
    A database would make more sense in a live production, as well as some backend functionality to adjust prices dynamically.
    The display menu isn't optimized for speed, but tabulates prices before displaying each page to ensure accuracy.
    
    A summary page allows our users to view their order, and make changes as needed.
    The summary box took extra effort for appearances and functionality, but the end result was a nice visual.
    
    Adding a new Item or Combo simply brought users back to the "Home" menu to add something new to the order.
    
    The program allows users to remove an individual item, or an entire combo.
    It does not allow for removing an individual item from a combo.  This caused issues with the pricing code.
    
    The user can also decide to cancel their order, and this simply exits them from the entire ordering process.
    It does offer a pop-up to ensure the user understands this is an exit from the system, and not abort last item ordered. 
    
    The user can also confirm their order, and the system defers to another system to accept payment.
    An additional step would be a connection to the external system, and receiving feedback/directions along the way.
    
##Criticisms

  Black text should be improved for visibility or utilize the same color scheme: Orange due to visual difficulties.
    * Development problems with going from high resolution platform to presenting on a projector
  No obvious back buttons, and no way to simply go back in the middle of a Combo order.
    * Users want rapid reversal mechanics, and it's tedious to wait til order summary before changing a mistake
  Order Summary shouldn't number each combo item, but simply number the combo item to easily identify it as one group of items.
    * Artifact from debugging listbox selection to align with combo choice logic.
  The sub-items under a combo might not be intuitive enough with using the indented "+" item layout.
    * Considerations: Color, Size, Indent, Prefix
  Users can't customize their burgers, fries, shakes, etc.
    * Optional menu was planned, but not finished in time.
  It might make more sense to offer a scrollable menu item view, this would allow a longer list of items and options.
    * Like a carousel of images on a website * Arrows for longer lists, larger screen area for details/images
    
    
    
    

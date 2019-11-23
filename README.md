# ASP.NET MVC Android Issue Test

This is a sample .NET MVC Project using .NET 4.6.2.  This is a base project that was created fresh on the 23rd of November 2019 with only 1 model, 1 view and 2 action results added.

This project is to show case an interest issue I have come across on a MVC project that I manage.  I run a website that has a Basket system that allows users to add items to their basket, once they have done this their are redirected to a basket detail page where they can remove/amend the item or make a payment.

There seems to be an issue only on Android devices which causes a button on the screen to be clicked on load of the basket detail page.  By this I mean:
  1 - User adds item to their Basket
  2 - Item is added to the User's Basket and is redirected to the Basket Detail Page
  3 - On Load, Android devices clicks the Remove button against the item, actioning the delete of the item from the basket without actually changing the page the user is viewing.
  
This causes issues because any action that happens next fails as the item is no longer in the users basket.

I have been able to replicate this with a base MVC project which contains a Basket Detail page and a Remove action.  If I debug the project with a Breakpoint on the BasketDetail & Remove ActionResults and then navigate to the BasketDetail page using an Android device, You can see that the BasketDetail is run and then return to the user and then half a second later the action for Remove is actioned.

The first time I tested this it happened as explained above, however, occasionally this did not always occur (probably around 75% of the time).

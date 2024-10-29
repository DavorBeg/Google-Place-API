# What is this?
this is example API for pulling data from google places, and saving them to local database with feature to add it as favorite place in database, where in any time I can pull all my favorite stored places.

# Google documentation
I built this app by following next documentation: [Documentation](https://developers.google.com/maps/documentation/places/web-service/nearby-search)

# What tools I used?

 1. **Visual studio** - IDE
 2. **Postman** - For testing my endpoints
 3. **Json formatter** - For creating my c# models from google documentation.
 4. **Microsoft SQL Server Managment Studio** - for database managment
 
 # What technologies I used?
 
 4. **.NET 8** - for my API and SignalR
 5. **MediatR** - for CQRS 
 6. **EF CORE** - for ORM 
 7. **MSSQL** - for my database
 8. **JWT** - For my authentication and authorization
 9. **Serilog** - For some basic logging
 10. **AutoMapper** - For mapping my DTOs
 11. **Onion architecture** - (Not tecnology) Architecture of my app

# What I wanted to use?

 1. **Fluent validator** - For validating my user inputs, but I gave up on that. No special need for that.

# Layout of my application
[![Layout-Of-App.png](https://i.postimg.cc/T12vQ6V3/Layout-Of-App.png)](https://postimg.cc/wyrrTn4C)

This is how I organized my application. Like I mentioned already I used Onion Architecture because I found it easy and comfortable to use. Also to upgrade it in any time without some common problems. 
Green arrows are showing flow of project references.
Gray boxes indicate layers of onion architecture.
In my application every project have suffix with e.g. ' ***.Domain*** '.
That suffix indicates in which layer given project is placed.

# How I handled my business logic?

All my logic is located in **MediatR** handlers and some basic **services**. 
I found out that **MediatR** library and **CQRS** pattern will help me a lot 
with some features, so I implemented almost all logic inside **handlers** and **behaviors**. 

For example lets take **SignalR** feature. If my given request is type of: **SearchPlacesForLocationCommand**, my behavior will send to all subscribed clients,
message via SignalR about searched place.
Let check the diagram how this actually work.

[![Signal-RBehavior.png](https://i.postimg.cc/pX6y9GvF/Signal-RBehavior.png)](https://postimg.cc/w7D9Zk7q)

We can see how our request travels inside 
**MediatR** > 
**Thru pipeline where SignalR will send message if condition is valid** > 
**Some handler which will inject needed services**.

> WARNING
> In some behaviors and handlers I sent user claims from command to handler, but later I created service called IUserAccessor from which I could get my current user easier.

In this way all others MediatR behaviors works... And they are:

 1. **CachingBehavior**
 2. **LockingRequestMechanismBehavior**
 3. **RequestExceptionHandler**
 4. **SaveToDatabaseBehavior**

Where **RequestExceptionHandler** is not classic behavior, but ***IRequestExceptionHandler*** but for sake of simplicity I will put him just as behavior.

# Application services

With handlers and behaviors, I have put some of my logic inside services.
There is next services in my app:

 1. **AuthenticationService**
 2. **RepositoryManager**
 3. **RequestLocker**
 4. **ServiceManager**
 5. **UserAccessor**

I will not go to any details about app services, because I want to mention one thing. And that is **ServiceManager**.

I have created this manager class for all my services, but for some reason, manager is empty?
Its empty because at beginning of project I was not expecting to use so much MediatR, but to use it only for behaviors... And for all logic e.g. mapping, to place it inside services. This is why you can find only Lazy class of **IAuthenticationService** which was first created service in my project.

# App Repositories

All my logic for ORM and database is placed inside ***Repository.Infrastructure*** layer, because in future it is much easier to switch technologies if needed. 
For every repository I used specific interface to follow **SOLID** principle. 
Specific **Interface Segregation Pattern**.

For configure all my data I used **EF CORE Fluent API** where I really lost a lot of time, can say like 3 days, just because I am used to configuring that inside database. But in this application it was much much better to go with fluent API, which I didnt know very well, so I spent great amount of time on research some basic features, until I got valid migration and database update.

# Securing synchronized request execution

This part was most interesting part, yet so simple to implement with MediatR.
As I mentioned earlier I have behavior called **LockingRequestMechanismBehavior**
which is paired with singleton service **RequestLocker**. 
To avoid some complicated explanation how I created this, lets look at flow diagram:

[![Locking-Request-Pipeline.png](https://i.postimg.cc/XY2w2c9K/Locking-Request-Pipeline.png)](https://postimg.cc/qN3hqKbg)

This may look complicated, but important part of this story is that, request after locking behavior does not jump automatically on other behavior or to return response, instead it will be catched inside semaphore and there request will wait until semaphore will be free again.

To be continued...



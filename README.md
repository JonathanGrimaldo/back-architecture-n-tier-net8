I stared this project just for learning and educational purposes...
is not done, is currently in progress I fix some details yet
--
I stared with 3 layers following the N-Tier architecture

But after of some changes I added 1 additional layer = Domain, trying to follow the Onion Architecture principles but keeping the N-Tier layers

The project init with 3 main layer

Presentation (WebAPI)
Business(Application)
Persistence (Data Access)

and

Presentation has a reference of Business
Business has a reference of Persistence

And the Presentation layer orchest the 2 layers adding the services of the dependency container, and it works at the beginning

But now the architecture was updated, for the next

Presentation (WebAPI)
Business (Application)
Persistence (Data Access)
Domain (Core logic)

Presentation has reference of Business and Persistence (N-Tier classic is Presentation -> Business, but in this case we dont follow this flow)
Business has a reference to Domain(Core)
Persistence has a reference to Domain(Core)

--
This project has been configured repository pattern, with generic and non generic repository, configurable repository as you needed
We use the unit of work for keep all repositories in one place

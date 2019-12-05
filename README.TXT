I used the three-tier architecture. This is a client-server software architecture pattern in which the user interface (presentation), 
functional process logic ("business rules"), computer data storage and data access are developed and maintained as independent modules, 
most often on separate platforms.
Apart from the usual advantages of modular software with well-defined interfaces, the three-tier architecture is intended to allow 
any of the three tiers to be upgraded or replaced independently in response to changes in requirements or technology.

Every module has Entities object (Controllers, DAL and Services). I used this architecture so I could hide not relevant or internally used 
data. For example, the DAL layer may not want to return all the data that was feched from the DB but only a part of it, like so all other layers
may need to hide data from the other layers.
I used the build in IOC for .Net Core but I could really use any other like Ninject.
I didn't add logging I tought its an over kill.
  


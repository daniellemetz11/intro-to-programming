//Week 1 Review

//low level coding patterns and medium level coding concepts 

//DDD
// - we have some things that represent a set of related things in our business
//      - entities (domain entities)
//      - root for adding or accessing related stuff about that entity, or doing things with that entity
//      - aggregate root 
// - we need some thingies (services) that handle particular responsibilities related to some state and process 
        // - look up accounts
        // - storing changes





// SOLID
// - single responsibility , each code module should have a single access of change 
// - open/closed - a code module should be open for extension but closed for modification 
//    - BonusClock, didn't have to change it when wanted to use businesstimeprovider, just extended it 
// - liskov substitution
//    - instances of a type should be replacebable by subtypes of the same type
// - interface segregation - code modules should depend on small client specific interfaces, write the code you wish you had, make it less complex, give the work to "someone" else 
//   - 
// - dependency inversion - 



//implicit operator 



//unit tests
// cant test late bound things
// ex. networks, databases, file systems, etc 
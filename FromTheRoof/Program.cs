using FromTheRoof.Class;
using FromTheRoof.Init;

Player player = GameInitializer.CreatePlayer();

List<GameEvent> events = EventInitializer.CreateRandomEvents();
List<GameAction> actions = ActionInitializer.CreateDefaultActions();
List<Course> courses = CourseInitializer.CreateWeeklyCourses();

Simulation simulation= new Simulation(player, actions, courses, events);
simulation.Start();
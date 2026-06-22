using FromTheRoof.Class;
using FromTheRoof.Init;

Player player = GameInitializer.CreatePlayer();

List<GameAction> actions = ActionInitializer.CreateDefaultActions();
List<Course> courses = CourseInitializer.CreateWeeklyCourses();

Simulation simulation= new Simulation(player,actions,courses);
simulation.Start();
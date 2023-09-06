// Processing Items
const double DRIVERS_WAGE = 5.27;
const int COST_OF_PIE = 10;
const double COST_OF_TOPPING = .25;
string userInput;

// Input Declarations
int numberOfPies;
int amountOfToppings;
double driversTip;

double serviceFee;

// Outputs
double orderCost;


Console.WriteLine("How many pizzas were ordered?");
userInput = Console.ReadLine();
numberOfPies = int.Parse(userInput);


System.Console.WriteLine("How many topping were selected?");
userInput = Console.ReadLine();
amountOfToppings = int.Parse(userInput);

System.Console.WriteLine("What is the driver's tip?");
userInput = Console.ReadLine();
driversTip = double.Parse(userInput);


orderCost = DRIVERS_WAGE + driversTip + (COST_OF_PIE * numberOfPies) + (COST_OF_TOPPING * amountOfToppings);

System.Console.WriteLine("Your total order cost is: $" + orderCost);
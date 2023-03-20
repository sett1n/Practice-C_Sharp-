using Task_1.Model;

CoffeeMachine coffeeMachine = CoffeeMachine.getState();

coffeeMachine.addWater(); 
coffeeMachine.addCoffeeBeans(); 

coffeeMachine.makeCoffee(); 

coffeeMachine.coffeeMachineState(); 
using UnityEngine;
using System.Collections;

public class LogicalHmwk : MonoBehaviour {

    public string vegetable;
    public string meat;
    public string carb;

    void Start()
    {
        print("Please enter foods to create a full meal. Hint: Green Beans, Steak, and Potatoes.");
    }

	public void OnMouseClick()
    {
        if (vegetable == "Green Beans" && meat == "Steak" && carb =="Potatoes")
        {
            print("That's a great meal!");
        }
        if (vegetable != "Green Beans" && meat == "Steak" && carb == "Potatoes")
        {
            print("Your meal would be better with Green Beans for a vegetable.");
        }
        if (vegetable == "Green Beans" && meat != "Steak" && carb == "Potatoes")
        {
            print("Your meal needs a steak.");
        }
        if (meat == "Tuna" || meat == "Salmon")
        {
            print("Fish are friends, not food.");
            print("Have you tried the Chef's Special?");
        }

        if (meat != "Tuna" && meat != "Salmon")// an || makes it print always
        {
            print("Some folks like Tuna or Salmon.");
        }
        if (vegetable == "Green Beans" && meat == "Steak" && carb != "Potatoes")
        {
            print("I recommend rounding out your meal with Potatoes.");
        }
        if (vegetable == "Chef's Special" || meat == "Chef's Special" || carb == "Chef's Special")
        {
            print("You have found the secret dessert menu: ice cream, cheesecake, pie. Please order through the Vegetable option.");
        }
        
        if(vegetable == "ice cream" || vegetable == "cheesecake" || vegetable == "pie")
        {
            print("Enjoy your dessert.");
        }
        if (meat == "ice cream" || meat == "cheesecake" || meat == "pie" || carb == "ice cream" || carb == "cheesecake" || carb == "pie")
        {
            print("///Way to follow instructions///");
        }
        if (meat == "human" || meat == "people")
        {
            print("That is not okay, you sicko.");
        }
    }
}

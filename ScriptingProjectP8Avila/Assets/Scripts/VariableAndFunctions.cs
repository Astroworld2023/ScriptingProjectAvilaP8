using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableAndFunctions : MonoBehaviour
{
    //Create a variable of type integer 
    // Global Variable = Accessed anywhere in the script
    int myint = 2;


    // Start is called before the first frame update
    void Start()
    {
        // I am going to run my int thru my function to multiply it by 2
        myint = MultiplyByTwo(myint);

        // I am gonna print the results to the console
        Debug.Log(myint);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Creating a function that takes a int parameter and multiplies it by 2
    int MultiplyByTwo(int number)
    {
        //creating a variable to store my results
        int results;
        //multiplying the passed parameter by 2
        results = number * 2;

        //Returning the results
        return results;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f;
    }
    void TemperatureTest()
    {
        // If the coffee's temperature is greater than the hottest drinking temperature...
        if (coffeeTemperature > hotLimitTemperature)
        {
            // ..DO this
            print("Coffee is too hot");
        }
        //If it isnt but the coffe temp. is less than the coldest drink temp.
        else if (coffeeTemperature < coldLimitTemperature)
        {
            //do this..
            print("Coffee is too cold");
        }
        //If it iws neither of those than
        else
        {
            print("Coffee is just right");
        }
    }

}         
    

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCapacity : MonoBehaviour
{
    //Max population
    [SerializeField] 
    private int maxCapacity;

    //Current population
    [SerializeField] 
    private int currentPop;

    //Counter to determine interval between growth or decline
    [SerializeField]
    private float counter = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Counter counts down
        counter -= Time.deltaTime;
        
        //Start of game, when there is 0 capacity, the population will count down by one every 5 seconds
        if (currentPop > maxCapacity)
        {
            DyingPop();
        }
        
        //Once building is placed, population grows at the same interval until it reaches max capacity
        else if (currentPop <= maxCapacity)
        {
            GrowingPop();
        }
    }

    private void DyingPop()
    {
        if (counter <= 0)
        {
            currentPop -= 1;

            counter = 5;
            
        }
    }
    
    private void GrowingPop()
    {
        if (counter <= 0)
        {
            currentPop += 1;

            counter = 5;
        }
    }

    //To be called once building is placed, increases the maximum capacity.
    public void IncreaseCapacity()
    {
        maxCapacity += 50;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCapacity : MonoBehaviour
{
    //Max population
    [SerializeField] 
    private int maxCapacity;

    public ScenedataSO ScenedataSO;

    //Current population
    [SerializeField] 
    private int currentPop;

    //Counter to determine interval between growth or decline
    [SerializeField]
    private float countdown = 1f;

    [SerializeField] 
    private int counter = 0;

    public MartianPooler _mp;

    // Start is called before the first frame update
    void Start()
    {
        _mp.MakeAmntAvailable(4);
    }

    // Update is called once per frame
    void Update()
    {
        //Counter counts down
        countdown -= Time.deltaTime;
        
        //Start of game, when there is 0 capacity, the population will count down by one every 5 seconds
        if (currentPop > maxCapacity)
        {
            DyingPop();
            
            if (Mathf.Approximately(currentPop % 5f, 0f))
            {
                _mp.MakeAmntUnavailable(0);
            }
        }
        
        //Once building is placed, population grows at the same interval until it reaches max capacity
        else if (currentPop <= maxCapacity)
        {
            GrowingPop();
            
            if (Mathf.Approximately(currentPop % 5f, 0f))
            {
                if (countdown == 1)
                {
                    _mp.MakeAmntAvailable(counter);

                    counter += 1;
                }
            }
        }

        ScenedataSO.currentPop = currentPop;
    }

    private void DyingPop()
    {
        if (countdown <= 0)
        {
            currentPop -= 1;

            countdown = 1;
            
        }
    }
    
    private void GrowingPop()
    {
        if (countdown <= 0)
        {
            currentPop += 1;

            countdown = 1;
        }
    }

    //To be called once building is placed, increases the maximum capacity.
    public void IncreaseCapacity()
    {
        maxCapacity += 50;
    }
}

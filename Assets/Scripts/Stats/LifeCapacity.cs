using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCapacity : MonoBehaviour
{
    [SerializeField] 
    private int maxCapacity;

    [SerializeField] 
    private int currentPop;

    [SerializeField]
    private float counter = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter -= Time.deltaTime;
        
        if (currentPop > maxCapacity)
        {
            DyingPop();
        }
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
}

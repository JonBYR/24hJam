using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HungerLevel : MonoBehaviour
{
    public float hunger;
    public float rateOfHungerDecrease;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        hunger = 100.0f;
        rateOfHungerDecrease = 1f;
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        hunger -= rateOfHungerDecrease;
        if (timer >= 60)
        {
            rateOfHungerDecrease += Mathf.Log(timer, 10);
            timer = 0;
        }
    }
}

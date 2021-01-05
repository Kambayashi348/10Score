using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    int score;

    void Start()
    {
        score = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void CountUp()
    {
        score = score + 1;
        
    }


}

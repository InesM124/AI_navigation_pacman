using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coins: MonoBehaviour
{
    public static int score0 = 0;
    Text score;
    
    void Start()
    {
        score = GetComponent<Text>();
        if (score == null)
        {
            Debug.LogError("Text component not found. Make sure it is attached to the GameObject.");
        }
    }

    void Update()
    {
        if (score != null)
        {
            score.text = "Score: " + score0;
        }
    }
}

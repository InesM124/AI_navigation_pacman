using System.Collections;
using System.Collections.Generic;


using UnityEngine;


public class GetCoin : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {   
           
            coins.score0 += 1;
           
            Destroy(gameObject);
        }
    }
}

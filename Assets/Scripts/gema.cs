using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gema : MonoBehaviour
{
    
    public GameObject Gema2;
    

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Gema2.SetActive(false);
          
        }
    }

}
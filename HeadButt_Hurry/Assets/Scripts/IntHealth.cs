using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IntHealth : MonoBehaviour
{
    public IntData Health;
    public GameObject Block;
    public UnityEvent destroyBlock;

    void Start()
    {
        Health.value = Random.Range(10, 20);
    
    }

    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            subtractHealth();
        }
        
    }

    public void subtractHealth()
    {
        Health.value--;
        if(Health.value <= 0)
        {
            destroyBlock.Invoke();
        }
    }

}

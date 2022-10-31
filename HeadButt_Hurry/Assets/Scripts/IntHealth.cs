using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IntHealth : MonoBehaviour
{
    
    public IntData Health;
    public GameObject Block;
    public UnityEvent destroyBlock;
    public IntDataList HealthDataListObj;
    

    public void Awake()
    {
        Health = HealthDataListObj.HealthSO;
    }

    void Start()
    {
        
    }

    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            subtractHealth();

        }
        if(other.CompareTag("DeathFloor"))
        {
            Destroy(gameObject);
        }
        
    }

    public void subtractHealth()
    {
        Health.value--;
        if(Health.value <= 0)
        {
            Destroy(gameObject);
        }
    }
    
    
    
    


}

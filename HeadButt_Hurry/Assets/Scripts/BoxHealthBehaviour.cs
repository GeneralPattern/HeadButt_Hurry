using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BoxHealthBehaviour : MonoBehaviour
{
    public UnityEvent HitBlock, DestroyBlock;
    public void OnTriggerEnter2D(Collider2D other)
    {
        HitBlock.Invoke();

        /*if(CurrentHealth < 1)
        {
            DestroyBlock.Invoke();
        }
        */
    }
}

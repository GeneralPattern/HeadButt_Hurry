using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IDContainerBehaviour : MonoBehaviour
{
    public ID idObj;
    public IntDataList healthIDDataListObj;
    public UnityEvent startEvent;
    
    public void Awake()
    {
        idObj = healthIDDataListObj.CurrentHealth;
    }

    public void Start()
    {
        startEvent.Invoke();
    }

}

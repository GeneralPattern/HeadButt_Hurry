using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class IntDataList : ScriptableObject
{
    public List<HealthID> healthIDList;

    public HealthID CurrentHealth;

    private int num;
    
    public void SetValueRandomly()
    {
        num = Random.Range(0, healthIDList.Count);
        CurrentHealth = healthIDList[num];
        Debug.Log(CurrentHealth);
    }


}

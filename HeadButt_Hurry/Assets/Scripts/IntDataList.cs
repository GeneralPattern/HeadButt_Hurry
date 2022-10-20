using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class IntDataList : ScriptableObject
{
    public List<IntData> healthList;

    public IntData CurrentHealth;

    private int num;
    
    public void SetValueRandomly()
    {
        num = Random.Range(0, healthList.Count);
        CurrentHealth = healthList[num];
        Debug.Log(CurrentHealth);
    }


}

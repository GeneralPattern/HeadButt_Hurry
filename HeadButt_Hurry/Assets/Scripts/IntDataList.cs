using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class IntDataList : ScriptableObject
{
    public List<IntData> healthList;

    public IntData HealthSO;

    private int num;
    
    public void SetValueRandomly()
    {
        num = Random.Range(0, healthList.Count);
        HealthSO = healthList[num];
        
    }


}

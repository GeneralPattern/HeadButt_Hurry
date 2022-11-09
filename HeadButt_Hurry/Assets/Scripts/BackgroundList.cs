using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class BackgroundList : ScriptableObject
{
    public GameObject[] backgroundList;
    public int num;
    public Vector2 home;

    public void PullFromList()
    {
        num ++;
        
    }
}

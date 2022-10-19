using UnityEngine;

[CreateAssetMenu]
public class HealthID : ID
{
    public int value = 2;

    public void UpdateValue(int num)
    {
        value += num;
        Debug.Log("Value Change");
    }
}


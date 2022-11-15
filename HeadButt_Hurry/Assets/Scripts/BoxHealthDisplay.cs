using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxHealthDisplay : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public IntData Health;
    public IntDataList HealthDataListObj;
    public Sprite health1;
    public Sprite health2;
    public Sprite health3;
    public Sprite health4;
    public Sprite health5;
    public Sprite health6;
    public Sprite health7;
    public Sprite health8;
    public Sprite health9;
    public Sprite health10;
    
    public void Awake()
    {
        Health = HealthDataListObj.HealthSO;

        switch (Health.value)
        {
            case 10:
                spriteRenderer.sprite = health10;
                break;

            case 9:
                spriteRenderer.sprite = health9;
                break;

            case 8:
                spriteRenderer.sprite = health8;
                break;

            case 7:
                spriteRenderer.sprite = health7;
                break;

            case 6:
                spriteRenderer.sprite = health6;
                break;

            case 5:
                spriteRenderer.sprite = health5;
                break;

            case 4:
                spriteRenderer.sprite = health4;
                break;

            case 3:
                spriteRenderer.sprite = health3;
                break;

            case 2:
                spriteRenderer.sprite = health2;
                break;

            case 1:
                spriteRenderer.sprite = health1;
                break;
        }
        
    }

    public void changeHealth()
    {
        switch (Health.value)
        {
            case 10:
                spriteRenderer.sprite = health10;
                break;

            case 9:
                spriteRenderer.sprite = health9;
                break;

            case 8:
                spriteRenderer.sprite = health8;
                break;

            case 7:
                spriteRenderer.sprite = health7;
                break;

            case 6:
                spriteRenderer.sprite = health6;
                break;

            case 5:
                spriteRenderer.sprite = health5;
                break;

            case 4:
                spriteRenderer.sprite = health4;
                break;

            case 3:
                spriteRenderer.sprite = health3;
                break;

            case 2:
                spriteRenderer.sprite = health2;
                break;

            case 1:
                spriteRenderer.sprite = health1;
                break;
        }
    }
}

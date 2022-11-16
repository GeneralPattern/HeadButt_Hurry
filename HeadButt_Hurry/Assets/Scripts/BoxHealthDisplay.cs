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
    public Sprite health11;
    public Sprite health12;
    public Sprite health13;
    public Sprite health14;
    public Sprite health15;
    public Sprite health16;
    public Sprite health17;
    public Sprite health18;
    public Sprite health19;
    public Sprite health20;
    public Sprite health21;
    public Sprite health22;
    public Sprite health23;
    public Sprite health24;
    public Sprite health25;
    
    public void Awake()
    {
        Health = HealthDataListObj.HealthSO;

        switch (Health.value)
        {
            case 25:
                spriteRenderer.sprite = health25;
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
            case 25:
                spriteRenderer.sprite = health25;
                break;

            case 24:
                spriteRenderer.sprite = health24;
                break;

            case 23:
                spriteRenderer.sprite = health23;
                break;

            case 22:
                spriteRenderer.sprite = health22;
                break;

            case 21:
                spriteRenderer.sprite = health21;
                break;

            case 20:
                spriteRenderer.sprite = health20;
                break;

            case 19:
                spriteRenderer.sprite = health19;
                break;

            case 18:
                spriteRenderer.sprite = health18;
                break;

            case 17:
                spriteRenderer.sprite = health17;
                break;

            case 16:
                spriteRenderer.sprite = health16;
                break;

            case 15:
                spriteRenderer.sprite = health15;
                break;

            case 14:
                spriteRenderer.sprite = health14;
                break;

            case 13:
                spriteRenderer.sprite = health13;
                break;

            case 12:
                spriteRenderer.sprite = health12;
                break;

            case 11:
                spriteRenderer.sprite = health11;
                break;

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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSwapBehaviour : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public IntData background;
    public Sprite bg1;
    public Sprite bg2;
    public Sprite bg3;

    
    public void changeBackground()
    {
        background.value ++;
        switch (background.value)
        {
            case 1:
                spriteRenderer.sprite = bg1;
                break;

            case 2:
                spriteRenderer.sprite = bg2;
                break;

            case 3:
                spriteRenderer.sprite = bg3;
                break;
        }
    }

    public void lowerBackgroundValue()
    {
        background.value --;
        background.value --;
    }



}

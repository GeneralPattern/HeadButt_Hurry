using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControlBehaviour : MonoBehaviour
{
    public float moveSpeed = .5f;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if(mousePos.x > 1)
            {
                transform.Translate(moveSpeed, 0, 0);
            }
            else if(mousePos.x < -1)
            {
                transform.Translate(-moveSpeed, 0, 0);
            }
        }
    }

    void TouchMove()
    {
        
    }
}

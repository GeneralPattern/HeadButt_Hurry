using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Update()
    {
        if(Input.touchCount > 0)
        {
            Jump();
        }
    }

    void Jump()
    {

    }
}

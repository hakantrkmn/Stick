using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickController : MonoBehaviour
{
    StickJump jumpController;

    private void Start() {
        jumpController = GetComponent<StickJump>();
    }


    
}

using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class BodyInteraction : MonoBehaviour
{

    public StickJump jumpController;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.GetComponent<Ground>())
        {
                    DOTween.Complete("JumpAnim");
            Debug.Log("body");
            jumpController.BodyJump(other.contacts[0].point);
        }
    }
}

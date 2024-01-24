using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class EndInteraction : MonoBehaviour
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
                transform.root.DOScaleY(0.9f, .04f).SetEase(Ease.OutBounce).SetLoops(2,LoopType.Yoyo).SetId("JumpAnim");
                jumpController.EndJump(transform.position);
                Debug.Log("kenar");

        }
    }


}

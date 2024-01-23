using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class StickJump : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce;

    public JumpVersions jumpVersion;
    

    Vector3 lastVelocity;

    [ShowIf("jumpVersion", JumpVersions.SmoothXVelocity)] public float maxXVelocity;
    public float maxYVelocity;
    public void EndJump(Vector3 endPos)
    {
        var direction = Vector3.zero;

        direction =  transform.position - endPos;



        switch (jumpVersion)
        {
            case JumpVersions.ResetXVelocity:
                rb.velocity = Vector2.zero;
                break;
            case JumpVersions.SmoothXVelocity:
                rb.velocity = new Vector3(rb.velocity.x, 0, 0);

                break;
        }


        rb.AddForce((Vector2)direction.normalized * jumpForce, ForceMode2D.Impulse);

    }
    public void BodyJump(Vector3 hitPos)
    {
        var direction =  transform.position- hitPos;
        rb.velocity = Vector3.zero;
        rb.AddForce(direction.normalized * jumpForce, ForceMode2D.Impulse);
        /*
         var speed = lastVelocity.magnitude;
         var direction = Vector3.Reflect(lastVelocity.normalized, hitPos);

         rb.velocity = direction * speed;
          */
    }


    private void Update()
    {
        lastVelocity = rb.velocity;
    }

    void FixedUpdate()
    {
        if (jumpVersion == JumpVersions.SmoothXVelocity)
        {
            rb.velocity = new Vector2(Mathf.Clamp(rb.velocity.x, -maxXVelocity, maxXVelocity), Mathf.Clamp(rb.velocity.y, -maxYVelocity, maxYVelocity));

        }

    }
}

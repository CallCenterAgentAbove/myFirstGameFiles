using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightWallJump : MonoBehaviour
{
    public bool wallJumpRight;
    public FloorChecker floorChecker;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("jumpSurface"))
        {
            wallJumpRight = true;

        }

        /*if (collision.CompareTag("jumpSurface") && !floorChecker.OnGround)
        {
            wallJumpRight = true;

        }*/
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("jumpSurface"))
        {
            wallJumpRight = false;

        }
        /*if (collision.CompareTag("jumpSurface") && !floorChecker.OnGround)
        {
            wallJumpRight = false;

        }*/
    }
}

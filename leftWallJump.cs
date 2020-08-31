using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftWallJump : MonoBehaviour
{

    public bool wallJumpLeft;
    public FloorChecker floorChecker;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("jumpSurface"))
        {
            wallJumpLeft = true;
        }
        //dont remove, this is for the walljump
        /*if (collision.CompareTag("jumpSurface") && !floorChecker.OnGround)
        {
            wallJumpLeft = true;

        }*/
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("jumpSurface"))
        {
            wallJumpLeft = true;
        }
        //dont remove, this is for the wall jump
        /*if (collision.CompareTag("jumpSurface") && !floorChecker.OnGround)
        {
            wallJumpLeft = false;

        }*/
    }
}

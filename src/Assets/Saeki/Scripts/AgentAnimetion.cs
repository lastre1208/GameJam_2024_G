using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentAnimetion : MonoBehaviour
{
    [SerializeField]
    Animator animator;
    [SerializeField]
    PlayerParameter playerParameter;
    

    public void WallHitAnim(int horizontal)
    {
        if(horizontal == 0)
            animator.SetTrigger("FallAgein");
        else if(horizontal == -1)
        animator.SetTrigger("LeftWall");
        else if(horizontal == 1)
            animator.SetTrigger("RightWall");
    }
    // Update is called once per frame
    void Update()
    {
        bool HitFlag = playerParameter.GetWallHitFlag();
        animator.SetBool("WallHit", HitFlag);
      
        if (HitFlag == false)
        {
            animator.SetTrigger("FallAgein");
        }

        if (playerParameter.Onlife == false)
        {
            if(playerParameter.GetFloorFlag())
                animator.SetTrigger("FloorDeath");

            else if (HitFlag)
            {
                animator.SetTrigger("RightDeath");
                animator.SetTrigger("LeftDeath");
            }       
            else    
                animator.SetTrigger("FloorDeath");         
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrakeMove : MonoBehaviour
{
    private bool Onbrake,brakeCap;
    GameObject child;
    PlayerParameter playerParameter;
    private void Start()
    {
        Onbrake = false;
        brakeCap = true;
    }

    void FixedUpdate()
    {
        if (Onbrake)
        {
            if (brakeCap == true)
            {
                playerParameter.SetFlag(true, transform.position.x - child.transform.position.x);
                brakeCap = false;
            }        
        }
        else
        {
            if (brakeCap == false)
            {
                playerParameter.SetFlag(false, 0);
                brakeCap = true;
            }
        }             
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.CompareTag("Hand"))
        {
            child = collision.transform.GetChild(0).gameObject;
            playerParameter = child.GetComponent<PlayerParameter>();
            //playerParameter.SetFlag(true, transform.position.x - child.transform.position.x);
            Onbrake = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Hand"))
        {
            child = collision.transform.GetChild(0).gameObject;
            playerParameter = child.GetComponent<PlayerParameter>();
            //playerParameter.SetFlag(false,0);
            Onbrake = false;
        }
    }
}

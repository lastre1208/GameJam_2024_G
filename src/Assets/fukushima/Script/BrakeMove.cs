using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrakeMove : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Hand")) {
            GameObject child = collision.transform.GetChild(0).gameObject;
            PlayerParameter playerParameter = child.GetComponent<PlayerParameter>();
            playerParameter.SetFlag(true, transform.position.x - child.transform.position.x);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Hand"))
        {
            GameObject child = collision.transform.GetChild(0).gameObject;
            PlayerParameter playerParameter = child.GetComponent<PlayerParameter>();
            playerParameter.SetFlag(false,0);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrakeMove : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Hand")) {
            GameObject child = collision.transform.GetChild(0).gameObject;
            PlayerParameter playerParameter = child.GetComponent<PlayerParameter>();
            playerParameter.SetFlag(true);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Hand"))
        {
            GameObject child = collision.transform.GetChild(0).gameObject;
            PlayerParameter playerParameter = child.GetComponent<PlayerParameter>();
            playerParameter.SetFlag(false);
        }
    }
}

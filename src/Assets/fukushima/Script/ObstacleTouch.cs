using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleTouch : MonoBehaviour
{
    public Collider target;
    PlayerMove playerMove;
    private void Start()
    {
        
        playerMove = GetComponent<PlayerMove>();
    }
    // Start is called before the first frame update
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

                Debug.Log("aaaa");
            playerMove.Onlife = false;
            
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverFlag : MonoBehaviour
{
    [SerializeField]
    PlayerParameter parameter;
    [SerializeField]
    GameObject UIobject;
    bool isGameOver = false;

    public void SetGameOver() => isGameOver = true;
    public bool GetGameOver() => isGameOver;

    // Update is called once per frame
    void Update()
    {
        if (!parameter.Onlife) { SetGameOver();}

        if(GetGameOver()) 
        {
            Invoke("ActiveUI", 2f);
        }
    }
    private void ActiveUI()
    {
        UIobject.SetActive(true);
        CancelInvoke();
    }
}

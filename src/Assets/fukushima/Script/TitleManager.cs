using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleManager : MonoBehaviour
{
    // Start is called before the first frame update
    private bool creditNow = false;
    [SerializeField] GameObject Credit;

    private void Start()
    {
        Credit.SetActive(creditNow);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            StartGame();
        }
        if(Input.GetKeyDown(KeyCode.Space)) {

            ToggleCredit();
        }
    }
    void StartGame()
    {
        SceneManager.LoadScene("Main Scene");
    }
    void ToggleCredit()
    {
        creditNow = !creditNow;
        Credit.SetActive(creditNow);

    }
}

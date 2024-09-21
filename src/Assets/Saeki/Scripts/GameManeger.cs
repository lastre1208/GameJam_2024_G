using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManeger : MonoBehaviour
{
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.R))
        {
            Scene loadScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(loadScene.name);
        }

        if (Input.GetKey(KeyCode.E)&& Input.GetKey(KeyCode.T))
        {
            SceneManager.LoadScene("Title");
        }

        if (Input.GetKey(KeyCode.Escape))
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;//ゲームプレイ終了

#else
            Application.Quit();

#endif
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StarControll : MonoBehaviour
{
    public void LoadLoadingScene()
    {
        // 加载名为"Loading"的场景

        if (SceneManager.GetSceneByName("loading") != null)
        {
            SceneManager.LoadScene("loading");
        }
        else
        {
            Debug.LogError("Scene 'loading' not found.");
        }
    }
}

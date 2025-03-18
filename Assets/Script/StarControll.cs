using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StarControll : MonoBehaviour
{
    public void LoadLoadingScene()
    {
        // ������Ϊ"Loading"�ĳ���

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

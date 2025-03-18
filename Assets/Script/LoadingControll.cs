using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingController : MonoBehaviour
{
    public Slider progressSlider; // 加载进度条
    public float loadDuration = 5.0f; // 从0到100%加载所需时间（秒）
    public string nextSceneName; // 要切换到的下一个场景名称

    private float elapsedTime = 0.0f; // 已经过去的时间

    void Start()
    {
        // 设置进度条初始值为0
        progressSlider.value = 0.0f;
        StartCoroutine(LoadSceneWithProgress());
    }

    private System.Collections.IEnumerator LoadSceneWithProgress()
    {
        // 增加加载进度值
        while (elapsedTime < loadDuration)
        {
            elapsedTime += Time.deltaTime;
            float progress = elapsedTime / loadDuration;
            progressSlider.value = Mathf.Clamp01(progress); // 确保值在0到1之间

            // 等待下一帧
            yield return null;
        }

        // 加载完成后切换到下一个场景
        SceneManager.LoadScene(nextSceneName);
    }
}

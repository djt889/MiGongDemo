using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RegisterManager : MonoBehaviour
{
    public InputField usernameInput;
    public InputField passwordInput;
    public Button registerButton;
  


    private void Start()
    {
        registerButton.onClick.AddListener(Register);
    }
    public void Register()
    {
        string username = usernameInput.text;
        string password = passwordInput.text;

        SaveCredentials(username, password);
        Debug.Log("注册成功");

        // 加载登录场景
        LoadLoginScene();
    }

    private void SaveCredentials(string username, string password)
    {
        // 实现保存逻辑，如保存到PlayerPrefs
        PlayerPrefs.SetString("Username", username);
        PlayerPrefs.SetString("Password", password);
        PlayerPrefs.Save();
    }

    private void LoadLoginScene()
    {
        // 加载名为"Login"的场景
        SceneManager.LoadScene("loginon");
    }
}

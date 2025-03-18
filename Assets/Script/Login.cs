using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public InputField usernameInput;
    public InputField passwordInput;
    public Button button;

    private void Start()
    {
        button.onClick.AddListener(Login1);
    }
    public void Login1()
    {
        string username = usernameInput.text;
        string password = passwordInput.text;

        if (ValidateCredentials(username, password))
        {
            SceneManager.LoadScene("Star");
        }
        else
        {
            Debug.Log("账号或密码错误");
        }
    }

    private bool ValidateCredentials(string username, string password)
    {
        // 实现验证逻辑，如从数据库查询
        return username == PlayerPrefs.GetString("Username") && password == PlayerPrefs.GetString("Password");
    }
}

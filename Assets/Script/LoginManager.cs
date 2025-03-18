using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour
{
    public InputField usernameInput;
    public InputField passwordInput;
    public Button loginButton;

    private void Start()
    {
        // 设置按钮点击事件
        loginButton.onClick.AddListener(OnLoginClicked);
    }

    private void OnLoginClicked()
    {
        string username = usernameInput.text;
        string password = passwordInput.text;

        // 验证账号和密码
        if (username == "admin" && password == "123456")
        {
            // 登录成功，跳转到场景1
            SceneManager.LoadScene("loading");
        }
        else
        {
            // 登录失败，显示错误消息
            Debug.Log("登录失败，账号或密码错误！");
            // 这里可以添加UI提示，比如显示一个错误标签
        }
    }
}

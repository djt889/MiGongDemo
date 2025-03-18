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
            Debug.Log("�˺Ż��������");
        }
    }

    private bool ValidateCredentials(string username, string password)
    {
        // ʵ����֤�߼���������ݿ��ѯ
        return username == PlayerPrefs.GetString("Username") && password == PlayerPrefs.GetString("Password");
    }
}

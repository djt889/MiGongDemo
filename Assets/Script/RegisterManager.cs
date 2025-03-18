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
        Debug.Log("ע��ɹ�");

        // ���ص�¼����
        LoadLoginScene();
    }

    private void SaveCredentials(string username, string password)
    {
        // ʵ�ֱ����߼����籣�浽PlayerPrefs
        PlayerPrefs.SetString("Username", username);
        PlayerPrefs.SetString("Password", password);
        PlayerPrefs.Save();
    }

    private void LoadLoginScene()
    {
        // ������Ϊ"Login"�ĳ���
        SceneManager.LoadScene("loginon");
    }
}

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
        // ���ð�ť����¼�
        loginButton.onClick.AddListener(OnLoginClicked);
    }

    private void OnLoginClicked()
    {
        string username = usernameInput.text;
        string password = passwordInput.text;

        // ��֤�˺ź�����
        if (username == "admin" && password == "123456")
        {
            // ��¼�ɹ�����ת������1
            SceneManager.LoadScene("loading");
        }
        else
        {
            // ��¼ʧ�ܣ���ʾ������Ϣ
            Debug.Log("��¼ʧ�ܣ��˺Ż��������");
            // ����������UI��ʾ��������ʾһ�������ǩ
        }
    }
}

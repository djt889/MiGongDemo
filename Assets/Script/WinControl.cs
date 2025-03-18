using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.PlayerLoop;

public class WinControl : MonoBehaviour
{

    public bool useClick = true;//是否使用点击
    public bool useCollision = false;//是否使用碰撞
    public bool goToNextScene = false;//是否进入下一关
    public string nextScene = "NextScene";//下一关的场景名称
    public GameObject popup;//弹出框GameObject
    public Slider Hpslider;
    public Text statusText;
    void Start()
    {
       
    }

    private void SetHealthStatus(float value)
    {
        string status = "";
        if (value > 90)
        {
            status = "优秀";
        }
        else if (value > 70)
        {
            status = "良好";
        }
        else if (value > 60)
        {
            status = "合格";
        }
        else
        {
            status = "不合格，重新关卡";
            // 处理不合格，重新关卡的操作
        }
        statusText.text = "血量: " + value + "% " + status;
    }
    void Update()
    {
        //处理点击事件
        if (useClick && Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == this.gameObject)
                {
                    HandleInteraction();
                }
            }
        }

        if (useCollision)
        {
            //处理碰撞事件，通常通过OnCollisionEnter函数来处理碰撞
        }

        Hpslider.onValueChanged.AddListener(SetHealthStatus);
    }
    private void HandleInteraction()
    {
        if (popup != null)
        {
            popup.SetActive(true);//显示弹出框
        }

        if (goToNextScene)
        {
            SceneManager.LoadScene(nextScene);//进入下一关
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
           
            Destroy(gameObject);
        }
        if (useCollision && collision.gameObject.CompareTag("Player"))
        {
            HandleInteraction();
            
        }
    }



}

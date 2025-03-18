using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerControl : MonoBehaviour
{
    public int CoinCount = 0;
    private bool isPickup = false;
    public Text CoinText;
    public GameObject Coin;

    public GameObject HitPre;
    public GameObject BombPre;
    private Rigidbody rBody;
    private Animator animator;
    public Text HpText;
    public Slider Hpslider;
    public Slider CoinCountslider;
    public int demage=2;
    

    void Start()
    {
        rBody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();

        
    }

    void Update()
    {


        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(horizontal, 0, vertical);

        if(dir != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(dir);
            animator.SetBool("IsRun", true);
            transform.Translate(Vector3.forward * 2 * Time.deltaTime);
        }
        else
        {
            animator.SetBool("IsRun", false);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetTrigger("pickup");
        }

     
        if (Input.GetKeyDown(KeyCode.F) && isPickup)
        {
            CoinCount++;
            CoinCountslider.value++;
            AudioManger.Instance.PlayCoin(); // 注意：确保AudioManager的拼写正确
            Destroy(Coin);
            Coin = null; // 重置Coin引用，避免后续错误
            Debug.Log("拾取金币：" + CoinCount);
            CoinText.text = "CoinCount:" + CoinCount;
            isPickup = false; // 重置拾取状态
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Wall")
        {
            Hpslider.value -= demage;
            HpText.text = "HP:" + Hpslider.value;
            if (Hpslider.value <= 0)
            {
                AudioManger.Instance.PlayBomb();
                Instantiate(BombPre, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
            else
            {
                Instantiate(HitPre, collision.contacts[0].point, Quaternion.identity);
            }
        }
        

    }

   
    private void OnTriggerEnter(Collider coin)
    {
        if (coin.tag == "Coin")
        {
            Coin = coin.gameObject;
            Debug.Log("触碰到金币");
            isPickup = true;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        
    }
}

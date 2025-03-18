using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //碰撞效果
    public GameObject HitPre;
    //爆炸效果
    public GameObject BombPre;
    //血量
    public int hp = 3;
    private Rigidbody rBody;
   
    void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(horizontal, 0, vertical);
        if (dir != Vector3.zero)
        {
            rBody.velocity = dir * 2;
        }
    }

    //只要碰到碰撞体，就会调用
    private void OnCollisionEnter(Collision collision)
    {
        //如果碰到墙
        if (collision.collider.tag == "Wall")
        {
            hp--;
            if (hp <= 0)
            {
                AudioManger.Instance.PlayBomb();
                //死掉
                Instantiate(BombPre, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
            else
            {
                Instantiate(HitPre, collision.contacts[0].point, Quaternion.identity);
            }
        }
    }
}

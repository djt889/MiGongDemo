using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //��ײЧ��
    public GameObject HitPre;
    //��ըЧ��
    public GameObject BombPre;
    //Ѫ��
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

    //ֻҪ������ײ�壬�ͻ����
    private void OnCollisionEnter(Collision collision)
    {
        //�������ǽ
        if (collision.collider.tag == "Wall")
        {
            hp--;
            if (hp <= 0)
            {
                AudioManger.Instance.PlayBomb();
                //����
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

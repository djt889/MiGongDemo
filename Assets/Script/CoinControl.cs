using UnityEngine;
using UnityEngine.UI;

public class CoinControl : MonoBehaviour
{
    public int CoinCount = 0;
    //private bool isPickup = false;
    public Text CoinText;

    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(Vector3.forward * 90 * Time.deltaTime);
        //if (isPickup && Input.GetKeyDown(KeyCode.F))
        //{
        //    CoinCount++;
        //    AudioManger.Instance.PlayCoin();
        //    Destroy(gameObject);
        //    Debug.Log("ʰȡ��ң�" + CoinCount);
        //    CoinText.text = "CoinCount:" + CoinCount;
        //}
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    Debug.Log("���������");
    //    if (other.tag == "Player")
    //    {
    //        isPickup = true;
    //    }

    //}
    //private void OnTriggerExit(Collider other)
    //{
    //    isPickup = false;
    //}
    private void OnDestroy()
    {
        AudioManger.Instance.PlayCoin();
    }
}


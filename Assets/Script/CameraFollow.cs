using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // ��������Transform���
    public Vector3 offset; // ����������֮���ƫ����

    void LateUpdate()
    {
        // �����ʼ�ո�����ҵ�λ��
        transform.position = player.position + offset;

        // �����ʼ�ճ�����ҵ��ƶ�����
        transform.LookAt(player);
    }
}

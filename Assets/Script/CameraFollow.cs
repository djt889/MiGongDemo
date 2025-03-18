using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // 玩家物体的Transform组件
    public Vector3 offset; // 摄像机与玩家之间的偏移量

    void LateUpdate()
    {
        // 摄像机始终跟随玩家的位置
        transform.position = player.position + offset;

        // 摄像机始终朝向玩家的移动方向
        transform.LookAt(player);
    }
}

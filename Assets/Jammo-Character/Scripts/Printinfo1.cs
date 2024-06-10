using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Printinfo1 : MonoBehaviour
{
    private int collisionCount = 0; // 碰撞次数统计
    void OnTriggerEnter(Collider other)
    {
        // 检测到触发器触发时增加计数器并输出触发器信息
        collisionCount++;
        Debug.Log("Trigger Detected! Count: " + collisionCount + ", Trigger: " + other.name);
    }
}

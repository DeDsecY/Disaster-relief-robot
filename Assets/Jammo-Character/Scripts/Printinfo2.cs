using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Printinfo2 : MonoBehaviour
{
    private int collisionCount = 0; // 碰撞次数统计
    // Start is called before the first frame update
    void Start()
    {
        // 输出对象的位置
        Debug.Log("Position: " + transform.position);

        // 输出对象的面向方向
        Debug.Log("Facing Direction: " + transform.forward);
    }

    // Update is called once per frame
    void Update()
    {
        // 输出对象的位置
        Debug.Log("Position: " + transform.position);

        // 输出对象的面向方向
        Debug.Log("Facing Direction: " + transform.forward);
    }
    
}

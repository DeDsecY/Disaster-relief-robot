using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform target; // 要跟随的目标对象
    public float distance = 5.0f; // 摄像机与目标之间的距离
    public float height = 4.0f; // 摄像机相对于目标的高度
    public float damping = 5.0f; // 摄像机移动的平滑程度

    private void LateUpdate()
    {
        // 确保目标对象存在
        if (!target)
            return;

        // 计算目标位置
        Vector3 targetPosition = target.position - target.forward * distance + Vector3.up * height;

        // 直接设置摄像机位置
        transform.position = targetPosition;

        // 摄像机看向目标
        transform.LookAt(target.position);
    }
}
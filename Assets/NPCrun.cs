using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCrun : MonoBehaviour
{
    public Vector3 targetPosition = new Vector3(103f, 0f, 17f); // 目标位置
    private NavMeshAgent agent; // 导航代理组件

    void Start()
    {
        agent = GetComponent<NavMeshAgent>(); // 获取NavMeshAgent组件
        if (agent == null)
        {
            Debug.LogError("NavMeshAgent组件未添加到NPC游戏对象上！");
        }
        else if (agent.isOnNavMesh)
        {
            // 开始寻路
            agent.SetDestination(targetPosition);
        }
        else
        {
            Debug.LogError("NPC不在导航网格上，无法进行寻路！");
        }
    }

    void Update()
    {
        // 如果已经到达目标位置，停止移动
        if (!agent.pathPending && agent.remainingDistance < 0.1f)
        {
            // 停止寻路
            agent.isStopped = true;
            enabled = false; // 禁用脚本
        }
    }
}


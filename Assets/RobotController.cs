using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("NPC"))
        {
            // 如果Robot接触到NPC，通知NPC开始跟随Robot
            other.GetComponent<NPCController>().StartFollowing(transform);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("NPC"))
        {
           
        }
    }
}

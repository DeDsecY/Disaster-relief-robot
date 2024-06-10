using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    public float followSpeed = 2f; // Speed at which NPC follows the robot

    private Transform robotTransform; // Reference to the robot transform

    // Start following the robot
    public void StartFollowing(Transform robot)
    {
        robotTransform = robot;
    }

    void Update()
    {
        if (robotTransform != null)
        {
            // Calculate direction from NPC to Robot
            Vector3 direction = robotTransform.position - transform.position;
            direction.y = 0f; // Ensure NPC moves only along the horizontal plane

            // If the NPC is not close enough to the Robot
            if (direction.magnitude > 1f)
            {
                // Move NPC towards the Robot
                transform.position += direction.normalized * followSpeed * Time.deltaTime;

                // Rotate NPC to face the Robot
                transform.rotation = Quaternion.LookRotation(direction);
            }
        }
    }
}

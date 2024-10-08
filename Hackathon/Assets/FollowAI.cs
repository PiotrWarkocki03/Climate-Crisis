using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowAI : MonoBehaviour
{
    public NavMeshAgent ai;
    public Transform player;
   // public Animator animator;
    Vector3 dest;

    void Update()
    {
        dest = player.position;
        ai.destination = dest;

       /* if (!ai.pathPending)
        {
            if (ai.remainingDistance <= ai.stoppingDistance)
            {
                animator.ResetTrigger("");
                animator.SetTrigger("");
            }
        }
        else
        {
            animator.ResetTrigger("");
            animator.SetTrigger("");
        }
       */
    }
}

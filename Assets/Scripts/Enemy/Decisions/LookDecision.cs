﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PluggableAI/Decisions/Look")]
public class LookDecision : Decision
{
    public override bool Decide(EnemyStateController controller)
    {
        bool targetVisible = Look(controller);
        return targetVisible;
    }

    private bool Look(EnemyStateController controller)
    {
        // Check if an object is in front of this object, then attack it
        // RaycastHit2D hit = Physics2D.CircleCast(controller.eyes.position, 1.0f, controller.eyes.right, 10.0f);
        //RaycastHit2D hit = Physics2D.BoxCast(controller.eyes.position, new Vector2(controller.enemyData.lookRange, 1.0f), 0.0f, controller.eyes.TransformDirection(Vector3.right));
        RaycastHit2D hit = Physics2D.Raycast(controller.eyes.position, controller.eyes.TransformDirection(Vector3.right), controller.stats.chaseRange, controller.playerLayer);

        // Debug.Log(hit.transform.name);

        Debug.DrawRay(controller.eyes.position, controller.eyes.TransformDirection(Vector3.right) * controller.stats.chaseRange, Color.green);
        // Debug.DrawLine(controller.eyes.position, controller.eyes.TransformPoint(controller.eyes.position) * Vector3.right, Color.green);

        if(hit && hit.collider.CompareTag("Player"))
        {
            controller.chaseTarget = hit.transform;
            return true;
        }
        else
        {
            return false;
        }
    }
}

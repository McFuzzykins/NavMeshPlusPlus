using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleAvoidance : Seek
{
    public float avoidDist = 3f;
    public float lookAhead = 3f;
    public bool bonkWall = false;

    protected override Vector3 getTargetPosition()
    {
        RaycastHit hit; 

        if (Physics.Raycast(character.transform.position, character.linearVelocity, out hit, lookAhead))
        {
            bonkWall = true;
            return hit.point + (hit.normal * avoidDist);
        }
        else
        {
            bonkWall = false;
            return base.getTargetPosition();
        }
    }
}

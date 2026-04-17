/*****************************************************************************
// File Name :         WallBullet.cs
// Author :            Ethan Blankenship
// Creation Date :     April 16, 2026
//
// Brief Description : bullet code that I have not finished. What I want it to do 
is spawn a wall or something when the bullet hits the ground on impact.
*****************************************************************************/
using UnityEngine;

public class WallBullet : MonoBehaviour
{
    /// <summary>
    /// spawn Wall on walls and ground tagged objects. and delete on tag of lava.
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        //spawn Wall on walls and ground tagged objects. and delete on tag of lava.
    }
}

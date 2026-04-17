/*****************************************************************************
// File Name :         Bullet.cs
// Author :            Ethan Blankenship
// Creation Date :     April 16, 2026
//
// Brief Description : This code kills the bullet after The KillTime in Seconds.
*****************************************************************************/
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float KillTime;
    /// <summary>
    /// Destroys after KillTime seconds
    /// </summary>
    private void Awake()
    {
        Destroy(gameObject, KillTime);
    }
}

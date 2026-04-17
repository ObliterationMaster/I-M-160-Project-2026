/*****************************************************************************
// File Name :         SpinScript.cs
// Author :            Ethan Blankenship
// Creation Date :     April 16, 2026
//
// Brief Description :Sets the spin of the object it attaches to.
*****************************************************************************/
using UnityEngine;

public class SpinScript : MonoBehaviour
{
    [SerializeField] private float xspeed;
    [SerializeField] private float yspeed;
    [SerializeField] private float zspeed;

    /// <summary>
    /// constinly rotates the object by the speed values above.
    /// </summary>
    void Update()
    {
        transform.Rotate(xspeed * Time.deltaTime, yspeed * Time.deltaTime, zspeed * Time.deltaTime);
    }
}

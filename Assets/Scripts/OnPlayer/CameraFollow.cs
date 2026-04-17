/*****************************************************************************
// File Name :         CameraFollow.cs
// Author :            Ethan Blankenship
// Creation Date :     March 26, 2026
//
// Brief Description : makes the camersa follow the player.
*****************************************************************************/
using UnityEngine;
using UnityEngine.InputSystem;
public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Vector3 offset;
    /// <summary>
    /// code that make the camera offset the player it is set to 0 for first person.
    /// </summary>
    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
    ///
/*    public void Look(InputAction.CallbackCotext cotext)
    {

    }*/
}

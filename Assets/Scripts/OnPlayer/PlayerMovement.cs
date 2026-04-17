/*****************************************************************************
// File Name :         PlayerController.cs
// Author :            Ethan Blankenship
// Creation Date :     March 26, 2026
//
// Brief Description : Player movement script.
*****************************************************************************/
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    //variables
    private Rigidbody rb;
    //inputsystem variables
    //turning camera variables
    private InputAction move;
    [SerializeField] private float speed;

    private Vector3 playerMovement;
  /// <summary>
  /// inisiatyes the move funtions and rb is called
  /// </summary>
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        move = InputSystem.actions.FindAction("Move");
        move.performed += MovePerformed;
        move.canceled += MoveCanceled;
    }
    /// <summary>
    /// sets movement to 0 when not using the movement action
    /// </summary>
    /// <param name="obj"></param>
    private void MoveCanceled(InputAction.CallbackContext obj)
    {
        playerMovement = Vector3.zero;
    }
    /// <summary>
    /// set player movement for fixed update
    /// </summary>
    /// <param name="obj"></param>
    private void MovePerformed(InputAction.CallbackContext obj)
    {
        playerMovement.x = obj.ReadValue<Vector2>().x * speed;
        playerMovement.z = obj.ReadValue<Vector2>().y * speed;
    }

    /// <summary>
    /// sets the player movement
    /// </summary>
    private void FixedUpdate()
    {
        // rb.linearVelocity = new Vector3(playerMovement.x, rb.linearVelocity.y, playerMovement.z);
        rb.linearVelocity = transform.TransformDirection(new Vector3(playerMovement.x, rb.linearVelocity.y, playerMovement.z));
    }
}

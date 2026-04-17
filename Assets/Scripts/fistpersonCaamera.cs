using UnityEngine;
using UnityEngine.InputSystem;

public class fistpersonCaamera : MonoBehaviour
{

    [SerializeField] private Transform roatationxtarget;
    [SerializeField] private Transform roatationytarget;
    [SerializeField] private float rotationSesitivyt;
    [SerializeField] private float VeritcalRotation;
    private InputAction look;
    private float xPoint;
    private float yPoint;
    [SerializeField] private float rotationLimit;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        look = InputSystem.actions.FindAction("Look");
        Cursor.visible =false;
        Cursor.lockState = CursorLockMode.Locked;
        
    }
    private void LateUpdate()
    {

        yPoint = look.ReadValue<Vector2>().y * rotationSesitivyt;
        
        VeritcalRotation -= yPoint;
        VeritcalRotation = Mathf.Clamp( VeritcalRotation, -rotationLimit, rotationLimit );
        roatationxtarget.localEulerAngles = Vector3.right * VeritcalRotation;
        roatationxtarget.Rotate(Vector3.right * VeritcalRotation);
        
        xPoint = look.ReadValue<Vector2>().x* rotationSesitivyt;
        roatationytarget.Rotate(Vector3.up *xPoint);
    }
}

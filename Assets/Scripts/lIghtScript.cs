/*****************************************************************************
// File Name :         lIghtScript.cs
// Author :            Ethan Blankenship
// Creation Date :     April 16, 2026
//
// Brief Description : Sets the light on of off in the script editor. Switches the light on and off when it is 
hit by bullets.
*****************************************************************************/
using UnityEngine;

public class lIghtScript : MonoBehaviour
    // 0 = off
{ [SerializeField] private int lit;
    [SerializeField] private GameObject lightObject;
    /// <summary>
    /// on awake since the light is default to on when lit is set to 0 it sets the light to false.
    /// </summary>
    private void Awake()
    {
        //this means that the light should always be lit as default and only set at 0 in this script.
        if (lit == 0)
        {
            lightObject.SetActive(false);
        }
    }
    /// <summary>
    /// the switch statement that turns on and off the light when it is hit. While switching the light on and off.
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Bullet") && lit == 0)
        {
            lightObject.SetActive(true);
            lit = 1;
            print(lit);
            Destroy(collision.gameObject);
        }
        else 
        {
            lightObject.SetActive(false);
            lit = 0;

            print(lit);
            Destroy(collision.gameObject);
        }
    }
}

/*****************************************************************************
// File Name :         KeyScript.cs
// Author :            Ethan Blankenship
// Creation Date :     April 16, 2026
//
// Brief Description : The script on a key that makes the door conected to it open/ setActive(false)
*****************************************************************************/
using UnityEngine;
public class KeyScript : MonoBehaviour
{
    [SerializeField] private GameObject door;
    /// <summary>
    /// The collition deteciton that activates on the given key and the Player to setActive(false).
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && gameObject.tag == "Kgold")
        {
            Destroy(gameObject);
            door.SetActive(false);
        }
    }
}

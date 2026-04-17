/*****************************************************************************
// File Name :         DestructableObjects.cs
// Author :            Ethan Blankenship
// Creation Date :     March 26, 2026
//
// Brief Description : code conectd to destructable walls or objects to destroy them.
*****************************************************************************/
using UnityEngine;

public class DestructableObjects : MonoBehaviour
{
    [SerializeField] private GameObject spawnItem;
    /// <summary>
    /// When the object is destroyed it will spawn the prefab  connected to it.
    /// </summary>
    private void OnDestroy()
    {


    }
    /// <summary>
    /// set the health to full.
    /// </summary>
    void Start()
    {
        
    }  
    /// <summary>
    /// detection of objects that can destroy the object.
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
                if (collision.gameObject.CompareTag("Bullet") && gameObject.tag == "RegularDGO")
        {
                   if (spawnItem != null)
                    {
                          Instantiate(spawnItem, transform.position, Quaternion.identity);
                    }
           // collectSound.Play(); //sound that make when the object is destroyed
           Destroy(gameObject);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Explosive") && gameObject.tag == "ExplosiveDGO")
        {
            if (spawnItem != null)
            {
                Instantiate(spawnItem, transform.position, Quaternion.identity);
            }
            // collectSound.Play(); //sound that make when the object is destroyed
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }


}

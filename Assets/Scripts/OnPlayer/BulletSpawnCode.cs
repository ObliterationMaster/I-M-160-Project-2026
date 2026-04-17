/*****************************************************************************
// File Name :         BulletSpawnCode.cs
// Author :            Ethan Blankenship
// Creation Date :     March 26, 2026
//
// Brief Description : supposed to spawn bullets with velosity to the
*****************************************************************************/
using UnityEngine;
using UnityEngine.InputSystem;

public class BulletSpawnCode : MonoBehaviour
{
    // nothing right now 
    [SerializeField] private GameObject regularBullet;

    //Need to make the prefabs to connect ot explosive bullet
    [SerializeField] private GameObject explosiveBullet;
    [SerializeField] private GameObject wallBullet;
    [SerializeField] private float bulletSpeed;
    private InputAction shoot;
    [SerializeField] private GameObject gun;
    private GameObject bullet;
    private InputAction SwitchBullet;
    private int GunState;
    [SerializeField] private Material RegularGun;
    [SerializeField] private Material ExplosiveGun;
    [SerializeField] private Material WallGun;


    private void Start()
    {
        SwitchBullet = InputSystem.actions.FindAction("SwitchBullet");
        shoot = InputSystem.actions.FindAction("Shoot");
        shoot.performed += ShootPerformed;
        SwitchBullet.performed += SwitchBulletPerformed;
    }

    private void SwitchBulletPerformed(InputAction.CallbackContext obj)
    {           if(GunState < 2)
        {if(GunState ==0 )
            {
                gun.GetComponent<MeshRenderer>().material = ExplosiveGun;

            }
            if (GunState == 1)
            {
                gun.GetComponent<MeshRenderer>().material = WallGun;
             }



                GunState++;
            
            //Then Change gun color to differentiate or change material
        }
        else 
        {
            gun.GetComponent<MeshRenderer>().material = RegularGun;
            GunState = 0;
            //gun state back to regular color
        }


    }

    private void ShootPerformed(InputAction.CallbackContext obj)
    {
        switch (GunState)
        {
            case 0:
                print("regular Shot");
                bullet = Instantiate(regularBullet, gun.transform.position, Quaternion.identity);

                break;
            case 1:
            
                print("Explosive Shot");
                bullet = Instantiate(explosiveBullet, gun.transform.position, Quaternion.identity);

                break;
            case 2:

                print("Wall Shot");
                bullet = Instantiate(wallBullet, gun.transform.position, Quaternion.identity);

                break;
        }
        bullet.GetComponent<Rigidbody>().AddForce(gun.transform.up * 200 * bulletSpeed);
    }

    private void OnDestroy()
    {
        shoot.performed -= ShootPerformed;
        SwitchBullet.performed -= SwitchBulletPerformed;
    }
}

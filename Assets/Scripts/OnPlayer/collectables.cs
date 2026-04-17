 /*****************************************************************************
// File Name :         collectables.cs
// Author :            Ethan Blankenship
// Creation Date :     March 26, 2026
//
// Brief Description : collectable code that sits of player.
*****************************************************************************/
using Mono.Cecil.Cil;
using TMPro;
using UnityEngine;

public class collectables : MonoBehaviour
{
    [SerializeField] private TMP_Text coinText;
    private int Coincount;
    //[SerializeField] private TMP_Text KeyText;
    private int Keycount;
    //[SerializeField] private int DoorRequirement;
    //[SerializeField] private int keynumber;
    void Start()
    {

        coinText.text = "Coins: " + Coincount.ToString();   //ToString because we are smarter than machine
        //KeyText.text = Keycount.ToString() + "    ";
    }

  /* private void OnTriggerEnter(Collision trigger)
    {
        //
        if (trigger.gameObject.CompareTag("CoinTag"))
        {   //calls the funtion to add coins and chang the number in the textmeshpro
            coinMath(1);
    
         
            Destroy(trigger.gameObject);
        }
        //keys that increase
        // does not work.
     /*   if (collision.gameObject.CompareTag("KeyTag"))
        {
            Keycount++;

            KeyText.text = Keycount.ToString() + "    "; 
            Destroy(collision.gameObject);
        }

      /*  if (collision.gameObject.CompareTag("Door") && DoorRequirement <= keynumber)
        {

       } 


    } */ 
    /// <summary>
    /// collects the item or power up on collision
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter(Collider trigger)
    {
        if (trigger.gameObject.CompareTag("CoinTag"))
        {   //calls the funtion to add coins and chang the number in the textmeshpro
            coinMath(1);


            Destroy(trigger.gameObject);
        }
    }
    public void coinMath(int coin)
    {
        Coincount = coin + Coincount;
        coinText.text = "Coins: " + Coincount.ToString();
       
    }


}
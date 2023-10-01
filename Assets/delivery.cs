using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delivery : MonoBehaviour
{

   [SerializeField] float destroyDelay = 0.1f;
   bool hasPackage = false;

   private void OnCollisionEnter2D(Collision2D other) 
   {
    Debug.Log("Ouch!");
   }

   private void OnTriggerEnter2D(Collider2D other) 
   {
    if (other.tag == "Package" && hasPackage == false) // !hasPackage
    {
      Debug.Log("Package Picked Up!");
      hasPackage = true;
      Destroy(other.gameObject, destroyDelay);
    } 

    if (other.tag == "Customer" && hasPackage == true) // hasPackage
    {
      Debug.Log("Package Delivered!");
      hasPackage = false;
    }
   }

   // private void OnTriggerExit2D(Collider2D other) 
   // {
   //  Debug.Log("Player Exit!");
   // }
}

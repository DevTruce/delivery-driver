using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
   private void OnCollisionEnter2D(Collision2D other) 
   {
    Debug.Log("Ouch!");
   }

   private void OnTriggerEnter2D(Collider2D other) 
   {
    Debug.Log("Player Enter!");
   }

   private void OnTriggerExit2D(Collider2D other) 
   {
    Debug.Log("Player Exit!");
   }
}

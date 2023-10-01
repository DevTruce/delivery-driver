using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delivery : MonoBehaviour
{

  [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
  [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);
  [SerializeField] float destroyDelay = 0.1f;

  bool hasPackage = false;

  SpriteRenderer spriteRenderer;

  private void Start()
  {
    spriteRenderer = GetComponent<SpriteRenderer>();
  }
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
      spriteRenderer.color = hasPackageColor;
      Destroy(other.gameObject, destroyDelay);
    } 

    if (other.tag == "Customer" && hasPackage == true) // hasPackage
    {
      Debug.Log("Package Delivered!");
      hasPackage = false;
      spriteRenderer.color = noPackageColor;
    }
   }

   // private void OnTriggerExit2D(Collider2D other) 
   // {
   //  Debug.Log("Player Exit!");
   // }
}

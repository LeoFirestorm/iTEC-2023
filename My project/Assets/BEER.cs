using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BEER : MonoBehaviour
{
   
   private void OnTriggerEnter(Collider other) 
   {
      print("Beer");

      Inventory Inventory = other.GetComponent<Inventory>();

      if(Inventory != null)
      {
        Inventory.BEERCollected();
        gameObject.SetActive(false);
      }  
   } 
}

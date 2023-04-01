using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory PlayerInventory = other.GetComponent<PlayerInventory>();
        if (PlayerInventory != null)
        {
            PlayerInventory.BeerCollected();
            gameObject.SetActive(false);
        }
    }
}

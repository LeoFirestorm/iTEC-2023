using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfbeers { get; private set; }
    public static object Numberofbeers { get; internal set; }

    public UnityEvent<PlayerInventory> OnBeerCollected; 
    public void BeerCollected()
    {
        NumberOfbeers++;
        OnBeerCollected.Invoke(this);
    }
}

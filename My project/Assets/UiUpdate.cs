using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiUpdate : MonoBehaviour
{
    private TextMeshProUGUI Bottle;

    // Start is called before the first frame update
    void Start()
    {
        Bottle = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateBottle(PlayerInventory playerInventory)

    {
        Bottle.text = PlayerInventory.Numberofbeers.ToString();
    }

}

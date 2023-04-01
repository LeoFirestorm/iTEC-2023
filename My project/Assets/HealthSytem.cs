using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSytem : MonoBehaviour
{

    public float maxHealth;
    public float currentHealth;

    public float damage;
    public float healing;
    public GameObject Player;
    public GameObject Enemy;
    public GameObject Playerlife;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            DamageHealth();
            print("TOUCHING");
        }
    }

    private void Start()
    {
        currentHealth = maxHealth;
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ApplyHealing();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            DamageHealth();
        }

        if (currentHealth == 0|| currentHealth < 0) Destroy(Playerlife);

       
    }

  

    void ApplyHealing()
    {
        if (currentHealth < maxHealth)
        {
            currentHealth = currentHealth + healing;
        }
    }

    public void DamageHealth()
    {
        if (currentHealth > 0)
        {
            currentHealth = currentHealth - damage;
        }
    }



    
}

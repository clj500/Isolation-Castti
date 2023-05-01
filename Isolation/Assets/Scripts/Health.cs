using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int health = 100;

    private int MAX_HEALTH = 100;

    // Update is called once per frame
    void Update()
    {
        // Debug for controlling player health
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //Damage(10);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
           // Heal(10);
        }
    }

    public void Damage(int amount)
    {
        if (amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot have negative Damage values!");
        }

        this.health -= amount;

        if (health <= 0)
        {
            Die();
        }
    }

    public void Heal(int amount)
    {
        if (amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot have negative Healing values!");
        }

        bool overMaxHealth = health + amount > MAX_HEALTH;

        if (overMaxHealth)
        {
            health = MAX_HEALTH;
        }
        else
        {
            this.health += amount;
        }

    }

    private void Die()
    {
        Debug.Log("You Are Dead!");
        Destroy(gameObject);
    }
}

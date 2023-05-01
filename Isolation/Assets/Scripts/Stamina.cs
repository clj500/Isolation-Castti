using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stamina : MonoBehaviour
{
    [SerializeField] private int stamina = 200;

    private int MAX_STAMINA = 200;

    // Update is called once per frame
    void Update()
    {
        // Debug for controlling player health
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Fatigue(10);
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            Energize(10);
        }
    }

    public void Fatigue(int amount)
    {
        if (amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot have negative Fatigue values!");
        }

        this.stamina -= amount;

        if (stamina <= 0)
        {
            PassOut();
        }
    }

    public void Energize(int amount)
    {
        if (amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot have negative Energize values!");
        }

        bool overMaxHealth = stamina + amount > MAX_STAMINA;

        if (overMaxHealth)
        {
            stamina = MAX_STAMINA;
        }
        else
        {
            this.stamina += amount;
        }

    }

    private void PassOut()
    {
        Debug.Log("You Have Passed Ou!");
        Destroy(gameObject);
    }
}

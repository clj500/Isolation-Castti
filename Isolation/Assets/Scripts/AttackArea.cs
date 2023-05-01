using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackArea : MonoBehaviour
{
    [SerializeField] private int damage = 3;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        // Checks whether the collider that attackArea has collided with has a Health value
        if (collider.GetComponent<Health>() != null)
        {
            Health health = collider.GetComponent<Health>();
            health.Damage(damage);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClick : MonoBehaviour
{
    public GameObject player;
    public GameObject gameObject;
    public Inventory inventory;

    public AudioSource click;
    public AudioSource destroy;

    private float distance;

    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
    }

    void OnMouseDown()
    {
        click.Play();

        if (distance < 5)
        {
            StartCoroutine(wait());

            IEnumerator wait()
            {
                destroy.Play();

                //Wait for 5 seconds
                yield return new WaitForSeconds(5);

                Destroy(gameObject);
            }
        }
    }
}

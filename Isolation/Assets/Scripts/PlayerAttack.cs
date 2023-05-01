using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    // Reference to the player animator
    public Animator animator;
    // reference to animator parameters
    public string attack = "Attack";


    private GameObject attackArea = default;

    private bool isAttacking = false;

    private float attackDuration = 0.25f;
    private float timer = 0f;

    private void Start()
    {
        attackArea = transform.GetChild(0).gameObject;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }

        if (isAttacking)
        {
            timer += Time.deltaTime;

            if (timer >= attackDuration)
            {
                timer = 0;
                isAttacking = false;
                attackArea.SetActive(isAttacking);
            }
        }
    }

    private void Attack()
    {
        isAttacking = true;
        attackArea.SetActive(isAttacking);
        animator.SetTrigger(attack);
    }

    /* // Reference to the player animator
     public Animator animator;
     // reference to animator parameters
     public string attack = "Attack";
     // For attack delay b/w playing the animation
     public float delay = 0.3f;
     private bool actionBlocked;


     // Start is called before the first frame update
     void Start()
     {
         attackArea = transform.GetChild(0).gameObject;
     }

     // Update is called once per frame
     void Update()
     {
         if (Input.GetKeyDown(KeyCode.Space))
         {
             Attack();
         }
     }

     // Method to play attack animation
     public void Attack()
     {
         if (actionBlocked)
         {
             return;
         }
         attackArea.SetActive(true);

         animator.SetTrigger(attack);
         actionBlocked = true;
         StartCoroutine(DelayAttack());
     }

     private IEnumerator DelayAttack()
     {
         yield return new WaitForSeconds(delay);
         actionBlocked = false;

         attackArea.SetActive(false);
     }*/
}

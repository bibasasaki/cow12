using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cawzombie : MonoBehaviour
{
    [SerializeField] private int HP = 100;
    private Animator animator;
    public bool isDead;

    public victory vin;

    private void Start()
    {
        animator = GetComponent<Animator>();  
    }

    public void TakeDamage(int damageAmount)
    {
        HP -= damageAmount;

        if (HP <= 0 && !isDead)
        {
            isDead = true;
            animator.SetTrigger("DIE");
            vin.Victory();
            Destroy(gameObject);
        }
        else
        {
            animator.SetTrigger("DAMAGE");
        }
    }

    internal void TakeDamage()
    {
        throw new NotImplementedException();
    }
}

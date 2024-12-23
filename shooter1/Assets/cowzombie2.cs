using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cowzombie2 : MonoBehaviour
{
    [SerializeField] private int HP = 100;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();  
    }

    public void TakeDamage(int damageAmount)
    {
        HP -= damageAmount;

        if (HP <= 0 )
        {
            animator.SetTrigger("DIE");
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

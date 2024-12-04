
using System;
using System.Collections;
using UnityEngine;


public class damage : MonoBehaviour
{
    [SerializeField] private float reloadTimer = 2f;
   [field: SerializeField] public float DamageAmount {get; private set;}
     [field: SerializeField] public bool IsActive {get; private set;} = true;

    public void ReleaseDamage(){
        IsActive = false;
        Invoke(nameof(ResetFlag), reloadTimer);

    }

    private void ResetFlag() => IsActive = true;


    private bool isDamaiging;
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out healthbar hp))
        {
            isDamaiging = true;
            StartCoroutine(ApplyDamage(hp));
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out healthbar hp))
        {
            isDamaiging = false;
        }
    }

    IEnumerator ApplyDamage(healthbar hp)
    {
        while (isDamaiging)
        {
            Debug.Log("DAMAGE PLAYER!!");
            hp.TakeDamage(DamageAmount);
            ReleaseDamage();
            yield return new WaitForSeconds(1);
        }
    }

       
}


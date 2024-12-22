using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAttack : MonoBehaviour
{
      private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.CompareTag("Melee"))
        {
            print("hit" + collider.gameObject.name + " !");
            Destroy(collider.gameObject);
        }
    }
}

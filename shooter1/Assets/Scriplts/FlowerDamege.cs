using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerDamege : MonoBehaviour
{
    // Start is called before the first frame update


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Melee"))
            Destroy(gameObject);//Or apply a damage method
    }
}

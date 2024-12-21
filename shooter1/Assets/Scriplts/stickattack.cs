using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stickattack : MonoBehaviour
{
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            anim.SetBool("attacking",true);
        else if(Input.GetButtonUp("Fire1"))
            anim.SetBool("attacking", false);
        
           
    }
}

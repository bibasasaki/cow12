using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stickattack : MonoBehaviour
{
    Animator anim;
    public Collider call;

    private void Start()
    {
        anim = GetComponent<Animator>();
        call.enabled = false;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            anim.SetBool("attacking",true);
            call.enabled = true;
        }
        else if(Input.GetButtonUp("Fire1"))
        {
            anim.SetBool("attacking", false);
            call.enabled = false;
            
        }
        
           
    }
}

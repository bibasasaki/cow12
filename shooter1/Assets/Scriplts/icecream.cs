using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class icecream : MonoBehaviour, IClickable
{
    private Outline _outline;
    private bool isUsed;

    public weapons _gun;

    private void Awake()
    {
        _outline = GetComponent<Outline>();
        _outline.enabled = false;
    }



    public  void Hover()
    {
        if(isUsed) return;
        _outline.enabled = true;
        Debug.Log("Hover");

    }
    public void UnHover()
    {
        if(isUsed) return;

        _outline.enabled = false;
          Debug.Log("UNHover");
    }
    public void Click()
    {
        if (!isUsed)
        {
        _gun.Reload();
        isUsed = true;
        }
        Destroy(gameObject);

    }
}

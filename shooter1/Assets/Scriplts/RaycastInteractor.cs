using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastInteractor : MonoBehaviour
{
    [SerializeField] private Camera camera;
    [SerializeField] private float rayLength = 100f;
    [SerializeField] private LayerMask interactableLayers;

    private Ray _ray;
    private RaycastHit _hit;

    private IClickable _current;
    private IClickable _previous;
   

  
    private void Update()
    {
        
        _ray = camera.ScreenPointToRay(new Vector3(Screen.width * 0.5f, Screen.height * 0.5f, 10f));
        bool hasHit = Physics.Raycast(_ray, out _hit, rayLength, interactableLayers);    
        
        // если луч куда то попадает
        if(hasHit && _hit.collider.TryGetComponent(out IClickable actualClickable))
        {
            _previous = _current;
            _current = actualClickable;

            if(_previous != _current)
            {
                  OnFocusExit(ref _previous);
                _current.Hover();
              
            }

            if(Input.GetKeyDown(KeyCode.F))
            {
                _current.Click();
            }


            

        }
        else
        {
            OnFocusExit(ref _previous);
            OnFocusExit(ref _current);
        }
    }


    private void OnFocusExit(ref IClickable clickable)
    {
        if(clickable != null)
        {
            clickable.UnHover();
            clickable = null;
        }

    }
    
}

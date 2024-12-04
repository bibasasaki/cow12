
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




       
}


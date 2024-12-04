
using UnityEngine;

public class PlayerCollisionChecker : MonoBehaviour
{

    private healthbar hp;

    void Awake(){
        hp = GetComponent<healthbar>();
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
       // if(hit.collider.TryGetComponent(out damage enemy) && enemy.IsActive)
       // {
       //      hp.TakeDamage(enemy.DamageAmount);
       //      enemy.ReleaseDamage();
       // }
    }
}

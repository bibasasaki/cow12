using UnityEngine;

public class bullets : MonoBehaviour
{
    public int bulletDamage;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Target"))
        {
            print("hit" + collision.gameObject.name + " !");
            Destroy(gameObject);
        }

        if(collision.gameObject.CompareTag("Zombie"))
        {
            collision.gameObject.GetComponent<cawzombie>().TakeDamage(bulletDamage);
            print("hit" + collision.gameObject.name + " !");
            Destroy(gameObject);
        }
    }
}

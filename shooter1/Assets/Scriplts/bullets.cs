using UnityEngine;

public class bullets : MonoBehaviour
{
    private int bulletDamage;


    public void Init(Vector3 direction, float velocity, int damage)
    {
        bulletDamage = damage;
        GetComponent<Rigidbody>().AddForce(direction * velocity, ForceMode.Impulse);
    }    

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Target"))
        {
            print("hit" + collision.gameObject.name + " !");
            Destroy(gameObject);
        }

        if (collision.gameObject.TryGetComponent(out cawzombie cow))
        {
            cow.TakeDamage(bulletDamage);
            Debug.Log("hit" + cow.name + " !");
            Destroy(gameObject);
        }
        if (collision.gameObject.TryGetComponent(out cowzombie2 cow2))
        {
            cow2.TakeDamage(bulletDamage);
            Debug.Log("hit" + cow.name + " !");
            Destroy(gameObject);
        }

    }
}

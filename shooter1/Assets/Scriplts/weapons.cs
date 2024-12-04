
using System.Collections;
using TMPro;
using UnityEngine;

public class weapons : MonoBehaviour
{
   public bool isShooting, readyToShoot;

   public int bulletsPerBurst = 1;
   public int currentBurst;
   public int weaponDemage;

    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float bulletVelocity = 30;
    public float bulletPrefabLifeTime = 3f;


public float reloadTime;
public int magazineSize, bulletsLeft;
public bool isReloading;

public TextMeshProUGUI ammoDisplay;




    // Update is called once per frame
    void Update()
    {
     

     if(Input.GetKeyDown(KeyCode.R) && bulletsLeft < magazineSize && isReloading == false)
     {
      Reload();
     }

     if (ammoDisplay != null)
     {
      ammoDisplay.text = $"{bulletsLeft/bulletsPerBurst}/{magazineSize/bulletsPerBurst}";
     }

     if(!isReloading && readyToShoot && Input.GetKeyDown(KeyCode.Mouse0) && bulletsLeft > 0 )
        {
          currentBurst = bulletsPerBurst;
          FireWeapon();
        }

    }

    public void FireWeapon()
    {
      bulletsLeft--;
      
      GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, Quaternion.identity);
      bullets bul = bullet.GetComponent<bullets>();
      bul.bulletDamage = weaponDemage;


      bullet.GetComponent<Rigidbody>().AddForce(bulletSpawn.forward.normalized * bulletVelocity, ForceMode.Impulse);

      StartCoroutine(DestroyBulletAfterTime(bullet, bulletPrefabLifeTime));

    }

    public void Reload()
    {
      isReloading = true;
      Invoke("ReloadCompleted",reloadTime);
    }

    private void ReloadCompleted()
    {
      bulletsLeft = magazineSize;
      isReloading = false;
    }



    private IEnumerator DestroyBulletAfterTime(GameObject bullet, float delay)
    {
       yield return new WaitForSeconds(delay);
       Destroy(bullet);

    }

    private void Awake()
    {
      readyToShoot = true;
      currentBurst = bulletsPerBurst;
      bulletsLeft = magazineSize;
    }
}


using System.Collections;
using TMPro;
using UnityEngine;

public class weapons : MonoBehaviour
{
   public bool isShooting, readyToShoot;

    public int bulletsPerBurst = 1;
   public int currentBurst;
   public int weaponDemage;

    public bullets bulletPrefab;
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
      if(!pause.isPaused && !victory.isPaused)

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
    { if(!pause.isPaused && !victory.isPaused)
    
      bulletsLeft--;
      bullets bul = Instantiate(bulletPrefab, bulletSpawn.position, Quaternion.identity);
      bul.Init(bulletSpawn.forward.normalized, bulletVelocity, weaponDemage);  

      StartCoroutine(DestroyBulletAfterTime(bul.gameObject, bulletPrefabLifeTime));

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
      if(!pause.isPaused && !victory.isPaused)
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

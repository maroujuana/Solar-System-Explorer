using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Security.Cryptography;
using UnityEngine.UI;

public class BulletShooter : MonoBehaviour
{

    public Transform LeftNozzle;
    public Transform RightNozzle;
    public Transform MiddleNozzle;

    public GameObject bulletPrefab_Red;
    public GameObject bulletPrefab_Blue;
    public GameObject bulletPrefab_Black;
    public GameObject bulletPrefab_Green;

    public float timer =5;

    public AudioClip ShootSFX;
    public static AudioSource audioSource;

    
    public Text bulletCountUI;
    public int MaxMagazineSize = 30;

    GameObject LeftNozzle_Bullet;
    GameObject RightNozzle_Bullet;
    GameObject MiddleNozzle_Bullet;
    int currentBulletCount;
    bool canFire = true;

    float reloadtime = 1;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        currentBulletCount = MaxMagazineSize;
    }

    // Update is called once per frame

    public void firegun(GameObject bulletprefab)
    {
        if (currentBulletCount > 0)
        {
            LeftNozzle_Bullet = Instantiate(bulletprefab, LeftNozzle.transform.position, transform.rotation);
            RightNozzle_Bullet = Instantiate(bulletprefab, RightNozzle.transform.position, transform.rotation);
            MiddleNozzle_Bullet = Instantiate(bulletprefab, MiddleNozzle.transform.position, transform.rotation);

            audioSource.PlayOneShot(ShootSFX);

            Destroy(LeftNozzle_Bullet, timer);
            Destroy(RightNozzle_Bullet, timer);
            Destroy(MiddleNozzle_Bullet, timer);

            currentBulletCount-=3;
        }

    }

    public void reload()
    {
        currentBulletCount = MaxMagazineSize;
        canFire = true;
    }

    void Update()
    {
        if (canFire == true)
        {

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                firegun(bulletPrefab_Red);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                firegun(bulletPrefab_Blue);
            }
            if (Input.GetKeyDown(KeyCode.Q))
            {
                firegun(bulletPrefab_Black);
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                firegun(bulletPrefab_Green);
            }
            bulletCountUI.text = "Bullet: " + currentBulletCount;
            if (currentBulletCount == 0)
            {
                canFire = false;
                bulletCountUI.text = "Empty";
            }
        }

        

        if (Input.GetKeyDown(KeyCode.R))
        {
            canFire = false;
            bulletCountUI.text = "Reloading..";
            Invoke("reload", 1);
        }
    }


}

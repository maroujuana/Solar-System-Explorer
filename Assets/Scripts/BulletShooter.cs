using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShooter : MonoBehaviour
{
    public Transform LeftNozzle;
    public Transform RightNozzle;
    public GameObject bulletPrefab_Red;
    public GameObject bulletPrefab_Blue;
    public GameObject bulletPrefab_Black;
    public GameObject bulletPrefab_Green;
    GameObject LeftNozzle_Bullet;
    GameObject RightNozzle_Bullet;

    public float timer;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            LeftNozzle_Bullet = Instantiate(bulletPrefab_Red, LeftNozzle.transform.position, transform.rotation);
            RightNozzle_Bullet = Instantiate(bulletPrefab_Red, RightNozzle.transform.position, transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            LeftNozzle_Bullet = Instantiate(bulletPrefab_Blue, LeftNozzle.transform.position, transform.rotation);
            RightNozzle_Bullet = Instantiate(bulletPrefab_Blue, RightNozzle.transform.position, transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            LeftNozzle_Bullet = Instantiate(bulletPrefab_Black, LeftNozzle.transform.position, transform.rotation);
            RightNozzle_Bullet = Instantiate(bulletPrefab_Black, RightNozzle.transform.position, transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            LeftNozzle_Bullet = Instantiate(bulletPrefab_Green, LeftNozzle.transform.position, transform.rotation);
            RightNozzle_Bullet = Instantiate(bulletPrefab_Green, RightNozzle.transform.position, transform.rotation);
        }

        Destroy(LeftNozzle_Bullet, timer);
        Destroy(RightNozzle_Bullet, timer);
    }

}

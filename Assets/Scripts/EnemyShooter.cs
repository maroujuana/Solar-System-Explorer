using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    public Transform Nozzle;

    public GameObject bulletPrefab;

    public AudioClip ShootSFX;
    public static AudioSource audioSource;

    public Transform Target;

    GameObject EnemyBullet;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        //Invoke("EnemyShoot", Random.Range(2, 5));

        InvokeRepeating("EnemyShoot", 0, Random.Range(2, 5));
    }

    void EnemyShoot()
    {
        EnemyBullet = Instantiate(bulletPrefab, Nozzle.transform.position, transform.rotation);

        Destroy(EnemyBullet, 5);
    }
    void Update()
    {
        transform.LookAt(new Vector3(Target.position.x, this.gameObject.transform.position.y, Target.position.z));
    }
}

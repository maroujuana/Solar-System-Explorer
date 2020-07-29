using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTarget : MonoBehaviour
{
    public GameObject TargetPrefab;
    public Transform TargetLocation;
    public float timer;
    public string Player;

    public AudioClip AlertSFX;
    public AudioClip SafeSFX;
    public AudioSource audioSource;

    private GameObject SpawnedTarget;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag(Player))
        {
            SpawnedTarget = Instantiate(TargetPrefab, TargetLocation.transform.position, transform.rotation);
            audioSource.PlayOneShot(AlertSFX);
        }

        Destroy(SpawnedTarget, timer);
    }

    private void OnTriggerExit(Collider collider)
    {
        if(collider.gameObject.CompareTag(Player))
        {
            Destroy(SpawnedTarget);
            audioSource.PlayOneShot(SafeSFX);
        }


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

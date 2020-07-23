using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTarget : MonoBehaviour
{
    public GameObject TargetPrefab;
    public Transform TargetLocation;
    public float timer;
    public string Player;


    private GameObject SpawnedTarget;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag(Player))
        {
            SpawnedTarget = Instantiate(TargetPrefab, TargetLocation.transform.position, transform.rotation);
        }

        Destroy(SpawnedTarget, timer);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

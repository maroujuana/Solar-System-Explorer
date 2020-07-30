using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class BulletCollision : MonoBehaviour
{
    public int hp = 1;
    public string Tag;

    public static int score = 0;

    public AudioClip destroySFX;
    public AudioClip ScoreSFX;
    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(Tag))
        {
            hp--;
            if (hp <= 0)
            {
                AudioSource.PlayClipAtPoint(destroySFX, this.gameObject.transform.position);
                BulletShooter.audioSource.PlayOneShot(ScoreSFX);
                Destroy(this.gameObject);
                score++;
                
            }
            Destroy(collision.gameObject);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

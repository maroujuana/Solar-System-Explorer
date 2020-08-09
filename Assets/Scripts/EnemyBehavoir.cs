using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class EnemyBehavoir : MonoBehaviour
{
    public int maxHealth = 100;
    public int CurrentHealth;

    public GameObject healthBarUI;
    public Slider healthSlider;
    public Image Fill;

    public AudioClip destroySFX;
    public AudioClip ScoreSFX;

    public string Tag;
    public static int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = maxHealth;
        healthSlider.value = calculateHealth();
    }

    // Update is called once per frame
    void Update()
    {
        healthSlider.value = calculateHealth();

        if (CurrentHealth <= 0) CurrentHealth = 0;

        if (calculateHealth() > 0.5f)
        {
            Fill.color = Color.green;
            if (CurrentHealth > maxHealth) CurrentHealth = maxHealth;
        }
        if ((calculateHealth() <= 0.50) && calculateHealth() > 0.10)
        {
            Fill.color = Color.yellow + Color.red;
        }
        if ((calculateHealth() <= 0.10f) && calculateHealth() > 0)
        {
            Fill.color = Color.red;
        }

        if (calculateHealth() <= 0)
        {
            Destroy(this.gameObject);
            AudioSource.PlayClipAtPoint(destroySFX, this.gameObject.transform.position);
            BulletShooter.audioSource.PlayOneShot(ScoreSFX);
            score++;
        }
    }

    float calculateHealth()
    {
        return Convert.ToSingle(CurrentHealth) / Convert.ToSingle(maxHealth);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(Tag))
        {
            DamageHealth(BulletMovement.damage);
            Destroy(collision.gameObject);
        }
    }

    public void DamageHealth(int damage)
    {
        CurrentHealth -= damage;
    }

}

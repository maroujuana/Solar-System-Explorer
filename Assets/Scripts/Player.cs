using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int CurrentHealth;

    public GameObject healthBarUI;
    public Slider healthSlider;
    public Image Fill;

    public Text YouLoseText;

    public string Tag;

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
            YouLoseText.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }

    float calculateHealth()
    {
        return Convert.ToSingle(CurrentHealth) / Convert.ToSingle(maxHealth);

    }
    public void DamageHealth(int damage)
    {
        CurrentHealth -= damage;
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag(Tag))
        {
            DamageHealth(25);
        }
    }

}

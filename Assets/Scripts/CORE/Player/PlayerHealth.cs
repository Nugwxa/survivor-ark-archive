﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 100;
    public int currentHealth;
    public Slider healthSlider;
    public Image damageImage;
    public UserInput userInput; 
    public AudioClip deathClip;
    public float flashSpeed = 5f;
    public Color flashColour = new Color(2f, 0f, 0f, 0.1f);

    public GameObject pauseMenu;
    public GameObject gameController;


    Animator anim;
    AudioSource playerAudio;
    UserInput playerMovement;
    bool isDead;
    bool damaged;


	void Awake ()
    {
        anim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
        playerMovement = GetComponent<UserInput>();
        currentHealth = startingHealth;
	}
	

	void Update ()
    {
        if (damaged)
        {
            damageImage.color = flashColour;
        }
        else
        {
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }
        damaged = false;
	}


    public void TakeDamage (int amount)
    {
        damaged = true;

        currentHealth -= amount;

        healthSlider.value = currentHealth;

        playerAudio.Play();

        if(currentHealth <= 0 && !isDead)
        {
            Death();
        }
    }


    void Death ()
    {
        isDead = true;

        //playerShooting.DisableEffects ();

        anim.SetTrigger("Die");

        playerAudio.clip = deathClip;
        playerAudio.Play();
        pauseMenu.SetActive(false);
        gameController.SetActive(false);

        playerMovement.enabled = false;
        userInput.enabled = false;
    }
}

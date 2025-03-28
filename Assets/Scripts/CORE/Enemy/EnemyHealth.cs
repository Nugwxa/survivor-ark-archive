﻿using UnityEngine;
using UnityEngine.AI;

public class EnemyHealth : MonoBehaviour
{
    public int startingHealth = 100;
    public int currentHealth;
    public float sinkSpeed = 2.5f;
    public int scoreValue = 10;
    public GameObject Particle;
    public GameObject StartParticle;
    public GameObject enemyIcon;
    public GameObject minimapEnemyIcon;
    public AudioClip deathClip;


    Animator anim;
    AudioSource enemyAudio;

    CapsuleCollider capsuleCollider;
    bool isDead;
    bool isSinking;


	void Awake ()
    {
        StartParticle.SetActive(true);
        anim = GetComponent <Animator> ();
        enemyAudio = GetComponent <AudioSource> ();

        capsuleCollider = GetComponent <CapsuleCollider> ();

        currentHealth = startingHealth;
	}
	
	
	void Update ()
    {
		if(isSinking)
        {
            transform.Translate(-Vector3.up * sinkSpeed * Time.deltaTime);
        }
	}


    public void TakeTotalDamage(int amount)
    {
        if (isDead)
            return;

        enemyAudio.Play();

        currentHealth -= amount;

        if (currentHealth <= 0)
        {
            Death();
        }
    }

    public void TakeDamage (int amount, Vector3 hitPoint)
    {
        if (isDead)
            return;

        enemyAudio.Play();

        currentHealth -= amount;

        


        if(currentHealth <= 0)
        {
            Death ();
        }
    }


    void Death ()
    {
        isDead = true;

        capsuleCollider.isTrigger = true;

        anim.SetTrigger("Dead");
        GetComponent<NavMeshAgent>().enabled = false;
        GetComponent<SphereCollider>().enabled = false;
        GetComponent<CapsuleCollider>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;

        ScoreManagerLevel001.score += scoreValue;
        ScoreManagerLevel002.score += scoreValue;
        ScoreManager.score += scoreValue;
        enemyIcon.SetActive(false);
        minimapEnemyIcon.SetActive(true);
        enemyAudio.clip = deathClip;
        enemyAudio.Play();
    }


    public void StartSinking ()
    {
              
        isSinking = true;
        Particle.SetActive(true);
        Destroy(gameObject, 2f);
    }
}

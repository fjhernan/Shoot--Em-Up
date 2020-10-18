using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class Player : MonoBehaviour
{
    public GameObject bullet;
    public Animator animator;
    public Transform shottingOffset;
    private AudioSource a;
    public AudioClip ac, ac2;
    // Update is called once per frame

    private void Start()
    {
        a = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("Player Destroyed");
        if (collision.gameObject.name == "EnemyBullet(Clone)")
        {
            a.PlayOneShot(ac2);
            animator.SetTrigger("Death");
            GameObject.Find("ScoreManager").GetComponent<ScoreManager>().OnDeath();
            StartCoroutine(CountDown());
        }
            

        
    }

    IEnumerator CountDown(){
        yield return new WaitForSeconds(1.0f);
        EditorSceneManager.LoadScene(2);
    }

    public void Shoot()
    {
        Debug.Log("Is this being called?");
        a.PlayOneShot(ac);
        animator.SetTrigger("Shoot");
        Debug.Log("Ouch!");
    }
}

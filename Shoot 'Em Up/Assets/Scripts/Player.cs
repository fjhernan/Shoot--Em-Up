using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  public GameObject bullet;
    private Animator animator;

  public Transform shottingOffset;
    // Update is called once per frame
    void Update()
    {
        animator = GetComponent<Animator>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Player Destroyed");
        GameObject.Find("ScoreManager").GetComponent<ScoreManager>().OnDeath();
    }

    public void Shoot(){
        Debug.Log("Shoot is called");
        animator.SetTrigger("Shoot");
    }
}

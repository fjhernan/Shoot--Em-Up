using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

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
        //Debug.Log("Player Destroyed");
        if(collision.gameObject.name == "EnemyBullet(Clone)")
            GameObject.Find("ScoreManager").GetComponent<ScoreManager>().OnDeath();
    
        EditorSceneManager.LoadScene(2);
    }

    public void Shoot(){
        //Debug.Log("Shoot is called");
        animator.SetTrigger("Shoot");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class Player : MonoBehaviour
{
  public GameObject bullet;

  public Transform shottingOffset;
    // Update is called once per frame
    void Update()
    {
        /*
      if (Input.GetKeyDown(KeyCode.Space))
      {
        GameObject shot = Instantiate(bullet, shottingOffset.position, Quaternion.identity);
        Debug.Log("Bang!");

        Destroy(shot, 3f);

      }*/
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
<<<<<<< HEAD
<<<<<<< HEAD
        //Debug.Log("Player Destroyed");
        if(collision.gameObject.name == "EnemyBullet(Clone)")
            GameObject.Find("ScoreManager").GetComponent<ScoreManager>().OnDeath();
    
        EditorSceneManager.LoadScene(2);
    }

    public void Shoot(){
        //Debug.Log("Shoot is called");
        animator.SetTrigger("Shoot");
=======
=======
>>>>>>> parent of 84018a8... Animations begin
        //GameObject particle = Instantiate(particleEffect, transform.position, Quaternion.identity);
        //GameObject.Find("ScoreManager").GetComponent<ScoreManager>().Scored(1);
        Debug.Log("Ouch!");
        //Debug.Log("Destroyed enemy " + (index + 1));
        //Destroy(particle, 2.0f);
        //GameObject.Find("EnemyManager").GetComponent<EnemyManager>().removeEnemy((float)index);
        Destroy(gameObject);
<<<<<<< HEAD
>>>>>>> parent of 84018a8... Animations begin
=======
>>>>>>> parent of 84018a8... Animations begin
    }
}

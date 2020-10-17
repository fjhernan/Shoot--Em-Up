using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject particleEffect;
    public Animator animator;
    private int index = 0;
    private bool last = false;
    private int type;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();    
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
<<<<<<< HEAD
        Debug.Log(index);
        //GameObject particle = Instantiate(particleEffect, transform.position, Quaternion.identity);
        GameObject.Find("ScoreManager").GetComponent<ScoreManager>().Scored(type);
        //Debug.Log("Ouch!");
        //Debug.Log("Destroyed enemy " + (index+1));
        //Destroy(particle, 2.0f);
        GameObject.Find("EnemyManager").GetComponent<EnemyManager>().RemoveEnemy((float) index);
        animator.SetTrigger("Death");
        //Destroy(gameObject);
        GetComponent<BoxCollider2D>().isTrigger = true;
=======
        GameObject particle = Instantiate(particleEffect, transform.position, Quaternion.identity);
        GameObject.Find("ScoreManager").GetComponent<ScoreManager>().Scored(1);
        Debug.Log("Ouch!");
        Debug.Log("Destroyed enemy " + (index+1));
        Destroy(particle, 2.0f);
        GameObject.Find("EnemyManager").GetComponent<EnemyManager>().removeEnemy((float) index);
        Destroy(gameObject);
>>>>>>> parent of 84018a8... Animations begin
    }
    public void setIndex(float r)
    {
        index = (int)r;
    }
    public int getIndex(){
        int temp = index;
        return temp;
    }
    
    public void setLast(bool value){
        last = value;
    }

    public bool getLast(){
        bool temp = last;
        return temp;
    }

    public void SetEnemyType(int t) {
        type = t;
        switch (t) {
            case 0:
                GetComponent<SpriteRenderer>().color = Color.black;
                break;
            case 1:
                GetComponent<SpriteRenderer>().color = Color.red;
                break;
            case 2:
                GetComponent<SpriteRenderer>().color = Color.blue;
                break;
            case 3:
                GetComponent<SpriteRenderer>().color = Color.green;
                break;
            default:
                break;
        }
    }
}

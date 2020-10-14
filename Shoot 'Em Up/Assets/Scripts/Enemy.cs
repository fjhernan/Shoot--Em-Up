using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject particleEffect;
    private int index = 0;
    private bool last = false;
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject particle = Instantiate(particleEffect, transform.position, Quaternion.identity);
        GameObject.Find("ScoreManager").GetComponent<ScoreManager>().Scored(1);
        Debug.Log("Ouch!");
        Debug.Log("Destroyed enemy " + (index+1));
        Destroy(particle, 2.0f);
        GameObject.Find("EnemyManager").GetComponent<EnemyManager>().RemoveEnemy((float) index);
        Destroy(gameObject);
    }
    public void SetIndex(float r)
    {
        index = (int)r;
    }
    public int GetIndex(){
        int temp = index;
        return temp;
    }
    
    public void SetLast(bool value){
        last = value;
    }

    public bool GetLast(){
        bool temp = last;
        return temp;
    }

    
}

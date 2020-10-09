﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject particleEffect;
    private int index = 0;
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject particle = Instantiate(particleEffect, transform.position, Quaternion.identity);
        GameObject.Find("ScoreManager").GetComponent<ScoreManager>().Scored(1);
        Debug.Log("Ouch!");
        Debug.Log("Destroyed enemy " + (index+1));
        Destroy(particle, 2.0f);
        //GameObject.Find("EnemyManager").GetComponent<EnemyManager>().removeEnemy((float) index);
        //GameObject.Find("EnemyManager").GetComponent<EnemyManager>().current();
        Destroy(gameObject);
    }
    public void setIndex(float r)
    {
        index = (int)r;
    }
}
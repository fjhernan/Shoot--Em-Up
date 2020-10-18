using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barricade : MonoBehaviour
{
    private AudioSource a;
    public AudioClip ac;
    // Start is called before the first frame update
    void Start()
    {
        a = GetComponent<AudioSource>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Bullet(Clone)" || collision.gameObject.name == "EnemyBullet(Clone)")
        {
            a.PlayOneShot(ac);
            StartCoroutine(CountDown());
            //Destroy(gameObject);
        }
    }

    IEnumerator CountDown(){
        yield return new WaitForSeconds(.2f);
        Destroy(gameObject);
        //a.PlayOneShot(ac);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public float amplify = 1.0f;
    public GameObject player;
    public GameObject bullet;
    public Transform shootingOffset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Horizontal");

        player.transform.Translate(move * amplify * Time.deltaTime, 0, 0);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject shot = Instantiate(bullet, shootingOffset.position, Quaternion.identity);
            Debug.Log("Bang!");

            Destroy(shot, 3f);
        }
    }
}

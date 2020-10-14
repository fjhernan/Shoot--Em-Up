using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public GameObject barricade;
    public Transform placement;
    // Start is called before the first frame update
    void Start()
    {
        SpawnBarricade();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnBarricade() {
        GameObject Spawn = null; 
        Transform tempPlace = placement;

        for (int j = 0; j < 4; j++) { 

            for (int i = 0; i < 5; i++) {
                Spawn = GameObject.Instantiate(barricade, tempPlace);
                Spawn.transform.position = new Vector3(Spawn.transform.position.x - (i * 0.2f) - (j * 3.0f),
                    Spawn.transform.position.y, Spawn.transform.position.z);
            }
        }
    }
}

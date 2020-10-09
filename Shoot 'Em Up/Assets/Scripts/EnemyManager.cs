using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject enemy;
    public Transform enemyTransform;
    private ArrayList enemies = new ArrayList();
    //private ArrayList enemies = new ArrayList();
    // Start is called before the first frame update
    void Start()
    {
        spawnEnemies();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void spawnEnemies()
    {
        int column = 7;
        float position = 0;
        Transform placement = enemyTransform;
        GameObject Spawn = null;
        for (float i = 0.0f; i < 2.0f; i++)
        {
            for (float j = 0.0f; j < column; j++)
            {
                Spawn = GameObject.Instantiate(enemy, placement);
                Spawn.transform.position = new Vector3(Spawn.transform.position.x - (j * 2.0f), Spawn.transform.position.y - (i * 2.0f),
                    Spawn.transform.position.z);
                Spawn.GetComponent<Enemy>().setIndex(position);
                enemies.Add(Spawn);
                position++;
            }
        }
        //Debug.Log(enemies.Count);
    }
    
    public void removeEnemy(float i){
        enemies.Remove(i);    
    }

    public void current()
    {
        Debug.Log(enemies.Count);
    }
}
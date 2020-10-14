using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject enemy;
    public GameObject bullet;
    public Transform enemyTransform;
    private ArrayList enemies = new ArrayList();
    private float time = 0.0f, direction = .05f, speed = 0.5f;
    private float fireTime = 0.0f;
    private bool reverse = false;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemies();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        fireTime += Time.deltaTime;

        if (time >= speed){
            foreach(GameObject go in enemies){
                go.transform.position = new Vector3(go.transform.position.x - direction , go.transform.position.y, go.transform.position.z);
                if(go.transform.position.x <= -7.0f || go.transform.position.x >= 7.0f){
                    reverse = true;
                    Debug.Log(go.transform.position.x);
                }
            }
            if (reverse == true){
                BorderHit();
            }
            time = 0;
        }

        if(fireTime >= 3.0f){
            foreach(GameObject go in enemies){
                if(go.GetComponent<Enemy>().GetLast() == true){
                    Vector3 temp = new Vector3(go.transform.position.x, go.transform.position.y - 1.0f, go.transform.position.z);
                    GameObject shot = Instantiate(bullet, temp, Quaternion.identity);
                    Destroy(shot, 2.0f);
                    break;
                }
            }
            fireTime = 0;
        }
        
    }

    private void SpawnEnemies()
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
                Spawn.GetComponent<Enemy>().SetIndex(position);
                if(position >= 7){
                    Spawn.GetComponent<Enemy>().SetLast(true);
                }
                enemies.Add(Spawn);
                position++;
            }
        }
    }
    
    public void RemoveEnemy(float i){   
        int temp = 0;
        foreach(GameObject go in enemies){
            if(go.GetComponent<Enemy>().GetIndex() == i){
                enemies.RemoveAt(temp);
                break;
            }
            temp++;
        }
        if(enemies.Count  % 4 == 0) {
            speed /= 2.0f;
            Debug.Log("Speeding Up");
        }
        else if(enemies.Count == 1){
            speed /= 4.0f;
        }
    }

    public void BorderHit(){
        direction *= -1;
        foreach(GameObject go in enemies)
        {
            go.transform.position = new Vector3(go.transform.position.x, go.transform.position.y - 0.5f, go.transform.position.z);
        }
        reverse = false;
    }
}
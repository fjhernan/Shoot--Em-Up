using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainManager : MonoBehaviour
{
    public Transform spawn;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemies();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnEnemies() {
        float size = 0.40f;
        GameObject go = null;
        for (int i = 0; i < 4; i++){
            go = GameObject.Instantiate(enemy, spawn);
            go.transform.position = new Vector3(go.transform.position.x - (i * 3.5f), go.transform.position.y, go.transform.position.z);
            go.transform.localScale = new Vector3(go.transform.localScale.x * size,
                go.transform.localScale.y * size, go.transform.localScale.z * size);
            go.GetComponent<Enemy>().SetEnemyType(i);
            size += 0.20f;
        }
    }

    public void StartGame()
    {
        EditorSceneManager.LoadScene("DemoScene");
    }
}

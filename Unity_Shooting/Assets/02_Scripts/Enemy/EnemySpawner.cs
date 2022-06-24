using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    float randEnemy;
    int randSpawnBone;
    int randSpawnbat;
    public float spawnDelaybat;
    public float spawnDelaybones;
    public Transform spawnpos_1;
    public Transform spawnpos_2;
    public Transform spawnpos_3;
    public GameObject bat;
    public GameObject bone; 
    void Start()
    {
        StartCoroutine("SpawnEnemy");
    }

    IEnumerator SpawnEnemy()
    {
        while(true)
        {
            randSpawnBone = Random.Range(1, 4);
            randSpawnbat = Random.Range(1, 4);
            randEnemy = Random.Range(1f, 2f);
            if(randEnemy >= 1)
            {
                switch(randSpawnbat)
                {
                    case 1 :
                            Instantiate(bat, new Vector2(spawnpos_1.position.x,spawnpos_1.position.y), Quaternion.identity);
                            yield return new WaitForSeconds(spawnDelaybat);
                            break;
                    case 2 :
                            Instantiate(bat, new Vector2(spawnpos_2.position.x,spawnpos_2.position.y), Quaternion.identity);
                            yield return new WaitForSeconds(spawnDelaybat);
                            break;
                    case 3 :
                            Instantiate(bat, new Vector2(spawnpos_3.position.x,spawnpos_3.position.y), Quaternion.identity);
                            yield return new WaitForSeconds(spawnDelaybat);
                            break;
                }
            }
            if(randEnemy <= 2)
            {
                switch(randSpawnBone)
                {
                    case 1 :
                        Instantiate(bone, new Vector2(spawnpos_1.position.x,spawnpos_1.position.y), Quaternion.identity);
                        yield return new WaitForSeconds(spawnDelaybones);
                        break;
                    case 2 :
                        Instantiate(bone, new Vector2(spawnpos_2.position.x,spawnpos_2.position.y), Quaternion.identity);
                        yield return new WaitForSeconds(spawnDelaybones);
                        break;
                    case 3 :
                        Instantiate(bone, new Vector2(spawnpos_3.position.x,spawnpos_3.position.y), Quaternion.identity);
                        yield return new WaitForSeconds(spawnDelaybones);
                        break;
                }
            }
        }
    }
}

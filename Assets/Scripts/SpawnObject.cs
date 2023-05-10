
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public float timespawn = 1;
    public float repeatspawnrate = 3;
    public GameObject[] enemies;
    public Transform XRangeLeft;
    public Transform XRangeRight;
    public Transform YRangeUp;
    public Transform YRangeDown;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("SpawnEnemies",timespawn,repeatspawnrate); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnEnemies(){

        Vector3 SpawnPosition = new Vector3(0,0,0);

        SpawnPosition = new Vector3(Random.Range(XRangeLeft.position.x,XRangeRight.position.x),Random.Range(YRangeUp.position.y,YRangeDown.position.y),0);
        GameObject enemie = Instantiate(enemies[Random.Range(0,enemies.Length)],SpawnPosition,gameObject.transform.rotation);

    }
}

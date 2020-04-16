using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleHandler : MonoBehaviour
{
    [SerializeField]
    GameObject obstaclePrefab;

    // Start is called before the first frame update
    void Start()
    {
        for(int i =0; i < Random.Range(5,15); i++ )
        {
            GameObject temp = Instantiate(obstaclePrefab,
                new Vector3( Random.Range(-4,4), 1 , Random.Range( transform.position.z - 10, transform.position.z + 10) ),
                Quaternion.identity);
            temp.transform.parent = gameObject.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

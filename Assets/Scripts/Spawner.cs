using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Tyre;
    public GameObject Ice;
    public GameObject Walrus;
    public GameObject Barrel;

    public int SpawnNumber;

    public float position;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SpawnObjects()
    {
        SpawnNumber = Random.Range(1, 5);

        position = Random.Range(-3, 3);

        if(SpawnNumber == 1)
        {
            Instantiate(Tyre, new Vector3(position, transform.position.y, transform.position.z), Quaternion.identity);
        }
        if (SpawnNumber == 2)
        {
            Instantiate(Ice, new Vector3(position, transform.position.y, transform.position.z), Quaternion.identity);
        }
        if (SpawnNumber == 3)
        {
            Instantiate(Walrus, new Vector3(position, transform.position.y, transform.position.z), Quaternion.identity);
        }
        if (SpawnNumber == 4)
        {
            Instantiate(Barrel, new Vector3(position, transform.position.y, transform.position.z), Quaternion.identity);
        }
    }
}

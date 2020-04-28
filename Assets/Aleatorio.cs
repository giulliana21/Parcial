using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aleatorio : MonoBehaviour
{
    public GameObject esfera;
    public Vector3 spawn;
    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-13f, 13f);
        float z = Random.Range(30f, 58f);
        transform.position = new Vector3(x, 15f, z);
        
    }

    // Update is called once per frame
    void Update()
    {
        


    }


  
}

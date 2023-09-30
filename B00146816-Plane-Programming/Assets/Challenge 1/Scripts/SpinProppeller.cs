using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinProppeller : MonoBehaviour
{

    private float propellorSpeed = 1000;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Basically we are saying that while the plane goes forward, we want the propellor
        //to spin smooth with deltatime and with the speed
        transform.Rotate(Vector3.forward, propellorSpeed * Time.deltaTime );


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeOnDisable : MonoBehaviour
{

    public GameObject Cube;
    // Start is called before the first frame update
    private void OnEnable()
    {

        Instantiate(Cube, transform.position, Quaternion.identity);


    }


    private void OnDisable()
    {

        Instantiate(Cube, transform.position, Quaternion.identity);

    }



    // Update is called once per frame
    void Update()
    {
        
    }
}

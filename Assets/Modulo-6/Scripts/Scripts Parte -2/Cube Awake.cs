using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public GameObject Cube;
    // Start is called before the first frame update
    void Start()
    {





        
    }



    private void Awake()
    {
        Instantiate(Cube, transform.position, Quaternion.identity);



    }






    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubos : MonoBehaviour
{

    

    public GameObject Cube;
    public List<GameObject> listadecubos;
    public float factordeescalamiento;
    public int numCubos = 0;

    // Start is called before the first frame update
    void Start()
    {

            listadecubos = new List<GameObject>();


        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        numCubos++;
        GameObject tempGameObject = Instantiate<GameObject>(Cube);
        tempGameObject.name = "Cubos" + numCubos;
        tempGameObject.transform.position = Random.insideUnitSphere;







    }
}

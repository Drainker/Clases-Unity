using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{


    public GameObject objToSpawn;
    



    // Start is called before the first frame update
    void Start()
    {

        Instantiate(objToSpawn, transform.position, Quaternion.identity);
        var meshRendererMaterial = objToSpawn.GetComponent<MeshRenderer>().material;
        meshRendererMaterial.color = Color.white;




    }



    private void Awake()
    {

        GameObject tempGameObject = Instantiate<GameObject>(objToSpawn);
        tempGameObject.name = "Cubo";
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;





    }



    // Update is called once per frame
    void Update()
    {

        




    }

        
    

}











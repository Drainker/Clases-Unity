using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour


    
{
    public GameObject sphere;
    // Start is called before the first frame update
    void Start()
    {

        Instantiate(sphere, transform.position, Quaternion.identity);
        var meshRendererMaterial = sphere.GetComponent<MeshRenderer>().material;
        meshRendererMaterial.color = Color.white;



    }

    // Update is called once per frame
    void Update()
    {

        GameObject tempGameObject = Instantiate<GameObject>(sphere);
        tempGameObject.name = "Esfera";
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;



    }
}

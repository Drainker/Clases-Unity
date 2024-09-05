using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour
{

    public GameObject capsule;
    // Start is called before the first frame update
    void Start()
    {

        Instantiate(capsule, transform.position, Quaternion.identity);
        var meshRendererMaterial = capsule.GetComponent<MeshRenderer>().material;
        meshRendererMaterial.color = Color.white;



    }

    

    // Update is called once per frame
    void FixedUpdate()
    {

        GameObject tempGameObject = Instantiate<GameObject>(capsule);
        tempGameObject.name = "capsula";
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;




    }
}

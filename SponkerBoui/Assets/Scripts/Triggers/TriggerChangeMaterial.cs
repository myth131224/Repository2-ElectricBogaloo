using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChangeMaterial : MonoBehaviour
{
    public Material changeToMaterial; //references another material
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Get the renderer component
        Renderer render = GetComponent<Renderer>();

        //Set the material to the new one
        render.material = changeToMaterial;
    }


}

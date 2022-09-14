using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEsfera1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] sensor;
    bool salio = true;
    Color colorB;
    static Reiniciar objeto = new Reiniciar();
    
    

     void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collisionInfo)
    {
        var cubeRenderer = sensor[0].GetComponent<Renderer>();
         colorB = cubeRenderer.material.GetColor("_Color");
    }
    private void OnTriggerStay(Collider obj)
    {
        for (int i = 0; i < 3; i++)
        {
            var cubeRenderer = sensor[i].GetComponent<Renderer>();
            
            cubeRenderer.material.SetColor("_Color", Color.white);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        for (int i = 0; i < 3; i++)
        {
            var cubeRenderer = sensor[i].GetComponent<Renderer>();
            cubeRenderer.material.SetColor("_Color", colorB);
        }
    }

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name == "Piso")
        {
            if (this.GetComponent<Renderer>().material.GetColor("_Color").g > 0.4f) //Esfera pequeña
            {
                objeto.getAcabar()[0] = true;
            }
            else if (this.GetComponent<Renderer>().material.GetColor("_Color").g < 0.1) //Esfera mediana
            {
                objeto.getAcabar()[1] = true;
            }
            else //Esfera grande
                objeto.getAcabar()[2] = true;
        }
       

        }
        
  


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reiniciar : MonoBehaviour
{
    public GameObject[] esferas;
    Vector3 [] esferasPosIncial=new Vector3[3]; //posicion inicial de las esferas
    Quaternion[] esferasRotationInicial = new Quaternion[3];//Rotacion inicial de las esferas
    public static bool[] acabar = new bool[3];
  


    public Reiniciar()
    {
    }

    public void Start()
    {   //Esfera pequeña
        esferasPosIncial[0]= new Vector3(151.823f, 106.44f, -399.326f);
        esferasRotationInicial[0] = new Quaternion(5.012f, -16.957f, 15.987f,0);
        //Esfera mediana
        esferasPosIncial[1] = new Vector3(151.823f, 106.463f, -401.32f);
        esferasRotationInicial[1] = new Quaternion(5.012f, -16.957f, 15.987f,0);
        //Esfera grande
        esferasPosIncial[2] = new Vector3(151.823f, 106.5f, -403.328f);
        esferasRotationInicial[2] = new Quaternion(5.012f, -16.957f, 15.987f,0);
    }


    //Get and Set de acabar

    public bool[] getAcabar()
    {
        return acabar;
    }
    public void setAcabar(int i, bool band)
    {
        acabar[i] = band;
    }
        
   

    private void Update()
    {
        

        int i = 0;
        while (i < 2)
        {
            if (acabar[i] == false)
                break;
            i++;
        }
        if (i == 2) // Todas acabaron
        {
            for (int j = 0; j <= 2; j++)
            { esferas[j].transform.position = esferasPosIncial[j];
                esferas[j].transform.rotation = esferasRotationInicial[j];
                acabar[j] = false;
            }
        }
        
    }
}

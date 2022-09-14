using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diapositiva : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform[] elementos;
    public float speed;
    public int elementoActual = 0;
    bool band6 = false;
    bool band8 = false;
    bool band20 = false;
    bool band22 = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, elementos[elementoActual].position, speed * Time.deltaTime);
        transform.rotation = Quaternion.Lerp(transform.rotation, elementos[elementoActual].rotation, speed * Time.deltaTime * 0.9f);

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (elementoActual == 6) // Caso especifico
                band6 = true;
            else
                band6 = false;
            if (elementoActual == 20) // Caso especifico
                band20 = true;
            else
                band20 = false;
            elementoActual = (elementoActual + 1) % elementos.Length;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (elementoActual == 8) // Caso especifico
                band8 = true;
            else
                band8 = false;
            if (elementoActual == 22) // Caso especifico
                band22 = true;
            else
                band22 = false;
            elementoActual -= 1;
            if (elementoActual < 0)
            {
                elementoActual = elementos.Length - 1;
            }

        }
        // Evaluar si realiza cambios de pivote automaticos

        if (elementoActual == 7 && band8 == true)
        {
            if ((transform.position - elementos[7].position).sqrMagnitude < 110)
            {
                elementoActual = (elementoActual - 1);
                band8 = false;
            }
        }
        else if (elementoActual == 7 && band6 == true)
        {
            if ((transform.position - elementos[7].position).sqrMagnitude < 110)
            {
                elementoActual = (elementoActual + 1);
                band6 = false;
            }
        }

        if (elementoActual == 21 && band22 == true)
        {
            if ((transform.position - elementos[21].position).sqrMagnitude < 110)
            {
                elementoActual = (elementoActual - 1);
                band22 = false;
            }
        }
        else if (elementoActual == 21 && band20 == true)
        {
            if ((transform.position - elementos[21].position).sqrMagnitude < 110)
            {
                elementoActual = (elementoActual + 1);
                band20 = false;
            }
        }

       



    }
}

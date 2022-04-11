using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Vamos a programar un algoritmo que permita al usuario convertir una cantidad de dinero en 
//pesos argentinos a su equivalente en moneda extranjera. Se debe poder ingresar por Inspector el monto a convertir 
//y una letra correspondiente a la moneda extranjera que se quiere convertir, las opciones son:
//D, para dólares
//R, para reales
//E, para euros
//(La cotización de la moneda será investigada por quien realice el examen).
//El programa debe cumplir los siguientes requerimientos:
//Si se ingresa otra cosa que no sea “D”, “R” o “E” se debe mostrar el mensaje “Opción de moneda extranjera no válida”.
//Si la cantidad de dinero de dinero a convertir es menor que 1000, mostrar el mensaje “El monto mínimo es $1000”. 
//Si los valores ingresados son válidos devolver el mensaje 
//"[monto a convertir] pesos argentinos equivalen a [cantidad covertida] [moneda elegida] ".
//Ejemplo: "1000 pesos equivalen a 3 dólares".


public class Ejercicio1 : MonoBehaviour
{
    public int montoaconvertir;
    public string moneda;
    
    // Start is called before the first frame update
    void Start()
    {

        int D = 112;
        int R = 24;
        int E = 123;

        if ( montoaconvertir < 1000)
        {
            Debug.Log("El monto minimo es $1000");
        }
        else if (moneda == "D")
        {
            int conversion = montoaconvertir * D;
            Debug.Log(montoaconvertir + " $ equivale a " + conversion + moneda);
        }
        else if (moneda == "R")
        {
            int conversion = montoaconvertir * R;
            Debug.Log(montoaconvertir + " $ equivale a " + conversion + moneda);
        }
        else if (moneda == "E")
        {
            int conversion = montoaconvertir * E;
            Debug.Log (montoaconvertir + " $ equivale a " + conversion + moneda);
        }
        else 
        {
            Debug.Log("Opcion de moneda extranjera no valida");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

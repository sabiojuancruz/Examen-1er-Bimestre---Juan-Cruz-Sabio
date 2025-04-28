using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmpresaDeMudanza : MonoBehaviour
{
    public int carga;
    public float distancia;

    float pphUtilitario = 3000; //pph = precio por hora
    float pphPickup = 4500;
    float pphCamion = 7000;

    string vehiculo;
    int velocidadVehiculo = 25;
    float horasViaje;

    float precioHora;
    float precioViaje;
    float gastosRegreso;
    float precioFinal;

    // Start is called before the first frame update
    void Start()
    {
        if (carga < 100)
        {
            Debug.Log("La carga no puede ser menor a 100kg");
            return;
        }

        if (distancia < 1)
        {
            Debug.Log("La distancia no puede ser menor a 1km");
            return;
        }

        if (carga <= 2000)
        {
            vehiculo = "utilitario";
            precioHora = pphUtilitario;
        }
        else if (carga <= 5000)
        {
            vehiculo = "pickup";
            precioHora = pphPickup;
        }
        else
        {
            vehiculo = "camion";
            precioHora = pphCamion;
        }

        if (distancia >= 50)
        {
            gastosRegreso = precioHora;
        }

        horasViaje = distancia / velocidadVehiculo;
        precioViaje = horasViaje * precioHora;
        precioFinal = precioViaje + gastosRegreso;

        Debug.Log($"Vehiculo necesario: {vehiculo}");
        Debug.Log($"Horas necesarias: {horasViaje}");
        Debug.Log($"Precio total de {horasViaje} horas a ${precioHora}: ${precioFinal}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

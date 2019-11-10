using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luces{

    public bool conectar()
{
    Debug.Log("Conectando al sistema de iluminación");
    try
    {
        Debug.Log("Conexión ok");
        return true;
    }
    catch (Exception e)
    {
        Debug.Log("Excepción");
        Debug.Log(e.StackTrace.ToString());
        return false;
    }
}

public bool desconectar()
{
    Debug.Log("Desconectando del sistema de iluminación");
    try
    {
        Debug.Log("Desconexión ok");
        return true;
    }
    catch (Exception e)
    {
        Debug.Log("Excepción");
        Debug.Log(e.StackTrace.ToString());
        return false;
    }
}

public bool encender()
{
    Debug.Log("Encendiendo el sistema de iluminación");
    try
    {
        Debug.Log("Encendido");
        return true;
    }
    catch (Exception e)
    {
        Debug.Log("Excepción");
        Debug.Log(e.StackTrace.ToString());
        return false;
    }
}

public bool apagar()
{
    Debug.Log("Apagando el sistema de iluminación");
    try
    {
        Debug.Log("Apagado");
        return true;
    }
    catch (Exception e)
    {
        Debug.Log("Excepción");
        Debug.Log(e.StackTrace.ToString());
        return false;
    }
}

}
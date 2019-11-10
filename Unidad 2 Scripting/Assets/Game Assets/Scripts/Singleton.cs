using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton
{
    private readonly static Singleton _instance = new Singleton();

    private Singleton() { }

    public Singleton getInstance(){ return _instance; }
}

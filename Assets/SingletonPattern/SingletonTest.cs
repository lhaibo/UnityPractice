using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HBFramework;
public class SingletonTest : SingletonBaseMono<SingletonTest>
{
    
    public void Oops()
    {
        print("oops!");
    }
}

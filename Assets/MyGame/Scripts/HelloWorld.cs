//smeers: 
//printing messages to the unity console

using System;
using UnityEngine;


public class HelloWorld : MonoBehaviour
{
	void Start ()
    {
        string message = "Hello World";

        print(message);
        Debug.Log(message);
        Console.WriteLine(message);

        print("Print" + message);
        Debug.Log("DebugLog" + message);
        Console.WriteLine("Writeline" + message);
	}
}

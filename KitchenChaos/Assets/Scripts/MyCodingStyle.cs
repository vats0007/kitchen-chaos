using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MyCodeStyle : MonoBehaviour
{
    // Constants: Uppercase SnakeCase
    public const int CONSTANT_FIELD = 56;

    // Properties: PascalCase
    public static MyCodeStyle Instance { get; private set; }

    // Events: PascalCase
    //public event EventHandler OnSomethingHappened;

    // Fields: camelCase
    private float memberVariable;

    // Function Names: PascalCase
    private void Awake()
    {
        Instance = this;

        DoSomething(10f);
    }

    // Function Params: camelCase
    private void DoSomething(float time)
    {
        //Do Something...
        memberVariable = time + Time.deltaTime;
        if (memberVariable > 0)
        {
            //Do Something
        }
    }
}


/*  RULES
 *  
 *  Spend Time on deciding Names
 *  Don't be afraid to rename
 *  no single letter
 *  no acronyms
 *  
 */

/*
 * Always Saparate The Visuals and The Logic
 * 
 * Always be Explicit(about Declarations and about private/public..etc.)
 */

/*
 * Time.deltatime returns the float value for time taken to load a single frame
 * Only necessery things should be public (to change those are private make public functions)
 * 
 *  CLEAN CODE
 *  -> Minimize Access
 *  -> Manage Complexity while building
 *  -> use consts insted of string
 *
 */
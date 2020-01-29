using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ExerciseReturnValue : MonoBehaviour
{
    public float randomMin;
    public float randomMax;
    void Start()
    {
        var IntReturnVariable = IntReturn();
        var FloatReturnVariable = FloatReturn();
        var StringReturnVariable = StringReturn();
        Debug.Log(IntReturnVariable);
        Debug.Log(FloatReturnVariable);
        Debug.Log(StringReturnVariable);
    }

    private void Update()
    {
        Debug.Log(Random.Range(randomMin, randomMax));
    }
    public void NoReturn()
    {
    }
    public int IntReturn()
    {
        int intR2 = 14;
        return intR2;
    }
    public float FloatReturn()
    {
        float floatR = 12;
        return floatR;
    }
    public string StringReturn()
    {
        string stringR = "Hello";
        return stringR;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    public Text result;
    public InputField ipfVarA;
    public InputField ipfVarB;
    public Button btnAddNumbers;
    public Button btnSubNumbers;
    public int value;
    public float a;
    public float b;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void AddNumbersOnClick()
    {
        float variableA = float.Parse(ipfVarA.text);
        float variableB = float.Parse(ipfVarB.text);
        float Addresult = variableA + variableB;


        result.text = Addresult.ToString();

    }

    public void SubNumbersOnClick()
    {
        float variableA = float.Parse(ipfVarA.text);
        float variableB = float.Parse(ipfVarB.text);
        float Addresult = variableA - variableB;


        result.text = Addresult.ToString();

    }

    public void MultipleNumbersOnClick()
    {
        float variableA = float.Parse(ipfVarA.text);
        float variableB = float.Parse(ipfVarB.text);
        float Addresult = variableA * variableB;


        result.text = Addresult.ToString();

    }

    public void DivideNumbersOnClick()
    {
        float variableA = float.Parse(ipfVarA.text);
        float variableB = float.Parse(ipfVarB.text);
        float Addresult = variableA / variableB;


        result.text = Addresult.ToString();

    }

    public void PythagorasNumbersOnClick()
    {
        PythagorasMethode(a, b);
        float result = PythagorasMethode(a, b) + PythagorasMethode(a, b);
        Debug.Log("result: " + result);


    }

    int Square(int a)
    {

        Debug.Log("result Square" + a * a);
        return a * a;

    }

    float PythagorasMethode(float a, float b)
    {
        float cSquare;
        cSquare = (a * a) + (b * b);
        float c = Mathf.Sqrt(cSquare);
        Debug.Log("cSquare:" + cSquare);
        Debug.Log("c:" + c);
        return c;

    }


}

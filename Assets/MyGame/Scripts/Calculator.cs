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
}

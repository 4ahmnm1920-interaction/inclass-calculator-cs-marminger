using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExerciseIfStatement : MonoBehaviour
{

    public bool condition;
    public string text;
    public string text2;

    // Start is called before the first frame update
    void Start()
    {
        if (condition)
        {
           // Debug.Log("Diese Aussage (Condition) ist richtig!");

        }
        else
        {
           // Debug.Log("Diese Aussage ist (Condition) ist falsch");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Random.Range(5f, 15f) > 10)
        {
           //Debug.Log("Der Wert ist über zehn");

        }
        else
        {
           // Debug.Log("Der Wert ist unter zehn");
        }

        //if statement string
        if (text == text2)
        {
           // Debug.Log("Text1 entspricht Text2");
        }

        else

        {
          //  Debug.Log("Text1 entspricht nicht Text2");
        }


        //If statement mit mehreren Konditionen

        if (text == text2 && condition)
        {
          //  Debug.Log("Beide Konditionen sind richtig");
        }

        if (text == text2||condition)
        {
          //  Debug.Log("Eine der beiden Konditionen ist richtig");
        }


        if ( text == text2 )
        { 
            if (condition)
            {
                Debug.Log("Beide Konditionen sind wahr");
            }

            else 
            {
                Debug.Log("Nur eine Konditionen ist wahr");
            }
        }
    }
}
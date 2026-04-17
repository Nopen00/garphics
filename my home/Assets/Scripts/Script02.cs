using UnityEngine;
using TMPro;
public class Script02 : MonoBehaviour
{
    TMP_Text showText;
    public TMP_InputField inputText1;
    public TMP_InputField inputText2;
    double PlayTime = 0;

    int num1=0;
    int num2=0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        showText = GetComponent<TMP_Text>();
        showText.text = "Hello World";
    }

    // Update is called once per frame
    void Update()
    {
        // PlayTime += Time.deltaTime;
        // if(PlayTime < 5)
        // {
        // showText.text = "Hello World";
        // }else
        // {
        //     //Debug.Log($"Play Time : {PlayTime}, Frame Time : {Time.deltaTime}");
        //     showText.text = $"Play Time : {(int)PlayTime}\nFrame Time : {Time.deltaTime}";
        // }

        if(int.TryParse(inputText1.text,out num1))
        {
            
        }
        if(int.TryParse(inputText2.text,out num2))
        {
            
        }
        showText.text = $"{num1}+{num2} = {num1+num2}";
            
    }
}

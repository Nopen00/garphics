using UnityEngine;

public class Script01 : MonoBehaviour
{
    public int abcDef = 100;
    double playTime=0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


        Debug.Log($"Hello World {abcDef}");
    
    }

    // Update is called once per frame
    void Update()
    {
        
        playTime += Time.deltaTime;
        if(playTime < 5)
        {
        Debug.Log($"Play Time : {playTime}");
        }else
        {
            Debug.Log($"Play Time : {playTime}, Frame Time : {Time.deltaTime}");
        }

    }
}

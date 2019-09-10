using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LitJson;
using System.IO;
using System;
using SimpleJSON;



public class getengrpm : MonoBehaviour
{

    public Text rpm;
    public Text temp;
    public Text pressure;
    public Text mileage;
    bool flag = true;
    // Coroutine getCor = null;
    public string title;

    string url = "http://theminimalist.esy.es/getrpmAR.php?name=fan";
    private string a;

    void Awake()
    {


        StartCoroutine(getText());

    }




    IEnumerator getText()
    {
        while (flag == true)
        {
            WWW www = new WWW(url);
            yield return www;
            //readText.text = www.text;
            string json1= www.text;
             JSONNode jsonnode = SimpleJSON.JSON.Parse(json1); //most imp
            //Debug.Log(jsonnode["r"][0]["temp"].ToString());
            rpm.text = jsonnode["r"][0]["rpm"];
            temp.text= jsonnode["r"][0]["temp"];
            pressure.text= jsonnode["r"][0]["pressure"];
            mileage.text= jsonnode["r"][0]["mileage"];

            


        }
        yield return new WaitForSeconds(2);

    }
   
}

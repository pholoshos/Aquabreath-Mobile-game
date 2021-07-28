using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlay : MonoBehaviour
{
    public int selectedOption;
    public int correctOption = 1;
    public Text pointText;
    public bool levelClear = false;
    public int points = 0;
    // Start is called before the first frame update
    void Start()
    {
        pointText.text = points+" points";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void option1(){
        selectedOption = 1;
        check();
        
    }
    void check(){
        if(selectedOption == correctOption && levelClear == false){
            points += 10;
            pointText.text = points+" points";
            levelClear = true;
        }
    }
    public void option2(){
        selectedOption = 2;
        check();
    }
    public void option3(){
        selectedOption = 3;
        check();
    }
}

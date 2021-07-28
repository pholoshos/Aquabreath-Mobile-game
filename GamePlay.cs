using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlay : MonoBehaviour
{
    public int selectedOption;
    public int level;
    public int correctOption = 1;
    public Text pointText;
    public bool levelClear = false;
    public int points = 0;
    public string[] questions;
    public Options[] levelOptions;
    // Start is called before the first frame update
    void Start()
    {
        setOptions();
        pointText.text = points+" points";
    }

    // Update is called once per frame
    public void  setOptions(){

        levelOptions[0].option1 = "Cup";
        levelOptions[0].option2 = "Paper Bag";
        levelOptions[0].option3 = "Car";
        levelOptions[0].correctOption = 1;

        levelOptions[1].option1 = "";
        levelOptions[1].option2 = "";
        levelOptions[1].option3 = "";

        levelOptions[2].option1 = "";
        levelOptions[2].option2 = "";
        levelOptions[2].option3 = "";

        levelOptions[3].option1 = "";
        levelOptions[3].option2 = "";
        levelOptions[3].option3 = "";

        levelOptions[4].option1 = "";
        levelOptions[4].option2 = "";
        levelOptions[4].option3 = "";
    }

    void Update()
    {
        
    }
    public void option1(){
        selectedOption = 1;
        check();
        
    }
    void check(){
        correctOption = Options[level].correctOption;
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

    public class Options{
        public int correctOption;
        public string option1,option2,option3;
    }
}

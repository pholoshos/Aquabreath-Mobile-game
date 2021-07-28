using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlay : MonoBehaviour
{
    public int selectedOption;
    public Text[] optionsText;
    public int level;
    public int correctOption = 1;
    public Text pointText,questionText;
    public bool levelClear = false;
    public int points = 0;
    public string[] questions;
    Options[] levelOptions = new Options[100];
    // Start is called before the first frame update
    void Start()
    {
        level = PlayerPrefs.GetInt("level");
        setOptions();
        getStarted();
        points = PlayerPrefs.GetInt("score");

        pointText.text = points+" points";
    }

    // Update is called once per frame
    public void getStarted(){
        questionText.text = questions[level];
        optionsText[0].text = levelOptions[level].option1;
        optionsText[1].text = levelOptions[level].option2;
        optionsText[2].text = levelOptions[level].option3;
    }
    public void  setOptions(){
        //add options for each option 1, to 3 and its correct answer
        levelOptions[0] = new Options();
        levelOptions[0].option1 ="cup";
        levelOptions[0].option2 = "Paper Bag";
        levelOptions[0].option3 = "Car";
        levelOptions[0].correctOption = 1;

        levelOptions[1] = new Options();
        levelOptions[1].option1 = "Family";
        levelOptions[1].option2 = "Planet";
        levelOptions[1].option3 = "Cats";
         levelOptions[1].correctOption = 2;

        levelOptions[2] = new Options();
        levelOptions[2].option1 = "in the morning";
        levelOptions[2].option2 = "afternoon";
        levelOptions[2].option3 = "evening";
        levelOptions[2].correctOption = 1;

        levelOptions[3] = new Options();
        levelOptions[3].option1 = "using a hosepipe";
        levelOptions[3].option2 = "leave the tap running";
        levelOptions[3].option3 = "using a bucket";
        levelOptions[3].correctOption = 3;

        levelOptions[4] = new Options();
        levelOptions[4].option1 = "play in pool";
        levelOptions[4].option2 = "use sprinklers on lawn";
        levelOptions[4].option3 = "play with water on pavement";
        levelOptions[4].correctOption = 1;

        levelOptions[5] = new Options();
        levelOptions[5].option1 = "80";
        levelOptions[5].option2 = "1";
        levelOptions[5].option3 = "8";
        levelOptions[5].correctOption = 3;

        levelOptions[6] = new Options();
        levelOptions[6].option1 = "boiling";
        levelOptions[6].option2 = "freezing";
        levelOptions[6].option3 = "warm";
        levelOptions[6].correctOption = 1;

        levelOptions[7] = new Options();
        levelOptions[7].option1 = "early in the morning";
        levelOptions[7].option2 = "afternoon";
        levelOptions[7].option3 = "evening";
        levelOptions[7].correctOption = 1;

        levelOptions[8] = new Options();
        levelOptions[8].option1 = "use running tap";
        levelOptions[8].option2 = "bucket or bowl";
        levelOptions[8].option3 = "bathtub";
        levelOptions[8].correctOption = 2;

        levelOptions[9] = new Options();
        levelOptions[9].option1 = "yes";
        levelOptions[9].option2 = "no";
        levelOptions[9].option3 = "none";
        levelOptions[9].correctOption = 1;

        levelOptions[10] = new Options();
        levelOptions[10].option1 = "Big bucket";
        levelOptions[10].option2 = "small bowl";
        levelOptions[10].option3 = "running tap";
        levelOptions[10].correctOption = 2;


        
    }

    void Update()
    {
        
    }
    public void option1(){
        selectedOption = 1;
        check();
        
    }
    void check(){
        correctOption = levelOptions[level].correctOption;
        if(selectedOption == correctOption ){
            
            points += 10;
            pointText.text = points+" points";
            level += 1;
            PlayerPrefs.SetInt("level",level);
            PlayerPrefs.SetInt("score",points);
            optionsText[0].text = levelOptions[level].option1;
            optionsText[1].text = levelOptions[level].option2;
            optionsText[2].text = levelOptions[level].option3;
            questionText.text = questions[level];
            
        }else{

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
    public class Options{
        public int correctOption;
        public string option1;
        public string option2;
        public string option3;
    }

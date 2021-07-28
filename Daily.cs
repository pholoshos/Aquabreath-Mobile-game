using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Daily : MonoBehaviour
{
    public String[] tasks;
    public Text dailyTaskText, pointText,dailyTaskNumberText;
    String taskForToday;
    // Start is called before the first frame update
    void Start()
    {
        checkUser();
        
        DateTime nowDate = DateTime.Now;
        int day = PlayerPrefs.GetInt("day");
        int month = PlayerPrefs.GetInt("month");
        int year = PlayerPrefs.GetInt("year");
        DateTime  date = new DateTime(year,month,day);
        
        Debug.Log(nowDate);
        Debug.Log(date);
        int days = (date.Day -  nowDate.Day)*-1;
        if(nowDate > date){ 
            if(tasks.Length > days){
                taskForToday = tasks[days];

                dailyTaskNumberText.text ="challange "+day.ToString();
                dailyTaskText.text = taskForToday;

            }
        }else{
            Debug.Log("hello");
        }

        
        
    }
    public void checkUser(){
        if(PlayerPrefs.GetInt("userSet") == 1){
            Debug.Log("User active");
            loadTask();
        }else{
            newUser();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void newUser(){
        PlayerPrefs.SetInt("setUser",1);
        DateTime date = DateTime.Now;
        PlayerPrefs.SetInt("day",date.Day);
        PlayerPrefs.SetInt("month",date.Month);
        PlayerPrefs.SetInt("year",date.Year);
        Debug.Log("date set :"+date.ToString());
    }
    public void loadTask(){
        DateTime date = DateTime.Now;
        Debug.Log("loading tasks");
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionChange : MonoBehaviour
{
    public int questionAmount = 3;
    public int answerAmount = 6;
    public Texture[] texture = new Texture[3];
    public string[] questions;
    public string[] answers;
    public string[] potentialAnswers;
    public GameObject image1;
    public GameObject image2;
    public Text questionText;
    public GameObject button1;
    public GameObject button2;
    public int counter = 0;
    public bool complete;
    public GameObject hud;

    private void Awake()
    {
        hud = GameObject.FindGameObjectWithTag("HUD");


        questions = new string[questionAmount];
        answers = new string[questionAmount];
        potentialAnswers = new string[answerAmount];

        
        questions[0] = "Does the plant have colourful petals?";
        questions[1] = "Do the leaves look spiky or smooth?";
        questions[2] = "What colour are the spots on the plant?";

        answers[0] = "Yes";
        answers[1] = "Spiky";
        answers[2] = "Red";


        potentialAnswers[0] = "Yes";
        potentialAnswers[1] = "No";
        potentialAnswers[2] = "Smooth";
        potentialAnswers[3] = "Spiky";
        potentialAnswers[4] = "Red";
        potentialAnswers[5] = "Blue";




    }
    // Update is called once per frame
    void Update()
    {
        switch (counter)
        {
            case 0:
                questionText.text = questions[0];
                button1.GetComponent<Text>().text = potentialAnswers[0];
                button2.GetComponent<Text>().text = potentialAnswers[1];
                image1.GetComponent<RawImage>().texture = texture[0];
                image2.GetComponent<RawImage>().texture = texture[1];
                break;
            case 1:
                questionText.text = questions[1];
                button1.GetComponent<Text>().text = potentialAnswers[2];
                button2.GetComponent<Text>().text = potentialAnswers[3];
                image1.GetComponent<RawImage>().texture = texture[2];
                image2.GetComponent<RawImage>().texture = texture[3];
                break;
            case 2:
                questionText.text = questions[2];
                button1.GetComponent<Text>().text = potentialAnswers[4];
                button2.GetComponent<Text>().text = potentialAnswers[5];
                image1.GetComponent<RawImage>().texture = texture[4];
                image2.GetComponent<RawImage>().texture = texture[5];
                break;
              
        }

        if(counter == 3)
        {
            hud.GetComponent<HUD>().BookGame();
        }
        
    }
    public void FirstbuttonPress()
    {
        switch (counter)
        {
            case 0:
                if(button1.GetComponent<Text>().text == answers[counter])
                {
                    counter += 1;
                }
                break;
            case 1:
                if (button1.GetComponent<Text>().text == answers[counter])
                {
                    counter += 1;
                }
                break;
            case 2:
                if (button1.GetComponent<Text>().text == answers[counter])
                {
                    counter += 1;
                }
                break;


        }
    }
    public void SecondButtonPress()
    {
        switch (counter)
        {
            case 0:
                if (button2.GetComponent<Text>().text == answers[counter])
                {
                    counter += 1;
                }
                break;
            case 1:
                if (button2.GetComponent<Text>().text == answers[counter])
                {
                    counter += 1;
                }
                break;
            case 2:
                if (button2.GetComponent<Text>().text == answers[counter])
                {
                    counter += 1;
                }
                break;


        }
    }
}

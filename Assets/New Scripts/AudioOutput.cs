using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioOutput : MonoBehaviour
{

 //   public GameObject Textbox;
    string dialogue;
    string letter;
    public AudioSource source;
    private Object[] clips;
    private bool isPlaying;

    
    public GameObject speaker_hoop;
    public GameObject speaker_book;
    public GameObject speaker1;
    public GameObject speaker2;
    public GameObject speaker3;

    // Start is called before the first frame update
    void Start()
    {
        clips = Resources.LoadAll("Music", typeof(AudioClip));
    }

    // Update is called once per frame
    void Update()
    {
        //if (Textbox.IActive()) {Submit();}
    }

    void Submit()
    {
        if (isPlaying) return;
        isPlaying = true;
//        dialogue = Textbox.GetComponent<Text>().text;
        Debug.Log(dialogue);
        StartCoroutine(playWord(dialogue));
    }

    public void Brainy1()
    {
        StartCoroutine(playWord("bubba bubba, there you are the plants are wild this is bizarre"));
        speaker1.SetActive(false);
    }

    public void Brainy2()
    {
        StartCoroutine(playWord("find my book, it’s on the grass work out what the plants ate last"));
        speaker2.SetActive(false);
    }

    public void Brainy3()
    {
        StartCoroutine(playWord("thank you bubba thanks for saving me oh what’s that they dropped a key"));
        speaker3.SetActive(false);
    }

    public void Hoop()
    {
        StartCoroutine(playWord("whats this on the ground a peculiar ring maybe i could use it to hold some string"));
        speaker_hoop.SetActive(false);
    }

    public void Book()
    {
        StartCoroutine(playWord("i identified the plants and know they like flies they like them even more than i like fries"));
        speaker_book.SetActive(false);
    }



    IEnumerator playWord(string word)
    {
        Debug.Log(word);
        for (int i = 0; i < word.Length; i++)
        {
            playLetter(word[i]);
            yield return new WaitForSeconds(0.125f);
        }

        isPlaying = false; 
    }

    void playLetter(char letter)
    {
        int i;

        switch (letter)
        {
            case 'a':
                i = 0;
                break;
            case 'b':
                i = 1;
                break;
            case 'c':
                i = 2;
                break;
            case 'd':
                i = 3;
                break;
            case 'e':
                i = 4;
                break;
            case 'f':
                i = 5;
                break;
            case 'g':
                i = 6;
                break;
            case 'h':
                i = 7;
                break;
            case 'i':
                i = 8;
                break;
            case 'j':
                i = 9;
                break;
            case 'k':
                i = 10;
                break;
            case 'l':
                i = 11;
                break;
            case 'm':
                i = 12;
                break;
            case 'n':
                i = 13;
                break;
            case 'o':
                i = 14;
                break;
            case 'p':
                i = 15;
                break;
            case 'q':
                i = 16;
                break;
            case 'r':
                i = 17;
                break;
            case 's':
                i = 18;
                break;
            case 't':
                i = 19;
                break;
            case 'u':
                i = 20;
                break;
            case 'v':
                i = 21;
                break;
            case 'w':
                i = 22;
                break;
            case 'x':
                i = 23;
                break;
            case 'y':
                i = 24;
                break;
            case 'z':
                i = 25;
                break;
            default:
                i = 26;
                break;
        }
        Debug.Log(i);
        Debug.Log(letter);
        source.clip = (AudioClip)clips[i];
        source.Play();
    }
}

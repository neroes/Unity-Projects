using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    public static int multi;

    Text text;


    void Awake ()
    {
        text = GetComponent <Text> ();
        score = 0;
        multi = 1;
    }


    void Update ()
    {
        text.text = "Score: " + score + "\n" + "Multiplier: " + multi;
    }
    public static void AddScore (int amount)
    {
        ScoreManager.score += amount * multi;
    }
}

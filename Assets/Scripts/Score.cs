using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    
    [SerializeField]public static int score = 00;
    void Start()
    {
        score = 00;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();
        if (score == 50)
        {
            SceneManager.LoadScene(3);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    private int counter = 450;

    // Update is called once per frame
    void Update()
    {
        counter -= 1;
        if (counter <= 0)
            SceneManager.LoadScene("betasceneMarek");
    }
}

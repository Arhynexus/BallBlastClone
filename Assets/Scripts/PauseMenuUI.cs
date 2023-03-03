using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuUI : MonoBehaviour
{
    [SerializeField] private Transform pauseMenu;
    private bool isPause;
    private int isPauseCounter;
    void Start()
    {
        isPause = false;
        isPauseCounter = 0;
    }

    public void IsPauseCounter()
    {
        int counter = 2;
            isPauseCounter = counter;
    }

    

    // Update is called once per frame
    void Update()
    {



        if (Input.GetKeyDown(KeyCode.Escape) == true)
        {
            Cursor.visible = true;
            isPauseCounter++;
        }
        if (isPauseCounter == 1)
        {
            pauseMenu.gameObject.SetActive(true);
            isPause = true;
        }
        if (isPauseCounter == 2)
        {
            Cursor.visible = false;
            pauseMenu.gameObject.SetActive(false);
            isPause = false;
            isPauseCounter = 0;
        }



    }
}

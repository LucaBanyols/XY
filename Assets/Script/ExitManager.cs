using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitManager : MonoBehaviour
{
    public GameObject nextRoomCanvas;
    private int nbActivate = 0;

    public void AddNbActivate()
    {
        nbActivate += 1;
        if (nbActivate >= 5) {
            openExit();
        }
    }
    
    public void SubNbActivate()
    {
        nbActivate -= 1;
    }

    public void openExit()
    {
        Debug.Log("Exit open");
        StartCoroutine(LoadingNextRoom());
    }

    IEnumerator LoadingNextRoom()
    {
        nextRoomCanvas.SetActive(true);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("RoomWin");
    }
}

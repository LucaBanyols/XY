using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TableManager : MonoBehaviour
{
    public GameObject buttonTable1;
    public GameObject buttonTable2;
    public GameObject buttonTable3;
    public GameObject buttonTable4;
    public GameObject buttonTable5;

    public GameObject nextRoomCanvas;

    private bool table1 = false;
    private bool table2 = false;
    private bool table3 = false;
    private bool table4 = false;
    private bool table5 = false;

    public void turnTrueTableStatus(int tableNb)
    {
        Debug.Log("Table " + tableNb);
        switch (tableNb)
        {
            case 1:
                if (table1 == true)
                    break;
                if (table2 == false && table3 == false && table4 == false && table5 == false)
                {
                    Debug.Log("Table 1 is true");
                    table1 = true;
                }
                if (table2 == true || table3 == true || table4 == true || table5 == true)
                {
                    Debug.Log("Reset by table 1");
                    resetAllTable();
                }
                break;
            case 2:
                if (table2 == true)
                    break;
                if (table1 == false && table3 == false && table4 == false && table5 == false)
                {
                    Debug.Log("Table 2 is true");
                    table2 = true;
                    break;
                }
                if (table1 == true && table3 == false && table4 == false && table5 == false)
                {
                    Debug.Log("Table 2 is true");
                    table2 = true;
                    break;
                }
                if (table1 == false || table3 == true || table4 == true || table5 == true)
                {
                    Debug.Log("Reset by table 2");
                    resetAllTable();
                    break;
                }
                break;
            case 3:
                if (table3 == true)
                    break;
                if (table1 == false && table2 == false && table4 == false && table5 == false)
                {
                    Debug.Log("Table 3 is true");
                    table3 = true;
                    break;
                }
                if (table1 == true && table2 == true && table4 == false && table5 == false)
                {
                    Debug.Log("Table 3 is true");
                    table3 = true;
                    break;
                }
                if (table1 == false || table2 == false || table4 == true || table5 == true)
                {
                    Debug.Log("Reset by table 3");
                    resetAllTable();
                    break;
                }
                break;
            case 4:
                if (table4 == true)
                    break;
                if (table1 == false && table2 == false && table3 == false && table5 == false)
                {
                    Debug.Log("Table 4 is true");
                    table4 = true;
                    break;
                }
                if (table1 == true && table2 == true && table3 == true && table5 == false)
                {
                    Debug.Log("Table 4 is true");
                    table4 = true;
                    break;
                }
                if (table1 == false || table2 == false || table3 == false || table5 == true)
                {
                    Debug.Log("Reset by table 4");
                    resetAllTable();
                    break;
                }
                break;
            case 5:
                if (table5 == true)
                    break;
                if (table1 == false && table2 == false && table3 == false && table4 == false)
                {
                    Debug.Log("Table 5 is true");
                    table5 = true;
                    break;
                }
                if (table1 == true && table2 == true && table3 == true && table4 == true)
                {
                    Debug.Log("Table 5 is true");
                    table5 = true;
                    Debug.Log("Exit open");
                    openExit();
                    break;
                }
                else
                {
                    Debug.Log("Reset by table 5");
                    resetAllTable();
                    break;
                }
                break;
        }
    }

    public void resetAllTable()
    {
        Debug.Log("Reset all table is called");
        buttonTable1.GetComponent<ChangeMaterial>().SetOriginalMaterial();
        table1 = false;
        buttonTable2.GetComponent<ChangeMaterial>().SetOriginalMaterial();
        table2 = false;
        buttonTable3.GetComponent<ChangeMaterial>().SetOriginalMaterial();
        table3 = false;
        buttonTable4.GetComponent<ChangeMaterial>().SetOriginalMaterial();
        table4 = false;
        buttonTable5.GetComponent<ChangeMaterial>().SetOriginalMaterial();
        table5 = false;
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
        SceneManager.LoadScene("Room02 (Sean)");
    }
}

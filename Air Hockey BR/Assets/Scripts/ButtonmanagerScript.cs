using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ButtonmanagerScript : MonoBehaviour {


    public GameObject Settingbackground;
    public void ButtonPressed(string one)
    {
        SceneManager.LoadScene("AfterStartScene", LoadSceneMode.Single);
    }

    public void ExitGameBtn(string two)
    {
        Application.Quit();
    }

    public void SettingBtn(string three)
    {
        Settingbackground.SetActive(true);
    }

    public void SettingBackBtn(string three)
    {
       Settingbackground.SetActive(false);
    }


}

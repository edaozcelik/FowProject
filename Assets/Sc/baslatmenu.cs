using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class baslatmenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Giris()
    {
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    public void Cikis()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class MainMenu : MonoBehaviour {

    private Button start;

	void Start ()
    {
        start = GetComponent<Button>();
        start.onClick.AddListener(loadGame);
    }
	
    private void loadGame()
    {
        SceneManager.LoadScene("Main");
    }
}

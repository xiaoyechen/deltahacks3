using UnityEngine;
using System.Collections;

public class QuitGame : MonoBehaviour {


    private void OnTriggerEnter(Collider collision)
    {
        if(collision.tag == "Hand")
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
        }

    }
}

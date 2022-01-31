using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    [SerializeField] KeyCode restartGame;
    //[SerializeField] Vector3 vector3;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(restartGame))
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
}

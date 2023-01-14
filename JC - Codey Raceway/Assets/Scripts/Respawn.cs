using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    private void OnControllerColliderHit(ControllerColliderHit other)
    {
        if (other.gameObject.tag == "Terrain")
        {
            SceneManager.LoadScene(0);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemBoxSpawner : MonoBehaviour
{
    public GameObject itemBox;

    public int numberOfBoxes;

    public int modifyXPosition;
    public int modifyZPosition;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberOfBoxes; i++)
        {
            GameObject itemBoxClone = Instantiate(
                itemBox, 
                new Vector3(
                    transform.position.x + modifyXPosition * i, 
                    transform.position.y,
                    transform.position.z + modifyZPosition * i
                    ), 
                transform.rotation);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectRandomPowerup : MonoBehaviour
{
    public List<GameObject> powerupList;
    public int randomNumberInList;
    public GameObject chosenPowerup;
    public GameObject spawnPos;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && chosenPowerup != null)
        {
            Instantiate(chosenPowerup, spawnPos.transform.position, transform.rotation);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "itemBoxes")
        {
            
        }
    }

    public void selectPowerup()
    {
        Debug.Log("thing");
        randomNumberInList = Random.Range(0, powerupList.Count-1);
        chosenPowerup = powerupList[randomNumberInList];
    }
}

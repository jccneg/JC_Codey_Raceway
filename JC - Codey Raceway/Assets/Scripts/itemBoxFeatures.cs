using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemBoxFeatures : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, Time.deltaTime * 100f);
        transform.Rotate(Vector3.right, Time.deltaTime * 100f);
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            SelectRandomPowerup code = other.gameObject.GetComponent<SelectRandomPowerup>();
            code.selectPowerup();
            gameObject.SetActive(false);
            Invoke("itemBoxRespawn", 2.0f);
        }
    }

    private void itemBoxRespawn()
    {
        gameObject.SetActive(true);
    }
}

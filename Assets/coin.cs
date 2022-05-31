using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public GameManager gameManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameManager.AddCoinCount();
            
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    private void Start()
    {
        GameObject managerObject = GameObject.Find("GameManager");
        gameManager = managerObject.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Transform transform = this.transform;
        transform.Rotate(0.0f, 5.0f, 0.0f,Space.World);
    }
}

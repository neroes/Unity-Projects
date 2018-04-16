using UnityEngine;
using System.Collections;

public class Multi_PowerUp : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            ScoreManager.multi += 1;
            Destroy(gameObject);
        }
    }
}

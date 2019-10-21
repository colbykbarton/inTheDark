using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadLightController : MonoBehaviour
{
    public GameObject myObject;
    public GameObject light;
    public PlayerCharacter player;
    // Start is called before the first frame update
    void Start()
    {
        this.myObject = GameObject.FindWithTag("Player");
        player = myObject.GetComponent<PlayerCharacter>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.player.getCandelCount() < 1)
        { 
            Debug.Log("you made it in");
            light.SetActive(false);
        }
        else
        {
            light.SetActive(true);
        }
    }
}

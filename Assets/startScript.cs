using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startScript : MonoBehaviour
{
    [SerializeField] public TextMesh startLabel;

    // Start is called before the first frame update
    void Start()
    {
        startLabel.text = "To win the game, reach the finish line without being shot and before the time is up.";
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            Time.timeScale = 1;
            Destroy(gameObject);
        }
    }
}

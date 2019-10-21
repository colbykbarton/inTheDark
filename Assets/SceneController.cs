using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    private GameObject _enemy;
    // Start is called before the first frame update
    void Start()
    {
        _enemy = Instantiate(enemyPrefab) as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
    }
}

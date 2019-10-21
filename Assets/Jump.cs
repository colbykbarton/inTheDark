using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
	public float speed = 100f;
	public Rigidbody rb;

	// Start is called before the first frame update
	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown("space"))
		{
            rb.transform.Translate(0, speed * Time.deltaTime, 0);
        }
	}
}

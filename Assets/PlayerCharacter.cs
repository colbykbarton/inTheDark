using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    [SerializeField] public TextMesh scoreLabel;
    private int _health;
    private float timeLeft = 15.0f;
    private bool gameOver = false;
	private int _candels;
    private int _candelLife;
    private bool hasBoot;
    private bool hasSpring;
    private string message;
    float _t = 0f;
    int newCandel = 10;
    FBSInput inputScript;
    // Start is called before the first frame update
    void Start()
    {
		Time.timeScale = 0;
		_health = 10;
		_candels = 0;
        _candelLife = newCandel;
        hasBoot = false;
        hasSpring = false;
        inputScript = GetComponent<FBSInput>();
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKey("t"))
		{
			timeLeft = 1000.0f;
			_health = 1000;
            _candels = 524;
            inputScript.gotBoot();
            inputScript.gotSpring();
            hasBoot = true;
            hasSpring = true;
		}
		if (!gameOver)
		{
            //scoreLabel.text = "Health: " + _health + "\n" + "Time: " + Math.Round(timeLeft, 2) + "s" + "\n" + "Candels: " + _candel + "'s left";
            message = "Health: " + _health + "\n" + "Candels: " + _candels + "'s left";
            if (hasBoot)
            {
                message += "\n Boot Collected: \n f to run";
            }
            if (hasSpring)
            {
                message += "\n Spring Collected: \n Space to jump";
            }
            scoreLabel.text = message;
            timeLeft -= Time.deltaTime;
		}
       // if (timeLeft < 0 || _health <= 0)
        if (_health <= 0)
        {
			if (!gameOver)
			{
				//scoreLabel.text = "Health: " + _health + "\n" + "Time: " + Math.Round(timeLeft, 2) + "\n" + "GAME OVER";
                scoreLabel.text = "GAME OVER, you lost :(";
                scoreLabel.color = Color.red;
				Time.timeScale = 0;
				gameObject.SetActive(true);
				gameOver = true;
			}
        }

        if (_candels > 0)
        {
            _t += Time.deltaTime;

            if (_t >= 1f)
            {
                _t = 0f;
                if (_candelLife > 0)
                {
                    _candelLife--;
                }
                else
                {
                    _candels--;
                    _candelLife = newCandel;
                }
            }
        }
        
    }

    public void Hurt(int damage)
    {
        _health -= damage;
        Debug.Log("Health: " + _health);
    }

	public void giveCandel(){
		_candels += 1;
	}

    public void winGame()
	{
		gameOver = true;
		scoreLabel.text = "YOU WON THE GAME";
		scoreLabel.color = Color.green;
		Debug.Log("hello");
		Time.timeScale = 0;
	}

    public void giveSpring()
    {
        inputScript.gotSpring();
        hasSpring = true;
    }
    public int getCandelCount()
    {
        return _candels;
    }
    public void giveBoots()
    {
        hasBoot = true;
        inputScript.gotBoot();
    }
}

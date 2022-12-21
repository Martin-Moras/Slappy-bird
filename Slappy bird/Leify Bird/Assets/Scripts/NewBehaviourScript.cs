using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewBehaviourScript : MonoBehaviour
{
	public GameOverScreen gameOverScreen;

	private Rigidbody2D rb;
	private bool IsJumpPresst;
	public int score;
	public float jumpheight;
	public bool isDead;
	public GameInputs Inputs;

	public float wee;
	// Start is called before the first frame update
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		if (Inputs == null) Inputs = new();
		Inputs.Enable();
	}
	private void Update()
	{
		Input();
	}
	private void OnCollisionEnter2D(Collision2D collision)
	{
 		GameOver();
	}
	private void OnTriggerEnter2D(Collider2D other)
	{
		score += 1;
	}
	// Update is called once per frame
	private void FixedUpdate()
	{
		speed();
		Flab();

	}

	private void GameOver()
	{
		isDead = true;
		gameOverScreen.Setup(score);
	}
	void Flab()
	{
		if (IsJumpPresst && isDead == false)
		{
			rb.velocity = new Vector2(0, jumpheight);
			
		}


	}

	void speed()
	{
		if (isDead == false)
		{
			transform.position += new Vector3(wee, 0, 0);
		}
	}
	private void OnEnable()
	{
		if (Inputs == null) Inputs = new();
		Inputs.Enable();
	}
	private void OnDisable()
	{
		if (Inputs == null) Inputs = new();
		Inputs.Disable();
	}
	private void Input()
	{
		float d = Inputs.Movement.Jump.ReadValue<float>();
		IsJumpPresst = 1 == Inputs.Movement.Jump.ReadValue<float>();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyMovement : MonoBehaviour
{
    public Camera flyCam;
	public Vector3 CurrentVelocity = new Vector3(0,1,1);
	public GameObject flyStart;
	public GameObject fly;
	public float countdown = 10.0f;

    // Update is called once per frame
    void Update()
    {
		if (flyStart.GetComponent<FlyGame>().flyMoving)
		{
			countdown -= Time.deltaTime;

			if (countdown <= 0.0f)
			{
				CurrentVelocity = new Vector3(0, Random.Range(-5f, 5f), Random.Range(-5f, 5f));
				countdown = 10.0f;
			}
			transform.position += CurrentVelocity * Time.deltaTime;

			// The code below is just to wrap the screen for the agent like in Asteroids for example
			Vector3 position = transform.position;
			Vector3 viewportPosition = flyCam.WorldToViewportPoint(position);



			while (viewportPosition.x < 0.0f)
			{
				viewportPosition.x += 1.0f;
			}
			while (viewportPosition.x > 1.0f)
			{
				viewportPosition.x -= 1.0f;
			}
			while (viewportPosition.y < 0.0f)
			{
				viewportPosition.y += 1.0f;
			}
			while (viewportPosition.y > 1.0f)
			{
				viewportPosition.y -= 1.0f;
			}

			//position = flyCam.ViewportToWorldPoint(viewportPosition);
			position.x = 0;
			
			fly.transform.position = position;
		}
	}
}

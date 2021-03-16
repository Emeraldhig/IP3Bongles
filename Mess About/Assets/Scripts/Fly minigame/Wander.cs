using UnityEngine;

public class Wander : SteeringBehaviour
{
    /// <summary>
    /// Controls how large the imaginary circle is
    /// </summary>
    [SerializeField]
    protected float circleRadius = 75.0f;

    /// <summary>
    /// Controls how far from the agent position should the centre of the circle be
    /// </summary>
    [SerializeField]
    protected float circleDistance = 150.0f;


    [SerializeField]
    protected float randomDisplacement = 15.0f;

    [SerializeField]
    private float countdown = 5.0f;

    private Vector3 previousPosition;

    [SerializeField]
    protected float speed = 1.0f;

    public bool start = false;

    public GameObject flyStart;

    protected override void Start()
    {
        base.Start();

        speed = Random.Range(1.0f, 5.0f);

        transform.up = RandomPointOnCircle();

        previousPosition = transform.up * (circleDistance + circleRadius);
    }
    

    public override Vector3 UpdateBehaviour(SteeringAgent steeringAgent)
    {

        if (flyStart.GetComponent<FlyGame>().flyMoving)
        {


            countdown -= Time.deltaTime;

            if (countdown <= 0.0f)
            {
                speed = Random.Range(1.0f, 5.0f);
                countdown = 5.0f;
            }

            Vector3 targetPosition = RandomPointOnCircle();

            targetPosition *= randomDisplacement;

            targetPosition += previousPosition;

            Vector3 circlePos = transform.position + (transform.up * circleDistance);
            targetPosition = circlePos + (Vector3.Normalize(targetPosition - circlePos) * circleRadius);

            previousPosition = targetPosition;

            // Get the desired velocity for seek and limit to maxSpeed
            desiredVelocity = Vector3.Normalize(targetPosition - transform.position) * speed;

            // Calculate steering velocity and limit it according to how much it can turn
            steeringVelocity = desiredVelocity - steeringAgent.CurrentVelocity;
            // testVector = randomPoint;
            //test = distance;
        }
            return steeringVelocity;
      
        
	}

    protected static Vector3 RandomPointOnCircle()
    {
        float angle = Random.value * 2.0f * Mathf.PI;

        return new Vector3(Mathf.Cos(angle), Mathf.Sin(angle), 0.0f);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    [SerializeField] private float ballGravity = 3000.0f;

    private int obstacleBumpCount = 0;
    public int ObstacleBumpCount => this.obstacleBumpCount;
    

    private Rigidbody ballRB;


    private bool canAddBump = true;
    private Coroutine delayBumpCount;

    // Start is called before the first frame update
    void Start()
    {
        this.ballRB = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.ballRB.AddForce(Vector3.down * this.ballGravity, ForceMode.Acceleration);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            if (this.canAddBump)
            {
                this.obstacleBumpCount++;
                collision.gameObject.GetComponent<ObjectHit>().TurnObstacleRed();

                this.canAddBump = false;

                this.delayBumpCount = StartCoroutine(this.AllowBumpingAgain());
            }
                
        }
    }

    private IEnumerator AllowBumpingAgain()
    {
        yield return new WaitForSeconds(0.4f);

        this.canAddBump = true;
    }
}

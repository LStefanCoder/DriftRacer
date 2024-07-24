using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driftscorer_tut : MonoBehaviour

    //based on https://www.youtube.com/watch?v=t3uh70YPvjw

    public RigidBody car;

    private float speed = 0;
    private float driftAngle = 0;
    private float driftFactor = 1;
    private float currentScore;
    private float totalScore;

    private bool isDrifting = false;

    public float minSpeed = 5;
    public float minAngle = 10;
    public float driftDelay = 0.2f;
    public GameObject DrifterObject;
    public Color driftNormalColor;
    public Color driftNearStopColor;
    public Color driftEndColor;

    private IEnumerator stopDriftingCoroutine = null;

{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //ManageDrift();
        //ManageUI();
    }

    void ManageDrift()
    {
        speed = car.velocity.magnitude;
        driftAngle = Vector3.Angle(car.transform.forward, (car.velocity + car.transform.forward).normalized);
        if(driftAngle > 120)
        {
            driftAngle = 0;
        }
        if (driftAngle >= minAngle && speed > minSpeed)
        {
            if(!isDrifting || stopDriftingCoroutine != null)
            {
                StartDrift();
            }
        }
        else
        {
            if (isDrifting)
            {
                StopDrift();
            }
        }

        if (isDrifting)
        {
            currentScore += Time.deltatTime * driftAngle * driftFactor;
            driftFactor += Time.deltaTime;
        }
    }

    async void StartDrift()
    {
        if(!isDrifting)
        {
            await Task.Delay(Mathf.RoundToInt(1000 * driftingDelay));
            driftFactor = 1;
        }
        currentScoreText.color = driftNormalColor;
        isDrifting = true;
    }

    void StopDrift()
    {
        stopDriftingCoroutine = StoppingDrift();
        StartCoroutine(stopDriftingCoroutine);    }

    private IEnumerator StoppingDrift()
    {
        yield return new WaitForSeconds(0.1f);
        currentScoreText.color = driftNearStopColor;
        yield return new WaitForSeconds(driftingDelay * 4f);
        totalScore += currentScore;
        isDrifting = false;
        currentScoreText.color = driftEndColor;
        yield return new WaifForSeconds(0.5f);
        currentScore = 0;
        car.SetActive(false);
    }

    void ManageUI()
    {
        totalScoreText.text = "Total: " + (totalScore + currentScore).ToString("###,###,000");
        factorText.text = driftFactor.ToString("###,###,##0.0") + "X";
        currentScoreText.text = currentScore.ToString("###,###,000");
        driftAngleText.text = driftAngle.ToString("###,###,000");
    }
}

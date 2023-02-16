using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundTrans : MonoBehaviour
{

    private void Update()
    {
        if(Ground.Instance.WaveCount == Ground.Instance.EndPhase && transform.position.x > -5.7f)
        {
            transform.Translate(-transform.right * 10 * Time.deltaTime);
        }
        else if (transform.position.x <= -5.7f)
        {
            Ground.Instance.EndPhase = int.MaxValue;
        }
    }
}

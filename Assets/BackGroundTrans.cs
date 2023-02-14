using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundTrans : MonoBehaviour
{

    private void Update()
    {
        if(Ground.WaveCount == Ground.EndPhase && transform.position.x > -5.7f)
        {
            transform.Translate(-transform.right * 10 * Time.deltaTime);
        }
        else if (transform.position.x <= -5.7f)
        {
            Ground.WaveCount = 0;
            Ground.EndPhase = int.MaxValue;
        }
    }
}

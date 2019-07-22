using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Generate : MonoBehaviour
{
    public Text piValueText;
    public GameObject pointPrefab;
    public float radiu = 0;
    public float waitTime = 0;
    public int number = 0;

    public int soto = 0;
    public int uti = 0;

    public int count = 0;

    private void Start()
    {
        StartCoroutine(GeneratePoint());   
    }

    private IEnumerator GeneratePoint()
    {
        while(number >= 0)
        {
            float randomX = Random.Range(-radiu, +radiu);
            float randomY = Random.Range(-radiu, +radiu);
            GameObject obj = GameObject.Instantiate(pointPrefab);
            obj.transform.position = new Vector3(randomX, randomY, 0);
            obj.transform.SetParent(this.transform);
            if (Mathf.Sqrt(randomX * randomX + randomY * randomY) <= radiu)
            {
                uti++;
            }
            //number--;
            count++;
            yield return null;
            //yield return new WaitForSeconds(waitTime);
        }
        yield return null;
    }

    private void Update()
    {
        piValueText.text = "π = " + (float)(4 * uti) / (float)count;
    }

}

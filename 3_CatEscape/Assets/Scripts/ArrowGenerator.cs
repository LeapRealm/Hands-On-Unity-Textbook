using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    private float span = 0.5f;
    private float delta = 0;

    private void Update()
    {
        delta += Time.deltaTime;
        if (delta > span)
        {
            delta = 0;
            GameObject arrowInstance = Instantiate(arrowPrefab);
            int positionX = Random.Range(-12, 13);
            arrowInstance.transform.position = new Vector3(positionX, 7, 0);
        }
    }
}
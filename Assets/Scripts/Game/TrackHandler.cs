using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TrackHandler : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 0f;

    [SerializeField]
    GameObject trackPrefab;

    [SerializeField]
    Text textScore;

    private float distanceOfDeletion = -20;
    internal int nScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textScore.text = nScore.ToString();

        gameObject.transform.Translate(-Vector3.forward * Time.deltaTime * moveSpeed);

        if (gameObject.transform.position.z < distanceOfDeletion)
        {
            nScore += 5;

            // Destroy object and move bound
            Destroy(gameObject.transform.GetChild(0).gameObject);
            distanceOfDeletion = distanceOfDeletion - 20;

            // Add new track
            GameObject tempTrack = Instantiate(trackPrefab, Vector3.zero, Quaternion.identity);
            tempTrack.transform.position = new Vector3(0, 0, gameObject.transform.GetChild(gameObject.transform.childCount - 1).transform.position.z + 20);
            tempTrack.transform.parent = gameObject.transform;
           
        }
    }
}

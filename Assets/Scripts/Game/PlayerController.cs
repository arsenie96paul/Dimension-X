using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 0f;

    [SerializeField]
    GameObject cam;

    [SerializeField]
    TrackHandler th;
    
    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        if (Input.GetButton("MoveRight"))
        {
            gameObject.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }

        if (Input.GetButton("MoveLeft"))
        {
            gameObject.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if ( other.tag == "Obstacle" || other.gameObject.tag == "Border")
        {
            cam.transform.parent = null;
            th.enabled = false;
            gameObject.SetActive(false);
            Invoke("GameOver",2.5f);
        }
    }

    private void GameOver()
    {
        PlayerPrefs.SetInt("CurrentScore", th.nScore);
        SceneManager.LoadScene(0);
    }
}

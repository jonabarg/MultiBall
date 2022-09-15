using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lecture : MonoBehaviour {

    [SerializeField]
    private Transform[] balls;
    private Vector3[] og_balls;

    private List<float> speeds;

    private void Awake() {
        og_balls = new Vector3[balls.Length];
        speeds = new List<float>();
        for(int i = 0; i < balls.Length; i++) {
            speeds.Add(Random.Range(.1f, 1f)/2);
            og_balls[i] = balls[i].position;
        }
    }
    void Update() {
        if (Input.GetKey("w")) {
            for (int i = 0; i < balls.Length; i++) {
                balls[i].position += new Vector3(speeds[i], 0, 0);
            }
        }
        if (Input.GetKey("a")) {
            for (int i = 0; i < balls.Length; i++) {
                balls[i].position += new Vector3(0, 0, speeds[i]);
            }
        }
        if (Input.GetKey("s")) {
            for (int i = 0; i < balls.Length; i++) {
                balls[i].position -= new Vector3(speeds[i], 0, 0);
            }
        }
        if (Input.GetKey("d")) {
            for (int i = 0; i < balls.Length; i++) {
                balls[i].position -= new Vector3(0, 0, speeds[i]);
            }
        }
        if (Input.GetKey("space")) {
            for (int i = 0; i < balls.Length; i++) {
                balls[i].position = og_balls[i];
            }
        }
    }
}

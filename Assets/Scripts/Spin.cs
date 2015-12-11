using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour {

    public Controller gameController;

    const int nrItems = 18;
    bool isSpinning = false;
    int frameCounter = 0;
    int spinFrames = 0;

    int item = 0;
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            spinFrames = Random.Range(90, 130);
            item = (item + spinFrames) % (nrItems / 2);
            frameCounter = 0;
            isSpinning = true;
        }

        if (isSpinning) {
            transform.Rotate(new Vector3(0.0f, 1.0f, 0.0f), -360.0f / nrItems);

            if (frameCounter < spinFrames) {
                ++frameCounter;
            } else {
                isSpinning = false;
                gameController.CheckItems();
            }
        }
	}

    public int GetItem() {
        return item;
    }
}

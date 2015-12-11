using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

    public Spin spinner1;
    public Spin spinner2;
    public Spin spinner3;

    public void CheckItems() {
        int i1 = spinner1.GetItem();
        int i2 = spinner2.GetItem();
        int i3 = spinner3.GetItem();

        if (i1 == i2 && i2 == i3) {
            Debug.Log("3 of a kind!");
        } else if (i1 == i2 || i1 == i3 || i2 == i3) {
            Debug.Log("2 of a kind!");
        }
    }
}

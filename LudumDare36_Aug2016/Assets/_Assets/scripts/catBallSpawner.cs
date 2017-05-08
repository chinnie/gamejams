using UnityEngine;
using System.Collections;
using VRTK;

public class catBallSpawner : MonoBehaviour {
    public VRTK_Lever lever;
    public GameObject ToCopy;

    private void Update()
    {
        //if lever is pulled
                
        // spawn item
       
    }
}


/*            if (Button.ButtonDown)
            {
                GameObject newGo = GameObject.Instantiate(ToCopy);
                newGo.transform.position = this.transform.position + new Vector3(0, 1, 0);
                newGo.transform.localScale = ToCopy.transform.lossyScale;

    */
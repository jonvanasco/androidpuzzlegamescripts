using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear : MonoBehaviour
{
    [SerializedField]
	private GameObject winText;

    // Start is called before the first frame update
    void Start()
    {
        winText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
		
	if (Bear.locked && Koala.locked && Hare.locked)
		winText.setActive(true);
		
    }
}

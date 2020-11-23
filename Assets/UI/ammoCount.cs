using UnityEngine;
using UnityEngine.UI;

public class ammoCount : MonoBehaviour
{
    public Text ammoText;
    public GameObject playerObject;


    // Update is called once per frame
    void Update()
    {
        if (playerObject != null)
        {
            Player player = playerObject.gameObject.GetComponent<Player>();

            ammoText.text = player.AmmoCount().ToString();
        }
        
    }


}

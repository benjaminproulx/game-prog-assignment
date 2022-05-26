using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryDiamond : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject particles;
    public GameObject player;
    public string level;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [System.Obsolete]
    private IEnumerator Victory()
    {
        Camera.main.transform.parent = null;
        player.gameObject.active = false;
        Instantiate(particles, player.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(level);
    }

    [System.Obsolete]
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && GameObject.FindGameObjectsWithTag("Diamond").Length == 0)
        {
            GetComponent<MeshRenderer>().enabled = false;
            StartCoroutine(Victory());
        }
    }
}

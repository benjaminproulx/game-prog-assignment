using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class KillZone : MonoBehaviour
{
    // Start is called before the first frame update
    public string level;
    public GameObject particles;
    public GameObject player;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [System.Obsolete]
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(Death());
        }
    }

    [System.Obsolete]
    private IEnumerator Death()
    {
        Camera.main.transform.parent = null;
        Instantiate(particles, player.transform.position, Quaternion.identity);
        player.active = false;
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(level);
    }
}

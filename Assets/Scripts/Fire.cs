using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject player;
    public Vector3 fireSpeed = new Vector3(0f, .005f, 0f);
    private AudioSource fireAudio;
    public AudioClip deathSound;
    // Start is called before the first frame update
    void Start()
    {
        fireAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(fireSpeed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            fireAudio.PlayOneShot(deathSound, 1.0f);
            Destroy(other.gameObject);
        }
    }
}

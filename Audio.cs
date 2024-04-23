private AudioSource audioSource;
public AudioClip audioClip;

void Start()
{
    audioSource = GetComponent<AudioSource>();
}

void Update()
{
    audioSource.clip = audioClip;
    if (...)
    {
        audioSource.Play();
    }

}
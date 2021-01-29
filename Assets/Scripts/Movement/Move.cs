using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    [SerializeField]
    private bool moving;

    [SerializeField]
    private float speed;

    [SerializeField]
    private GameObject jar;

    [SerializeField]
    private GameObject jarPos;

    [SerializeField]
    private GameObject jarInv;

    [SerializeField]
    private GameObject Key;

    [SerializeField]
    private GameObject netItem;

    [SerializeField]
    private GameObject hoop;

    [SerializeField]
    private Transform originalPosition;

    [SerializeField]
    private GameObject stickPosition;

    [SerializeField]
    private GameObject netPosition;

    [SerializeField]
    private Transform hoopPosition;

    [SerializeField]
    private GameObject net;

    [SerializeField]
    private GameObject hoopObj;

    [SerializeField]
    private GameObject soloNet;

    [SerializeField]
    private GameObject invetory;

    [SerializeField]
    public static bool[] collected = new bool[3];

    public bool[] collect = new bool[collected.Length];

    private Animation anim;

    private string sceneName;

    private static bool collectedJar;

    int i;


    public GameObject speaker;
    public Transform speechPosition;
    public GameObject speech1;

    private AudioOutput audioscript;

    public bool objectObtained()
    {

        for (int i = 0; i < collect.Length; i++)
        {
            collect[i] = collected[i];

            return collect[i];
        }

        return collect[i];
    }
    // Start is called before the first frame update
    void Start()
    {
        if (sceneName == "Brainy")
        {
            speech1.transform.position = new Vector3(speechPosition.transform.position.x, speechPosition.transform.position.y, speechPosition.transform.position.z);
            speaker.SetActive(true);
        }
        
        speed = 10;
        anim = gameObject.GetComponent<Animation>();
    }
    public void StartVoice()
    {
        if (sceneName == "Brainy")
        {
            audioscript = GetComponent<AudioOutput>();
        }
    }
    private void Awake()
    {
        invetory.transform.position = new Vector3(-23, 9, -15);
        Instantiate(invetory);
        invetory.transform.localScale = new Vector3(2, 2, 0);

    }
    // Update is called once per frame
    void Update()
    {
        sceneName = SceneManager.GetActiveScene().name;

        if (sceneName == "crossroads")
        {
            sceneTransfer();

            if (!collectedJar)
            {
                if (moving == true)
                {
                    float MoveDistance = speed * Time.deltaTime; // calculate distance to move
                    transform.position = Vector3.MoveTowards(transform.position, jar.transform.position, MoveDistance);
                    anim.Play("WalkAnim");
                }

                if (Vector3.Distance(transform.position, jar.transform.position) < 1f)
                {
                   
                    GetComponent<AudioSource>().Play();     //Play the sfx attached to the object
                    anim.Play("PickupAnim");
                    StartCoroutine(timer());
                    collectedJar = true;
                    Destroy(jar);
                    jarInv.transform.position = jarPos.transform.position;
                    
                    Return();
                    i += 1;
                    moving = false;
                }
                if (collectedJar && transform.position != originalPosition.position)
                {
                    Return();
                    moving = false;
                }
            }
            if(collectedJar)
            {
                jar.transform.position = new Vector3(40000, 40000, 40000);
            }    
            
        }


        if (sceneName == "Brainy")
        {
           
            if (hoop != null)
            {
                if (moving == true)
                {
                    float MoveDistance = speed * Time.deltaTime; // calculate distance to move
                    transform.position = Vector3.MoveTowards(transform.position, hoop.transform.position, MoveDistance);
                    anim.Play("WalkAnim");
                }

                if (Vector3.Distance(transform.position, hoop.transform.position) < 1f)
                {
                    GetComponent<AudioSource>().Play();     //Play the sfx attached to the object
                    anim.Play("PickupAnim");
                    StartCoroutine(timer());
                    collected[i] = true;
                    Destroy(hoop);
                    hoopObj.transform.position = hoopPosition.transform.position;
                    Instantiate(hoopObj);
                    Return();
                    i += 1;
                    moving = false;
                }
            }

            /*if (Key == null && transform.position != originalPosition.position)
            {
                Return();
                moving = false;
            }*/

           
        }
        if (sceneName == "lake")
        {
            if (Key != null)
            {
                if (moving == true)
                {
                    float MoveDistance = speed * Time.deltaTime; // calculate distance to move
                    transform.position = Vector3.MoveTowards(transform.position, Key.transform.position, MoveDistance);
                    anim.Play("WalkAnim");
                }

                if (Vector3.Distance(transform.position, Key.transform.position) < 1f)
                {
                    GetComponent<AudioSource>().Play();     //Play the sfx attached to the object
                    anim.Play("PickupAnim");
                    StartCoroutine(timer());
                    collected[i] = true;
                    Destroy(Key);
                    stickPosition.SetActive(true);
                    net.transform.position = stickPosition.transform.position;
                    //Instantiate(net);
                    Return();
                    i += 1;
                    moving = false;
                }
            }
            if (netItem != null && Key == null)
            {
                if (moving == true)
                {
                    float MoveDistance = speed * Time.deltaTime; // calculate distance to move
                    transform.position = Vector3.MoveTowards(transform.position, netItem.transform.position, MoveDistance);
                    anim.Play("WalkAnim");
                }

                if (Vector3.Distance(transform.position, netItem.transform.position) < 1f)
                {
                    GetComponent<AudioSource>().Play();     //Play the sfx attached to the object
                    anim.Play("PickupAnim");
                    StartCoroutine(timer());
                    collected[i] = true;
                    Destroy(netItem);
                    netPosition.SetActive(true);
                    soloNet.transform.position = netPosition.transform.position;
                   // Instantiate(soloNet);
                }
            }

            if (netItem == null && transform.position != originalPosition.position)
            {
                Return();
                moving = false;
            }
        }
    }

    public void Return()
    {
        float MoveDistance = speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, originalPosition.position, MoveDistance);
    }

    public void Moving()
    {
        moving = true;
    }

    void OnMouseDown()
    {
        moving = true;
    }

    IEnumerator timer()
    {
        yield return new WaitForSeconds(5.0f);
    }

    private void sceneTransfer()
    {
        bool Jungle1, Lake1;
        Jungle1 = Key.GetComponent<SceneCollision>().Jungle;
        Lake1 = Key.GetComponent<SceneCollision>().Lake;
        if (Key != null && collectedJar)
        {
            if (moving == true)
            {
                if (Jungle1) // this decides what path player takes based on item selected
                {
                    float MoveDistance = speed * Time.deltaTime; // calculate distance to move
                    transform.position = Vector3.MoveTowards(transform.position, Key.transform.position, MoveDistance);
                    
                    if (Vector3.Distance(transform.position, Key.transform.position) < 1f)
                    {
                        
                        SceneManager.LoadScene("Brainy");
                    }
                }
                else
                {
                    float MoveDistance = speed * Time.deltaTime; // calculate distance to move
                    transform.position = Vector3.MoveTowards(transform.position, net.transform.position, MoveDistance);
                   
                    if (Vector3.Distance(transform.position, net.transform.position) < 1f)
                    {
                        SceneManager.LoadScene("lake");
                    }
                }
            }
        }
    }

}


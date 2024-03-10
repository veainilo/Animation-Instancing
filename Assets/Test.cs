using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField]
    private GameObject instancing;

    [SerializeField]
    private GameObject normal;

    [SerializeField]
    private bool isInstancing;

    // Start is called before the first frame update
    void Start()
    {
        // 生成1000个到随机位置
        for (int i = 0; i < 1000; i++)
        {
            if (isInstancing)
            {
                GameObject go = Instantiate(instancing);
                go.name = instancing.name;
                go.transform.position = new Vector3(Random.Range(-10f, 10f), 0, Random.Range(-10f, 10f));
            }
            else
            {
                GameObject go = Instantiate(normal);
                go.name = normal.name;
                go.transform.position = new Vector3(Random.Range(-10f, 10f), 0, Random.Range(-10f, 10f));
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
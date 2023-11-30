using UnityEngine;

public class RotateParent : MonoBehaviour
{
    private Transform[] childrenTransforms;
    private Vector3[] positions;
    private Quaternion[] rotations;
    private int currentIndex = 0;

    void Start()
    {
        childrenTransforms = new Transform[transform.childCount];
        positions = new Vector3[]
        {
            new Vector3(0, 3.03f, 0), new Vector3(-3f, 0, 0),
            new Vector3(0, -3.03f, 0), new Vector3(3.06f, 0, 0)
        };
        rotations = new Quaternion[]
        {
            Quaternion.Euler(0, 0, 0), Quaternion.Euler(0, 0, 90),
            Quaternion.Euler(0, 0, 180), Quaternion.Euler(0, 0, 270)
        };

        for (int i = 0; i < transform.childCount; i++)
        {
            childrenTransforms[i] = transform.GetChild(i);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            RotateCounterClockwise();
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            RotateClockwise();
        }
    }

    void RotateCounterClockwise()
    {
        currentIndex = (currentIndex + 1) % 4;

        if (currentIndex == 0)
        {
            for (int i = 0; i < childrenTransforms.Length; i++)
            {
                childrenTransforms[i].SetLocalPositionAndRotation(positions[i], rotations[i]);
            }
        }
        else
        {
            for (int i = 0; i < childrenTransforms.Length; i++)
            {
                int rotationIndex = (currentIndex + i) % 4;
                childrenTransforms[i].SetLocalPositionAndRotation(positions[rotationIndex], rotations[rotationIndex]);
            }
        }
    }

    void RotateClockwise()
    {
        currentIndex = (currentIndex - 1 + 4) % 4;

        if (currentIndex == 0)
        {
            for (int i = 0; i < childrenTransforms.Length; i++)
            {
                childrenTransforms[i].SetLocalPositionAndRotation(positions[i], rotations[i]);
            }
        }
        else
        {
            for (int i = 0; i < childrenTransforms.Length; i++)
            {
                int rotationIndex = (currentIndex + i) % 4;
                childrenTransforms[i].SetLocalPositionAndRotation(positions[rotationIndex], rotations[rotationIndex]);
            }
        }
    }
}

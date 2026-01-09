using UnityEngine;

public class TeamMember : MonoBehaviour
{
    public int team;

    public Material[] shirts;

    // Update is called once per frame
    void Update()
    {
        GetComponentInChildren<Renderer>().material = shirts[team];
    }
}

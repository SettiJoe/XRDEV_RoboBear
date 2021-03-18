using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PaintballPellet : MonoBehaviour
{
    public List<Material> paints = new List<Material>();
    private int count;

    public int PaintIndex { get; } = Random.Range(max: PaintIndex,
                                                  count);

    public PaintballPellet(int paintIndex)
    {
        this.PaintIndex = paintIndex;
    }

    void Start()
    {
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Paintable")
        {
            collision.collider.GetComponent<Renderer>().material = paints[PaintIndex];
            
            // Randomize paintIndex
            

            // condition to taper index within set Index

            Destroy(this.gameObject);
        }
    }

    public override bool Equals(object obj)
    {
        return obj is PaintballPellet pellet &&
               base.Equals(obj) &&
               PaintIndex == pellet.PaintIndex;
    }
}
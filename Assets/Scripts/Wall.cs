using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {

    public Sprite dmgSprite;
    public int hp = 1;

    private SpriteRenderer spriteRenderer;
	// Use this for initialization
	void Awake () {
        spriteRenderer = GetComponent<SpriteRenderer>();
	}
	public void DamageWall(int less)
    {
        spriteRenderer.sprite = dmgSprite;
        hp = -less;
        if (hp <= 0)
            gameObject.SetActive(false);
    }
	// Update is called once per frame
	void Update () {
	
	}
}

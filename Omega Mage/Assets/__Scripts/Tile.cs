using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour {
	//public fields
	public string          type;

	//hidden private fields
	private string         _tex;
	private int            _height = 0;
	private Vector3        _pos;

	//Properties with get{} and set{}

	//height moves the Tile up or down.  Walls have height = 1
	public int height{
		get { return(_height);}
		set{
			_height = value;
			AdjustHeight();
		}
	}

	//Sets the texture of the Tile based on a string
	//It requires LayoutTiles, so it's commented out for now
	/*
	public string tex{
		get{
			return(_tex);
		}
		set{
			_tex = value;
			name = "TilePrefab_" + _tex; //Sets the name of this GameObject
			Texture2D t2d = LayoutTiles.S.GetTileTex(_tex);
			if(t@D == null){
				Utils.tr("ERROR", "Tile.type[set]=",value,
					"No matching Texture2D in LayoutTiles.S.tileTexture!");
			}else{
				renderer.material.mainTexture = t2D;
			}
		}
	}
	*/

	//Uses the "new" keyword to replace the pos inherited from PT_MonoBehaviour
	//without the "new" keyword, the two properties would conflict
	new public Vector3 pos{
		get { return(_pos);}
		set{
			_pos = value;
			AdjustHeight();
		}
	}
}

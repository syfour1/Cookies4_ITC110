using UnityEngine;

public class CharConverter : MonoBehaviour 
{
    public KeyCode CharToKeyCode(char character)
	{
        switch(character){
            'a':{
                return KeyCode.A;
            }
            'b':{
                return KeyCode.B;
            }
			'c':{
				return KeyCode.C;
			}
			'd':{
				return KeyCode.D;
			}
			'e':{
				return KeyCode.E;
			}
			'f':{
				return KeyCode.F;
			}
			'g':{
				return KeyCode.G;
			}
			'h':{
				return KeyCode.H;
			}
			'i':{
				return KeyCode.I;
			}
			'j':{
				return KeyCode.J;
			}
			'k':{
				return KeyCode.K;
			}
			'l':{
				return KeyCode.L;
			}
			'm':{
				return KeyCode.M;
			}
			'n':{
				return KeyCode.N;
			}
			'o':{
				return KeyCode.O;
			}
			'p':{
				return KeyCode.P;
			}
			'q':{
				return KeyCode.Q;
			}
			'r':{
				return KeyCode.R;
			}
			's':{
				return KeyCode.S;
			}
			't':{
				return KeyCode.T;
			}
			'u':{
				return KeyCode.U;
			}
			'v':{
				return KeyCode.V;
			}
			'w':{
				return KeyCode.W;
			}
			'x':{
				return KeyCode.X;
			}
			'y':{
				return KeyCode.Y;
			}
			'z':{
				return KeyCode.Z;
			}
            //...and so on until you hit Z. I'm not really sure how we'd want to handle capitalization here, but this should get close enough.
        }
    }
}
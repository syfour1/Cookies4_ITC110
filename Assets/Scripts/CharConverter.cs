using UnityEngine;

public class CharConverter : MonoBehaviour
{
	public static KeyCode CharToKeyCode(char character)
	{
		switch(character)
		{
			case('a'):
			{
                return KeyCode.A;
				break;
            }
            case('b'):
			{
                return KeyCode.B;
				break;
            }
			case('c'):
			{
				return KeyCode.C;
				break;
			}
			case('d'):
			{
				return KeyCode.D;
				break;
			}
			case('e'):
			{
				return KeyCode.E;
				break;
			}
			case('f'):
			{
				return KeyCode.F;
				break;
			}
			case('g'):
			{
				return KeyCode.G;
				break;
			}
			case('h'):
			{
				return KeyCode.H;
				break;
			}
			case('i'):
			{
				return KeyCode.I;
				break;
			}
			case('j'):
			{
				return KeyCode.J;
				break;
			}
			case('k'):
			{
				return KeyCode.K;
				break;
			}
			case('l'):
			{
				return KeyCode.L;
				break;
			}
			case('m'):
			{
				return KeyCode.M;
				break;
			}
			case('n'):
			{
				return KeyCode.N;
				break;
			}
			case('o'):
			{
				return KeyCode.O;
				break;
			}
			case('p'):
			{
				return KeyCode.P;
				break;
			}
			case('q'):
			{
				return KeyCode.Q;
				break;
			}
			case('r'):
			{
				return KeyCode.R;
				break;
			}
			case('s'):
			{
				return KeyCode.S;
				break;
			}
			case('t'):
			{
				return KeyCode.T;
				break;
			}
			case('u'):
			{
				return KeyCode.U;
				break;
			}
			case('v'):
			{
				return KeyCode.V;
				break;
			}
			case('w'):
			{
				return KeyCode.W;
				break;
			}
			case('x'):
			{
				return KeyCode.X;
				break;
			}
			case('y'):
			{
				return KeyCode.Y;
				break;
			}
			default:
			{
				return KeyCode.Z;
			}
			//...and so on until you hit Z. I'm not really sure how we'd want to handle capitalization here, but this should get close enough.
		}
	}

	public static bool CapitalCharToKeyCode(char character)
	{
		switch(character)
		{
			case('A'):
			{
                return true;
				break;
            }
            case('B'):
			{
                return true;
				break;
            }
			case('C'):
			{
				return true;
				break;
			}
			case('D'):
			{
				return true;
				break;
			}
			case('E'):
			{
				return true;
				break;
			}
			case('F'):
			{
				return true;
				break;
			}
			case('G'):
			{
				return true;
				break;
			}
			case('H'):
			{
				return true;
				break;
			}
			case('I'):
			{
				return true;
				break;
			}
			case('J'):
			{
				return true;
				break;
			}
			case('K'):
			{
				return true;
				break;
			}
			case('L'):
			{
				return true;
				break;
			}
			case('M'):
			{
				return true;
				break;
			}
			case('N'):
			{
				return true;
				break;
			}
			case('O'):
			{
				return true;
				break;
			}
			case('P'):
			{
				return true;
				break;
			}
			case('Q'):
			{
				return true;
				break;
			}
			case('R'):
			{
				return true;
				break;
			}
			case('S'):
			{
				return true;
				break;
			}
			case('T'):
			{
				return true;
				break;
			}
			case('U'):
			{
				return true;
				break;
			}
			case('V'):
			{
				return true;
				break;
			}
			case('W'):
			{
				return true;
				break;
			}
			case('X'):
			{
				return true;
				break;
			}
			case('Y'):
			{
				return true;
				break;
			}
			case('Z'):
			{
				return true;
			}
			default:
			{
				return false;
			}
		}
	}
}
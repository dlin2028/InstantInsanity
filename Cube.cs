using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantInsanity
{
    public enum Color
    {
        Red,
        Blue,
        Green,
        White
    }
    class Cube
    {
        public Color Top
        {
            get
            {
                return Colors[0];
            }
            set
            {
                Colors[0] = value;
            }
        }    //0
        public Color Bottom
        {
            get
            {
                return Colors[1];
            }
            set
            {
                Colors[1] = value;
            }
        } //1
        public Color Front
        {
            get
            {
                return Colors[2];
            }
            set
            {
                Colors[2] = value;
            }
        }  //2
        public Color Left
        {
            get
            {
                return Colors[3];
            }
            set
            {
                Colors[3] = value;
            }
        }   //3
        public Color Back
        {
            get
            {
                return Colors[4];
            }
            set
            {
                Colors[4] = value;
            }
        }   //4
        public Color Right
        {
            get
            {
                return Colors[5];
            }
            set
            {
                Colors[5] = value;
            }
        }  //5

        public List<Color> Colors;

        public Cube()
        {
            Colors = new List<Color>();
            for (int i = 0; i < 6; i++)
            {
                Colors.Add(new Color());
            }
        }

        public void RotateLeft()
        {
            Color temp = Front;
            Front = Left;
            Left = Back;
            Back = Right;
            Right = temp;
        }
        public void RotateRight()
        {
            Color temp = Front;
            Front = Right;
            Right = Back;
            Back = Left;
            Left = temp;
        }
        public void RotateUp()
        {
            Color temp = Top;
            Top = Front;
            Front = Bottom;
            Bottom = Back;
            Back = temp;
        }
        public void RotateDown()
        {
            Color temp = Top;
            Top = Back;
            Back = Bottom;
            Bottom = Front;
            Front = temp;
        }
    }
}

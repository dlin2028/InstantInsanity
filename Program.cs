using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantInsanity
{
    class Program
    {
        public static List<Cube> Cubes;
        static void Main(string[] args)
        {
            Cubes = new List<Cube>();
            Cubes.Add(new Cube
            {
                Top = Color.Blue,
                Bottom = Color.White,
                Front = Color.Red,
                Left = Color.Green,
                Back = Color.White,
                Right = Color.Red
            });
            Cubes.Add(new Cube
            {
                Top = Color.Green,
                Bottom = Color.White,
                Front = Color.Blue,
                Left = Color.Red,
                Back = Color.Red,
                Right = Color.Red
            });
            Cubes.Add(new Cube()
            {
                Top = Color.Red,
                Bottom = Color.Green,
                Front = Color.Blue,
                Left = Color.Green,
                Back = Color.Blue,
                Right = Color.White
            });
            Cubes.Add(new Cube()
            {
                Front = Color.White,
                Bottom = Color.White,
                Left = Color.Blue,
                Back = Color.Blue,
                Right = Color.Red
            });

            int counter = 0;

            for (int i = 0; i < 4; i++)
            {
                Cubes[i].RotateLeft();
                for (int j = 0; j < 4; j++)
                {
                    Cubes[i].RotateDown();

                    for (int k = 0; k < 4; k++)
                    {
                        Cubes[k].RotateLeft();
                        for (int l = 0; l < 4; l++)
                        {
                            Cubes[k].RotateDown();

                            for (int m = 0; m < 4; m++)
                            {
                                Cubes[m].RotateLeft();
                                for (int n = 0; n < 4; n++)
                                {
                                    Cubes[m].RotateDown();

                                    for (int o = 0; o < 4; o++)
                                    {
                                        Cubes[o].RotateLeft();
                                        for (int p = 0; p < 4; p++)
                                        {
                                            Cubes[o].RotateDown();
                                            for (int q = 0; q < 4; q++)
                                            {
                                                for (int r = q; r < 4; r++)
                                                {
                                                    Cube temp = Cubes[q];
                                                    Cubes[q] = Cubes[r];
                                                    Cubes[r] = temp;
                                                    if (CheckCubes())
                                                    {
                                                        Console.WriteLine("yasy");
                                                        goto yay;
                                                    }
                                                    counter++;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            yay:
            int nah = 1;
            foreach (var cube in Cubes)
            {
                Console.WriteLine(nah++ + "---------------------");
                Console.WriteLine("Top: " + cube.Top.ToString());
                Console.WriteLine("Bottom: " + cube.Bottom.ToString());
                Console.WriteLine("Front: " + cube.Front.ToString());
                Console.WriteLine("Left: " + cube.Left.ToString());
                Console.WriteLine("Back: " + cube.Back.ToString());
                Console.WriteLine("Right: " + cube.Right.ToString());
            }

            Console.WriteLine(counter);
            Console.ReadKey();

            ////break padlock

            //for (int i = 0; i < length; i++)
            //{
            //    for (int j = 0; j < length; j++)
            //    {
            //        for (int k = 0; k < length; k++)
            //        {
            //            for (int l = 0; l < length; l++)
            //            {
            //                i, j, k, l
            //            }
            //        }
            //    }
            //}

        }

        public static bool CheckCubes()
        {
            foreach (var cube in Cubes)
            {
                foreach (var cube2 in Cubes)
                {
                    if (cube == cube2) continue;

                    for (int i = 0; i < 6; i++)
                    {
                        if (i == 3 || i == 5) continue;

                        if (cube.Colors[i] == cube2.Colors[i])
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}

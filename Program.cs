using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iks_Oks_sa_koordinatama
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            string k1 = "* | * | *\n";
            string l = "__________\n\n";
            string k2 = "* | * | *\n";
            string k3 = "* | * | *\n";
            StringBuilder strk1 = new StringBuilder(k1);
            StringBuilder strk2 = new StringBuilder(k2);
            StringBuilder strk3 = new StringBuilder(k3);
            char player;
            char potez1 = '?';
            char potez2 = '?';
            char potez = '?';
            int br = 0;
            int resenje = 0;

            //ISPIS TABLE-------------------------------------------------------------
            //Console.WriteLine(k1 + l + k2 + l + k3 ); ----KORISTI SE TOKOM CELE PARTIJE
            //ISPIS TABLE-------------------------------------------------------------



            #region KO IGRA PRVI?
            Console.Write("Ako zelite da igrate prvi upisitet 0, u suprotnom upisite 1: ");
            do
            {
                player = Convert.ToChar(Console.ReadLine());
                if (player != '0' && player != '1')
                {
                    Console.Write("Neispravan unos, probajte ponovo: ");
                }
            }
            while (player != '0' && player != '1');
            Console.Clear();


            if (player == '0')
                Console.WriteLine("Vi igrate prvi!");

            else if (player == '1')
            {
                Console.WriteLine("Racunar je odigrao prvi!");
            }
            #endregion

            #region  PRVI POTEZ RACUNARA
            if (player == '1')
            {
                 potez1 = (char)random.Next('0', '3');
                 potez2 = (char)random.Next('0', '3');

                 #region odredjivanje koordinata
                 if (potez1 == '0' && potez2 == '0')
                 {
                     potez = '1';
                 }

                 else if (potez1 == '0' && potez2 == '1')
                 {
                     potez = '2';
                 }

                 else if (potez1 == '0' && potez2 == '2')
                 {
                     potez = '3';
                 }

                 else if (potez1 == '1' && potez2 == '0')
                 {
                     potez = '4';
                 }

                 else if (potez1 == '1' && potez2 == '1')
                 {
                     potez = '5';
                 }

                 else if (potez1 == '1' && potez2 == '2')
                 {
                     potez = '6';
                 }

                 else if (potez1 == '2' && potez2 == '0')
                 {
                     potez = '7';
                 }

                 else if (potez1 == '2' && potez2 == '1')
                 {
                     potez = '8';
                 }

                 else if (potez1 == '2' && potez2 == '2')
                 {
                     potez = '0';
                 }
                 #endregion

                #region switch odabir poteza X
                switch (potez)
                {
                    case '1':
                        {
                            strk1[0] = 'X';
                            break;
                        }

                    case '2':
                        {
                            strk1[4] = 'X';
                            break;
                        }

                    case '3':
                        {
                            strk1[8] = 'X';
                            break;
                        }

                    case '4':
                        {
                            strk2[0] = 'X';
                            break;
                        }

                    case '5':
                        {
                            strk2[4] = 'X';
                            break;
                        }

                    case '6':
                        {
                            strk2[8] = 'X';
                            break;
                        }

                    case '7':
                        {
                            strk3[0] = 'X';
                            break;
                        }

                    case '8':
                        {
                            strk3[4] = 'X';
                            break;
                        }

                    case '0':
                        {
                            strk3[8] = 'X';
                            break;
                        }
                }
                #endregion
                Console.WriteLine(strk1 + l + strk2 + l + strk3);
                br += 2;
            }
            #endregion




            do
            {
                #region MOJ POTEZ
                if (br % 2 == 0)
                {
                    if (br == 0)
                    {
                        Console.WriteLine(k1 + l + k2 + l + k3);

                    }

                    do
                    {
                        Console.Write("Vasa koordinata X: ");
                        potez1 = char.Parse(Console.ReadLine());

                        Console.Write("Vasa koordinata Y: ");
                        potez2 = char.Parse(Console.ReadLine());
                        
                    } while (potez1 < '0' && potez1 > '3' && potez2 < '0' && potez2 > '3');
                   

                    #region odredjivanje koordinata
                    if (potez1 == '0' && potez2 == '0')
                    {
                        potez = '1';
                    }

                    else if (potez1 == '0' && potez2 == '1')
                    {
                        potez = '2';
                    }

                    else if (potez1 == '0' && potez2 == '2')
                    {
                        potez = '3';
                    }

                    else if (potez1 == '1' && potez2 == '0')
                    {
                        potez = '4';
                    }

                    else if (potez1 == '1' && potez2 == '1')
                    {
                        potez = '5';
                    }

                    else if (potez1 == '1' && potez2 == '2')
                    {
                        potez = '6';
                    }

                    else if (potez1 == '2' && potez2 == '0')
                    {
                        potez = '7';
                    }

                    else if (potez1 == '2' && potez2 == '1')
                    {
                        potez = '8';
                    }

                    else if (potez1 == '2' && potez2 == '2')
                    {
                        potez = '0';
                    }
                    #endregion

                    
                    #region switch odabir poteza O
                    switch (potez)
                    {
                        case '1':
                            {
                                if (strk1[0] == '*' && strk1[0] != 'O' && strk1[0] != 'X')
                                {
                                    strk1[0] = 'O';
                                    br++;
                                }
                                break;
                            }

                        case '2':
                            {
                                if (strk1[4] == '*' && strk1[4] != 'O' && strk1[4] != 'X')
                                {
                                    strk1[4] = 'O';
                                    br++;
                                }
                                break;
                            }

                        case '3':
                            {
                                if (strk1[8] == '*' && strk1[8] != 'O' && strk1[8] != 'X')
                                {
                                    strk1[8] = 'O';
                                    br++;
                                }
                                break;
                            }

                        case '4':
                            {
                                if (strk2[0] == '*' && strk2[0] != 'O' && strk2[0] != 'X')
                                {
                                    strk2[0] = 'O';
                                    br++;
                                }
                                break;
                            }

                        case '5':
                            {
                                if (strk2[4] == '*' && strk2[4] != 'O' && strk2[4] != 'X')
                                {
                                    strk2[4] = 'O';
                                    br++;
                                }
                                break;
                            }

                        case '6':
                            {
                                if (strk2[8] == '*' && strk2[8] != 'O' && strk2[8] != 'X')
                                {
                                    strk2[8] = 'O';
                                    br++;
                                }
                                break;
                            }

                        case '7':
                            {
                                if (strk3[0] == '*' && strk3[0] != 'O' && strk3[0] != 'X')
                                {
                                    strk3[0] = 'O';
                                    br++;
                                }
                                break;
                            }

                        case '8':
                            {
                                if (strk3[4] == '*' && strk3[4] != 'O' && strk3[4] != 'X')
                                {
                                    strk3[4] = 'O';
                                    br++;
                                }
                                break;
                            }

                        case '0':
                            {
                                if (strk3[8] == '*' && strk3[8] != 'O' && strk3[8] != 'X')
                                {
                                    strk3[8] = 'O';
                                    br++;
                                }
                                break;
                            }

                        default:
                            Console.WriteLine("GRESKA U SWITCHU!!!");
                            break;
                    }
                    #endregion
                    Console.Clear();
                    Console.WriteLine(strk1 + l + strk2 + l + strk3);

                }

                else if (potez < '0' && potez > '2')
                    Console.WriteLine("Pogresan unos, pokusaj ponovo:");




                #endregion

                #region MOJA PROVERA

                if (strk1[0] == 'O' && strk1[4] == 'O' && strk1[8] == 'O')
                {

                    Console.Clear();
                    Console.WriteLine("Cestitamo, pobedio si!");
                    Console.WriteLine(strk1 + l + strk2 + l + strk3);
                    br = 13;
                }

                else if (strk2[0] == 'O' && strk2[4] == 'O' && strk2[8] == 'O')
                {
                    Console.Clear();
                    Console.WriteLine("Cestitamo, pobedio si!");
                    Console.WriteLine(strk1 + l + strk2 + l + strk3);
                    br = 13;
                }

                else if (strk3[0] == 'O' && strk3[4] == 'O' && strk3[8] == 'O')
                {
                    Console.Clear();
                    Console.WriteLine("Cestitamo, pobedio si!");
                    Console.WriteLine(strk1 + l + strk2 + l + strk3);
                    br = 13;
                }

                else if (strk1[0] == 'O' && strk2[0] == 'O' && strk3[0] == 'O')
                {
                    Console.Clear();
                    Console.WriteLine("Cestitamo, pobedio si!");
                    Console.WriteLine(strk1 + l + strk2 + l + strk3);
                    br = 13;
                }

                else if (strk1[4] == 'O' && strk2[4] == 'O' && strk3[4] == 'O')
                {
                    Console.Clear();
                    Console.WriteLine("Cestitamo, pobedio si!");
                    Console.WriteLine(strk1 + l + strk2 + l + strk3);
                    br = 13;
                }

                else if (strk1[8] == 'O' && strk2[8] == 'O' && strk3[8] == 'O')
                {
                    Console.Clear();
                    Console.WriteLine("Cestitamo, pobedio si!");
                    Console.WriteLine(strk1 + l + strk2 + l + strk3);
                    br = 13;
                }

                else if (strk1[0] == 'O' && strk2[4] == 'O' && strk3[8] == 'O')
                {
                    Console.Clear();
                    Console.WriteLine("Cestitamo, pobedio si!");
                    Console.WriteLine(strk1 + l + strk2 + l + strk3);
                    br = 13;
                }

                else if (strk1[8] == 'O' && strk2[4] == 'O' && strk3[0] == 'O')
                {
                    Console.Clear();
                    Console.WriteLine("Cestitamo, pobedio si!");
                    Console.WriteLine(strk1 + l + strk2 + l + strk3);
                    br = 13;
                }
                #endregion

                #region POTEZ RACUNARA I PROVERA
                if (br % 2 == 1)
                {
                    potez1 = (char)random.Next('0', '3');
                    potez2 = (char)random.Next('0', '3');               

                    #region odredjivanje koordinata
                    if (potez1 == '0' && potez2 == '0')
                    {
                        potez = '1';
                    }

                    else if (potez1 == '0' && potez2 == '1')
                    {
                        potez = '2';
                    }

                    else if (potez1 == '0' && potez2 == '2')
                    {
                        potez = '3';
                    }

                    else if (potez1 == '1' && potez2 == '0')
                    {
                        potez = '4';
                    }

                    else if (potez1 == '1' && potez2 == '1')
                    {
                        potez = '5';
                    }

                    else if (potez1 == '1' && potez2 == '2')
                    {
                        potez = '6';
                    }

                    else if (potez1 == '2' && potez2 == '0')
                    {
                        potez = '7';
                    }

                    else if (potez1 == '2' && potez2 == '1')
                    {
                        potez = '8';
                    }

                    else if (potez1 == '2' && potez2 == '2')
                    {
                        potez = '0';
                    }
                    #endregion



                    #region RACUNAR JE POBEDIO
                    if (strk1[0] == 'X' && strk1[4] == 'X' || strk1[0] == 'X' && strk1[8] == 'X' || strk1[4] == 'X' && strk1[8] == 'X' && br != 12)
                    {
                        if (strk1[0] != 'O' && strk1[4] != 'O' && strk1[8] != 'O')
                        {
                            strk1[0] = 'X';
                            strk1[4] = 'X';
                            strk1[8] = 'X';
                            Console.Clear();
                            Console.WriteLine("Racunar je pobedio!");
                            Console.WriteLine(strk1 + l + strk2 + l + strk3);
                            br = 12;
                            resenje = 2;

                        }

                    }

                    if (strk2[0] == 'X' && strk2[4] == 'X' || strk2[0] == 'X' && strk2[8] == 'X' || strk2[4] == 'X' && strk2[8] == 'X' && br != 12)
                    {
                        if (strk2[0] != 'O' && strk2[4] != 'O' && strk2[8] != 'O')
                        {
                            strk2[0] = 'X';
                            strk2[4] = 'X';
                            strk2[8] = 'X';
                            Console.Clear();
                            Console.WriteLine("Racunar je pobedio!");
                            Console.WriteLine(strk1 + l + strk2 + l + strk3);
                            br = 12;
                            resenje = 2;
                        }
                    }

                    if (strk3[0] == 'X' && strk3[4] == 'X' || strk3[0] == 'X' && strk3[8] == 'X' || strk3[4] == 'X' && strk3[8] == 'X' && br != 12)
                    {
                        if (strk3[0] != 'O' && strk3[4] != 'O' && strk3[8] != 'O')
                        {
                            strk3[0] = 'X';
                            strk3[4] = 'X';
                            strk3[8] = 'X';
                            Console.Clear();
                            Console.WriteLine("Racunar je pobedio!");
                            Console.WriteLine(strk1 + l + strk2 + l + strk3);
                            br = 12;
                            resenje = 2;
                        }
                    }

                    if (strk1[0] == 'X' && strk2[0] == 'X' || strk1[0] == 'X' && strk3[0] == 'X' || strk2[0] == 'X' && strk3[0] == 'X' && br != 12)
                    {

                        if (strk1[0] != 'O' && strk2[0] != 'O' && strk3[0] != 'O')
                        {
                            strk1[0] = 'X';
                            strk2[0] = 'X';
                            strk3[0] = 'X';
                            Console.Clear();
                            Console.WriteLine("Racunar je pobedio!");
                            Console.WriteLine(strk1 + l + strk2 + l + strk3);
                            br = 12;
                            resenje = 2;
                        }
                    }

                    if (strk1[4] == 'X' && strk2[4] == 'X' || strk1[4] == 'X' && strk3[4] == 'X' || strk2[4] == 'X' && strk3[4] == 'X' && br != 12)
                    {

                        if (strk1[4] != 'O' && strk2[4] != 'O' && strk3[4] != 'O')
                        {
                            strk1[4] = 'X';
                            strk2[4] = 'X';
                            strk3[4] = 'X';
                            Console.Clear();
                            Console.WriteLine("Racunar je pobedio!");
                            Console.WriteLine(strk1 + l + strk2 + l + strk3);
                            br = 12;
                            resenje = 2;
                        }
                    }

                    if (strk1[8] == 'X' && strk2[8] == 'X' || strk1[8] == 'X' && strk3[8] == 'X' || strk2[8] == 'X' && strk3[8] == 'X' && br != 12)
                    {
                        if (strk1[8] != 'O' && strk2[8] != 'O' && strk3[8] != 'O')
                        {
                            strk1[8] = 'X';
                            strk2[8] = 'X';
                            strk3[8] = 'X';
                            Console.Clear();
                            Console.WriteLine("Racunar je pobedio!");
                            Console.WriteLine(strk1 + l + strk2 + l + strk3);
                            br = 12;
                            resenje = 2;
                        }
                    }

                    if (strk1[0] == 'X' && strk2[4] == 'X' || strk1[0] == 'X' && strk3[8] == 'X' || strk2[4] == 'X' && strk3[8] == 'X' && br != 12)
                    {
                        if (strk1[0] != 'O' && strk2[4] != 'O' && strk3[8] != 'O')
                        {
                            strk1[0] = 'X';
                            strk2[4] = 'X';
                            strk3[8] = 'X';
                            Console.Clear();
                            Console.WriteLine("Racunar je pobedio!");
                            Console.WriteLine(strk1 + l + strk2 + l + strk3);
                            br = 12;
                            resenje = 2;
                        }
                    }

                    if (strk1[8] == 'X' && strk2[4] == 'X' || strk1[8] == 'X' && strk3[0] == 'X' || strk2[4] == 'X' && strk3[0] == 'X' && br != 12)
                    {
                        if (strk1[8] != 'O' && strk2[4] != 'O' && strk3[0] != 'O')
                        {
                            strk1[8] = 'X';
                            strk2[4] = 'X';
                            strk3[0] = 'X';
                            Console.Clear();
                            Console.WriteLine("Racunar je pobedio!");
                            Console.WriteLine(strk1 + l + strk2 + l + strk3);
                            br = 12;
                            resenje = 2;
                        }
                    }
                    #endregion




                    #region Blok
                    if (br != 12)
                    {
                        if (strk1[0] == 'O' && strk1[4] == 'O' || strk1[0] == 'O' && strk1[8] == 'O' || strk1[4] == 'O' && strk1[8] == 'O')
                        {
                            if (strk1[0] != 'O' && strk1[0] != 'X' && resenje != 1)
                            {
                                strk1[0] = 'X';
                                resenje = 1;
                                br++;

                            }

                            else if (strk1[4] != 'O' && strk1[4] != 'X' && resenje != 1)
                            {
                                strk1[4] = 'X';
                                resenje = 11;
                                br++;


                            }

                            else if (strk1[8] != 'O' && strk1[8] != 'X' && resenje != 1)
                            {
                                strk1[8] = 'X';
                                resenje = 1;
                                br++;


                            }
                        }

                        if (strk2[0] == 'O' && strk2[4] == 'O' || strk2[0] == 'O' && strk2[8] == 'O' || strk2[4] == 'O' && strk2[8] == 'O')
                        {
                            if (strk2[0] != 'O' && strk2[0] != 'X' && resenje != 1)
                            {
                                strk2[0] = 'X';
                                resenje = 1;
                                br++;

                            }

                            else if (strk2[4] != 'O' && strk2[4] != 'X' && resenje != 1)
                            {
                                strk2[4] = 'X';
                                resenje = 1;
                                br++;

                            }

                            else if (strk2[8] != 'O' && strk2[8] != 'X' && resenje != 1)
                            {
                                strk2[8] = 'X';
                                resenje = 1;
                                br++;

                            }
                        }

                        if (strk3[0] == 'O' && strk3[4] == 'O' || strk3[0] == 'O' && strk3[8] == 'O' || strk3[4] == 'O' && strk3[8] == 'O')
                        {
                            if (strk3[0] != 'O' && strk3[0] != 'X' && resenje != 1)
                            {
                                strk3[0] = 'X';
                                resenje = 1;
                                br++;

                            }

                            else if (strk3[4] != 'O' && strk3[4] != 'X' && resenje != 1)
                            {
                                strk3[4] = 'X';
                                resenje = 1;
                                br++;

                            }

                            else if (strk3[8] != 'O' && strk3[8] != 'X' && resenje != 1)
                            {
                                strk3[8] = 'X';
                                resenje = 1;
                                br++;

                            }
                        }







                        if (strk1[0] == 'O' && strk2[0] == 'O' || strk1[0] == 'O' && strk3[0] == 'O' || strk2[0] == 'O' && strk3[0] == 'O')
                        {
                            if (strk1[0] != 'O' && strk1[0] != 'X' && resenje != 1)
                            {
                                strk1[0] = 'X';
                                resenje = 1;
                                br++;

                            }

                            else if (strk2[0] != 'O' && strk2[0] != 'X' && resenje != 1)
                            {
                                strk2[0] = 'X';
                                resenje = 1;
                                br++;

                            }

                            else if (strk3[0] != 'O' && strk3[0] != 'X' && resenje != 1)
                            {
                                strk3[0] = 'X';
                                resenje = 1;
                                br++;

                            }
                        }

                        if (strk1[4] == 'O' && strk2[4] == 'O' || strk1[4] == 'O' && strk3[4] == 'O' || strk2[4] == 'O' && strk3[4] == 'O')
                        {
                            if (strk1[4] != 'O' && strk1[4] != 'X' && resenje != 1)
                            {
                                strk1[4] = 'X';
                                resenje = 1;
                                br++;

                            }

                            else if (strk2[4] != 'O' && strk2[4] != 'X' && resenje != 1)
                            {
                                strk2[4] = 'X';
                                resenje = 1;
                                br++;

                            }

                            else if (strk3[4] != 'O' && strk3[4] != 'X' && resenje != 1)
                            {
                                strk3[4] = 'X';
                                resenje = 1;
                                br++;

                            }
                        }

                        if (strk1[8] == 'O' && strk2[8] == 'O' || strk1[8] == 'O' && strk3[8] == 'O' || strk2[8] == 'O' && strk3[8] == 'O')
                        {
                            if (strk1[8] != 'O' && strk1[8] != 'X' && resenje != 1)
                            {
                                strk1[8] = 'X';
                                resenje = 1;
                                br++;

                            }

                            else if (strk1[2] != 'O' && strk2[8] != 'X' && resenje != 1)
                            {
                                strk2[8] = 'X';
                                resenje = 1;
                                br++;

                            }

                            else if (strk3[8] != 'O' && strk3[8] != 'X' && resenje != 1)
                            {
                                strk1[8] = 'X';
                                resenje = 1;
                                br++;

                            }
                        }




                        if (strk1[0] == 'O' && strk2[4] == 'O' || strk1[0] == 'O' && strk3[8] == 'O' || strk2[4] == 'O' && strk3[8] == 'O')
                        {
                            if (strk1[0] != 'O' && strk1[0] != 'X' && resenje != 1)
                            {
                                strk1[0] = 'X';
                                resenje = 1;
                                br++;

                            }

                            else if (strk2[4] != 'O' && strk2[4] != 'X' && resenje != 1)
                            {
                                strk2[4] = 'X';
                                resenje = 1;
                                br++;

                            }

                            else if (strk3[8] != 'O' && strk3[8] != 'X' && resenje != 1)
                            {
                                strk3[8] = 'X';
                                resenje = 1;
                                br++;

                            }
                        }

                        if (strk1[8] == 'O' && strk2[4] == 'O' || strk1[8] == 'O' && strk3[0] == 'O' || strk2[4] == 'O' && strk3[0] == 'O')
                        {
                            if (strk1[8] != 'O' && strk1[8] != 'X' && resenje != 1)
                            {
                                strk1[8] = 'X';
                                resenje = 1;
                                br++;

                            }

                            else if (strk2[4] != 'O' && strk2[4] != 'X' && resenje != 1)
                            {
                                strk2[4] = 'X';
                                resenje = 1;
                                br++;

                            }

                            else if (strk3[0] != 'O' && strk3[0] != 'X' && resenje != 1)
                            {
                                strk3[0] = 'X';
                                resenje = 1;
                                br++;

                            }
                        }
                    }

                    #endregion

                    if (resenje == 1 && br < 11)
                    {

                        Console.Clear();
                        Console.WriteLine(strk1 + l + strk2 + l + strk3);
                    }

                    if (resenje == 0 && br < 11)
                    {

                        #region switch odabir poteza X
                        switch (potez)
                        {
                            case '1':
                                {
                                    Console.WriteLine("Usao 1");
                                    if (strk1[0] == '*' && strk1[0] != 'X' && strk1[0] != 'O')
                                    {
                                        strk1[0] = 'X';
                                        br++;
                                    }
                                    break;

                                }

                            case '2':
                                {
                                    Console.WriteLine("Usao 2");
                                    if (strk1[4] == '*' && strk1[4] != 'X' && strk1[4] != 'O')
                                    {
                                        strk1[4] = 'X';
                                        br++;
                                    }
                                    break;

                                }

                            case '3':
                                {
                                    Console.WriteLine("Usao 3");
                                    if (strk1[8] == '*' && strk1[8] != 'X' && strk1[8] != 'O')
                                    {
                                        strk1[8] = 'X';
                                        br++;
                                    }
                                    break;

                                }

                            case '4':
                                {
                                    Console.WriteLine("Usao 4");
                                    if (strk2[0] == '*' && strk2[0] != 'X' && strk2[0] != 'O')
                                    {
                                        strk2[0] = 'X';
                                        br++;
                                    }
                                    break;

                                }

                            case '5':
                                {
                                    Console.WriteLine("Usao 5");
                                    if (strk2[4] == '*' && strk2[4] != 'X' && strk2[4] != 'O')
                                    {
                                        strk2[4] = 'X';
                                        br++;
                                    }
                                    break;

                                }

                            case '6':
                                {
                                    Console.WriteLine("Usao 6");
                                    if (strk2[8] == '*' && strk2[8] != 'X' && strk2[8] != 'O')
                                    {
                                        strk2[8] = 'X';
                                        br++;
                                    }
                                    break;

                                }

                            case '7':
                                {
                                    Console.WriteLine("Usao 7");
                                    if (strk3[0] == '*' && strk3[0] != 'X' && strk3[0] != 'O')
                                    {
                                        strk3[0] = 'X';
                                        br++;
                                    }
                                    break;
                                }

                            case '8':
                                {
                                    if (strk3[4] == '*' && strk3[4] != 'X' && strk3[4] != 'O')
                                    {
                                        Console.WriteLine("Usao 8");
                                        strk3[4] = 'X';
                                        br++;
                                    }
                                    break;
                                }

                            case '0':
                                {
                                    Console.WriteLine("Usao 9");
                                    if (strk3[8] == '*' && strk3[8] != 'X' && strk3[8] != 'O')
                                    {
                                        strk3[8] = 'X';
                                        br++;
                                    }
                                    break;
                                }

                        }
                        #endregion
                        Console.Clear();
                        Console.WriteLine(strk1 + l + strk2 + l + strk3);
                    }
                    resenje = 0;




                }
                #endregion

                #region NERESENO - NE GLEDAJ DO SAMOG KRAJA
                if (br == 9 && player == '0')
                {
                    Console.WriteLine("Nereseno!");
                    br++;
                }

                if (br == 10 && player == '1')
                    Console.WriteLine("Nereseno!");

                #endregion
            }
            while (br < 10);




            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace AK1PA_exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Obvod a obsah obdelniku
            //Console.WriteLine("Please enter side A of the rectangle: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter side B of the rectangle: ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("The area of this rectangle is: " + a * b + " .");
            //int v = 2 * a + 2 * b;
            //Console.WriteLine("The circumference of this rectangle is: " + v + " .");
            //Console.ReadKey();

            //Obvod a obsah ctverce
            //Console.WriteLine("Please enter side of a square: ");
            //int c = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("This square has area of " + c * c + " and circumference of " + 4 * c + " .");
            //Console.ReadKey();

            //Obvod a obsah kruhu.
            //Console.WriteLine("Please enter radius of a circle: ");
            //int r = Convert.ToInt32(Console.ReadLine());
            //double circleCircumference = Math.PI * 2 * r;
            //double circleArea = Math.PI * r * r;     
            //Console.WriteLine("This circle has area of " + circleArea + " and circumference of " + circleCircumference + " .");
            //Console.ReadKey();

            //Vypocet obvodu a obsahu trojuhelniku
            //Console.WriteLine("Please enter 3 sides of a triangle: ");
            //double a = Convert.ToDouble(Console.ReadLine());
            //double b = Convert.ToDouble(Console.ReadLine());
            //double c = Convert.ToDouble(Console.ReadLine());
            //double triCircum = a + b + c;
            //double halfCircum = triCircum / 2;
            //double triArea = Math.Sqrt(halfCircum * (halfCircum - a) * (halfCircum - b) * (halfCircum - c));
            //Console.WriteLine("Circumference of this triangle is " + triCircum + " and it´s area is " + triArea + " .");
            //Console.ReadKey();

            //Vypocet BMI
            //Console.WriteLine("Please enter you height in metres: ");
            //double height = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("And you weight in kilograms: ");
            //double weight = Convert.ToDouble(Console.ReadLine());
            //double bmi = Math.Round( weight / (height * height), 1);
            //Console.WriteLine("Your BMI index is " + bmi + " .");
            //Console.ReadKey();

            //Splatka hypoteky
            //decimal uver;
            //decimal urokSazba;
            //decimal v;
            //decimal splatka;
            //int pocetSplatek;
            //Console.WriteLine("Please insert loan amount: ");
            //uver = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("Please insert your interest rate in percents: ");
            //urokSazba = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("Please insert your payment term: ");
            //pocetSplatek = Convert.ToInt32(Console.ReadLine());
            //v = 1 / (1 + (urokSazba / 100 / 12));
            //decimal tmp = v;
            //for (int i = 1; i < pocetSplatek * 12; i++)
            //{
            //    tmp = tmp * v;
            //}
            //splatka = Math.Round((urokSazba / 100 / 12 * uver) / (1 - tmp), 0);
            //Console.WriteLine("Your expected monthly payment of this loan is " + splatka + " czech crowns.");
            //Console.ReadKey();

            //Vyroky o trojhuelniku
            //double a = 3;
            //double b = 4;
            //double c = 5;
            //bool result;
            //result = a * a + b * b == c * c;
            //if (result)
            //{
            //    Console.WriteLine("This triangle is right triangle.");
            //}
            //else
            //{
            //    Console.WriteLine("This triangle is not right triangle.");
            //}
            //bool exists;
            //exists = (a + b > c) && (b + c > a) && (c + a > b);
            //if (result)
            //{
            //    Console.WriteLine("... and it is indeed a triangle.");
            //}
            //else
            //{
            //    Console.WriteLine("... but in fact it is not a triangle.");
            //}
            //Console.ReadKey();

            //Porovnani vysledku testu
            //int test1 = 16;
            //int test2 = 2;
            //int test3 = 10;
            //bool greaterThan = (test1 > 15) || (test2 > 15) || (test3 > 15);
            //if (greaterThan)
            //{
            //    Console.WriteLine("At least one result is greater than 15.");
            //}
            //else
            //{
            //    Console.WriteLine("No result is greater than 15.");
            //}
            //bool allGreaterThan = (test1 > 15) && (test2 > 15) && (test3 > 15);
            //if (allGreaterThan)
            //{
            //    Console.WriteLine("All results are greater than 15.");
            //}
            //else
            //{
            //    Console.WriteLine("Not all results are greater than 15.");
            //}
            //bool atLeastTwoGreaterThan = (test1 > 15) && (test2 > 15) || (test1 > 15) && (test3 > 15) || (test2 > 15) && (test3 > 15);
            //if (atLeastTwoGreaterThan)
            //{
            //    Console.WriteLine("At least two results are greater than 15.");
            //}
            //else
            //{
            //    Console.WriteLine("Less than two results are greater than 15.");
            //}
            //Console.ReadKey();

            //Porovnani dvou cisel a testy na lichost a sudost
            //Console.WriteLine("Insert first number:");
            //double first = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Insert second number.");
            //double second = Convert.ToDouble(Console.ReadLine());
            //if (first > second)
            //{
            //    Console.WriteLine("First number is greater.");
            //}
            //else if(second > first)
            //{
            //    Console.WriteLine("Second number is greater.");
            //} 
            //else
            //{
            //    Console.WriteLine("Numbers are equal.");
            //}
            //if (first % 5 == 0)
            //{
            //    Console.WriteLine("First number can be divided by 5 without remainder.");
            //} 
            //else
            //{
            //    Console.WriteLine("First number cannot be divided by 5 without remainder.");
            //}
            //if (first % 2 == 0)
            //{
            //    Console.WriteLine("First number is even.");
            //}
            //else if (first % 2 == 1)
            //{
            //    Console.WriteLine("First number is odd.");
            //} 
            //else
            //{
            //    Console.WriteLine("Not even, not odd.");
            //}
            //Console.ReadKey();

            //Koreny kv rovnice

            //Console.WriteLine("Please insert quadratic equation coefficients: Ax2 + Bx + C");
            //double A = Convert.ToDouble(Console.ReadLine());
            //double B = Convert.ToDouble(Console.ReadLine());
            //double C = Convert.ToDouble(Console.ReadLine());
            //double D = B * B - 4 * A * C;
            //if (D == 0)
            //{
            //    double x1 = -B / (2 * A);
            //    double x2 = x1;
            //    Console.WriteLine("The only solution is " + x1 + " .");
            //}
            //else if (D > 0)
            //{
            //    double x1 = (- B + Math.Sqrt(D)) / (2 * A);
            //    double x2 = (- B - Math.Sqrt(D)) / (2 * A);
            //    Console.WriteLine("Solution x1 is " + x1 + " and x2 is " + x2 + " .");
            //} else
            //{
            //    Console.WriteLine("This equation does not have solution from Real number set");
            //}
            //Console.ReadKey();

            //Maximum a minimum ze tří čísel
            //double a = 2;
            //double b = 6;
            //double c = 3;
            //double max = Math.Max(a, Math.Max(b, c));
            //double min = Math.Min(a, Math.Min(b, c));
            //Console.WriteLine("Maximum is " + max + " and minimum is " + min + " .");
            //Console.ReadKey();

            //Dva nejlepsi testy
            //int test1 = 22;
            //int test2 = 20;
            //int test3 = 21;
            //if (test1 > test2)
            //{
            //    if (test2 > test3)
            //    {
            //        Console.WriteLine("Best performers are test 1 and test 2.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Best performers are test 1 and test 3.");
            //    }
            //} 
            //else if (test2 > test3)
            //{
            //    if (test3 > test1)
            //    {
            //        Console.WriteLine("Best performers are test 2 and test 3.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Best performers are test 2 and test 1.");
            //    }
            //}
            //Console.ReadKey();

            //všechna licha od 10 do 100
            //for (int i = 10; i <= 100; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadKey();

            //všechna suda od 10 do 100
            //for (int i = 10; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }  
            //}
            //Console.ReadKey();

            //všechna delitelna 5 nebo 3 od 10 do 100
            //for (int i = 10; i <= 100; i++)
            //{
            //    if (i % 5 == 0 || i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadKey();

            // Tri pokusy na stisk Enteru.
            //ConsoleKey key;
            //int pocetStisknuti = 3;
            //int pocet = 0;
            //for (int i = 0; i < pocetStisknuti && Console.ReadKey(true).Key != ConsoleKey.Enter; i++)
            //{
            //    key = Console.ReadKey(true).Key;
            //    Console.WriteLine($"Nestiskl jsi Enter, ale {key}. Pokus cislo {i}");
            //    pocet++;
            //}
            //if (pocet < 3)
            //{
            //    Console.WriteLine("Stiskl jsi Enter.");
            //}
            //else
            //{
            //    Console.WriteLine("Nepodarilo se ti stisknout Enter.");
            //}
            //Console.ReadKey();

            //Vypocet faktorialu
            //int cislo = 9;
            //int faktorial = cislo;
            //if (cislo == 0)
            //{
            //    Console.WriteLine("1");
            //}
            //else
            //{
            //    while (cislo > 1)
            //    {
            //        faktorial = faktorial * (cislo - 1);
            //        cislo--;
            //    }
            //    Console.WriteLine(faktorial);
            //}
            //Console.ReadKey();

            //Vypocet mocniny
            //int baseNumber = 3;
            //int power = 4;
            //int result = baseNumber;
            //while (power > 1)
            //{
            //    result = result * baseNumber;
            //    power--;
            //}
            //Console.WriteLine(result);
            //Console.ReadKey();

            // Splatka hypoteky - rozsirena
            //decimal uver;
            //decimal urokSazba;
            //decimal v;
            //decimal splatka;
            //int pocetSplatek;
            //Console.WriteLine("Please insert loan amount: ");
            //uver = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("Please insert your interest rate in percents: ");
            //urokSazba = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("Please insert your payment term: ");
            //pocetSplatek = Convert.ToInt32(Console.ReadLine());
            //v = 1 / (1 + (urokSazba / 100 / 12));
            //decimal tmp = v;
            //for (int i = 1; i < pocetSplatek * 12; i++)
            //{
            //    tmp = tmp * v;
            //}
            //splatka = Math.Round((urokSazba / 100 / 12 * uver) / (1 - tmp), 0);
            //Console.WriteLine("Your expected monthly payment of this loan is " + splatka + " czech crowns.");
            //decimal dluh = uver;
            //for (int i = 0; i < (pocetSplatek * 12); i++)
            //{
            //    decimal urok = Math.Round(dluh * (urokSazba / 100 / 12), 0);
            //    decimal umor = Math.Round(splatka - urok, 0);
            //    dluh = dluh - umor;
            //    Console.WriteLine("Mesic: " + i + " | Splatka: " + splatka + " | Urok: " + urok + " | Umor: " + umor + " | Stav dluhu: " + dluh);
            //}
            //Console.ReadKey();

            //Nejmensi, Suma a prumer z pole. porovani dvou poli, reverse a porovnani sum
            //int[] array = { 1, 15, 21, 22, 24, 3, 7, 8 };
            //int smallest = array.Min();
            //int sumOfArray = array.Sum();
            //double average = array.Average();
            //int oddCount = 0;
            //int evenCount = 0;
            //foreach (int number in array)
            //{
            //    if (number % 2 == 0)
            //    {
            //        evenCount++;
            //    }
            //    else if (number % 2 == 1)
            //    {
            //        oddCount++;
            //    }
            //}
            //Console.WriteLine("Minimum from the array is " + smallest);
            //Console.WriteLine("Sum of all numbers in the array is " + sumOfArray);
            //Console.WriteLine("Average of all numbers in the array is " + average);
            //Console.WriteLine("These is " + evenCount + " even numbers and " + oddCount + " odd numbers.");
            //Array.Reverse(array, 0, array.Length);
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write($"{array[i]}, ");
            //}
            //Console.WriteLine("");
            //int[] array2 = { 8, 7, 3, 24, 22, 21, 15, 2 };
            //bool areEqual = true;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array.Length != array2.Length)
            //    {
            //        Console.WriteLine("Arrays do not have equal lengths");
            //        areEqual = false;
            //        break;
            //    }
            //    else if (array[i] != array2[i])
            //    {
            //        areEqual = false;
            //    }
            //}
            //if (areEqual)
            //{
            //    Console.WriteLine("Arrays are equal.");
            //}
            //else
            //{
            //    Console.WriteLine("Arrays are not equal.");
            //}
            //if (array.Sum() == array2.Sum())
            //{
            //    Console.WriteLine("Both array have the same sum.");
            //}
            //else
            //{
            //    Console.WriteLine("Arrays have different sums.");
            //}
            //Console.ReadKey();

            //Prvocisla
            //for (int i = 2; i <= 100; i++)
            //{
            //    int counter = 0;
            //    for (int j = 2; j <= i / 2; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            counter++;
            //            break;
            //        }
            //    }
            //    if (counter == 0 && i != 1)
            //    {
            //        Console.Write($"{i} ");
            //    }
            //}
            //Console.ReadKey();

            //Nejcasteji opakovane cislo v poli
            //int[] numberArray = { 1,2,2,3,101,101,101,101,101,1,1,1,1};
            //int count = 0;
            //int tmp = 0;
            //int nejpocetnejsi = 0;
            //for (int i = 0; i < numberArray.Length; i++)
            //{
            //    tmp = 0;
            //    for (int j = 0; j < numberArray.Length; j++)
            //    {
            //        if (numberArray[i] == numberArray[j])
            //        {
            //            tmp++;
            //        }
            //    }
            //    if (tmp > count)
            //    {
            //        count = tmp;
            //        nejpocetnejsi = numberArray[i] ;
            //    }
            //}
            //Console.WriteLine(nejpocetnejsi);
            //Console.ReadKey();

            //Soucet a nasobeni matic 3x3
            //int[,] matice1 = {   { 1, 2, 3 }, 
            //                    { 5, 9, 10 }, 
            //                    { 11, 2, 5 } };
            //int[,] matice2 = {   { 1, 2, 3 },
            //                    { 5, 9, 10 },
            //                    { 11, 2, 5 } };
            //int[,] soucet = new int [3,3];
            //int[,] nasobek = new int[3,3];
            //for (int i = 0; i <= 2; i++)
            //{
            //    for (int j = 0; j <= 2; j++)
            //    {
            //        soucet[i, j] = matice1[i, j] + matice2[i, j];
            //        Console.Write($"{soucet[i, j]}, ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //for (int i = 0; i <= 2; i++)
            //{
            //    for (int j = 0; j <= 2; j++)
            //    {
            //        nasobek[i, j] = matice1[i, 0] * matice2[0, j] + matice1[i, 1] * matice2[1, j] + matice1[i, 2] * matice2[2, j];
            //        Console.Write($"{nasobek[i, j]}, ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();

            //Struktura Bod
            //Point3D point1 = new Point3D(5, 30, 80);
            //double vzdalenost = point1.VzdalenostOdPocatku();
            //Console.WriteLine($"Point X[{point1.x}]");
            //Console.WriteLine(vzdalenost);
            //Console.ReadKey();

            //Struktura komplexni cislo
            //ComplexNumber cislo = new ComplexNumber();
            //cislo.a = 3;
            //cislo.b = 4;
            //Console.WriteLine(cislo.GetMagnitude());
            //Console.ReadKey();

            //Dvou a tri-rozmerny vektor
            //Vector v1 = new Vector(2, 3, 1);
            //Vector v2 = new Vector(5, 9, 5);
            //Vector soucet = new Vector((v1.x + v2.x), (v1.y + v2.y), (v1.z + v2.z));
            //Vector vektSoucin = new Vector(((v1.y * v2.z) - (v1.z * v2.y)), ((v1.z * v2.x) - (v1.x - v2.z)), ((v1.x - v2.y) - (v1.y - v2.x)));
            //int skalSoucin = (v1.x * v2.x + v1.y * v2.y + v1.z * v2.z);
            //Console.WriteLine($"Product of vector addition is : X {soucet.x}, Y {soucet.y}, Z {soucet.z} ");
            //Console.WriteLine($"Product of vector multiplication is : X {vektSoucin.x}, Y {vektSoucin.y}, Z {vektSoucin.z} ");
            //Console.WriteLine($"Product of scalar multiplication is : {skalSoucin}");
            //Console.ReadKey();

            //Pole komplexnich cisel a porovnani velikosti
            //ComplexNumber[] numberArray = new ComplexNumber[5];
            //numberArray[0] = new ComplexNumber(2, 5);
            //numberArray[1] = new ComplexNumber(3, 5);
            //numberArray[2] = new ComplexNumber(10, 1);
            //numberArray[3] = new ComplexNumber(1, 15);
            //numberArray[4] = new ComplexNumber(2, 5);
            //double magnitude = 0;
            //int index = 0;
            //for (int i = 0; i < numberArray.Length; i++)
            //{
            //    double tmp = numberArray[i].GetMagnitude();
            //    if (tmp > magnitude)
            //    {
            //        index = i;
            //        magnitude = tmp;
            //    }
            //}
            //Console.WriteLine($"Complex number {numberArray[(index)].a} + {numberArray[index].b}i has the biggest magnitude.");
            //Console.ReadKey();

            //Struktura Pixel
            //Pixel[] pxl = new Pixel[5];
            //pxl[1].R = 120;
            //pxl[1].G = 250;
            //pxl[1].B = 0;
            //pxl[2].R = 12;
            //pxl[2].G = 200;
            //pxl[2].B = 120;
            //pxl[3].R = 0;
            //pxl[3].G = 0;
            //pxl[3].B = 0;
            //pxl[4].R = 255;
            //pxl[4].G = 150;
            //pxl[4].B = 150;
            //pxl[0].R = 0;
            //pxl[0].G = 190;
            //pxl[0].B = 200;
            //int blackCount = 0;
            //double brightness = 0;
            //int index = 0;
            //for (int i = 0; i < pxl.Length; i++)
            //{
            //    pxl[i].PixelTest(pxl[i].R, pxl[i].G, pxl[i].B);
            //    if (pxl[i].R == 0 && pxl[i].G == 0 && pxl[i].B == 00)
            //    {
            //        blackCount++;
            //    }
            //    double tmp = ((0.21 * pxl[i].R) + (0.72 * pxl[i].G) + (0.07 * pxl[i].B));
            //    if (tmp > brightness)
            //    {
            //        brightness = tmp;
            //        index = i;
            //    }
            //}
            //Console.WriteLine($"Number of black pixels is {blackCount}");
            //Console.WriteLine($"Darkest pixel is #{index} with RGB {pxl[index].R},{pxl[index].G},{pxl[index].B} and brightness {brightness}.");
            //Console.ReadKey();

            //Trida Circle
            //Circle c1 = new Circle(5);
            //Console.WriteLine($"Circle circumference is {c1.CircleCircum()} metres and area of {c1.CircleArea()} square metres.");
            //Circle c2 = new Circle(3);
            //c1.Radius = 3;
            //if (c1.Radius == c2.Radius)
            //{
            //    Console.WriteLine("Circle 1 does have the same radius as Circle 2 ");
            //}
            //else
            //{
            //    Console.WriteLine("Circles 1 and 2 are not the same.");
            //}
            //Console.ReadKey();

            //Trida VypocetHypo
            //Console.WriteLine("Insert loan amount:");
            //decimal vyseUveru = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("Insert yearly interest rate: ");
            //decimal urokSazba = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("Insert payment term length in years: ");
            //int dobaSplaceni = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please insert your monthly net income: ");
            //decimal income = decimal.Parse(Console.ReadLine());
            //Hypoteka hypo1 = new Hypoteka(vyseUveru, urokSazba, dobaSplaceni);
            //decimal splatka = hypo1.VypocetSplatky();
            //int podil = Decimal.Compare(splatka/income, (decimal)0.40);
            //if (podil > 0 || ((vyseUveru / (income * 12)) > 5))
            //{
            //    Console.WriteLine("Your net income is not sufficient!");
            //}
            //else
            //{
            //    Console.WriteLine($"Monthly payment of your loan is {hypo1.VypocetSplatky()} CZK and the total amount to be paid is {hypo1.VypocetSplatky() * hypo1.DobaSplaceni * 12} CZK");
            //}
            //Console.ReadKey();

            //Zavodnici
            //Console.WriteLine("Insert number of contestants: ");
            //int.TryParse(Console.ReadLine(), out int numberOfContestants);
            //Contestant[] contestants = new Contestant[numberOfContestants];
            //for (int i = 0; i < numberOfContestants; i++)
            //{
            //    Console.WriteLine($"Insert first name of contestant #{i+1}:");
            //    string firstName = Console.ReadLine();
            //    Console.WriteLine($"Insert last name of contestant #{i+1}:");
            //    string lastName = Console.ReadLine();
            //    Console.WriteLine($"Insert finishing time of Contestant #{i+1}:");
            //    double finishingTime = double.Parse(Console.ReadLine());
            //    contestants[i] = new Contestant(firstName, lastName, finishingTime);
            //}
            //Contestant fastest = contestants[0];
            //Contestant slowest = contestants[0];
            //double tmp = 0;

            //foreach (Contestant contestant in contestants)
            //{
            //    if (contestant.FinishingTime < fastest.FinishingTime)
            //    {
            //        fastest = contestant;
            //    }

            //    if (contestant.FinishingTime > slowest.FinishingTime)
            //    {
            //        slowest = contestant;
            //    }

            //    tmp = tmp + contestant.FinishingTime;
            //}
            //Console.WriteLine($"Fastest time was {fastest.FinishingTime} minutes");
            //Console.WriteLine($"Slowest time was {slowest.FinishingTime} minutes");
            //Console.WriteLine($"Average time was {tmp/numberOfContestants} minutes");
            //Console.WriteLine($"Winner is {fastest.FirstName} {fastest.LastName}");
            //Console.ReadKey();

            //Airplanes
            //int numberOfPlanes = 3;
            //Airplanes[] airplanes = new Airplanes[numberOfPlanes];
            //bool anotherInsert= true;
            //int j = 0;
            //for (int i = 0; i < numberOfPlanes; i++)
            //{
            //    Console.WriteLine("Please insert airplane name: ");
            //    string name =  Console.ReadLine();
            //    Console.WriteLine("Insert fuel tank volume in m3: ");
            //    double fuelTankVolume = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Insert average speed in m/s: ");
            //    double aSpeed = double.Parse( Console.ReadLine());
            //    Console.WriteLine("Insert maximum speed in m/s: ");
            //    double mSpeed = double.Parse(Console.ReadLine());
            //    airplanes[i] = new Airplanes(name, fuelTankVolume, aSpeed, mSpeed);
            //}
            //Airplanes fastest = airplanes[0];
            //Console.WriteLine("Name | Fuel Tank | Average Speed | Max Speed");
            //foreach (Airplanes plane in airplanes)
            //{
            //    Console.WriteLine($"{plane.Name} | {plane.FuelTankVolume} | {plane.MaxSpeed} | {plane.AverageSpeed}");
            //    if (plane.MaxSpeed > fastest.MaxSpeed)
            //    {
            //        fastest = plane;
            //    }
            //}
            //Console.WriteLine($"Fastest airplane in this catalogue is {fastest.Name} with maximum speed {fastest.MaxSpeed} m/s.");
            //Console.ReadKey();

            //Matice vedl diagonala plnění
            //int n = 70;
            //int[,] matice = new int[n, n];
            //int x = 1;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (j < n-x)
            //        {
            //            matice[i, j] = 1;
            //        } 
            //        else
            //        {
            //            matice[i, j] = 0;
            //        }
            //        Console.Write(matice[i, j]);
            //    }
            //    x++;
            //    Console.WriteLine();
            //}
            //Console.ReadKey();

            //BubbleSort plneni nahodnymi cisly
            //int[] array = new int[500];
            //Random random = new Random();
            //for (int i = 0; i < 500; i++)
            //{
            //    array[i] = random.Next(5000);
            //}
            //Console.WriteLine("Naplneno, stiskni libovolnou klavesu.");
            //Console.ReadKey();
            //BubbleSort(array);
            //foreach (int element in array)
            //{
            //    Console.Write($"{element}, ");
            //}
            //Console.ReadKey();



        }

        public static int[] BubbleSort(int[] array)
        {
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }

        struct Pixel
        {
            public int R, G, B;

            public Pixel(int R, int G, int B)
            {
                this.R = R;
                this.G = G;
                this.B = B;
            }
    
            public void PixelTest (int R, int G, int B)
            {
                    if (R > 255 || R < 0 || G > 255 || G < 0 || B > 255 || B < 0)
                    {
                        throw new ArgumentOutOfRangeException("Range of RGB has to be between 0 and 255.");
                    }
            }
        }


        struct Vector
        {
            public int x, y, z;

            public Vector(int x, int y, int z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
        }

        struct Point3D
        {
            public int x, y, z;

            public Point3D (int x, int y, int z)
            {
                this.x = x; 
                this.y = y; 
                this.z = z;
            }

            public double VzdalenostOdPocatku()
            {
                return Math.Pow((x * x + y * y + z * z), (double) 1/2);
            }
        }

        struct ComplexNumber
        {
            public int a, b;

            public ComplexNumber(int a, int b)
            {
                this.a = a;
                this.b = b;
            }
           
            public double GetMagnitude()
            {
                return Math.Round(Math.Sqrt(b * b + a * a), 3);    
            }
        }


    }
}

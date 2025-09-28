// Se tienen las notas del primer parcial de los alumnos de dos cursos, el curso A y el curso B, cada curso cuenta con 5 alumnos.
// Realizar un programa que muestre el curso que obtuvo el mayor promedio general.

using System;

namespace dos_cursos_array
{
    class dos_cursos_array
    {
        private float[] cursoA;
        private float[] cursoB;
        private float promedioA;
        private float promedioB;
        private float sumaA;
        private float sumaB;

        public void Carga()
        {
            cursoA = new float[5];
            cursoB = new float[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Ingrese la nota {i + 1} del curso A: ");
                cursoA[i] = float.Parse(Console.ReadLine());
                sumaA = sumaA + cursoA[i];
            }

            for (int j = 0; j < 5; j++)
            {
                Console.Write($"Ingrese la nota {j + 1} del curso B: ");
                cursoB[j] = float.Parse(Console.ReadLine());
                sumaB = sumaB + cursoB[j];
            }
        }

        public void Promedio()
        {
            promedioA = sumaA / 5;
            promedioB = sumaB / 5;

        }

        public void Imprimir()
        {
            if (promedioA > promedioB)
            {
                Console.WriteLine($"Con un {promedioA} el Curso A tiene mejor promedio");
            }
            else
            {
                Console.WriteLine($"Con un {promedioB} el Curso B tiene mejor promedio");
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            dos_cursos_array curso = new dos_cursos_array();
            curso.Carga();
            curso.Promedio();
            curso.Imprimir();
        }
    }
}
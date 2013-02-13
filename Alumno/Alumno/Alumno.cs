using System;

namespace Alumno
{
   class Alumno
    {
      public int matricula, edad, semestre;
      public string nombre, carrera;

       public void promocion()
       {
       semestre+=1;
       }
       public void cambiodecarrera()
       {
       Console.Write("A que carrera desea cambiarse?");
           carrera = Console.ReadLine();
       }
        public void cumpleanos()
       {
       edad=+1;
       }
        public void cambiomatricula()
      {
       Console.Write("Cual es la nueva matricula?");
       matricula = int.Parse(Console.ReadLine());
       }

    }
}

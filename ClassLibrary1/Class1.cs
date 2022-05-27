using System;


namespace EDexamenT6a8
{
    ///<summary>
    ///<para>Clase que gestiona las notas para una asignatura</para>
    ///<para>Introducir asignaturas, registrar notas, calcular notas de trimestre y finales.</para>
    ///<para>Se usó la tabluación para ordenar el código y dejarlo de una forma más prolija</para>
    ///</summary>
    ///
    class Asignatura
    {
        ///<summary>
        ///Se encapsularon estos campos porque están publicos. Creo propiedades junto con ellos.
        ///</summary>

        private string CodigodelaAsignatura;
        private string NombredelaAsignatura;
        private double NotadelPrimertrimestre;
        private double NotadelSegungoTrimestre;
        private double NotadelTercerTrimestre;
        private double NotaFinaldelCurso;

        ///<summary>
        /// Se cambió el nombre de las variables que venian precedidas por un this. que no era necesario.
        ///</summary>
        public Asignatura(string CodigodelaAsignatura, string NombredelaAsignatura, double NotadelPrimertrimestre, double NotadelSegungoTrimestre, double NotadelTercerTrimestre, double NotaFinaldelCurso)
        {  
            CodigodelaAsignatura  = CodigodelaAsignatura; 
            NombredelaAsignatura = NombredelaAsignatura; 
            NotadelPrimertrimestre = NotadelPrimertrimestre; 
            NotadelSegungoTrimestre = NotadelSegungoTrimestre;
            NotadelTercerTrimestre = NotadelTercerTrimestre;
            NotaFinaldelCurso = NotaFinaldelCurso;
        }        

        
        public string CodigodelaAsignatura
        {
            get { return CodigodelaAsignatura; }
        }
        public string NombredelaAsignatura
        {
            get { return NombredelaAsignatura; }
        }
        public string NotadelPrimertrimestre
        {
            get { return NotadelPrimertrimestre; }
        }
        public string NotadelSegungoTrimestre
        {
            get { return NotadelSegungoTrimestre; }
        }
        public string NotadelTercerTrimestre
        {
            get { return NotadelTercerTrimestre; }
        }
        public string NotaFinaldelCurso
        {
            get { return NotaFinaldelCurso; }
        }


        ///<summary>
        ///<para>Introduce una asignatura al sistema</para>
        ///<param>Codigo de Asignatura y Nombre de Asignatura</param>
        ///</summary>
        public void IntroducirMateria(string Cod_de_Asignatura, string Nombre_de_Asignatura)
        {
            CodigodelaAsignatura = Cod_de_Asignatura; 
            NombredelaAsignatura = Nombre_de_Asignatura;        
        }

        ///<summary>
        ///<para>Introduce una nota al sistema</para>
        ////<param>Notas correspondientes</param>
        ///<remarks>He usado la Indentación para que los parametros entren todos juntos en una misma linea</remarks>
        ///</summary>
        public void IntroducirlasNotas(double notadelExamen1, double notadelExamen2, double notadelExamen3,
                                       double notadelasPracticas1, double notadelasPracticas2, double notadelasPracticas3)
        {        
            {
                for (int i = 1; i < 4 ; i++)
                {   
                    Console.WriteLine("Trimestre evaluado 1, 2 ó 3: ");
                    var Trimestre = Console.ReadLine();

                    switch (Trimestre)
                    {   
                        case "1": 
                            Console.WriteLine("Nota de las prácticas: ");
                            notadelasPracticas1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Nota del examen: ");
                            notadelExamen1 = Convert.ToDouble(Console.ReadLine());
                            break;

                        case "2": 
                            Console.WriteLine("Nota de las prácticas: ");
                            notadelasPracticas2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Nota del examen: ");
                            notadelExamen2 = Convert.ToDouble(Console.ReadLine());
                            break;

                        case "3": 
                            Console.WriteLine("Nota de las prácticas: ");
                            notadelasPracticas3 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Nota del examen: ");
                            notadelExamen3 = Convert.ToDouble(Console.ReadLine());
                            break;
                    }
                }

            }
        }

         ///<summary>
         ///<para>Se calculan las notas teniendo un 20% de la nota de las prácticas y un 80% la nota del examen</para>
         ///////<param>Notas de los examenes de un trimestre dado y Notas de las practicas del trimestre dado</param>
         ///<returns>devuelve nota de cada trimestre</returns>
         ///<remarks>Tenemos 3 métodos iguales. Lo extraigo y creo un método unico. Le cambie el nombre para que sea más claro.</remarks>
         ///</summary>
        public double CalculoDeNotaTrimestral(double notadelExamen1, double notadelasPracticas1)
        {    
            NotadelPrimertrimestre = (notadelExamen 1 * 0.8) + (notadelasPracticas1) * 0.2;
            return NotadelPrimertrimestre;
        }

        double calculodelaNota2 = calculodelaNota1(double notadelExamen2, double notadelasPracticas2);
        double calculodelaNota3 = calculodelaNota1(double notadelExamen3, double notadelasPracticas3);
  

        ///<summary>
        ///<para>Nota final del curso</para>
        //////<returns>devuelve la nota final</returns>
        ///<remarks>Renombramos el método para que sea más claro lo que hace</remarks>
        ///</summary>
        public double CalculoNotaFinal()
        {   
            NotaFinaldelCurso = (NotadelPrimertrimestre + NotadelSegungoTrimestre + NotadelTercerTrimestre) / 3; 
            return NotaFinaldelCurso;
        }

        ///<summary>
        ///<remarks>He quitado la clase que estaba pendiente de hacer y la he puesto en una clase aparte VER PDF.</remarks>
        ///</summary>

}



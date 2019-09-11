using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDeClases
{
    /// <summary>
    /// Calse Punto: sirve para componer la figura
    /// </summary>
    public class Punto
    {
        private int x;
        private int y;

        public Punto()
        {
            X = 0;
            Y = 0;
        }

        public Punto(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

    }

    /// <summary>
    /// Clase Figura: es abstracta, por lo tanto no se podrá generar instancias de esta clase. 
    /// pero si se podrá heredar de ella. 
    /// Ejemplo: Triangulo ES UNA figura
    ///          Circunferencia ES UNA figura
    /// </summary>
    public abstract class Figura
    {
        /// <summary>
        /// composición con la clase punto 
        /// </summary>
        public Punto Posicion { get; set; }

        /// <summary>
        /// constructuor por defecto, solo crea una instancia de la clase punto
        /// </summary>
        public Figura()
        {
            Posicion = new Punto();    
        }

        /// <summary>
        /// Sobrecarga del constructor, tiene dos parámetros
        /// </summary>
        /// <param name="x">posición de la figura en x </param>
        /// <param name="y">posición de la figura en y </param>
        public Figura(int x, int y):this()
        {
            
            Posicion.X = x;
            Posicion.Y = y;
        }


        /// <summary>
        /// Sobrecarga del constructor, tiene como parámetro una objeto de tipo punto
        /// </summary>
        /// <param name="x">posición de la figura en x </param>
        /// <param name="y">posición de la figura en y </param>
        protected Figura(Punto punto) : this(punto.X,punto.Y)
        {
            //this.Posicion = punto;
        }

        /// <summary>      
        /// El modificador de acceso VIRTUAL permite que el método sea sobre-escrito por las clases que herenden de la clase figura.  
        /// </summary>
        /// <returns>texto indicando que tipo de figura es, si no se sobre-escribe muestra el tipo de la clase utilizando GetType()</returns>
        public virtual string MostrarFigura()
        {
            return "Figura" + this.GetType();
        }
        
    }

    /// <summary>
    /// Herencia de la clase Figura permite crear instancias de clases del tipo Triangulo
    /// </summary>
    public class Triangulo : Figura
    {
        public Triangulo()
        {
        }

        /// <summary>
        /// con la palabra clave "base" se llama al constructor de la clase Padre y se pasa los parámetros correspondientes
        /// </summary>
        /// <param name="posicion">Objeto tipo punto</param>
        public Triangulo(Punto posicion) : base(posicion)
        {

        }

        /// <summary>
        /// con la palabra clave "base" se llama al constructor de la clase Padre y se pasa los parámetros correspondientes
        /// </summary>
        /// <param name="posicion">Objeto tipo punto</param>
        public Triangulo(int x, int y) : base(x,y)
        {

        }

        /// <summary>
        /// Sobre-escritura del método MostrarFigura  
        /// </summary>
        /// <returns> devuelve el texto indicando que tipo de figura es y la posiciòn en pantalla</returns>
        public override string MostrarFigura()
        {            
            return "Figura: Triangulo en la posición (" + Posicion.X + ", "+ Posicion.Y  + ")";
        }
    }

    /// <summary>
    /// Herencia de la clase Figura permite crear instancias de clases del tipo Rectángulo
    /// </summary>
    public class Rectangulo : Figura
    {
        public Rectangulo()
        {
        }

        /// <summary>
        /// con la palabra clave "base" se llama al constructor de la clase Padre y se pasa los parámetros correspondientes
        /// </summary>
        /// <param name="posicion">Objeto tipo punto</param>
        public Rectangulo(Punto posicion) : base(posicion)
        {

        }

        /// <summary>
        /// con la palabra clave "base" se llama al constructor de la clase Padre y se pasa los parámetros correspondientes
        /// </summary>
        /// <param name="posicion">Objeto tipo punto</param>
        public Rectangulo(int x, int y) : base(x, y)
        {

        }

        /// <summary>
        /// Sobre-escritura del método MostrarFigura  
        /// </summary>
        /// <returns> devuelve el texto indicando que tipo de figura es y la posiciòn en pantalla</returns>
        public override string MostrarFigura()
        {
            return "Figura: Rectángulo en la posición (" + Posicion.X + ", " + Posicion.Y + ")";
        }
    }

    /// <summary>
    /// Herencia de la clase Figura permite crear instancias de clases del tipo Circunferencia 
    /// </summary>
    public class Circunferencia : Figura
    {
        /// <summary>
        /// Constructor de circunferencia
        /// </summary>
        public Circunferencia()
        {
        }

        /// <summary>
        /// con la palabra clave "base" se llama al constructor de la clase Padre y se pasa los parámetros correspondientes
        /// </summary>
        /// <param name="posicion">Objeto tipo punto</param>
        public Circunferencia(Punto posicion) : base(posicion)
        {

        }

        /// <summary>
        /// con la palabra clave "base" se llama al constructor de la clase Padre y se pasa los parámetros correspondientes
        /// </summary>
        /// <param name="posicion">Objeto tipo punto</param>
        public Circunferencia(int x, int y) : base(x, y)
        {

        }

        /// <summary>
        /// Sobre-escritura del método MostrarFigura  
        /// </summary>
        /// <returns> devuelve el texto indicando que tipo de figura es y la posiciòn en pantalla</returns>
        public override string MostrarFigura()
        {
            return "Figura: Circunferencia en la posición (" + Posicion.X + ", " + Posicion.Y + ")";
        }
    }
}

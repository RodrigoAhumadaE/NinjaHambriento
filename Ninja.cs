class Ninja{
  private int ConsumoCalorias;
  public List<Comida> HistorialComida;

  /* En la clase Ninja, agregue un constructor que establezca el consumo de calorías en 0 y
  cree una lista nueva y vacía de Alimentos en FoodHistory. */
  public Ninja(){
    ConsumoCalorias = 0;
    HistorialComida = new List<Comida>();
  }

  /* En la clase Ninja, agregue una propiedad pública "getter" llamada "IsFull" que devuelve
  un valor booleano basado en si la ingesta de calorías del Ninja es mayor a 1200 calorías. */
  public bool EstaLleno {
    get { return ConsumoCalorias > 1200; }
  }

  /* Desarrolle el método Comer de la clase Ninja para que, si el Ninja no está lleno, agregue las
  calorías al ConsumoCalorias, agregue la comida al HistorialComida e imprima el nombre
  de la comida y si está o no. Picante o Dulce a la consola. */
  public void Comer(Comida comida) {
    string picante;
    string dulce;
    if (!EstaLleno) {
      ConsumoCalorias += comida.Calorias;
      HistorialComida.Add(comida);
      if(comida.EsPicante){
        picante = "es picante";
      }else{
        picante = "no es picante";
      }
      if(comida.EsDulce){
        dulce = "es dulce";
      }else{
        dulce = "no es dulce";
      }
      Console.WriteLine($"{comida.Nombre} {picante} y {dulce}");
    }else{
      /* Termine de desarrollar el método Eat de la clase Ninja para que, si el Ninja está lleno, se imprima una advertencia en la consola. */
      Console.WriteLine("Ya has comido las calorías necesarias para hoy");
    }
  }

}


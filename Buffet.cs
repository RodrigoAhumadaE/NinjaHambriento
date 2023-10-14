class Buffet{
  public List<Comida> Menu;

  // En la clase Buffet, configure Menú en una lista codificada de 7 o más objetos de Comida que cree instancias manualmente
  public Buffet(){
    Menu = new List<Comida>(){
      new Comida("Pizza", 1000, false, false),
      new Comida("Hamburguesa", 800, false, false),
      new Comida("Tacos", 500, true, false),
      new Comida("Kimchi", 700, true, false),
      new Comida("Empanada", 900, false, false),
      new Comida("Completo", 600, false, false),
      new Comida("Chile Relleno", 400, true, false),
      new Comida("Ensalada", 200, false, false),
      new Comida("Fruta", 100, false, true),
      new Comida("Helado", 300, false, true),
    };
  }

  // En la clase Buffet, cree un método Servir que seleccione aleatoriamente un objeto Comida de la lista Menú y devuelva el objeto Comida
  public Comida Servir(){
    Random rand = new Random();
    int indice = rand.Next(Menu.Count);
    return Menu[indice];
  }
}


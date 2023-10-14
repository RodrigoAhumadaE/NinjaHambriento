class Comida{
  public string Nombre { get; set; }
  public int Calorias { get; set; }
  public bool EsPicante { get; set; }
  public bool EsDulce { get; set; }

  // Agregar un constructor a la clase Comida
  public Comida(string nombre, int calorias, bool esPicante, bool esDulce){
    Nombre = nombre;
    Calorias = calorias;
    EsPicante = esPicante;
    EsDulce = esDulce;
  }
}